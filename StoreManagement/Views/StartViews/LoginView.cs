using StoreManagement.Views.StartViews;
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
using StoreManagement.Views;
using StoreManagement.Views;

namespace StoreManagement
{
    public partial class LoginView : Form, ILoginView
    {
        private LoginPresenter _loginPresenter;
        public LoginView()
        {
            InitializeComponent();
            _loginPresenter = new LoginPresenter(this);
        }

        public string Username => textBox_username.Text;
        public string Password => maskedTextBox_password.Text;

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

        public void NavigateToWorkerView()
        {
            WorkerAddProductView workerView = new WorkerAddProductView();
            workerView.Show();
            this.Hide();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            _loginPresenter.Login();
        }
        private void button_create_Click(object sender, EventArgs e)
        {
            AddNewUserView addNewUserView = new AddNewUserView();
            addNewUserView.Show();
            this.Hide();
        }
    }
}
