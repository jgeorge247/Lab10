using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Circle
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double CalculateCircumference()
        {
            double Circumference = (2 * (Math.PI) * Radius);
            return Circumference;
        }

        public string CalculateFormattedCircumference()
        {
            double Circumference = (2 * (Math.PI) * Radius);
            return ($"{Circumference, 0:N2}");
        }

        public double CalculateArea ()
        {
            double Area = ((Math.PI) * Math.Pow(Radius, 2));
            return Area;
        }

        public string CalculateFormattedArea()
        {
            double Area = ((Math.PI) * Math.Pow(Radius, 2));
            return ($"{Area, 0:N2}");
        }
    }
}
