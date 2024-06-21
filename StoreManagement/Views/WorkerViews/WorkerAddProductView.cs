using StoreManagement.Models;
using StoreManagement.Presenters;
using StoreManagement.Views.StartViews;
using StoreManagement.Views.WorkerViews;
using System;
using System.Windows.Forms;

namespace StoreManagement.Views
{
    public partial class WorkerAddProductView : UserControl, IWorkerAddProductView
    {
        private readonly WorkerAddProductPresenter _presenter;
        public WorkerAddProductView(Model model)
        {
            InitializeComponent();
            _presenter = new WorkerAddProductPresenter(this, model);
        }
        public string ProductName { get => textBox_name.Text; set => textBox_name.Text = value; }
        public string Type { get => comboBox_type.Text; set => comboBox_type.Text = value; }
        public string Colour { get => comboBox_colour.Text; set => comboBox_colour.Text = value; }
        public string Price { get => textBox_price.Text; set => textBox_price.Text = value; }
        public string ProductSize { get => comboBox_size.Text; set => comboBox_size.Text = value; }
        public string Amount { get => textBox_amount.Text; set => textBox_amount.Text = value; }
        public event EventHandler SaveProduct;
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        public void ClearForm()
        {
            textBox_name.Text = "";
            comboBox_type.SelectedIndex = -1;
            comboBox_colour.SelectedIndex = -1;
            textBox_price.Text = "";
            comboBox_size.SelectedIndex = -1;
            textBox_amount.Text = "";
        }
        private void Button_save_Click(object sender, EventArgs e)
        {
            SaveProduct?.Invoke(this, EventArgs.Empty);
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
