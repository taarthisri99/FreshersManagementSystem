using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Trainee;

namespace Dal
{
    public class DatabaseAccessLayer
    {
        public void InsertTrainee(Fresher fresher)
        {
            SqlConnection sqlConnection = null;

            try
            {
                sqlConnection = new SqlConnection("data source=.; database=Freshers; integrated security=SSPI");
                SqlCommand sqlCommand = new SqlCommand($"spInsertTrainees '{fresher.Name}', {fresher.MobileNumber}" +
                    $", '{fresher.DateOfBirth}', '{fresher.Qualification}', '{fresher.Address}'", sqlConnection);

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        public List<Fresher> FetchTrainees()
        {
            SqlConnection sqlConnection = null;

            sqlConnection = new SqlConnection("data source=.; database=Freshers; integrated security=SSPI");


            // writing sql query  
            SqlCommand sqlCommand = new SqlCommand("spSelectTrainees", sqlConnection);

            // Opening Connection  
            sqlConnection.Open();

            // Executing the SQL query  
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

        public void UpdateTrainee(Fresher fresher)
        {
            SqlConnection sqlConnection = null;

            try
            {
                sqlConnection = new SqlConnection("data source=.; database=Freshers; integrated security=SSPI");
                SqlCommand sqlCommand = new SqlCommand($"spUpdateTrainee {fresher.Id}, '{fresher.Name}', {fresher.MobileNumber}, '1999-04-12', '{fresher.Qualification}', '{fresher.Address}'", sqlConnection);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public void DeleteTrainee(int id)
        {
            SqlConnection sqlConnection = null;

            try
            {
                sqlConnection = new SqlConnection("data source=.; database=Freshers; integrated security=SSPI");
                SqlCommand sqlCommand = new SqlCommand($"spDeleteTrainees {id}", sqlConnection);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}

