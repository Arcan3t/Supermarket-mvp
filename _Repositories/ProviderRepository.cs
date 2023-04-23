﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using Supermarket_mvp.Models;
using System.Data;

namespace Supermarket_mvp._Repositories
{
    internal class ProviderRepository : BaseRepository, IProviderRepository
    {
        public ProviderRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(ProviderModel providerModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Providers VALUES (@name)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = providerModel.Name;
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
                command.CommandText = "DELETE FROM Providers WHERE Provider_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(ProviderModel providerModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Providers SET Provider_Name = @name WHERE Provider_Id = @id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = providerModel.Name;
                command.Parameters.Add("@id", SqlDbType.Int).Value = providerModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ProviderModel> GetAll()
        {
            var providerList = new List<ProviderModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Providers ORDER BY Provider_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var providerModel = new ProviderModel();
                        providerModel.Id = (int)reader["Provider_Id"];
                        providerModel.Name = reader["Provider_Name"].ToString();
                        providerList.Add(providerModel);
                    }
                }
            }
            return providerList;
        }

        public IEnumerable<ProviderModel> GetByValue(string value)
        {
            var providerList = new List<ProviderModel>();
            int providerId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string providerName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Providers 
                                        WHERE Provider_Id = @id or Provider_Name LIKE @name+ '%'
                                        ORDER By Provider_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = providerId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = providerName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var providerModel = new ProviderModel();
                        providerModel.Id = (int)reader["Provider_Id"];
                        providerModel.Name = reader["Provider_Name"].ToString();
                        providerList.Add(providerModel);
                    }
                }
            }
            return providerList;
        }
    }
}
