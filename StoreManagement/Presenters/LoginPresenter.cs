﻿using StoreManagement.Views.StartViews;
using StoreManagement.DAL.Entities;
using StoreManagement.DAL;
using StoreManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StoreManagement.Presenters
{
    public class LoginPresenter
    {
        private ILoginView _view;
        private Model _model;
        public LoginPresenter(ILoginView view, Model model)
        {
            _view = view;
            _model = model;
        }

        public void Login()
        {
            string username = _view.Username;
            string password = _view.Password;

            User user = ValidateUser(username, password);

            if (user != null)
            {
                if (user.Type.ToLower() == "client")
                {
                    _view.NavigateToClientView(user.Id);
                }
                else if (user.Type.ToLower() == "worker")
                {
                    _view.NavigateToWorkerView(user.Id);
                }
            }
            else
            {
                _view.ShowMessage("Niepoprawne dane logowania. Spróbuj ponownie.");
            }
        }
        private User ValidateUser(string username, string password)
        {
            return _model.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }
    }
}
