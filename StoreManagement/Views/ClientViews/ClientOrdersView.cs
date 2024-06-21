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
    public partial class ClientOrdersView : UserControl, IClientOrdersView
    {
        private readonly ClientOrdersPresenter _presenter;
        private readonly int _clientId;
        public ClientOrdersView(Model model, int userId)
        {
            InitializeComponent();
            _presenter = new ClientOrdersPresenter(this, model, userId);
            _clientId = userId;
        }
        public event EventHandler DeleteOrder;
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        public void DisplayUsersOrders(List<Order> orders)
        {
            dataGridView_client_orders.Rows.Clear();
            foreach (Order order in orders)
            {
                dataGridView_client_orders.Rows.Add(order.Id, order.OrderDate, order.Thing1, order.Thing2, order.Thing3, order.Thing4, order.Thing5);
            }
        }
        public Order GetSelectedOrder()
        {
            if (dataGridView_client_orders.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView_client_orders.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["Order"].Value);

                return _presenter.Model.Orders.FirstOrDefault(order => order.Id == id);
            }
            else
            {
                ShowMessage("Please select an order.");
                return null;
            }
        }
        private void Button_delete_Click(object sender, EventArgs e)
        {
            DeleteOrder?.Invoke(this, EventArgs.Empty);
        }

        // Side buttons
        public void Button_shopping_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.ParentForm as MainForm;
            mainForm?.ShowUserControl(new ClientProductsView(_presenter.Model, _clientId));
        }
        public void Button_cart_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.ParentForm as MainForm;
            mainForm?.ShowUserControl(new ClientCartView(_presenter.Model, _clientId));
        }
        public void Button_logout_Click(object sender, EventArgs e)
        {
            _presenter.Logout();
            MainForm mainForm = this.ParentForm as MainForm;
            mainForm?.ShowUserControl(new LoginView(new Model()));
        }
    }
}
