using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Csharp
{
    internal static class Utility
    {
        // object member : 
        // non static member
        // depend on obj data 
        // non static 
        // called through object

        // function >>> class member
        // caled through clas ?
        // Solution ? How ? 
        // static member 
        // not depend on obj data
        public static double CmToInch(double cm)
        {
            return cm / 2.54;
        }
        public static double CalcCircleArea(double Radius)
        {
            return Math.PI * Radius * Radius;
        }
        // New method to calculate the perimeter of a rectangle
        public static double CalcRectanglePerimeter(double length, double width)
        {
            return 2 * (length + width);
        }
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
