
using AdoDotNetCoreAccess.Databaselayer;
using System.Data;
using System.Collections.Generic;

namespace AdoDotNetCoreAccess
{

    class DbProgram
    {
       static string connectionString = "Data Source=localhost, 1433; Database=AdoDemos; TrustServerCertificate=true; User ID=sa;Password=@12tf56so";
       static string connectionString2 = "Data Source=localhost, 1434; Database=master; TrustServerCertificate=true; User ID=sa;Password=@secret24";

        static void Main(string[] args)
        {
            //database 1
            TryConnection tryConnection1 = new TryConnection();
            List<ConnectionState> connStates1 = tryConnection1.TryConnect(connectionString);
            foreach (ConnectionState connState in connStates1)
            {
                Console.WriteLine($"Connection state was : {connState}");
            }

            //database 2
            TryConnection tryConnection2 = new TryConnection();
            List<ConnectionState> connStates2 = tryConnection2.TryConnect(connectionString2);
            foreach (ConnectionState connState in connStates2)
            {
                Console.WriteLine("Connection state was :" + connState);
            }
        }
    }
}