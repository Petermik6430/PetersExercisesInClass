using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoDotNetCoreAccess.Databaselayer
{
    class TryConnection
    {
        private SqlConnection conn;

        //string connectionString = "Data Source=localhost; Database=AdoDemos; TrustServerCertificate=true; User ID=sa;Password=@12tf56so";

        public List<ConnectionState> TryConnect(string connectionString)
        {
            //bool connWasOk = false;
            List<ConnectionState> connStates = null;


            conn = new SqlConnection(connectionString);

  
            if (conn != null)
            {
                conn.Open();
                ConnectionState connState1 = conn.State;
                conn.Close();
                ConnectionState connState2 = conn.State;
                connStates = new List<ConnectionState> { connState1, connState2 };
            }
            return connStates;
        }

    }
    
}
