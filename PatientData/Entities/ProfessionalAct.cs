using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientData.Entities
{
    class ProfessionalAct
    {
        public int OHPA { get; private set; }
        public int Diagnosis { get; private set; }

        public ProfessionalAct(int ohpa, int diagnosis)
        {
            if (ohpa < 1 || ohpa > 100)
            {
                throw new InvalidParameterException("Invalid OHPA code (" + ohpa + ").");
            }

            if (diagnosis < 1 || diagnosis > 200)
            {
                throw new InvalidParameterException("Invalid diagnosis (" + diagnosis + ").");
            }

            OHPA = ohpa;
            Diagnosis = diagnosis;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            ProfessionalAct pa = null;
            try
            {
                pa = (ProfessionalAct)obj;
            }
            catch (InvalidCastException)
            {
                return false;
            }

            return (
                this.OHPA == pa.OHPA &&
                this.Diagnosis == pa.Diagnosis);
        }
    }
}