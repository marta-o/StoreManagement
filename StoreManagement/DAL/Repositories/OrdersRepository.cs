using MySql.Data.MySqlClient;
using StoreManagement.DAL.Entities;
using System;
using System.Collections.Generic;

namespace StoreManagement.DAL.Repositories
{
    class OrdersRepository
    {
        public static List<Order> LoadAllOrders()
        {
            List<Order> orders = new List<Order>();

            using (var connection = DBConnection.Instance.CreateConnection())
            {
                string ALL_ORDERS = "SELECT * FROM orders";
                MySqlCommand command = new MySqlCommand(ALL_ORDERS, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    orders.Add(new Order(reader));
                connection.Close();
            }
            return orders;
        }
        public static List<Order> LoadUsersOrders(int clientId)
        {
            List<Order> orders = new List<Order>();

            using (var connection = DBConnection.Instance.CreateConnection())
            {
                string USER_ORDERS = "SELECT * FROM orders WHERE IdClient = @ClientId";
                MySqlCommand command = new MySqlCommand(USER_ORDERS, connection);
                command.Parameters.AddWithValue("@ClientId", clientId);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    orders.Add(new Order(reader));
                connection.Close();
            }
            return orders;
        }
        public static bool AddNewOrderToDB(Order order)
        {
            using (var connection = DBConnection.Instance.CreateConnection())
            {
                string ADD_ORDER = "INSERT INTO Orders (OrderDate, IdClient, Thing1, Thing2, Thing3, Thing4, Thing5) VALUES (@OrderDate, @IdClient, @Thing1, @Thing2, @Thing3, @Thing4, @Thing5); SELECT LAST_INSERT_ID();";
                MySqlCommand command = new MySqlCommand(ADD_ORDER, connection);
                command.Parameters.AddWithValue("@OrderDate", order.OrderDate);
                command.Parameters.AddWithValue("@IdClient", order.IdClient);
                command.Parameters.AddWithValue("@Thing1", order.Thing1);
                command.Parameters.AddWithValue("@Thing2", order.Thing2);
                command.Parameters.AddWithValue("@Thing3", order.Thing3);
                command.Parameters.AddWithValue("@Thing4", order.Thing4);
                command.Parameters.AddWithValue("@Thing5", order.Thing5);
                connection.Open();
                var result = command.ExecuteScalar();
                connection.Close();

                if (result != null)
                {
                    order.Id = Convert.ToInt32(result);
                    return true;
                }
                return false;
            }
        }
        public static bool DeleteOrderInDB(Order order)
        {
            using (var connection = DBConnection.Instance.CreateConnection())
            {
                string DELETE_ORDER = "DELETE FROM Orders WHERE Id = @Id";
                MySqlCommand command = new MySqlCommand(DELETE_ORDER, connection);
                command.Parameters.AddWithValue("@Id", order.Id);
                connection.Open();
                var result = command.ExecuteNonQuery();
                connection.Close();
                return result > 0;
            }
        }
    }
}
