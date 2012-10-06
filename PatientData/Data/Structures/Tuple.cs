using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientData.Data.Structures
{
    abstract class Tuple
    { }

    class Tuple<T1> : Tuple
    {
        public T1 t1 { get; private set; }

        public Tuple(T1 initT1)
        {
            t1 = initT1; 
        }
    }

    class Tuple<T1, T2> : Tuple
    {
        public T1 t1 { get; private set; }
        public T2 t2 { get; private set; }

        public Tuple(T1 initT1, T2 initT2)
        {
            t1 = initT1;
            t2 = initT2;
        }
    }

    class Tuple<T1, T2, T3> : Tuple
    {
        public T1 t1 { get; private set; }
        public T2 t2 { get; private set; }
        public T3 t3 { get; private set; }

        public Tuple(T1 initT1, T2 initT2, T3 initT3)
        {
            t1 = initT1;
            t2 = initT2;
            t3 = initT3;
        }
    }

    class Tuple<T1, T2, T3, T4> : Tuple
    {
        public T1 t1 { get; private set; }
        public T2 t2 { get; private set; }
        public T3 t3 { get; private set; }
        public T4 t4 { get; private set; }

        public Tuple(T1 initT1, T2 initT2, T3 initT3, T4 initT4)
        {
            t1 = initT1;
            t2 = initT2;
            t3 = initT3;
            t4 = initT4;
        }
    }

    class Tuple<T1, T2, T3, T4, T5> : Tuple
    {
        public T1 t1 { get; private set; }
        public T2 t2 { get; private set; }
        public T3 t3 { get; private set; }
        public T4 t4 { get; private set; }
        public T5 t5 { get; private set; }

        public Tuple(T1 initT1, T2 initT2, T3 initT3, T4 initT4, T5 initT5)
        {
            t1 = initT1;
            t2 = initT2;
            t3 = initT3;
            t4 = initT4;
            t5 = initT5;
        }
    }
}
