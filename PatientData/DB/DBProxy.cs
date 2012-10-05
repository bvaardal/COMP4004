using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Finisar.SQLite;

namespace PatientData.DB
{
    class DBProxy
    {
        private SQLiteConnection _sqlConnection;

        public DBProxy()
        {
        }

        /**
         *  <summary>
         *      Initializes SQLite DB connection. Connects to the specified DB and stores the 
         *      connection string for future use.
         *  </summary>
         *  
         *  <param name="dbName">Name of SQLite DB to connect to.</param>
         *  <param name="newDB">
         *      False if DB already exists. If true, a new DB will be created and any existing DB
         *      with the same name will be overwritten.
         *  </param>
         *  
         *  <exception cref="DBException" />
         *  
         */
        public void Init(String dbName, bool newDB = false)
        {
            _sqlConnection = new SQLiteConnection(
                "Data Source=" + dbName + ".db;" +
                "Version=3;" + 
                "New=" + newDB.ToString() + ";" + 
                "Compress=True;");
            
            try
            {
                _sqlConnection.Open();
            }
            catch (Exception x)
            {
                throw new DBException(x.Message);
            }

            if (newDB)
            {
                generatePatientDataDB();
            }

            _sqlConnection.Close();
        }

        /**
         *  <summary>
         *      Generates the table structure and its static content in the open DB (requires open 
         *      connection), based on the content of DB\init.sql.
         *  </summary>
         * 
         */
        private void generatePatientDataDB()
        {
            SQLiteCommand sqlCmd = null;
            String initCmd;
            StreamReader initSQL = null;
            try
            {
                initSQL = new StreamReader("DB" + Path.DirectorySeparatorChar + "init.sql");
            }
            catch (Exception)
            {
                throw new DBException("Could not initial new DB.");
            }

            while (!initSQL.EndOfStream)
            {
                initCmd = initSQL.ReadLine();
                sqlCmd = _sqlConnection.CreateCommand();
                sqlCmd.CommandText = initCmd;
                sqlCmd.ExecuteNonQuery();
            }
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
