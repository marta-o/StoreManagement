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
            LoadClothes();
        }
        public Model Model => _model;
        private void LoadClothes()
        {
            var clothes = _model.LoadAllClothes();
            _view.DisplayAllClothes(clothes);
        }
    }
}
