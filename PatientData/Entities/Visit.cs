﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientData.Entities
{
    using Actors;

    class Visit
    {
        public Patient Patient { get; private set; }
        public HealthProfessional HealthProfessional { get; private set; }
        public DateTime Date { get; private set; }
        public ProfessionalAct ProfessionalAct { get; private set; }
        public Rational Rational { get; private set; }

        public Visit(Patient p, HealthProfessional hp, DateTime date, ProfessionalAct proAct, Rational rational = Rational.initial)
        {
            if (date.CompareTo(new DateTime(2011, 1, 1)) < 0 || date.CompareTo(new DateTime(2011, 12, 31)) > 0)
            {
                throw new InvalidParameterException("Date was not within acceptable range (" + date.ToString() + ").");
            }
            if (p.UID < 0)
            {
                throw new InvalidParameterException("Invalid Patient ID (" + p.UID + ").");
            }
            if (hp.UID < 0)
            {
                throw new InvalidParameterException("Invalid Health Professional ID (" + hp.UID + ").");
            }

            Patient = p;
            HealthProfessional = hp;
            Date = date;
            ProfessionalAct = proAct;
            Rational = rational;
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
