using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PatientData
{
    using GUI;
    using Data;

    public class PatientDataController
    {
        private MainWindow view;
        private DBProxy model;

        public PatientDataController()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            view = new MainWindow(this);
            Application.Run(view);
        }
    }
}
