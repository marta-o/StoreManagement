using StoreManagement.DAL.Entities;
using StoreManagement.Models;
using StoreManagement.Views.ClientViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Presenters
{
    public class ClientOrdersPresenter
    {
        private IClientOrdersView _view;
        private Model _model;
        private int _clientId;

        public ClientOrdersPresenter(IClientOrdersView view, Model model, int clientId)
        {
            _view = view;
            _model = model;
            _clientId = clientId;
            _view.DeleteOrder += DeleteOrderHandler;
            LoadOrders();
        }
        public Model Model => _model;
        public void LoadOrders() 
        {
            var orders = _model.LoadUsersOrders(_clientId);
            _view.DisplayUsersOrders(orders);
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
        public void Logout()
        {
            _model.RestoreCartItems();
        }
    }
}
