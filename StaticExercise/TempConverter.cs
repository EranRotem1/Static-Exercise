using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal class TempConverter
    {
        public static double FahrenheitToCelcius(double degreesF)
        {
            return (degreesF - 32) * 5 / 9;
        }

        public static double CelciusToFahrenheit(double degreesC)
        {
            return degreesC * 9 / 5 + 32;
        }

    }
}
