using MySql.Data.MySqlClient;

namespace StoreManagement.DAL.Entities
{
    public class Clothes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Size { get; set; }
        public string Colour { get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }

        public Clothes() { }
        public Clothes(MySqlDataReader reader)
        {
            Id = int.Parse(reader["Id"].ToString());
            Name = reader["Name"].ToString();
            Category = reader["Category"].ToString();
            Size = reader["Size"].ToString();
            Colour = reader["Colour"].ToString();
            Price = int.Parse(reader["Price"].ToString());
            Amount = int.Parse(reader["Amount"].ToString());
        }
        public string ToInsert()
        {
            return $"('{Name}', '{Category}', '{Size}', '{Colour}', {Price}, {Amount})";
        }
    }
}
