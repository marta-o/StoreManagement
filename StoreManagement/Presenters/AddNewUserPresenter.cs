using StoreManagement.Views.StartViews;
using StoreManagement.Models;
using System;
using StoreManagement.DAL.Entities;

namespace StoreManagement.Presenters
{
    public class AddNewUserPresenter
    {
        private readonly IAddNewUserView _view;
        private readonly Model _model;
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
                _view.ShowMessage("All fields must be filled.");
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
                _view.ShowMessage("New user added successfully.");
            }
            else
            {
                _view.ShowMessage("Error while adding user.");
            }
        }
    }
}
