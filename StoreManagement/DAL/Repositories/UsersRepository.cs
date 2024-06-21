using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreManagement.DAL.Entities;
using MySql.Data.MySqlClient;

namespace StoreManagement.DAL.Repositories
{
    class UsersRepository
    {
        public static List<User> LoadAllUsers()
        {
            List<User> users = new List<User>();

            using (var connection = DBConnection.Instance.CreateConnection())
            {
                string ALL_USERS = "SELECT * FROM users";
                MySqlCommand command = new MySqlCommand(ALL_USERS, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    users.Add(new User(reader));
                connection.Close();
            }
            return users;
        }
        public static bool AddNewUserToDB(User user)
        {
            using (var connection = DBConnection.Instance.CreateConnection())
            {
                string ADD_USER = "INSERT INTO Users (Name, Surname, Address, Phone, Username, Password, Type) VALUES " + user.ToInsert();
                MySqlCommand command = new MySqlCommand(ADD_USER, connection);
                connection.Open();
                var result = command.ExecuteNonQuery();
                connection.Close();
                return result > 0;
            }
        }
        public static bool IsUsernameInDB(string username)
        {
            using (var connection = DBConnection.Instance.CreateConnection())
            {
                string CHECK_USERNAME = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                MySqlCommand command = new MySqlCommand(CHECK_USERNAME, connection);
                command.Parameters.AddWithValue("@Username", username);
                connection.Open();
                var count = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
                return count > 0;
            }
        }
    }
}
