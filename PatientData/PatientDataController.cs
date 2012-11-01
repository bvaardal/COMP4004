using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PatientData
{
    using GUI;
    using Data;
    using Entities;

    class PatientDataController
    {
        private MainWindow view;
        private DBProxy model;

        public PatientDataController()
        {
            /* View */
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            view = new MainWindow(this);
            Application.Run(view);
        }

        public void InitModel(String path, bool newDB)
        {
            model = new SQLiteProxy();
            model.Init(path, newDB);
        }

        /**
         *  <summary>
         *      Gets all ACVs (of same size as the given CM) for the given patient that match the
         *      given CM.
         *  </summary>
         *  
         *  <param name="pID">
         *      The ID of the patient to get ACVs for
         *  </param>
         *  <param name="cms">
         *      The CM to compare against
         *  </param>
         */
        public IEnumerable<IEnumerable<Visit>> GetMatchingACVs(HashSet<CMPair> cm, Patient p)
        {
            List<IEnumerable<Visit>> result = new List<IEnumerable<Visit>>();

            IEnumerable<IEnumerable<Visit>> acvs = model.GetACVs(p, cm.Count<CMPair>());

            foreach (IEnumerable<Visit> acv in acvs)
            {
                bool match = true;
                foreach (Visit v in acv)
                {
                    match &= cm.Contains<CMPair>(v);
                }
                if (match)
                {
                    result.Add(acv);
                }
            }

            return (IEnumerable<IEnumerable<Visit>>)result;
        }
    }
}
