using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using Finisar.SQLite;

namespace PatientData
{
    class Program
    {
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        private void SetConnection()
        {
            sql_con = new SQLiteConnection
                ("Data Source=demo.db;Version=3;New=True;Compress=True;");
        }

        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }

        private void LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select id, desc from mains";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            sql_con.Close();
        }

        private void Add()
        {
            string txtSQLQuery = "insert into  mains (desc) values ('test')";
            ExecuteQuery(txtSQLQuery);
        }

        static void Main(string[] args)
        {
            (new Testing.UnitTests.DBProxy_UnitTest()).test3();

        }
    }
}
