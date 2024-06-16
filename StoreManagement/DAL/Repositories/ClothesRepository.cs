﻿using MySql.Data.MySqlClient;
using StoreManagement.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.DAL.Repositories
{
    class ClothesRepository
    {
        public static List<Clothes> LoadAllClothes()
        {
            List<Clothes> clothes = new List<Clothes>();

            using (var connection = DBConnection.Instance.CreateConnection())
            {
                string ALL_CLOTHES = "SELECT * FROM clothes";
                MySqlCommand command = new MySqlCommand(ALL_CLOTHES, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    clothes.Add(new Clothes(reader));
                connection.Close();
            }
            return clothes;
        }

        public static bool AddNewClothesToDB(Clothes clothes)
        {
            using (var connection = DBConnection.Instance.CreateConnection())
            {
                string query = "INSERT INTO Clothes (Name, Category, Size, Colour, Price, Amount) VALUES " + clothes.ToInsert();
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();
                var result = command.ExecuteNonQuery();
                connection.Close();
                return result > 0;
            }
            /*bool state = false;
            using (var connection = DBConnection.Instance.Connection)
            {

                string ADD_CLOTHES = "INSERT INTO clothes (Name, Category, Size, Colour, Price, Amount) VALUES ";
                MySqlCommand command = new MySqlCommand($"{ADD_CLOTHES} {clothes.ToInsert()}", connection);
                connection.Open();
                var n = command.ExecuteNonQuery();
                if (n == 1) //nie wiem czy z if (bro mial tu bez if)
                    state = true;
                clothes.Id = (int)command.LastInsertedId;
                connection.Close();
            }
            return state;*/
        }

        /*public static bool EditClothesInDB(Clothes clothes, int idClothes)
        {
            bool state = false;
            using (var connection = DBConnection.Instance.Connection)
            {
                string EDIT_CLOTHES = $"UPDATE clothes SET Name='{clothes.Name}', Category='{clothes.Category}', Size='{clothes.Size}', Colour='{clothes.Colour}', " +
                    $"Price={clothes.Price}, Amount={clothes.Amount}, WHERE Id={idClothes}";
                MySqlCommand command = new MySqlCommand(EDIT_CLOTHES, connection);
                connection.Open();
                var n = command.ExecuteNonQuery();
                if (n == 1)
                    state = true;
                connection.Close();
            }
            return state;
        }

        public static bool RemoveClothesFromDB(Clothes clothes)
        {
            //nie wiem co tu ma byc na razie
            return true;
        }*/
    }
}
