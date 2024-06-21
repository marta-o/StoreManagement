using StoreManagement.DAL.Entities;
using StoreManagement.Models;
using StoreManagement.Presenters;
using StoreManagement.Views.StartViews;
using StoreManagement.Views.WorkerViews;
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
    public partial class WorkerEditProductView : UserControl, IWorkerEditProductView
    {
        private WorkerEditProductPresenter _presenter;
        private Clothes _clothes;
        public WorkerEditProductView(Model model, Clothes clothes)
        {
            InitializeComponent();
            _presenter = new WorkerEditProductPresenter(this, model);
            _clothes = clothes;
            PopulateForm(clothes);
        }

        public int ProductId => _clothes.Id;
        public string ProductName => textBox_name.Text;
        public string Type => comboBox_type.SelectedItem?.ToString();
        public string Colour => comboBox_colour.SelectedItem?.ToString();
        public int Price => int.Parse(textBox_price.Text);
        public string ProductSize => comboBox_size.SelectedItem?.ToString();
        public int Amount => int.Parse(textBox_amount.Text);

        public event EventHandler SaveProduct;

        private void Button_save_Click(object sender, EventArgs e)
        {
            SaveProduct?.Invoke(this, EventArgs.Empty);
        }
        public void PopulateForm(Clothes clothes)
        {
            textBox_name.Text = clothes.Name;
            textBox_price.Text = clothes.Price.ToString();
            comboBox_size.SelectedItem = clothes.Size;
            comboBox_type.SelectedItem = clothes.Category;
            comboBox_colour.SelectedItem = clothes.Colour;
            textBox_amount.Text = clothes.Amount.ToString();
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        public void ClearForm()
        {
            textBox_name.Text = "";
            comboBox_type.Text = "";
            comboBox_colour.Text = "";
            textBox_price.Text = "";
            comboBox_size.Text = "";
            textBox_amount.Text = "";
        }
        // boczne przyciski
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
