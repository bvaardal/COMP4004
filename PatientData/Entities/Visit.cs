using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientData.Entities
{
    class Visit
    {
        private long            _p = 0;
        private long            _hp = 0;
        private DateTime        _time;
        private Rational        _rational;
        private ProfessionalAct _proAct;
    }

    enum Rational
    {
        initial,
        checkup,
        followGup,
        referral,
        emergency
    }
}
