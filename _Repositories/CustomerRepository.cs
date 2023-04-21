using Microsoft.Data.SqlClient;
using Supermarket_mvp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp._Repositories
{
    internal class CustomerRepository : BaseRepository, ICustomerRepository
    {
        public CustomerRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(CustomerModel customerModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Customers VALUES (@document_number, @first_name, @last_name, @custome_address, @birthday, @phone_number, @email)";
                command.Parameters.Add("@document_number", SqlDbType.Int).Value = customerModel.DocumentNumber;
                command.Parameters.Add("@first_name", SqlDbType.NVarChar).Value = customerModel.FirstName;
                command.Parameters.Add("@last_name", SqlDbType.NVarChar).Value = customerModel.LastName;
                command.Parameters.Add("@customer_address", SqlDbType.NVarChar).Value = customerModel.Address;
                command.Parameters.Add("@birthday", SqlDbType.Date).Value = customerModel.Birthday;
                command.Parameters.Add("@phone_number", SqlDbType.BigInt).Value = customerModel.PhoneNumber;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = customerModel.Email;
                command.ExecuteNonQuery();
            }
        }

            public void Delete(int id)
            {
                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM Customers WHERE Customer_Id = @id";
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    command.ExecuteNonQuery();
                }
            }

            public void Edit(CustomerModel customerModel)
            {
                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"UPDATE Customers SET Document_Number = @document_number, First_Name = @first_name, Last_Name = @last_name, Customer_Address = @custome_address, Birthday = @birthday, Phone_Number = @phone_number, Email = @email WHERE Customer_Id = @id)";
                    command.Parameters.Add("@document_number", SqlDbType.Int).Value = customerModel.DocumentNumber;
                    command.Parameters.Add("@first_name", SqlDbType.NVarChar).Value = customerModel.FirstName;
                    command.Parameters.Add("@last_name", SqlDbType.NVarChar).Value = customerModel.LastName;
                    command.Parameters.Add("@customer_address", SqlDbType.NVarChar).Value = customerModel.Address;
                    command.Parameters.Add("@birthday", SqlDbType.Date).Value = customerModel.Birthday;
                    command.Parameters.Add("@phone_number", SqlDbType.BigInt).Value = customerModel.PhoneNumber;
                    command.Parameters.Add("@email", SqlDbType.NVarChar).Value = customerModel.Email;
                    command.ExecuteNonQuery();
                }
            }

            public IEnumerable<CustomerModel> GetAll()
            {
                var customerList = new List<CustomerModel>();
                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Customers ORDER BY Customer_Id DESC";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var customerModel = new CustomerModel();
                            customerModel.Id = (int)reader["Customer_Id"];
                            customerModel.DocumentNumber = (int)reader["Document_Number"];
                            customerModel.FirstName = reader["First_Name"].ToString();
                            customerModel.LastName = reader["Last_Name"].ToString();
                            customerModel.Address = reader["Customer_Address"].ToString();
                            customerModel.Birthday = (DateOnly)reader["Birthday"];
                            customerModel.PhoneNumber = (long)reader["Phone_Number"];
                            customerModel.Email = reader["Email"].ToString();
                            customerList.Add(customerModel);
                        }
                    }
                }
                return customerList;
            }

            public IEnumerable<CustomerModel> GetByValue(string value)
            {
                var customerList = new List<CustomerModel>();
                int customerId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
                string customerName = value;
                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"SELECT * FROM Customers
                                        WHERE Customer_Id = @id or Document_Number LIKE @document_Number + '%'
                                        ORDER By Customer_Id DESC";
                    command.Parameters.Add("@id", SqlDbType.Int).Value = customerId;
                    command.Parameters.Add("@document_number", SqlDbType.NVarChar).Value = customerName;
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var customerModel = new CustomerModel();
                            customerModel.Id = (int)reader["Customer_Id"];
                            customerModel.DocumentNumber = (int)reader["Document_Number"];
                            customerModel.FirstName = reader["First_Name"].ToString();
                            customerModel.LastName = reader["Last_Name"].ToString();
                            customerModel.Address = reader["Customer_Address"].ToString();
                            customerModel.Birthday = (DateOnly)reader["Birthday"];
                            customerModel.PhoneNumber = (long)reader["Phone_Number"];
                            customerModel.Email = reader["Email"].ToString();
                            customerList.Add(customerModel);
                        }
                    }
                }
                return customerList;
            }
        
}
