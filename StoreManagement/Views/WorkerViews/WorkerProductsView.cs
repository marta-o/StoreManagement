using StoreManagement.DAL.Entities;
using StoreManagement.Models;
using StoreManagement.Views.WorkerViews;
using StoreManagement.Presenters;
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
    public partial class WorkerProductsView : UserControl, IWorkerProductsView
    {
        private WorkerProductsPresenter _presenter;
        public WorkerProductsView(Model model)
        {
            InitializeComponent();
            _presenter = new WorkerProductsPresenter(this, model);
            DisplayAllClothes(_presenter.Model.LoadAllClothes());
        }
        public void DisplayAllClothes(List<Clothes> clothes)
        {
            dataGridView_products.Rows.Clear();
            foreach (var item in clothes)
            {
                dataGridView_products.Rows.Add(item.Id, item.Name, item.Category, item.Colour, item.Size, item.Price, item.Amount);
            }
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        public Clothes GetSelectedClothes()
        {
            if (dataGridView_products.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView_products.SelectedRows[0];
                string name = selectedRow.Cells["Name"].Value.ToString();
                string type = selectedRow.Cells["Type"].Value.ToString();

                return _presenter.Model.Clothes.FirstOrDefault(cloth => cloth.Name == name && cloth.Category == type);
            }
            else
            {
                ShowMessage("Please select a product.");
                return null;
            }
        }
        
        private void Button_add_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.ParentForm as MainForm;
            if (mainForm != null)
            {
                mainForm.ShowUserControl(new WorkerAddProductView(_presenter.Model));
            }
        }
        private void Button_edit_Click(object sender, EventArgs e)
        {
            Clothes selectedClothes = GetSelectedClothes();
            if (selectedClothes != null)
            {
                MainForm mainForm = this.ParentForm as MainForm;
                if (mainForm != null)
                {
                    WorkerEditProductView editProductView = new WorkerEditProductView(_presenter.Model, selectedClothes);
                    mainForm.ShowUserControl(editProductView);
                }
            }
        }

        private void Button_filter_Click(object sender, EventArgs e)
        {
            string selectedType = comboBox_type.SelectedItem?.ToString();
            string selectedColor = comboBox_color.SelectedItem?.ToString();
            string selectedSize = comboBox_size.SelectedItem?.ToString();
            // dodac filtrowanie po amount
            var filteredClothes = _presenter.Model.LoadAvailableClothes()
                .Where(c => (string.IsNullOrEmpty(selectedType) || c.Category == selectedType) &&
                            (string.IsNullOrEmpty(selectedColor) || c.Colour == selectedColor) &&
                            (string.IsNullOrEmpty(selectedSize) || c.Size == selectedSize))
                .ToList();

            DisplayAllClothes(filteredClothes);
        }


        //boczne przyciski
        private void Button_orders_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.ParentForm as MainForm;
            if (mainForm != null)
            {
                mainForm.ShowUserControl(new WorkerOrdersView(_presenter.Model));
            }
        }
        private void Button_users_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.ParentForm as MainForm;
            if (mainForm != null)
            {
                mainForm.ShowUserControl(new WorkerUsersView(_presenter.Model));
            }
        }
        public void Button_logout_Click(object sender, EventArgs e)
        {
            //_presenter.Logout();
            MainForm mainForm = this.ParentForm as MainForm;
            if (mainForm != null)
            {
                mainForm.ShowUserControl(new LoginView(new Model()));
            }
        }
    }
}