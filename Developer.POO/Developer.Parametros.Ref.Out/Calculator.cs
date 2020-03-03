using System;
using System.Collections.Generic;
using System.Text;

namespace Developer.Parametros.Ref.Out
{
    public class Calculator
    {

        public static double TripleRef(ref double value)
        {
            return value *= 3;
        }

        public static double TripleOut(double origin, out double result)
        {
            result = origin * 3;
            return result;
        }
    }
}
