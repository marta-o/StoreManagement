using StoreManagement.DAL.Entities;
using StoreManagement.Models;
using StoreManagement.Views.WorkerViews;
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
using StoreManagement.Views.StartViews;

namespace StoreManagement.Views
{
    public partial class WorkerProductsView : UserControl, IWorkerProductsView
    {
        private WorkerProductsPresenter _presenter;
        public WorkerProductsView(Model model)
        {
            InitializeComponent();
            _presenter = new WorkerProductsPresenter(this, model);
            DisplayAllClothes(_presenter.Model.LoadAllClothes());
        }
        public void DisplayAllClothes(List<Clothes> clothes)
        {
            listBox_products.Items.Clear();
            foreach (var item in clothes)
            {
                listBox_products.Items.Add($"{item.Name} ({item.Category}) - Size: {item.Size}, Colour: {item.Colour}, Price: {item.Price}, Amount: {item.Amount}");
            }
        }
        public Clothes GetSelectedClothes()
        {
            if (listBox_products.SelectedItem != null)
            {
                string selectedItem = listBox_products.SelectedItem.ToString();
                string name = selectedItem.Split('(')[0].Trim();
                string category = selectedItem.Split('(')[1].Split(')')[0].Trim();

                foreach (var cloth in _presenter.Model.Clothes)
                {
                    if (cloth.Name == name && cloth.Category == category)
                    {
                        return cloth;
                    }
                }
            }
            return null;
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.ParentForm as MainForm;
            if (mainForm != null)
            {
                mainForm.ShowUserControl(new WorkerAddProductView(_presenter.Model));
            }
        }

        //boczne przyciski
        private void button_orders_Click(object sender, EventArgs e)
        {

        }

        private void button_add_employee_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.ParentForm as MainForm;
            if (mainForm != null)
            {
                mainForm.ShowUserControl(new WorkerAddUserView(_presenter.Model, mainForm));
            }
        }
        public void button_logout_Click(object sender, EventArgs e)
        {
            //_presenter.Logout();
            MainForm mainForm = this.ParentForm as MainForm;
            if (mainForm != null)
            {
                mainForm.ShowUserControl(new LoginView(new Model()));
            }
        }

        /*
private void button_edit_Click(object sender, EventArgs e)
{
Model model = new Model();
MainForm mainForm = this.ParentForm as MainForm;
if (mainForm != null)
{
mainForm.ShowUserControl(new WorkerEditProductView(model));
}
}
*/
    }
}