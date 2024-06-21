using StoreManagement.Views.ClientViews;
using StoreManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreManagement.DAL.Entities;

namespace StoreManagement.Presenters
{
    public class ClientProductsPresenter
    {
        private IClientProductsView _view;
        private Model _model;
        private int _clientId;
        public ClientProductsPresenter(IClientProductsView clientProductsView, Model model, int clientId)
        {
            _view = clientProductsView;
            _model = model;
            _clientId = clientId; 
            LoadAvailableClothes();  
        }
        public Model Model => _model;
        public void LoadAvailableClothes()
        {
            var clothes = _model.LoadAvailableClothes();
            _view.DisplayAvailableClothes(clothes);
        }
        public void AddToCart()
        { 
            var selectedClothes = _view.GetSelectedClothes();
            if (selectedClothes != null)
            {
                selectedClothes.Amount--;
                _model.UpdateClothes(selectedClothes);
                _model.AddToCart(selectedClothes);
                _view.ShowMessage($"{selectedClothes.Name} added to cart");
                /*if (selectedClothes.Amount > 0)
                {
                    selectedClothes.Amount--;
                    _model.UpdateClothes(selectedClothes);
                    _model.AddToCart(selectedClothes);
                    _view.ShowMessage($"{selectedClothes.Name} added to cart");
                }
                else
                {
                    _view.ShowMessage("This item is out of stock.");
                }*/
            }
            LoadAvailableClothes();
        }
        public void Logout()
        {
            _model.RestoreCartItems();
        }
    }
}
