using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Objects_Lab
{
    public class Circle
    {
        double Radius { get; set; }

        public Circle (double radius)
        {
            Radius = radius;
        }

        public string CalculateCircumference () 
        {
            double circumference = (2 * Math.PI * Radius);
            return FormatNumber(circumference);
        }

        public string CalculateArea () 
        { 
            double area = Math.PI * (Radius * Radius);
            return FormatNumber(area);
        }

        private string FormatNumber(double result) 
        { 
            string resultFormat = Math.Round(result, 2).ToString();
            return resultFormat;
        }
    }
}
