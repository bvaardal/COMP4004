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

    partial class VisitForm : Form
    {
        public Visit visit { get; private set; }

        private Patient patient;

        public VisitForm(Patient p, List<HealthProfessional> hps, List<Rational> rs)
        {
            InitializeComponent();

            patient = p;

            txt_patientID.Text = p.ToString();
            cmb_hp.DataSource = hps;
            cmb_rational.DataSource = rs;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            visit = new Visit(
                patient, 
                (HealthProfessional)cmb_hp.SelectedItem, 
                dtp_date.Value, 
                new ProfessionalAct(int.Parse(txt_ohpa.Text), int.Parse(txt_diagnosis.Text)), 
                (Rational)cmb_rational.SelectedItem
            );

            this.Dispose();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
