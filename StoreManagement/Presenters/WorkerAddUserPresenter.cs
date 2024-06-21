using MySql.Data.MySqlClient;
using StoreManagement.Views.WorkerViews;
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
    public class WorkerAddUserPresenter
    {
        private IWorkerAddUserView _view;
        private Model _model;

        public WorkerAddUserPresenter(IWorkerAddUserView view, Model model)
        {
            _view = view;
            _model = model;
            _view.AddUser += Create;
        }
        public Model Model => _model;
        public void Create(object sender, EventArgs e)
        {
            string name = _view.UserName;
            string surname = _view.Surname;
            string address = _view.Address;
            string phone = _view.Phone;
            string username = _view.Username;
            string password = _view.Password;
            string type = "worker";

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) ||
                string.IsNullOrEmpty(address) || string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                _view.ShowMessage("All fields must be completed.");
                return;
            }
            if (_model.IsUsernameTaken(username))
            {
                _view.ShowMessage("Username is already taken.");
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
                _view.ShowMessage("A new user has been added.");
            }
            else
            {
                _view.ShowMessage("Error adding.");
            }
        }
    }
}
