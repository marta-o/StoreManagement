using System;
using System.Collections.Generic;
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
                string ADD_USER = "INSERT INTO Users (Name, Surname, Address, Phone, Username, Password, Type) VALUES (@Name, @Surname, @Address, @Phone, @Username, @Password, @Type); SELECT LAST_INSERT_ID();";
                MySqlCommand command = new MySqlCommand(ADD_USER, connection);
                command.Parameters.AddWithValue("@Name", user.Name);
                command.Parameters.AddWithValue("@Surname", user.Surname);
                command.Parameters.AddWithValue("@Address", user.Address);
                command.Parameters.AddWithValue("@Phone", user.Phone);
                command.Parameters.AddWithValue("@Username", user.Username);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@Type", user.Type);
                connection.Open();
                var result = command.ExecuteScalar();
                connection.Close();

                if (result != null)
                {
                    user.Id = Convert.ToInt32(result);
                    return true;
                }
                return false;
            }
        }
        public static bool DeleteUserInDB(User user)
        {
            try
            {
                using (var connection = DBConnection.Instance.CreateConnection())
                {
                    string DELETE_USER = "DELETE FROM Users WHERE Id = @Id";
                    MySqlCommand command = new MySqlCommand(DELETE_USER, connection);
                    command.Parameters.AddWithValue("@Id", user.Id);
                    connection.Open();
                    var result = command.ExecuteNonQuery();
                    connection.Close();
                    return result > 0;
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451)
                {
                    throw new InvalidOperationException("Cannot delete user. The user has associated orders.");
                }
                throw;
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
