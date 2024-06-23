using MySql.Data.MySqlClient;
using StoreManagement.DAL.Entities;
using System;
using System.Collections.Generic;


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
                string ADD_CLOTHES = "INSERT INTO Clothes (Name, Category, Size, Colour, Price, Amount) VALUES (@Name, @Category, @Size, @Colour, @Price, @Amount); SELECT LAST_INSERT_ID();";
                MySqlCommand command = new MySqlCommand(ADD_CLOTHES, connection);
                command.Parameters.AddWithValue("@Name", clothes.Name);
                command.Parameters.AddWithValue("@Category", clothes.Category);
                command.Parameters.AddWithValue("@Size", clothes.Size);
                command.Parameters.AddWithValue("@Colour", clothes.Colour);
                command.Parameters.AddWithValue("@Price", clothes.Price);
                command.Parameters.AddWithValue("@Amount", clothes.Amount);
                connection.Open();
                var result = command.ExecuteScalar();
                connection.Close();

                if (result != null)
                {
                    clothes.Id = Convert.ToInt32(result);
                    return true;
                }
                return false;
            }
        }
        public static bool DeleteClothesInDB(Clothes clothes)
        {
            try
            {
                using (var connection = DBConnection.Instance.CreateConnection())
                {
                    string DELETE_CLOTHES = "DELETE FROM Clothes WHERE Id = @Id";
                    MySqlCommand command = new MySqlCommand(DELETE_CLOTHES, connection);
                    command.Parameters.AddWithValue("@Id", clothes.Id);
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
                    throw new InvalidOperationException("Cannot delete clothes. The clothes has associated orders.");
                }
                throw;
            }
        }
        public static bool UpdateClothes(Clothes clothes)
        {
            using (var connection = DBConnection.Instance.CreateConnection())
            {
                string UPDATE_CLOTHES = "UPDATE clothes SET Name = @Name, Category = @Category, Size = @Size, Colour = @Colour, Price = @Price, Amount = @Amount WHERE Id = @Id";
                MySqlCommand command = new MySqlCommand(UPDATE_CLOTHES, connection);
                command.Parameters.AddWithValue("@Name", clothes.Name);
                command.Parameters.AddWithValue("@Category", clothes.Category);
                command.Parameters.AddWithValue("@Size", clothes.Size);
                command.Parameters.AddWithValue("@Colour", clothes.Colour);
                command.Parameters.AddWithValue("@Price", clothes.Price);
                command.Parameters.AddWithValue("@Amount", clothes.Amount);
                command.Parameters.AddWithValue("@Id", clothes.Id);
                connection.Open();
                var result = command.ExecuteNonQuery();
                connection.Close();
                return result == 1;
            }
        }
        public static List<Clothes> LoadAvailableClothes()
        {
            List<Clothes> clothes = new List<Clothes>();

            using (var connection = DBConnection.Instance.CreateConnection())
            {
                string AVAILABLE_CLOTHES = "SELECT * FROM clothes WHERE Amount > 0";
                MySqlCommand command = new MySqlCommand(AVAILABLE_CLOTHES, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    clothes.Add(new Clothes(reader));
                connection.Close();
            }
            return clothes;
        }
    }
}
