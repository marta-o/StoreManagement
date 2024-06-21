using StoreManagement.DAL.Entities;
using StoreManagement.Models;
using StoreManagement.Presenters;
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

namespace StoreManagement.Views.WorkerViews
{
    public partial class WorkerUsersView : UserControl, IWorkerUsersView 
    {
        private WorkerUsersPresenter _presenter;
        public WorkerUsersView(Model model)
        {
            InitializeComponent();
            _presenter = new WorkerUsersPresenter(this, model);
            DisplayAllUsers(_presenter.Model.LoadAllUsers());
        }
        public void DisplayAllUsers(List<User> users)
        {
            dataGridView_users.Rows.Clear();
            foreach (var user in users)
            {
                dataGridView_users.Rows.Add(user.Id, user.Name, user.Surname, user.Address, user.Phone, user.Username, user.Type);
            }
        }
        public User GetSelectedUsers()
        {
            if (dataGridView_users.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView_users.SelectedRows[0];
                string name = selectedRow.Cells["Name"].Value.ToString();
                string Type = selectedRow.Cells["Type"].Value.ToString();

                return _presenter.Model.Users.FirstOrDefault(user => user.Name == name && user.Type == Type);
            }
            return null;
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void button_sort_Click(object sender, EventArgs e)
        {
            string selectedType = comboBox_users.SelectedItem?.ToString();

            var filteredUsers = _presenter.Model.Users
                .Where(u => string.IsNullOrEmpty(selectedType) || u.Type == selectedType)
                .ToList();

            DisplayAllUsers(filteredUsers);
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
        private void Button_orders_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.ParentForm as MainForm;
            if (mainForm != null)
            {
                mainForm.ShowUserControl(new WorkerOrdersView(_presenter.Model));
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
