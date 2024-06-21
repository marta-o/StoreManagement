using StoreManagement.Models;
using StoreManagement.Presenters;
using StoreManagement.Views.StartViews;
using StoreManagement.Views.WorkerViews;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace StoreManagement.Views
{
    public partial class WorkerAddUserView : UserControl, IWorkerAddUserView
    {
        private readonly WorkerAddUserPresenter _presenter;

        public WorkerAddUserView(Model model)
        {
            InitializeComponent();
            _presenter = new WorkerAddUserPresenter(this, model);
            textBox_phone.TextChanged += ValidatePhoneNumber;
            textBox_name.TextChanged += ValidateNameSurname;
            textBox_surname.TextChanged += ValidateNameSurname;
            textBox_username.TextChanged += ValidateUsername;
        }
        public string UserName => textBox_name.Text;
        public string Surname => textBox_surname.Text;
        public string Address => textBox_address.Text;
        public string Phone => textBox_phone.Text;
        public string Username => textBox_username.Text;
        public string Password => maskedTextBox_password.Text;
        public event EventHandler AddUser;
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        public void ClearFields()
        {
            textBox_name.Text = "";
            textBox_surname.Text = "";
            textBox_address.Text = "";
            textBox_phone.Text = "";
            textBox_username.Text = "";
            maskedTextBox_password.Text = "";
        }
        private void Button_add_Click(object sender, EventArgs e)
        {
            AddUser?.Invoke(this, EventArgs.Empty);
        }
        private void ValidatePhoneNumber(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBox_phone.Text, @"^\d{0,9}$"))
            {
                ShowMessage("Phone number can only contain up to 9 digits.");
                textBox_phone.Text = textBox_phone.Text.Substring(0, textBox_phone.Text.Length - 1);
            }
        }
        private void ValidateNameSurname(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(((TextBox)sender).Text, @"^[a-zA-Z]*$"))
            {
                ShowMessage("Name and Surname can only contain letters.");
                ((TextBox)sender).Text = ((TextBox)sender).Text.Substring(0, ((TextBox)sender).Text.Length - 1);
            }
        }
        private void ValidateUsername(object sender, EventArgs e)
        {
            if (textBox_username.Text.Contains(" "))
            {
                ShowMessage("Username cannot contain spaces.");
                textBox_username.Text = textBox_username.Text.Replace(" ", string.Empty);
                textBox_username.SelectionStart = textBox_username.Text.Length;
            }
        }

        // Side buttons
        private void Button_products_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.ParentForm as MainForm;
            mainForm?.ShowUserControl(new WorkerProductsView(_presenter.Model));
        }
        private void Button_orders_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.ParentForm as MainForm;
            mainForm?.ShowUserControl(new WorkerOrdersView(_presenter.Model));
        }
        private void Button_users_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.ParentForm as MainForm;
            mainForm?.ShowUserControl(new WorkerUsersView(_presenter.Model));
        }
        public void Button_logout_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.ParentForm as MainForm;
            mainForm?.ShowUserControl(new LoginView(new Model()));
        }
    }
}
