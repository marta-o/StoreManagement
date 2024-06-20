using StoreManagement.DAL.Entities;
using StoreManagement.Models;
using StoreManagement.Views;
using StoreManagement.Views.WorkerViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Presenters
{
    public class WorkerProductsPresenter
    {
        private IWorkerProductsView _view;
        private Model _model;
        public WorkerProductsPresenter(IWorkerProductsView view, Model model)
        {
            _view = view;
            _model = model;
            LoadAvailableClothes();
        }
        public Model Model => _model;
        private void LoadAvailableClothes()
        {
            var availableClothes = _model.LoadAvailableClothes();
            _view.DisplayAllClothes(availableClothes);
        }
            /*
            private void AddProduct(object sender, EventArgs e)
            {
                // Navigate to WorkerAddProductView with the Model instance
                _mainForm.ShowUserControl(new WorkerAddProductView(_model));
            }
            */
            /*
            private void EditProduct(object sender, EventArgs e)
            {
                var selectedClothes = _view.GetSelectedClothes();
                if (selectedClothes != null)
                {
                    MainForm mainForm = (MainForm)_view;
                    mainForm.ShowUserControl(new WorkerEditProductView(selectedClothes));
                }
                else
                {
                    _view.ShowMessage("Select a product to edit.");
                }
            }
            */
        }
}
