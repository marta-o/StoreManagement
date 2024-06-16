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
                string query = "INSERT INTO Users (Name, Surname, Address, Phone, Username, Password, Type) VALUES " + user.ToInsert();
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();
                var result = command.ExecuteNonQuery();
                connection.Close();
                return result > 0;
            }
            /*bool state = false;
            using (var connection = DBConnection.Instance.Connection)
            {
                string ADD_USER = "INSERT INTO users (Name, Surname, Address, Phone, Username, Password, Type) VALUES ";
                MySqlCommand command = new MySqlCommand($"{ADD_USER} {user.ToInsert()}", connection);
                connection.Open();
                var n = command.ExecuteNonQuery();
                state = true;
                user.Id = (int)command.LastInsertedId;
                connection.Close();
            }
            return state;*/
        }

        // to chyba nie bedzie potrzebne
        /*public static bool EditUserInDB(User user, int idUser)
        {
            bool state = false;
            using (var connection = DBConnection.Instance.Connection)
            {
                string EDIT_USER = $"UPDATE users SET Name='{user.Name}', Surname='{user.Surname}', Address='{user.Address}', Phone='{user.Phone}', " +
                    $"Username='{user.Username}', Password='{user.Password}', Type='{user.Type}' WHERE Id={idUser}";
                MySqlCommand command = new MySqlCommand(EDIT_USER, connection);
                connection.Open();
                var n = command.ExecuteNonQuery();
                if (n == 1) 
                    state = true;
                connection.Close();
            }
            return state;
        }

        public static bool RemoveUserFromDB(User user)
        {
            //nie wiem co tu ma byc na razie
            return true;
        }*/
    }
}
