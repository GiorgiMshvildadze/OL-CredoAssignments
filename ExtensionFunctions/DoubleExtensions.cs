using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionFunctions
{
    public static class DoubleExtensions
    {
        public static double ToPercent(this double value)
        {
             var valueToPercent = value * 100;
            return valueToPercent;
        }
        public static double RoundDown(this double value)
        {
            return value -= value % 10;
        }
        public static decimal ToDecimal(this double value)
        {
            return (decimal) value ;
        }
    }
}
