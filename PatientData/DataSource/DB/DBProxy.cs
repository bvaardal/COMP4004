using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Finisar.SQLite;

namespace PatientData.DataSource.DB
{
    class DBProxy : DataSource
    {
        private SQLiteConnection sql_con;

        public DBProxy()
        {
        }

        /**
         *  <summary>
         *      Initializes SQLite DB connection. Connects to the specified DB (default test.db) 
         *      and stores the connection string for future use.
         *  </summary>
         *  
         *  <param name="dbName">Name of SQLite DB to connect to.</param>
         *  <param name="newDB">
         *      False if DB already exists. If true, a new DB will be created and any existing DB
         *      with the same name will be overwritten.
         *  </param>
         *  
         */
        public void Init(String dbName, bool newDB = false)
        {
            sql_con = new SQLiteConnection
                ("Data Source=" + dbName + ".db;Version=3;New=" + newDB.ToString() + ";Compress=True;");
            
            try
            {
                sql_con.Open();
            }
            catch (Exception x)
            {
                throw new DBException(x.Message);
            }

            sql_con.Close();
        }

        /**
         *  <summary>
         *      Generates the table structure in the open DB (requires open connection), based on
         *      the content of init.sql.
         *  </summary>
         * 
         */
        private void generateTables()
        {

        }
    }

    class DBException : Exception
    {
        public DBException(String s) 
            : base(s)
        {
        }
    }
}
