using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PatientData.GUI
{
    class CMPairControl
    {
        public CheckBox Enabled { get; private set; }
        public DateTimePicker Date { get; private set; }
        public ComboBox Rational { get; private set; }

        public CMPairControl(CheckBox chk, DateTimePicker dtp, ComboBox ddl)
        {
            Enabled = chk;
            Date = dtp;
            Rational = ddl;
        }
    }
}
