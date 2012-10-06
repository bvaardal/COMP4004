using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientData.Entities
{
    /*
    abstract class Entity
    {
    }
    */

    class InvalidParameterException : Exception
    {
        public InvalidParameterException(String msg)
            : base(msg)
        { }
    }
}
