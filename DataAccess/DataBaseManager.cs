using System.Data.SqlClient;

namespace FreshersManagement.Data
{
    public class DatabaseManager
    {
        private SqlConnection sqlConnection;

        public SqlConnection GetConnection()
        {
            string connectionString = "data source=.; database=Freshers; integrated security=SSPI";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            return sqlConnection;
        }

        public SqlCommand GetCommand(string command, SqlConnection sqlConnection)
        {
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

            return sqlCommand;
        }

    }
}