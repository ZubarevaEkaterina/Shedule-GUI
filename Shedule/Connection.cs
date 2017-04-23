using System.Data.OleDb;

namespace Schedule
{
    class ConnectionTo
    {
        public OleDbConnection connection = new OleDbConnection(Schedule.Properties.Settings.Default.SceduleConnectionString);
        public OleDbCommand query = new OleDbCommand();
        public OleDbDataReader reader;

        public void QueryExecuteReader(string textCommand)
        {
            connection.Open();
            query.CommandText = textCommand;
            query.Connection = connection;
            reader = query.ExecuteReader();
        }
        public void QueryExecuteNon(string textCommand)
        {
            connection.Open();
            query.CommandText = textCommand;
            query.Connection = connection;
            query.ExecuteNonQuery();
        }
        public void CloseConnection()
        {
            connection.Close();
        }
    }
}
