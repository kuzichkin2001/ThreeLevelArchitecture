using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DAO_Interface;
using ProjectEntities;

namespace DAO
{
    public class ProductDao : IProductDao
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;
        public void AddNewProduct(Product value)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddNewProduct";
                cmd.Parameters.AddWithValue("@productName", value.ProductName);
                cmd.Parameters.AddWithValue("@cost", value.Cost);
                cmd.Parameters.AddWithValue("@salePercent", value.SaleInfo.SalePercent);
                cmd.Parameters.Add(new SqlParameter
                {
                    DbType = DbType.DateTime,
                    ParameterName = "saleStartDate",
                    Direction = ParameterDirection.Input,
                    Value = value.SaleInfo.SaleStartDate == null ? (object)DBNull.Value : value.SaleInfo.SaleStartDate,
                });
                cmd.Parameters.Add(new SqlParameter
                {
                    DbType = DbType.DateTime,
                    ParameterName = "saleEndDate",
                    Direction = ParameterDirection.Input,
                    Value = value.SaleInfo.SaleEndDate == null ? (object)DBNull.Value : value.SaleInfo.SaleEndDate,
                });

                var idProduct = new SqlParameter
                {
                    DbType = DbType.Int32,
                    ParameterName = "idProduct",
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(idProduct);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public IEnumerable<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllProducts";
                connection.Open();

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    products.Add(new Product(
                        productName: Convert.ToString(reader["ProductName"]),
                        cost: Convert.ToDouble(reader["Cost"]),
                        id: (int)reader["ID_Product"],
                        saleInfo: new Sale(
                            salePercent: Convert.ToDouble(reader["SalePercent"]),
                            saleStartDate: 
                                reader["SaleStartDate"] is DBNull ? null : (DateTime?)Convert.ToDateTime(reader["SaleStartDate"]),
                            saleEndDate:
                                reader["SaleEndDate"] is DBNull ? null : (DateTime?)Convert.ToDateTime(reader["SaleEndDate"])
                        )
                    ));
                }
            }
            return products;
        }
        public IEnumerable<Product> SearchByProductName(string productName)
        {
            List<Product> searchResult = new List<Product>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SearchByProductName";
                cmd.Parameters.AddWithValue("@productName", productName);
                connection.Open();

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    searchResult.Add(new Product(
                        productName: Convert.ToString(reader["ProductName"]),
                        cost: Convert.ToDouble(reader["Cost"]),
                        id: Convert.ToInt32(reader["ID_Product"]),
                        saleInfo: new Sale(
                            salePercent: Convert.ToDouble(reader["SalePercent"]),
                            saleStartDate:
                                reader["SaleStartDate"] is DBNull ? null : (DateTime?)Convert.ToDateTime(reader["SaleStartDate"]),
                            saleEndDate:
                                reader["SaleEndDate"] is DBNull ? null : (DateTime?)Convert.ToDateTime(reader["SaleEndDate"])
                        )
                    ));
                }
            }
            return searchResult;
        }
        public void DeleteProduct(int idProduct)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteProduct";
                cmd.Parameters.AddWithValue("@idProduct", idProduct);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteSaleInfo(int idProduct)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteSaleInfo";
                cmd.Parameters.AddWithValue("@idProduct", idProduct);
                connection.Open();

                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateSaleInfo(int idProduct, double cost, double salePercent, DateTime? saleStartDate, DateTime? saleEndDate)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateSaleInfo";
                cmd.Parameters.AddWithValue("@idProduct", idProduct);
                cmd.Parameters.AddWithValue("@cost", cost);
                cmd.Parameters.AddWithValue("@salePercent", salePercent);
                cmd.Parameters.Add(new SqlParameter
                {
                    DbType = DbType.DateTime,
                    ParameterName = "saleStartDate",
                    Direction = ParameterDirection.Input,
                    Value = saleStartDate == null ? (object)DBNull.Value : (DateTime)saleStartDate,
                });
                cmd.Parameters.Add(new SqlParameter
                {
                    DbType = DbType.DateTime,
                    ParameterName = "saleEndDate",
                    Direction = ParameterDirection.Input,
                    Value = saleEndDate == null ? (object)DBNull.Value : saleEndDate,
                });
                connection.Open();

                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<Product> GetAllSaleInfo()
        {
            List<Product> sales = new List<Product>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllSaleInfo";
                connection.Open();

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    sales.Add(new Product(
                        productName: Convert.ToString(reader["ProductName"]),
                        cost: Convert.ToDouble(reader["Cost"]),
                        saleInfo: new Sale(
                            salePercent: Convert.ToDouble(reader["SalePercent"]),
                            saleStartDate:
                                reader["SaleStartDate"] is DBNull ? null : (DateTime?)Convert.ToDateTime(reader["SaleStartDate"]),
                            saleEndDate:
                                reader["SaleEndDate"] is DBNull ? null : (DateTime?)Convert.ToDateTime(reader["SaleEndDate"])
                        )
                    ));
                }
            }
            return sales;
        }

        public IEnumerable<Product> SearchBySaleDate(DateTime currentDate)
        {
            List<Product> searchResult = new List<Product>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SearchBySaleDate";
                cmd.Parameters.AddWithValue("@currentDate", currentDate);
                connection.Open();

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    searchResult.Add(new Product(
                        productName: Convert.ToString(reader["ProductName"]),
                        cost: Convert.ToDouble(reader["Cost"]),
                        id: Convert.ToInt32(reader["ID_Product"]),
                        saleInfo: new Sale(
                            salePercent: Convert.ToDouble(reader["SalePercent"]),
                            saleStartDate:
                                reader["SaleStartDate"] is DBNull ? null : (DateTime?)Convert.ToDateTime(reader["SaleStartDate"]),
                            saleEndDate:
                                reader["SaleEndDate"] is DBNull ? null : (DateTime?)Convert.ToDateTime(reader["SaleEndDate"])
                        )
                    ));
                }
            }
            return searchResult;
        }
    }
}
