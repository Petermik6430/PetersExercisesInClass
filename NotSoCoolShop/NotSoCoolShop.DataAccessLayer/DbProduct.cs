using NotSoCoolShop.DataAccessLayer.Interfaces;
using NotSoCoolShop.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotSoCoolShop.DataAccessLayer
{
   public class DbProduct : ICRUD<Product>
    {
    private string _connectionString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        public void Create(Product entity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using(SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Product (Title, Price) VALUES (@Title, @Price)";
                    cmd.Parameters.AddWithValue("Title", entity.Title);
                    cmd.Parameters.AddWithValue("Price", entity.Price);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable GetAll()
        {
            List<Product> products= new List<Product>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT Id, Title,Price FROM Product";
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Product product = new Product();
                        product.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                        product.Title = reader.GetString(reader.GetOrdinal("Title"));
                        product.Price = reader.GetDecimal(reader.GetOrdinal("Price"));
                        products.Add(product);
                    }
                    return products;


                }
               
            }


        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
