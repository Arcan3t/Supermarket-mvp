using System;
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
    internal class CategoryModeRespository : BaseRepository, ICategoryModeRespository
    {
        public CategoryModeRespository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(CategoryModeModel categoryModeModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Categories VALUES (@name, @observation)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categoryModeModel.Name;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = categoryModeModel.Observation;
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
                command.CommandText = "DELETE FROM Categories WHERE Category_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(CategoryModeModel categoryModeModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Categories SET Category_Name = @name, Category_Observation = @observation WHERE Category_Id = @id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categoryModeModel.Name;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = categoryModeModel.Observation;
                command.Parameters.Add("@id", SqlDbType.Int).Value = categoryModeModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<CategoryModeModel> GetAll()
        {
            var categoryModeList = new List<CategoryModeModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Categories ORDER BY Category_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoryModeModel = new CategoryModeModel();
                        categoryModeModel.Id = (int)reader["Category_Id"];
                        categoryModeModel.Name = reader["Category_Name"].ToString();
                        categoryModeModel.Observation = reader["Category_Observation"].ToString();
                        categoryModeList.Add(categoryModeModel);
                    }
                }
            }
            return categoryModeList;
        }

        public IEnumerable<CategoryModeModel> GetByValue(string value)
        {
            var categoryModeList = new List<CategoryModeModel>();
            int categoryModeId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string categoryModeName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Categories
                                        WHERE Category_Id = @id or Category_Name LIKE @name+ '%'
                                        ORDER By Category_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = categoryModeId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categoryModeName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoryModeModel = new CategoryModeModel();
                        categoryModeModel.Id = (int)reader["Category_Id"];
                        categoryModeModel.Name = reader["Category_Name"].ToString();
                        categoryModeModel.Observation = reader["Category_Observation"].ToString();
                        categoryModeList.Add(categoryModeModel);
                    }
                }
            }
            return categoryModeList;
        }
    }
}
