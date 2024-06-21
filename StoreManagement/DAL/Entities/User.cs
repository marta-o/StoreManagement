using MySql.Data.MySqlClient;


namespace StoreManagement.DAL.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }

        public User() { }
        public User(MySqlDataReader reader)
        {
            Id = int.Parse(reader["Id"].ToString());
            Name = reader["Name"].ToString();
            Surname = reader["Surname"].ToString();
            Address = reader["Address"].ToString();
            Phone = reader["Phone"].ToString();
            Username = reader["Username"].ToString();
            Password = reader["Password"].ToString();
            Type = reader["Type"].ToString();
        }
        public string ToInsert()
        {
            return $"('{Name}', '{Surname}', '{Address}', '{Phone}', '{Username}', '{Password}', '{Type}')";
        }
    }
}
