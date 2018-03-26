using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaAndPerimeter
{
    class Circle : Shape
    {

        public double Radius { get; private set; }

        public Circle(double Radius)
        {
            this.Radius = Radius;
            ShapeId++;
        }

        public override double CalculateArea()
        {
            return Math.PI * (Radius * Radius);
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

    }
}
