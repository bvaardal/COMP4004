using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PatientData.GUI
{
    using Entities;

    partial class MainWindow : Form
    {
        private PatientDataController controller;

        private Dictionary<CMPairControl, CMPair> cmPairsControls;
        
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

        #region Events
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
            IEnumerable<IEnumerable<Visit>> matches = controller.GetMatchingACVs(cm, Enumerable.Cast<Patient>(lst_patients.SelectedItems));

            List<ACVView> matchView = new List<ACVView>(matches.Count<IEnumerable<Visit>>());
            foreach (IEnumerable<Visit> match in matches)
            {
                matchView.Add(new ACVView(match));
            }
            lst_output.DataSource = matchView;

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

        private void btn_createTestData_Click(object sender, EventArgs e)
        {
            if (controller.IsModelInitialized())
            {
                GenerateTestData gtd = new GenerateTestData();
                gtd.Disposed += dlg_createTestData_Disposed;
                gtd.ShowDialog(this);
            }
            else
            {
                MessageBox.Show(this, "Please create new a DB, or open an existing one.", "Not connected to DB", MessageBoxButtons.OK);
            }
        }

        private void dlg_createTestData_Disposed(object sender, EventArgs e)
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
            lst_output.DataSource = getSafePatients((int)num_acvSize.Value);
            lbl_output.Text = "Safe patients with ACV size " + (int)num_acvSize.Value;
        }

        private void btn_unsafePatients_Click(object sender, EventArgs e)
        {
            lst_output.DataSource = getUnsafePatients((int)num_acvSize.Value);
            lbl_output.Text = "ACV of unsafe patients with ACV size " + (int)num_acvSize.Value;
        }
        #endregion

        #region Functions
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

        private void refreshLists()
        {
            lst_patients.DataSource = controller.GetPatients();
            if (((ListBox)lst_patients).SelectedItem != null)
            {
                lst_visits.DataSource = controller.GetVisitsByPatient((Patient)((ListBox)lst_patients).SelectedItem);
            }
            else
            {
                lst_visits.DataSource = new List<Visit>(0);
            }

        }

        private IEnumerable<Patient> getSafePatients(int acvSize)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<IEnumerable<ACVView>> getUnsafePatients(int acvSize)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
