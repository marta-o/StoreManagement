﻿using MySql.Data.MySqlClient;
using StoreManagement.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                string ALL_ORDERS = "SELECT * FROM orders WHERE IdClient = " + clientId;
                MySqlCommand command = new MySqlCommand(ALL_ORDERS, connection);
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
                string ADD_ORDER = "INSERT INTO Orders (OrderDate, IdClient, Thing1, Thing2, Thing3, Thing4, Thing5) VALUES " + order.ToInsert();
                MySqlCommand command = new MySqlCommand(ADD_ORDER, connection);
                connection.Open();
                var result = command.ExecuteNonQuery();
                connection.Close();
                return result > 0;
            }
        }
        public static bool DeleteOrderInDB(Order order)
        {
            using (var connection = DBConnection.Instance.CreateConnection())
            {
                string ADD_ORDER = "DELETE FROM Orders WHERE Id =  " + order.Id;
                MySqlCommand command = new MySqlCommand(ADD_ORDER, connection);
                connection.Open();
                var result = command.ExecuteNonQuery();
                connection.Close();
                return result > 0;
            }
        }
    }
}
