using StoreManagement.Views.WorkerViews;
using StoreManagement.Models;
using StoreManagement.DAL.Entities;
using System;

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
            _view.DisplayOrders(orders);
        }
        private void DeleteOrderHandler(object sender, EventArgs e)
        {
            Order order = _view.GetSelectedOrder();
            if (order != null && _model.DeleteOrder(order))
            {
                _view.ShowMessage("Order deleted");
                LoadOrders();
            }
            else
            {
                _view.ShowMessage("Error deleting order.");
            }
        }
    }
}
