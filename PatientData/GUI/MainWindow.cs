using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PatientData.GUI
{
    using Entities;

    partial class MainWindow : Form
    {
        private PatientDataController controller;

        private Dictionary<CMPairControl, CMPair> cmPairsControls;
        private List<Patient> patients;
        
        public MainWindow(PatientDataController pdc)
        {
            controller = pdc;
            
            InitializeComponent();
            
            cmPairsControls = new Dictionary<CMPairControl, CMPair>();
            cmPairsControls.Add(new CMPairControl(chk_cmVisit1Enable, dtp_cmVisit1Date, ddl_cmVisit1Rational), new CMPair(dtp_cmVisit1Date.Value, Rational.initial));
            cmPairsControls.Add(new CMPairControl(chk_cmVisit2Enable, dtp_cmVisit2Date, ddl_cmVisit2Rational), new CMPair(dtp_cmVisit2Date.Value, Rational.initial));
            cmPairsControls.Add(new CMPairControl(chk_cmVisit3Enable, dtp_cmVisit3Date, ddl_cmVisit3Rational), new CMPair(dtp_cmVisit3Date.Value, Rational.initial));
            cmPairsControls.Add(new CMPairControl(chk_cmVisit4Enable, dtp_cmVisit4Date, ddl_cmVisit4Rational), new CMPair(dtp_cmVisit4Date.Value, Rational.initial));
            cmPairsControls.Add(new CMPairControl(chk_cmVisit5Enable, dtp_cmVisit5Date, ddl_cmVisit5Rational), new CMPair(dtp_cmVisit5Date.Value, Rational.initial));

            List<Rational> rationals = new List<Rational>(5);
            rationals.Add(Rational.checkup);
            rationals.Add(Rational.emergency);
            rationals.Add(Rational.followUp);
            rationals.Add(Rational.initial);
            rationals.Add(Rational.referral);
            ddl_cmVisit1Rational.DataSource = new List<Rational>(rationals);
            ddl_cmVisit2Rational.DataSource = new List<Rational>(rationals);
            ddl_cmVisit3Rational.DataSource = new List<Rational>(rationals);
            ddl_cmVisit4Rational.DataSource = new List<Rational>(rationals);
            ddl_cmVisit5Rational.DataSource = new List<Rational>(rationals);
            ddl_cmVisit1Rational.SelectedItem = Rational.initial;
            ddl_cmVisit2Rational.SelectedItem = Rational.initial;
            ddl_cmVisit3Rational.SelectedItem = Rational.initial;
            ddl_cmVisit4Rational.SelectedItem = Rational.initial;
            ddl_cmVisit5Rational.SelectedItem = Rational.initial;

            dtp_cmVisit1Date.Value = DateTime.Parse("2011-01-01");
            dtp_cmVisit2Date.Value = DateTime.Parse("2011-01-01");
            dtp_cmVisit3Date.Value = DateTime.Parse("2011-01-01");
            dtp_cmVisit4Date.Value = DateTime.Parse("2011-01-01");
            dtp_cmVisit5Date.Value = DateTime.Parse("2011-01-01");

            chk_cmVisit1Enable.Checked = false;
            chk_cmVisit2Enable.Checked = false;
            chk_cmVisit3Enable.Checked = false;
            chk_cmVisit4Enable.Checked = false;
            chk_cmVisit5Enable.Checked = false;
        }

        /* Event handlers for MainWindow */
        #region Event Handlers
        private void enableCMVisit(object sender, EventArgs e)
        {
            /* Enable/disable controls in CMPairControl according to enable checkbox */
            foreach (CMPairControl c in cmPairsControls.Keys)
            {
                if (c.Enabled == sender)
                {
                    c.Date.Enabled = c.Enabled.Checked;
                    c.Rational.Enabled = c.Enabled.Checked;
                    break;
                }
            }
        }

        private void btn_match_Click(object sender, EventArgs e)
        {
            HashSet<CMPair> cm = generateCM();
            lst_output.DataSource = generateACVViews(controller.GetMatchingACVs(cm, Enumerable.Cast<Patient>(lst_patients.SelectedItems)));
            lbl_output.Text = "ACVs of selecte patients matching the CM";
        }

        private void mnb_newDB_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.FileOk += btn_newDBSave;
            fd.ShowDialog(this);
        }

        private void btn_newDBSave(object sender, EventArgs e)
        {
            SaveFileDialog fd = (SaveFileDialog)sender;
            controller.InitModel(fd.FileName, true);
            refreshLists();
        }

        private void mnb_openDB_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.FileOk += btn_newDBOpen;
            fd.ShowDialog(this);
        }

        private void btn_newDBOpen(object sender, EventArgs e)
        {
            OpenFileDialog fd = (OpenFileDialog)sender;
            controller.InitModel(fd.FileName, false);
            refreshLists();
        }

        private void mnb_useMemoryDB_Click(object sender, EventArgs e)
        {
            controller.InitModel();
            refreshLists();
        }

        private void btn_createScenario1TestData_Click(object sender, EventArgs e)
        {
            int startVisits = 20;
            int endVisits = 65;
            int increments = 5;
            int matchingPatients = 10;
            int randomPatients = 90;

            Thread t = new Thread(new ThreadStart(() =>
                {
                    createTestDataThreads(startVisits, endVisits, increments, matchingPatients, randomPatients);
                }
            ));
            t.Start();
        }

        private void btn_createScenario2TestData_Click(object sender, EventArgs e)
        {
            int startVisits = 20;
            int endVisits = 110;
            int increments = 10;
            int matchingPatients = 100;
            int randomPatients = 900;

            Thread t = new Thread(new ThreadStart(() =>
            {
                createTestDataThreads(startVisits, endVisits, increments, matchingPatients, randomPatients);
                refreshLists();
            }
            ));
            t.Start();
        }

        private void btn_createCustomTestData_Click(object sender, EventArgs e)
        {
            if (controller.IsModelInitialized())
            {
                GenerateTestData gtd = new GenerateTestData();
                gtd.Disposed += dlg_createCustomTestData_Disposed;
                gtd.ShowDialog(this);
            }
            else
            {
                MessageBox.Show(this, "Please create new a DB, or open an existing one.", "Not connected to DB", MessageBoxButtons.OK);
            }
        }

        private void dlg_createCustomTestData_Disposed(object sender, EventArgs e)
        {
            GenerateTestData gtd = (GenerateTestData)sender;
            controller.CreateTestData(gtd.MatchingPatients, gtd.MatchingVisits, gtd.RandomPatients, gtd.RandomVisits);
            refreshLists();
        }

        private void btn_refreshPatients_Click(object sender, EventArgs e)
        {
            refreshLists();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void lst_patients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ListBox)sender).SelectedItem != null)
            {
                lst_visits.DataSource = controller.GetVisitsByPatient((Patient)((ListBox)sender).SelectedItem);
            }
            else
            {
                lst_visits.DataSource = new List<Visit>(0);
            }
        }

        private void btn_createCM_Click(object sender, EventArgs e)
        {
            if (lst_visits.SelectedItems.Count > 5)
            {
                MessageBox.Show(this, "Please select at most 5 visits for the CM.", "Too many visits", MessageBoxButtons.OK);
            }
            else
            {
                int index = 0;
                foreach (Visit v in lst_visits.SelectedItems)
                {
                    CMPairControl cmpc = cmPairsControls.Keys.ElementAt(index++);
                    cmpc.Date.Value = v.Date;
                    cmpc.Rational.SelectedItem = v.Rational;
                    cmpc.Enabled.Checked = true;
                }

                for (int i = index; i < cmPairsControls.Keys.Count(); i++)
                {
                    cmPairsControls.Keys.ElementAt(index++).Enabled.Checked = false;
                }
            }
        }

        private void btn_safePatients_Click(object sender, EventArgs e)
        {
            lst_output.DataSource = controller.getSafePatients((int)num_acvSize.Value);
            lbl_output.Text = "Safe patients with ACV size " + (int)num_acvSize.Value;
        }

        private void btn_unsafePatients_Click(object sender, EventArgs e)
        {
            lst_output.DataSource = generateACVViews(controller.getUnsafePatients((int)num_acvSize.Value));
            lbl_output.Text = "ACV of unsafe patients with ACV size " + (int)num_acvSize.Value;
        }

        private void btn_getACVs_Click(object sender, EventArgs e)
        {
            lst_output.DataSource = generateACVViews(controller.GetACVs((Patient)lst_patients.SelectedItem, (int)num_acvSize.Value));
        }

        private void txt_patientFilter_TextChanged(object sender, EventArgs e)
        {
            if (lst_patients.DataSource != null)
            {
                try
                {
                    lst_patients.DataSource = new List<Patient>(patients.Where<Patient>(p => p.UID == int.Parse(((TextBox)sender).Text)));
                }
                catch (Exception)
                {
                    lst_patients.DataSource = patients;
                }
            }
        }
        #endregion

        #region Functions
        /**
         *  <summary>
         *      Creates a Combination to Match (CM) out of the selected Patients (between 1 and 5).
         *  </summary>
         */
        private HashSet<CMPair> generateCM()
        {
            /* Get enabled CMPairs */
            HashSet<CMPair> result = new HashSet<CMPair>();
            foreach (CMPairControl c in cmPairsControls.Keys)
            {
                if (c.Enabled.Checked)
                {
                    /* Get associated CMPair */
                    CMPair cmPair;
                    cmPairsControls.TryGetValue(c, out cmPair);
                    if (cmPair == null)
                    {
                        throw new Exception("An error occured while generating the CM. CMPairControls not set up correctly.");
                    }

                    /* Put View data in CMPair */
                    cmPair.Date = c.Date.Value;
                    cmPair.Rational = (Rational)c.Rational.SelectedValue;
                    result.Add(cmPair);
                }
            }
            return result;
        }

        /**
         *  <summary>
         *      Refresh model dependent lists.
         *  </summary>
         */
        private void refreshLists()
        {
            patients = controller.GetPatients();
            lst_patients.DataSource = patients;
            if (((ListBox)lst_patients).SelectedItem != null)
            {
                lst_visits.DataSource = controller.GetVisitsByPatient((Patient)((ListBox)lst_patients).SelectedItem);
            }
            else
            {
                lst_visits.DataSource = new List<Visit>(0);
            }
        }

        /**
         *  <summary>
         *      Turn list of ACVs into a list of viewable items.
         *  </summary>
         *  
         *  <param name="acvs">
         *      List of ACVs to convert.
         *  </param>
         *  
         *  <returns>
         *      List of ACVView items corresponding to the given ACVs.
         *  </returns>
         */
        private IEnumerable<ACVView> generateACVViews(IEnumerable<IEnumerable<Visit>> acvs)
        {
            List<ACVView> matchView = new List<ACVView>(acvs.Count<IEnumerable<Visit>>());
            foreach (IEnumerable<Visit> match in acvs)
            {
                matchView.Add(new ACVView(match));
            }
            return matchView;
        }

        private void createTestDataThreads(int startVisits, int endVisits, int increments, int matchingPatients, int randomPatients)
        {
            lbl_status.Text = "Creating test data";

            for (int i = startVisits; i <= endVisits; i += increments)
            {
                controller.CreateTestData(matchingPatients, i, randomPatients, i);
                
                this.BeginInvoke(new Action(() =>
                    {
                        prb_progress.Value = ((i - startVisits) / (endVisits - startVisits)) * 100;
                    }
                ));
            }

            this.BeginInvoke(new Action(() =>
                {
                    prb_progress.Value = 0;
                    lbl_status.Text = "Ready";
                }
            ));
        }
        #endregion
    }
}
