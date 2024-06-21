using StoreManagement.Views.WorkerViews;
using StoreManagement.Models;
using StoreManagement.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Presenters
{
    public class WorkerOrdersPresenter
    {
        private readonly IWorkerOrdersView _view;
        private readonly Model _model;
        public WorkerOrdersPresenter(IWorkerOrdersView view, Model model)
        {
            _view = view;
            _model = model;
            _view.DeleteOrder += DeleteOrderHandler;
            LoadOrders();
        }
        public Model Model => _model;
        private void LoadOrders()
        {
            var orders = _model.LoadAllOrders();
            _view.DisplayAllOrders(orders);
        }
        private void DeleteOrderHandler(object sender, EventArgs e)
        {
            Order order = _view.GetSelectedOrder();
            if (_model.DeleteOrder(order))
            {
                _view.ShowMessage("Order deleted");
                LoadOrders();
            }
            else
            {
                _view.ShowMessage("Error deleting.");
            }
        }
    }
}
