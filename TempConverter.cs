using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise1
{
    public class TempConverter
    {
        public static double FairenheitToCelsius(double x)
        {
            return (x - 32) * (5 / 9);
        }
        

        public static double CelsiusToFairenheit(double x)
        {
            return x * (9 / 5) +32;

        }






    }
}
