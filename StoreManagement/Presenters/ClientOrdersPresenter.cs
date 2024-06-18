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
            LoadOrders();
        }
        public Model Model
        {
            get { return _model; }
        }
        public void LoadOrders() 
        { 

        }
    }
}
