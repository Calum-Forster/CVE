using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace CVEDashboard.Models
{
    public class DBMethods
    {

        private SqlConnection connection;

        public SqlConnection getConnection()
        {
            string connectionString = "";

            connection = new SqlConnection(connectionString);
            connection.Open();

            Trace.WriteLine("Connection Established");

            return connection;
        }

        public SqlDataReader getReader(string query)
        {
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Connection = this.getConnection();

            SqlDataReader reader = cmd.ExecuteReader();

            Trace.WriteLine("Reading.....");
            return reader;
        }

    }
}