﻿using StoreManagement.Views.ClientViews;
using StoreManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreManagement.DAL.Entities;
using System.Windows.Forms;
using StoreManagement.DAL.Repositories;

namespace StoreManagement.Presenters
{
    public class ClientCartPresenter
    {
        private IClientCartView _view;
        private Model _model;
        private int _clientId;

        public ClientCartPresenter(IClientCartView view, Model model, int clientId)
        {
            _view = view;
            _model = model;
            _clientId = clientId;
            LoadCartItems();
        }
        public Model Model => _model;
        public void LoadCartItems()
        {
            _view.DisplayCartItems(_model.GetCartItems());
        }
        public void RemoveFromCart(Clothes clothes)
        {
            _model.RemoveFromCart(clothes);
            clothes.Amount++;
            _model.UpdateClothes(clothes);
            LoadCartItems();
        }
        public void PurchaseItems()
        {
            if (_model.CartItems.Count <= 5)
            {
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
                OrdersRepository.AddNewOrderToDB(order);
                _model.ClearCart();
                /*foreach (var clothes in _cartItems)
                {
                    _model.UpdateClothesAmount(clothes, -1);
                }*/
                _view.ShowMessage("Purchase completed successfully!");
                LoadCartItems();
            }
            else
            {
                _view.ShowMessage("You can only purchase up to 5 items per order.");
            }
        }

        public void Logout()
        {
            _model.RestoreCartItems();
        }
    }
}
