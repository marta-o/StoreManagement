using MySql.Data.MySqlClient;
using StoreManagement.Views.StartViews;
using StoreManagement.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Presenters
{
    public class AddNewUserPresenter
    {
        private IAddNewUserView _addNewUserView;
        public AddNewUserPresenter(IAddNewUserView view)
        {
            _addNewUserView = view;
            _addNewUserView.AddUser += Create;

        }
        public void Create(object sender, EventArgs e)
        {
            string name = _addNewUserView.UserName;
            string surname = _addNewUserView.Surname;
            string address = _addNewUserView.Address;
            string phone = _addNewUserView.Phone;
            string username = _addNewUserView.Username;
            string password = _addNewUserView.Password;
            string type = "client";

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) ||
                string.IsNullOrEmpty(address) || string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                _addNewUserView.ShowMessage("Wszystkie pola muszą być uzupełnione.");
                return;
            }
            bool isAdded = AddUserToDatabase(name, surname, address, phone, username, password, type);
            if (isAdded)
            {
                _addNewUserView.ShowMessage("Dodano nowego użytkownika.");
            }
            else
            {
                _addNewUserView.ShowMessage("Błąd podczas dodawania.");
            }
        }

        private bool AddUserToDatabase(string name, string surname, string address, string phone, string username, string password, string type)
        {
            try
            {
                using (var connection = DBConnection.Instance.GetConnection())
                {
                    connection.Open();
                    var query = "INSERT INTO Users (Name, Surname, Address, Phone, Username, Password, Type) VALUES (@Name, @Surname, @Address, @Phone, @Username, @Password, @Type)";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Surname", surname);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Type", type);

                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                _addNewUserView.ShowMessage($"Error: {ex.Message}");
                return false;
            }
        }
    }
}
