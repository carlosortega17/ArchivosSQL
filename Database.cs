using System.Data.SqlClient;

namespace ArchivosDB
{
    class Database
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection("Data Source=ATROX\\SQLEXPRESS;Initial Catalog=Ejemplos;Integrated Security=True");
            connection.Open();
            return connection;
        }
    }
}
