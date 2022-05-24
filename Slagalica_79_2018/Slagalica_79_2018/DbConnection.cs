using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.Sqlite;

namespace Slagalica_79_2018
{
    public class DbConnection
    {
        private static SqliteConnection connection=null;

        public static SqliteConnection Connection
        {
            get
            {
                if (connection == null)
                {
                    string path = AppDomain.CurrentDomain.BaseDirectory + "../../Database/rezultati.db";
                    connection = new SqliteConnection("Data Source="+path);
                }
                return connection;
            }
        }
    }
}
