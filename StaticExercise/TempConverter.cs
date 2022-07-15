using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {

       public static double FahrenheitToCelsius(double fahrenheitTemp)
        {
            double conversion = (fahrenheitTemp - 32) / 1.8;
            return Math.Round(conversion,2);
        }

        public static double CelsiusToFahrenheit(double CelsiusTemp)
        {
            double conversion = (CelsiusTemp * 1.8) + 32;
            return Math.Round(conversion, 2);
        }


    }
}
