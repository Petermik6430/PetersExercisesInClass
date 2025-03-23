
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using Microsoft.IdentityModel.Tokens;
using System.Configuration;


namespace DbFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            using (var conn= new SqlConnection(connection))
            {
                connection.Open();
                Console.WriteLine("Connected to database.");
            }
        }
            
       
    }
}