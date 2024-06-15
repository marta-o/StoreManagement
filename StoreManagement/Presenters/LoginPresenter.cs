using StoreManagement.Views.StartViews;
using StoreManagement.DAL.Entities;
using StoreManagement.DAL;
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
        private ILoginView _loginView;
        public LoginPresenter(ILoginView view)
        {
            _loginView = view;
        }

        public void Login()
        {
            string username = _loginView.Username;
            string password = _loginView.Password;

            User user = ValidateUser(username, password);

            if (user != null)
            {
                if (user.Type.ToLower() == "client")
                {
                    _loginView.NavigateToClientView();
                }
                else if (user.Type.ToLower() == "worker")
                {
                    _loginView.NavigateToWorkerView();
                }
            }
            else
            {
                _loginView.ShowMessage("Niepoprawne dane logowania. Spróbuj ponownie.");
            }
        }

        private User ValidateUser(string username, string password)
        {
            using (var connection = DBConnection.Instance.Connection)
            {
                var query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User(reader);
                        }
                    }
                }
            }
            return null;
        }
    }
}
