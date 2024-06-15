﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.DAL
{
    internal class DBConnection
    {
        private MySqlConnectionStringBuilder stringBuilder = new MySqlConnectionStringBuilder();

        private static DBConnection instance = null;
        public static DBConnection Instance
        {
            get
            {
                if (instance == null)
                    instance = new DBConnection();
                return instance;
            }
        }

        private MySqlConnection connection;
        public MySqlConnection Connection
        {
            get
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                return connection;
            }
        }

        private DBConnection()
        {

            //stworzenie connection stringa na podstawie danych zapisanych w Settings do których mamy dostęp spoza aplikacji 
            stringBuilder.UserID = Properties.Settings.Default.userID;
            stringBuilder.Server = Properties.Settings.Default.server;
            stringBuilder.Database = Properties.Settings.Default.database;
            stringBuilder.Port = Properties.Settings.Default.port;
            stringBuilder.Password = Properties.Settings.Default.paswd;

            connection = new MySqlConnection(stringBuilder.ToString());
        }
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(stringBuilder.ToString());
        }
    }
}
