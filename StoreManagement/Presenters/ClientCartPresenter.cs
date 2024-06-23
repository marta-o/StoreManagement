using StoreManagement.Views.ClientViews;
using StoreManagement.Models;
using System;
using System.Linq;
using StoreManagement.DAL.Entities;

namespace StoreManagement.Presenters
{
    public class ClientCartPresenter
    {
        private readonly IClientCartView _view;
        private readonly Model _model;
        private readonly int _clientId;
        public ClientCartPresenter(IClientCartView view, Model model, int clientId)
        {
            _view = view;
            _model = model;
            _clientId = clientId;
            _view.Purchase += MakeOrder;
            LoadCartItems();
        }
        public Model Model => _model;
        public void LoadCartItems()
        {
            int price = 0;
            foreach (Clothes item  in _model.GetCartItems())
            {
                price += item.Price;
            }
            _view.Price = price.ToString() + " zł";
            _view.DisplayCartItems(_model.GetCartItems());
        }
        public void RemoveFromCart(Clothes clothes)
        {
            _model.RemoveFromCart(clothes);
            clothes.Amount++;
            _model.UpdateClothes(clothes);
            LoadCartItems();
        }
        public void MakeOrder(object sender, EventArgs e)
        {
            if (_model.CartItems.Count > 5)
            {
                _view.ShowMessage("You can only purchase up to 5 items per order.");
                return;
            }
            var order = new Order
            {
                OrderDate = DateTime.Now,
                IdClient = _clientId,
                Thing1 = _model.CartItems.ElementAtOrDefault(0).Id,
                Thing2 = _model.CartItems.ElementAtOrDefault(1)?.Id,
                Thing3 = _model.CartItems.ElementAtOrDefault(2)?.Id,
                Thing4 = _model.CartItems.ElementAtOrDefault(3)?.Id,
                Thing5 = _model.CartItems.ElementAtOrDefault(4)?.Id
            };

            if (_model.AddOrderToDB(order)) 
            {
                _model.ClearCart();
                _view.ShowMessage("Purchase completed successfully!");
                LoadCartItems();
            }
            else
            {
                _view.ShowMessage("Error with the order.");
            }
        }
        public void Logout()
        {
            _model.RestoreCartItems();
        }
    }
}
