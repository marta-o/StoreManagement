using StoreManagement.DAL.Entities;
using StoreManagement.Models;
using StoreManagement.Presenters;
using StoreManagement.Views.ClientViews;
using StoreManagement.Views.StartViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.Views
{
    public partial class ClientCartView : UserControl, IClientCartView
    {
        private ClientCartPresenter _presenter;
        private int _clientId;
        public ClientCartView(Model model, int clientId)
        {
            InitializeComponent();
            _presenter = new ClientCartPresenter(this, model, clientId);
            _clientId = clientId;
            LoadCartItems();
        }
        private void LoadCartItems()
        {
            _presenter.LoadCartItems();
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        public void DisplayCartItems(List<Clothes> cartItems)
        {
            listBox_cart.Items.Clear();
            foreach (var item in cartItems)
            {
                listBox_cart.Items.Add($"{item.Name} - {item.Price}");
            }
        }
        private void button_remove_Click(object sender, EventArgs e)
        {
            if (listBox_cart.SelectedIndex != -1)
            {
                var selectedIdx = listBox_cart.SelectedIndex;
                var removedItem = _presenter.Model.CartItems[selectedIdx];
                _presenter.RemoveFromCart(removedItem);
                LoadCartItems();
            }
            else
            {
                ShowMessage("Please select an item to remove.");
            }
        }
        private void button_purchase_Click(object sender, EventArgs e)
        {
            _presenter.PurchaseItems();
        }
        

        //boczne przyciski
        public void button_shopping_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.ParentForm as MainForm;
            if (mainForm != null)
            {
                mainForm.ShowUserControl(new ClientProductsView(_presenter.Model, _clientId));
            }
        }
        public void button_my_orders_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.ParentForm as MainForm;
            if (mainForm != null)
            {
                mainForm.ShowUserControl(new ClientOrdersView(_presenter.Model, _clientId));
            }
        }
        public void button_logout_Click(object sender, EventArgs e)
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
