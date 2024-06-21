using StoreManagement.Presenters;
using StoreManagement.Models;
using System;
using System.Windows.Forms;

namespace StoreManagement.Views.StartViews
{
    public partial class LoginView : UserControl, ILoginView
    {
        private readonly LoginPresenter _loginPresenter;
        public LoginView(Model model)
        {
            InitializeComponent();
            _loginPresenter = new LoginPresenter(this, model);
        }
        public string Username => textBox_username.Text;
        public string Password => maskedTextBox_password.Text;

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        public void NavigateToClientView(int userId)
        {
            MainForm mainForm = this.ParentForm as MainForm;
            if (mainForm != null)
            {
                mainForm.ShowUserControl(new ClientProductsView(new Model(), userId));
            }
        }
        public void NavigateToWorkerView(int userId)
        {
            MainForm mainForm = this.ParentForm as MainForm;
            if (mainForm != null)
            {
                mainForm.ShowUserControl(new WorkerProductsView(new Model()));
            }
        }
        private void Button_login_Click(object sender, EventArgs e)
        {
            _loginPresenter.Login();
        }

        // Side buttons
        private void Button_create_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.ParentForm as MainForm;
            mainForm?.ShowUserControl(new AddNewUserView(new Model()));
        }
    }
}
