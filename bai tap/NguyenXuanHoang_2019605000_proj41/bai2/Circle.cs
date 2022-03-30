using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class Circle
    {
        private double radius;

        private double Getradius()
        {
            return radius;
        }

        private void Setradius(double value)
        {
            radius = value;
        }

        public Circle()
        {
            Setradius(0);
        }


        public Circle(float value)
        {
            Setradius(value);
        }

        public double Area()
        {
            return Math.PI * Getradius() * Getradius();
        }

        public double Perimeter()
        {
            return 2 * Math.PI * Getradius();
        }
        
    }
}
