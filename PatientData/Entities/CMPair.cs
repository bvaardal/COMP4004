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
    }

    class CMPairMatcher : IEqualityComparer<CMPair>
    {
        public bool Equals(CMPair x, CMPair y)
        {
            return (
                x.Date.Year == y.Date.Year &&
                x.Date.Month == y.Date.Month &&
                x.Date.Day == y.Date.Day &&
                x.Rational == y.Rational);
        }

        public int GetHashCode(CMPair obj)
        {
            throw new NotImplementedException();
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
