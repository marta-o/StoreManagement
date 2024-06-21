using StoreManagement.DAL.Entities;
using StoreManagement.Models;
using StoreManagement.Presenters;
using StoreManagement.Views.ClientViews;
using StoreManagement.Views.StartViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StoreManagement.Views
{
    public partial class ClientCartView : UserControl, IClientCartView
    {
        private readonly ClientCartPresenter _presenter;
        private readonly int _clientId;
        public ClientCartView(Model model, int clientId)
        {
            InitializeComponent();
            _presenter = new ClientCartPresenter(this, model, clientId);
            _clientId = clientId;
            LoadCartItems();
        }
        public event EventHandler Purchase;
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        private void LoadCartItems()
        {
            _presenter.LoadCartItems();
        }
        public void DisplayCartItems(List<Clothes> cartItems)
        {
            dataGridView_cart.Rows.Clear();
            foreach (var item in cartItems)
            {
                dataGridView_cart.Rows.Add(item.Name, item.Category, item.Colour, item.Size, item.Price); 
            }
        }
        public Clothes GetSelectedClothes()
        {
            if (dataGridView_cart.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView_cart.SelectedRows[0];
                string name = selectedRow.Cells["Name"].Value.ToString();
                string Type = selectedRow.Cells["Type"].Value.ToString();

                return _presenter.Model.CartItems.FirstOrDefault(cloth => cloth.Name == name && cloth.Category == Type);
            }
            else
            {
                ShowMessage("Please select a product.");
                return null;
            }
        }
        private void Button_remove_Click(object sender, EventArgs e)
        {
            var selectedClothes = GetSelectedClothes();
            if (selectedClothes != null)
            {
            _presenter.RemoveFromCart(selectedClothes);
            }
        }
        private void Button_purchase_Click(object sender, EventArgs e)
        {
            Purchase?.Invoke(this, EventArgs.Empty);
        }

        // Side buttons
        public void Button_shopping_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.ParentForm as MainForm;
            mainForm?.ShowUserControl(new ClientProductsView(_presenter.Model, _clientId));
        }
        public void Button_my_orders_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.ParentForm as MainForm;
            mainForm?.ShowUserControl(new ClientOrdersView(_presenter.Model, _clientId));
        }
        public void Button_logout_Click(object sender, EventArgs e)
        {
            _presenter.Logout();
            MainForm mainForm = this.ParentForm as MainForm;
            mainForm?.ShowUserControl(new LoginView(new Model()));
        }
    }
}
