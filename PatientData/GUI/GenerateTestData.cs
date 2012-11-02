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
    public partial class GenerateTestData : Form
    {
        public int MatchingPatients { get; private set; }
        public int MatchingVisits { get; private set; }
        public int RandomPatients { get; private set; }
        public int RandomVisits { get; private set; }

        public GenerateTestData()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            MatchingPatients = (int)num_matchingPatients.Value;
            MatchingVisits = (int)num_matchingVisits.Value;
            RandomPatients = (int)num_randomPatients.Value;
            RandomVisits = (int)num_randomVisits.Value;
            Dispose();
        }
    }
}
