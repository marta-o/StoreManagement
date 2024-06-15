using StoreManagement.Presenters;
using StoreManagement.Views.StartViews;
using StoreManagement.Views;
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
    public partial class AddNewUserView : Form, IAddNewUserView
    {
        private AddNewUserPresenter _presenter;
        public AddNewUserView()
        {
            InitializeComponent();
            _presenter = new AddNewUserPresenter(this); // Inicjalizacja prezentera
        }
        public string UserName => textBox_name.Text;
        public string Surname => textBox_surname.Text;
        public string Address => textBox_address.Text;
        public string Phone => textBox_phone.Text; // Upewnij się, że textBox_phone istnieje w formularzu
        public string Username => textBox_username.Text;
        public string Password => maskedTextBox_password.Text;
        public string Type => "client"; // Stała wartość, jeśli nie ma pola typu

        public event EventHandler AddUser;
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        public void NavigateToClientView()
        {
            ClientProductsView clientView = new ClientProductsView();
            clientView.Show();
            this.Hide();
        }
        
        private void button_sign_in_Click(object sender, EventArgs e)
        {
            AddUser?.Invoke(this, EventArgs.Empty);
        }

        private void button_log_in_Click(object sender, EventArgs e)
        {
            LoginView loginView = new LoginView();
            loginView.Show();
            this.Hide();
        }
    }
}
