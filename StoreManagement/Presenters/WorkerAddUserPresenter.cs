using StoreManagement.Views.WorkerViews;
using StoreManagement.Models;
using System;
using StoreManagement.DAL.Entities;

namespace StoreManagement.Presenters
{
    public class WorkerAddUserPresenter
    {
        private readonly IWorkerAddUserView _view;
        private readonly Model _model;

        public WorkerAddUserPresenter(IWorkerAddUserView view, Model model)
        {
            _view = view;
            _model = model;
            _view.AddUser += AddUserHandler;
        }
        public Model Model => _model;
        public void AddUserHandler(object sender, EventArgs e)
        {
            string name = _view.UserName;
            string surname = _view.Surname;
            string address = _view.Address;
            string phone = _view.Phone;
            string username = _view.Username;
            string password = _view.Password;
            string type = "worker";

            if (!ValidateInput())
                return;

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
                _view.ClearFields();
                _view.ShowMessage("A new user has been added.");
            }
            else
            {
                _view.ShowMessage("Error adding.");
            }
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(_view.UserName) ||
                string.IsNullOrEmpty(_view.Surname) ||
                string.IsNullOrEmpty(_view.Address) ||
                string.IsNullOrEmpty(_view.Phone) ||
                string.IsNullOrEmpty(_view.Username) ||
                string.IsNullOrEmpty(_view.Password))
            {
                _view.ShowMessage("All fields must be completed.");
                return false;
            }
            if (_model.IsUsernameTaken(_view.Username))
            {
                _view.ShowMessage("Username is already taken.");
                return false;
            }
            return true;
        }
    }
}
