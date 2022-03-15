using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using Trainee;

namespace FreshersManagement.Data
{
    public class DataAccess : IDataAccess
    {
        DatabaseManager databaseManager = new DatabaseManager();
        public int SaveTrainee(Fresher fresher)
        {
            SqlConnection sqlConnection = null;
            int numberOfRowsAffected = 0; 

            try
            {
                sqlConnection = databaseManager.GetConnection();
                SqlCommand sqlCommand = databaseManager.GetCommand($"spSaveTrainee", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", fresher.Id);
                sqlCommand.Parameters.AddWithValue("@name", fresher.Name);
                sqlCommand.Parameters.AddWithValue("@mobileNumber", fresher.MobileNumber);
                sqlCommand.Parameters.AddWithValue("@dateOfBirth", fresher.DateOfBirth);
                sqlCommand.Parameters.AddWithValue("@qualification", fresher.Qualification);
                sqlCommand.Parameters.AddWithValue("@address", fresher.Address);
                numberOfRowsAffected = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
            }
            finally
            {
                sqlConnection.Close();
            }

            return numberOfRowsAffected;
        }
        public List<Fresher> FetchTrainees()
        {
            SqlConnection sqlConnection = databaseManager.GetConnection();
            SqlCommand sqlCommand = databaseManager.GetCommand("spSelectTrainees", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            var freshers = new List<Fresher>();

            while (sqlDataReader.Read())
            {
                var fresher = new Fresher(Convert.ToInt32(sqlDataReader["Id"])
                    , Convert.ToString(sqlDataReader["Name"])
                    , Convert.ToInt64(sqlDataReader["MobileNumber"])
                    , Convert.ToDateTime(sqlDataReader["DateOfBirth"])
                    , Convert.ToString(sqlDataReader["Qualification"])
                    , Convert.ToString(sqlDataReader["Address"]));
                freshers.Add(fresher);
            }

            return freshers;
        }

        public void DeleteTrainee(int id)
        {
            SqlConnection sqlConnection = null;

            try
            {
                sqlConnection = databaseManager.GetConnection();
                SqlCommand sqlCommand = databaseManager.GetCommand($"spDeleteTrainee {id}", sqlConnection);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}

