using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientData.Entities
{
    class CMPair
    {
        public DateTime Date { get; set; }
        public Rational Rational { get; set; }

        public CMPair(DateTime dt, Rational r)
        {
            Date = dt;
            Rational = r;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            CMPair v = null;
            try
            {
                v = (CMPair)obj;
            }
            catch (InvalidCastException)
            {
                return false;
            }

            return (
                this.Date.Equals(v.Date) &&
                this.Rational == v.Rational);
        }

    }

    enum Rational
    {
        initial = 1,
        checkup,
        followUp,
        referral,
        emergency
    }
}
