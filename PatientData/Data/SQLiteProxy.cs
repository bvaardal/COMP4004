using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

using Finisar.SQLite;

namespace PatientData.Data
{
    using Entities;
    using Helpers;

    class SQLiteProxy : DBProxy
    {
        private static String SQL_GetHealthProfessionalByID =   "SELECT hpID from tbl_healthProfessional WHERE hpID = ";
        private static String SQL_GetHealtProfessionals =       "SELECT hpID from tbl_healthProfessional";
        private static String SQL_GetPatientByID =              "SELECT pID from tbl_patient WHERE pID = ";
        private static String SQL_GetPatients =                 "SELECT pID from tbl_patient";
        private static String SQL_GetVisitsByPatient =          "SELECT strftime('%Y-%m-%d', vDate) as date, hpID, ohpa, diagnosis, rID FROM tbl_visit WHERE pID = ";
        private static String SQL_InsertHealthProfessional =    "INSERT INTO tbl_healthProfessional (dummy) values ('')";
        private static String SQL_InsertPatient =               "INSERT INTO tbl_patient (dummy) values ('')";
        private static String SQL_InsertVisit =                 "INSERT INTO tbl_visit (vDate, pID, hpID, ohpa, diagnosis, rID) values (";
        private static String SQL_LastInsertID =                "SELECT last_insert_rowid()";

        private SQLiteConnection    _sqlConnection;
        private bool                _isOpen;

        public SQLiteProxy()
        {
            _isOpen = false;
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
                "Data Source=" + dbName + ";" +
                "Version=3;" + 
                "New=" + newDB.ToString() + ";" + 
                "Compress=True;");
            
            try
            {
                openDBConnection();
            }
            catch (Exception x)
            {
                throw new DBException(x.Message);
            }

            if (newDB)
            {
                generatePatientDataDB();
                _sqlConnection.ConnectionString =
                    "Data Source=" + dbName + ";" +
                    "Version=3;" +
                    "New=False;" +
                    "Compress=True;";
            }

            closeDBConnection();
        }

        private void openDBConnection()
        {
            if (!_isOpen)
            {
                _sqlConnection.Open();
                _isOpen = true;
            }
        }

        private void closeDBConnection()
        {
            if (_isOpen)
            {
                _sqlConnection.Close();
                _isOpen = false;
            }
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
                initSQL = new StreamReader("Data" + Path.DirectorySeparatorChar + "init.sql");
            }
            catch (Exception)
            {
                throw new DBException("Could not initial new DB.");
            }

            openDBConnection();
            while (!initSQL.EndOfStream)
            {
                initCmd = initSQL.ReadLine();
                sqlCmd = _sqlConnection.CreateCommand();
                sqlCmd.CommandText = initCmd;
                sqlCmd.ExecuteNonQuery();
            }
            closeDBConnection();
            initSQL.Close();
        }

        private long executeNonQuery(String command)
        {
            openDBConnection();
            SQLiteCommand sqlCmd = null;
            sqlCmd = _sqlConnection.CreateCommand();
            sqlCmd.CommandText = command;
            sqlCmd.ExecuteNonQuery();

            sqlCmd = _sqlConnection.CreateCommand();
            sqlCmd.CommandText = SQL_LastInsertID;
            long result = (long)sqlCmd.ExecuteScalar();
            closeDBConnection();

            return result;
        }

        /**
         *  <summary>
         *      Inserts patient into DB. For expansion purposes (patient info). The Patients's ID
         *      is set as part of this operation.
         *  </summary>
         *  
         *  <param name="p">
         *      Patient to be inserted. Currently not used because DB doesn't hold any other 
         *      information than ID, which is autoincrement. The Patients's ID is set as part of 
         *      this operation.
         *  </param>
         */
        public void InsertPatient(ref Patient p)
        {
            p.UID = executeNonQuery(SQL_InsertPatient);
        }

        /**
         *  <summary>
         *      Inserts health professional into DB. For expansion purposes (patient info). The 
         *      Health Professional's ID is set as part of this operation.
         *  </summary>
         *  
         *  <param name="hp">
         *      Health professional to be inserted. Currently not used because DB doesn't hold any
         *      other information than ID, which is autoincrement. The Health Professional's ID is
         *      set as part of this operation.
         *  </param>
         */
        public void InsertHealthProfessional(ref HealthProfessional hp)
        {
            hp.UID = executeNonQuery(SQL_InsertHealthProfessional);
        }

        public void InsertVisit(Visit v)
        {
            String date = "" + v.Date.Year.ToString("D4") + "-" + v.Date.Month.ToString("D2") + "-" + v.Date.Day.ToString("D2");

            executeNonQuery(
                SQL_InsertVisit + 
                "'" + date + "', " +
                v.Patient.UID + ", " +
                v.HealthProfessional.UID + ", " +
                v.ProfessionalAct.OHPA + ", " +
                v.ProfessionalAct.Diagnosis + ", " +
                (int)v.Rational + 
                ")");
        }

        public List<Visit> GetVisitsByPatient(Patient p)
        {
            if (p == null)
            {
                return new List<Visit>();
            }

            List<Visit> result = new List<Visit>(20);

            openDBConnection();
            SQLiteCommand sqlCmd = _sqlConnection.CreateCommand();
            SQLiteDataAdapter da = new SQLiteDataAdapter(SQL_GetVisitsByPatient + p.UID, _sqlConnection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                DateTime q_vDate;
                HealthProfessional q_hp;
                ProfessionalAct q_pa;
                Rational q_r;

                q_vDate = DateTime.Parse(r.Field<String>("date"));
                q_hp = getHealthProfessionalByID(r.Field<long>("hpID"));
                q_pa = new ProfessionalAct((int)r.Field<long>("ohpa"), (int)r.Field<long>("diagnosis"));
                q_r = (Rational)Enum.ToObject(typeof(Rational), r.Field<long>("rID"));

                result.Add(new Visit(p, q_hp, q_vDate, q_pa, q_r));
            }
            closeDBConnection();

            return result;
        }

        private HealthProfessional getHealthProfessionalByID(long hpID)
        {
            HealthProfessional result = null;

            openDBConnection();
            SQLiteCommand sqlCmd = _sqlConnection.CreateCommand();
            SQLiteDataAdapter da = new SQLiteDataAdapter(SQL_GetHealthProfessionalByID + hpID, _sqlConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                long q_hpID = dt.Rows[0].Field<long>("hpID");
                result = new HealthProfessional(q_hpID);
            }

            return result;
        }

        /**
         *  <summary>
         *      Gets the patient with the given ID.
         *  </summary>
         *  
         *  <param name="pID">
         *      The ID of the patient being requested.
         *  </param>
         */
        public Patient GetPatientByID(long pID)
        {
            Patient result = null;

            openDBConnection();
            SQLiteCommand sqlCmd = _sqlConnection.CreateCommand();
            SQLiteDataAdapter da = new SQLiteDataAdapter(SQL_GetPatientByID + pID, _sqlConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                long q_pID = dt.Rows[0].Field<long>("pID");
                result = new Patient(q_pID);
            }

            return result;
        }

        public List<Patient> GetPatients()
        {
            List<Patient> result = new List<Patient>();

            openDBConnection();
            SQLiteCommand sqlCmd = _sqlConnection.CreateCommand();
            SQLiteDataAdapter da = new SQLiteDataAdapter(SQL_GetPatients, _sqlConnection);
            DataSet ds = new DataSet();
            da.Fill(ds);

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                result.Add(new Patient(r.Field<long>("pID")));
            }
            closeDBConnection();

            return result;
        }

        public List<HealthProfessional> GetHealthProfessionals()
        {
            List<HealthProfessional> result = new List<HealthProfessional>();

            openDBConnection();
            SQLiteCommand sqlCmd = _sqlConnection.CreateCommand();
            SQLiteDataAdapter da = new SQLiteDataAdapter(SQL_GetHealtProfessionals, _sqlConnection);
            DataSet ds = new DataSet();
            da.Fill(ds);

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                result.Add(new HealthProfessional(r.Field<long>("hpID")));
            }
            closeDBConnection();

            return result;
        }

        /**
         *  <summary>
         *      Gets all Actual Combinations of Visits (ACV) for the Patient p in nTuples of a
         *      given size n.
         *  </summary>
         *  
         *  <param name="p">
         *      The patient to get ACVs for.
         *  </param>
         *  <param name="n">
         *      The size of the nTuple.
         *  </param>
         */
        public IEnumerable<IEnumerable<Visit>> GetACVs(Patient p, int n)
        {
            if (n < 1 || n > 5)
            {
                throw new TupleSizeException(n);
            }
            return TupleGenerator.VisitCombinations(GetVisitsByPatient(p), n);
        }
    }
}
