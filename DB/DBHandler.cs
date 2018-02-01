using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bab_1.DB
{
    class DBHandler
    {
        private static string dbName = "MyDatabase.sqlite";
        public static void CreateAndConfigureDatabase()
        {
            SQLiteConnection.CreateFile(dbName);

        }

        public static bool CreateDatabaseConnection()
        {
            SQLiteConnection dbConnection;
            dbConnection = new SQLiteConnection("Data Source=" + dbName + "; Version=3;");
            dbConnection.Open();

            return dbConnection.State == ConnectionState.Open;
        }

        public static bool checkLogin(String username, String password)
        {
            return true;
        }
    }
}