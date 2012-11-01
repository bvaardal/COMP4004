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
        private List<Rational> rationals;
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

            rationals = new List<Rational>(5);
            rationals.Add(Rational.checkup);
            rationals.Add(Rational.emergency);
            rationals.Add(Rational.followUp);
            rationals.Add(Rational.initial);
            rationals.Add(Rational.referral);
            ddl_cmVisit1Rational.DataSource = rationals;
            ddl_cmVisit2Rational.DataSource = rationals;
            ddl_cmVisit3Rational.DataSource = rationals;
            ddl_cmVisit4Rational.DataSource = rationals;
            ddl_cmVisit5Rational.DataSource = rationals;
        }

        #region Events
        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

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

        private void btn_getACVs_Click(object sender, EventArgs e)
        {
            HashSet<CMPair> cm = generateCM();

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
        #endregion

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
