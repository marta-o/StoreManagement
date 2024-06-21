using StoreManagement.Models;
using StoreManagement.Presenters;
using StoreManagement.Views.StartViews;
using StoreManagement.Views.WorkerViews;
using StoreManagement.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.Views
{
    public partial class WorkerOrdersView : UserControl, IWorkerOrdersView
    {
        private WorkerOrdersPresenter _presenter;
        public WorkerOrdersView(Model model)
        {
            InitializeComponent();
            _presenter = new WorkerOrdersPresenter(this, model);
        }
        public event EventHandler DeleteOrder;
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        public void DisplayAllOrders(List<Order> orders)
        {
            dataGridView_orders.Rows.Clear();
            foreach (Order order in orders)
            {
                dataGridView_orders.Rows.Add(order.Id, order.OrderDate, order.IdClient, order.Thing1, order.Thing2, order.Thing3, order.Thing4, order.Thing5);
            }
        }
        public Order GetSelectedOrder()
        {
            if (dataGridView_orders.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView_orders.SelectedRows[0];
                int id = int.Parse(selectedRow.Cells["Id"].Value.ToString());

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

        //boczne przyciski
        private void Button_products_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.ParentForm as MainForm;
            if (mainForm != null)
            {
                mainForm.ShowUserControl(new WorkerProductsView(_presenter.Model));
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
