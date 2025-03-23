using Microsoft.Data.SqlClient;
using System.Configuration;

namespace DbFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            // ConnectionString
            var connection = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

            // SQL Statement
            string getCustomer = "SELECT * FROM Customer WHERE id = @id";

            int id = 1; // Du kan ændre dette id til den kunde, du vil hente

            using (SqlConnection conn = new SqlConnection(connection))
            {
               

                using (SqlCommand readCommand = new SqlCommand(getCustomer, conn))
                {
                    readCommand.Parameters.AddWithValue("@id", id);
                        
                        if (conn != null)
                        {
                            conn.Open();
                            SqlDataReader sqlDataReader = readCommand.ExecuteReader();
                        List<Customer> customers = new List<Customer>();
                        

                        // Læs data fra databasen og vis det
                        Console.WriteLine($"Id: {sqlDataReader["Id"]}, Name: {sqlDataReader["Name"]}");
                        }
                        else
                        {
                            Console.WriteLine("No customer found with the specified ID.");
                        }
                    
                }
            }
        }
    }
}