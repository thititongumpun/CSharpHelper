using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CustomerOrderViewer.Models;

namespace CustomerOrderViewer.Repository
{
    public class CustomerOrderDetailRepo
    {
        private string _connectionString;
        public CustomerOrderDetailRepo(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IList<CustomerOrderDetail> GetList()
        {
            List<CustomerOrderDetail> customerOrderDetails = new List<CustomerOrderDetail>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT CustomerOrderId, CustomerId, ItemId, FirstName, LastName, [Description], Price FROM CustomerOrderDetail", connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                CustomerOrderDetail customerOrderDetail = new CustomerOrderDetail()
                                {
                                    CustomerOrderId = Convert.ToInt32(reader["CustomerOrderId"]),
                                    CustomerId = Convert.ToInt32(reader["CustomerId"]),
                                    ItemId = Convert.ToInt32(reader["ItemId"]),
                                    FirstName = reader["FirstName"].ToString(),
                                    LastName = reader["LastName"].ToString(),
                                    Description = reader["Description"].ToString(),
                                    Price = Convert.ToDecimal(reader["Price"])
                                };

                                customerOrderDetails.Add(customerOrderDetail);
                            }
                        }
                    }
                }
            }

            using var file = new System.IO.StreamWriter("WriteLines2.txt");

            return customerOrderDetails;
        }
    }
}