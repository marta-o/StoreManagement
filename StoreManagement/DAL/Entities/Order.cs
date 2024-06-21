using System;
using MySql.Data.MySqlClient;

namespace StoreManagement.DAL.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int IdClient { get; set; }
        public int Thing1 { get; set; }
        public int? Thing2 { get; set; }
        public int? Thing3 { get; set; }
        public int? Thing4 { get; set; }
        public int? Thing5 { get; set; }

        public Order() { }
        public Order(MySqlDataReader reader)
        {
            Id = int.Parse(reader["Id"].ToString());
            OrderDate = DateTime.Parse(reader["OrderDate"].ToString());
            IdClient = int.Parse(reader["IdClient"].ToString());
            Thing1 = int.Parse(reader["Thing1"].ToString());
            Thing2 = reader["Thing2"] == DBNull.Value ? (int?)null : int.Parse(reader["Thing2"].ToString());
            Thing3 = reader["Thing3"] == DBNull.Value ? (int?)null : int.Parse(reader["Thing3"].ToString());
            Thing4 = reader["Thing4"] == DBNull.Value ? (int?)null : int.Parse(reader["Thing4"].ToString());
            Thing5 = reader["Thing5"] == DBNull.Value ? (int?)null : int.Parse(reader["Thing5"].ToString());
        }

        public string ToInsert()
        {
            string thing2Value = Thing2.HasValue ? Thing2.Value.ToString() : "NULL";
            string thing3Value = Thing3.HasValue ? Thing3.Value.ToString() : "NULL";
            string thing4Value = Thing4.HasValue ? Thing4.Value.ToString() : "NULL";
            string thing5Value = Thing5.HasValue ? Thing5.Value.ToString() : "NULL";

            return $"('{OrderDate:yyyy-MM-dd HH:mm:ss}', {IdClient}, {Thing1}, {thing2Value}, {thing3Value}, {thing4Value}, {thing5Value})";
        }
    }
}
