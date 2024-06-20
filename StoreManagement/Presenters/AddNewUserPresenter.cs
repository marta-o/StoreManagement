﻿using MySql.Data.MySqlClient;
using StoreManagement.Views.StartViews;
using StoreManagement.DAL;
using StoreManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreManagement.DAL.Entities;

namespace StoreManagement.Presenters
{
    public class AddNewUserPresenter
    {
        private IAddNewUserView _view;
        private Model _model;
        public AddNewUserPresenter(IAddNewUserView view, Model model)
        {
            _view = view;
            _model = model;
            _view.AddUser += Create;

        }
        public void Create(object sender, EventArgs e)
        {
            string name = _view.UserName;
            string surname = _view.Surname;
            string address = _view.Address;
            string phone = _view.Phone;
            string username = _view.Username;
            string password = _view.Password;
            string type = "client";

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) ||
                string.IsNullOrEmpty(address) || string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                _view.ShowMessage("Wszystkie pola muszą być uzupełnione.");
                return;
            }
            
            User user = new User
            {
                Name = name,
                Surname = surname,
                Address = address,
                Phone = phone,
                Username = username,
                Password = password,
                Type = type
            };

            if (_model.AddUserToDB(user))
            {
                _view.ShowMessage("Dodano nowego użytkownika.");
            }
            else
            {
                _view.ShowMessage("Błąd podczas dodawania.");
            }
        }
    }
}
