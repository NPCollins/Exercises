using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SSGeek.Models;
using System.Data.SqlClient;

namespace SSGeek.DAL
{
    public class ProductSqlDAL : IProductDAL
    {
        private string connectionString = @"Data Source=DESKTOP-CTIJ0GB\SQLEXPRESS;Initial Catalog=AlienShoppingDatabase;Integrated Security=True";
        private string sqlCommandShowAllProducts = "Select * from products";
        private string sqlCommandShowProduct = "Select * from products WHERE product_id = @id;";
        public string SqlCommandShowProduct { get { return sqlCommandShowProduct; } }

        public string SqlCommandShowAllProducts
        {
            get { return sqlCommandShowAllProducts; } 
        }


        public string ConnectionString { get { return connectionString; } }

        public Product GetProduct(int id)
        {
            Product product = new Product();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand(SqlCommandShowProduct, conn);
                    command.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {


                        product.ProductId = Convert.ToInt32(reader["product_id"]);
                        product.Price = Convert.ToDouble(reader["price"]);
                        product.Name = Convert.ToString(reader["name"]);
                        product.ImageName = Convert.ToString(reader["image_name"]);
                        product.Description = Convert.ToString(reader["description"]);

                    }

                }
                return product;
            }
            catch (Exception)
            {

                throw;
            }
        }
       
        public List<Product> GetProducts()
        {
            List<Product> productList = new List<Product>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(SqlCommandShowAllProducts, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Product tempProduct = new Product();

                        tempProduct.ProductId = Convert.ToInt32(reader["product_id"]);
                        tempProduct.Price = Convert.ToDouble(reader["price"]);
                        tempProduct.Name = Convert.ToString(reader["name"]);
                        tempProduct.ImageName = Convert.ToString(reader["image_name"]);
                        tempProduct.Description = Convert.ToString(reader["description"]);

                        productList.Add(tempProduct);

                    }

                }
                return productList;
            }
            catch (Exception)
            {

                throw;
            }
        }

		
    }
}