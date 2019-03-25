using System.Data;

namespace CustomPage.Factories
{
    public class SqlServerEngineSpecifications : ISqlEngineSpecifications
    {
        private readonly string _connectionString;
       
        public SqlServerEngineSpecifications(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection CreateAndOpenConnection()
        {
            var sqlConnection = new System.Data.SqlClient.SqlConnection(_connectionString);

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            return sqlConnection;
        }
    }
}