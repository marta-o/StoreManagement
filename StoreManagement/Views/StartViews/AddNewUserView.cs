using StoreManagement.Presenters;
using StoreManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.Views.StartViews
{
    public partial class AddNewUserView : UserControl, IAddNewUserView
    {
        private AddNewUserPresenter _presenter;
        public AddNewUserView(Model model)
        {
            InitializeComponent();
            _presenter = new AddNewUserPresenter(this, model); 
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
            MainForm mainForm = this.ParentForm as MainForm;
            if (mainForm != null)
            {
                mainForm.ShowUserControl(new ClientProductsView());
            }
        }
        
        private void button_sign_in_Click(object sender, EventArgs e)
        {
            AddUser?.Invoke(this, EventArgs.Empty);
        }

        private void button_log_in_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.ParentForm as MainForm;
            if (mainForm != null)
            {
                mainForm.ShowUserControl(new LoginView(new Model()));
            }
        }
    }
}
