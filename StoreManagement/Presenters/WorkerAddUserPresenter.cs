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
        private IWorkerAddUserView _workerAddUserView;
        private Model _model;

        public WorkerAddUserPresenter(IWorkerAddUserView view, Model model)
        {
            _workerAddUserView = view;
            _model = model;
            _workerAddUserView.AddUser += Create;

        }
        public void Create(object sender, EventArgs e)
        {
            string name = _workerAddUserView.UserName;
            string surname = _workerAddUserView.Surname;
            string address = _workerAddUserView.Address;
            string phone = _workerAddUserView.Phone;
            string username = _workerAddUserView.Username;
            string password = _workerAddUserView.Password;
            string type = "worker";

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) ||
                string.IsNullOrEmpty(address) || string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                _workerAddUserView.ShowMessage("All fields must be completed.");
                return;
            }
            if (_model.IsUsernameTaken(username))
            {
                _workerAddUserView.ShowMessage("Username is already taken.");
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
                _workerAddUserView.ShowMessage("A new user has been added.");
            }
            else
            {
                _workerAddUserView.ShowMessage("Error adding.");
            }
        }
    }
}
