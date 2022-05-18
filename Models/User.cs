using System.Data.SqlClient;

namespace ArchivosDB.Models
{
    class User : IUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public byte[] Avatar { get; set; }

        private SqlConnection connection;

        public User()
        {
            connection = Database.GetConnection();
        }

        public User(string username, string password, string email, byte[] avatar)
        {
            connection = Database.GetConnection();
            Username = username;
            Password = password;
            Email = email;
            Avatar = avatar;
            Insert(this);
        }

        public void Insert(IUser user)
        {
            string query = "INSERT INTO Users (Username, Password, Email, Avatar) VALUES (@Username, @Password, @Email, @Avatar)";
            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@Username", user.Username);
            command.Parameters.AddWithValue("@Password", user.Password);
            command.Parameters.AddWithValue("@Email", user.Email);
            command.Parameters.AddWithValue("@Avatar", user.Avatar);
            command.ExecuteNonQuery();
            command.Dispose();
        }

        public void Update(IUser user)
        {

        }

        ~User()
        {
            connection.Close();
            connection = null;
        }
    }
}
