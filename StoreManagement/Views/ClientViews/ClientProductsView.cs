using StoreManagement.DAL.Entities;
using StoreManagement.DAL.Repositories;
using StoreManagement.Presenters;
using StoreManagement.Views.ClientViews;
using StoreManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreManagement.Views.StartViews;

namespace StoreManagement.Views
{
    public partial class ClientProductsView : UserControl, IClientProductsView
    {
        private ClientProductsPresenter _presenter;
        private int _clientId;
        public ClientProductsView(Model model, int clientId)
        {
            InitializeComponent();
            _presenter = new ClientProductsPresenter(this, model, clientId);
            _clientId = clientId;
            DisplayAvailableClothes(_presenter.Model.LoadAvailableClothes());
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        public void DisplayAvailableClothes(List<Clothes> clothes)
        {
            dataGridView_client_products.Rows.Clear();
            foreach (var item in clothes)
            {
                dataGridView_client_products.Rows.Add(item.Name, item.Category, item.Colour, item.Size, item.Price);
            }
        }
        public Clothes GetSelectedClothes()
        {
            if (dataGridView_client_products.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView_client_products.SelectedRows[0];
                string name = selectedRow.Cells["Name"].Value.ToString();
                string Type = selectedRow.Cells["Type"].Value.ToString();

                return _presenter.Model.Clothes.FirstOrDefault(cloth => cloth.Name == name && cloth.Category == Type);
            }
            else
            {
                ShowMessage("Please select a product.");
                return null;
            }
        }
        private void button_add_cart_Click(object sender, EventArgs e)
        {
            _presenter.AddToCart();
        }
        private void button_sort_Click(object sender, EventArgs e)
        {
            string selectedType = comboBox_type.SelectedItem?.ToString();
            string selectedColor = comboBox_colour.SelectedItem?.ToString();
            string selectedSize = comboBox_size.SelectedItem?.ToString();

            var filteredClothes = _presenter.Model.LoadAvailableClothes()
                .Where(c => (string.IsNullOrEmpty(selectedType) || c.Category == selectedType) &&
                            (string.IsNullOrEmpty(selectedColor) || c.Colour == selectedColor) &&
                            (string.IsNullOrEmpty(selectedSize) || c.Size == selectedSize))
                .ToList();

            DisplayAvailableClothes(filteredClothes);
        }

        // boczne przyciski
        public void Button_cart_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.ParentForm as MainForm;
            if (mainForm != null)
            {
                mainForm.ShowUserControl(new ClientCartView(_presenter.Model, _clientId));
            }
        }
        public void Button_my_orders_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.ParentForm as MainForm;
            if (mainForm != null)
            {
                mainForm.ShowUserControl(new ClientOrdersView(_presenter.Model, _clientId));
            }
        }
        public void Button_logout_Click(object sender, EventArgs e)
        {
            _presenter.Logout();
            MainForm mainForm = this.ParentForm as MainForm;
            if (mainForm != null)
            {
                mainForm.ShowUserControl(new LoginView(new Model()));
            }
        }
    }
}
