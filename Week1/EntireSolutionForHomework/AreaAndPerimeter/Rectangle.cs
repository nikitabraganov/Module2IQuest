using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaAndPerimeter
{
    class Rectangle : Shape
    {
        public double TopSide { get; private set; }
        public double LeftSide { get; private set; }

        public Rectangle(double TopSide, double LeftSide)
        {
            this.TopSide = TopSide;
            this.LeftSide = LeftSide;
            ShapeId++;
        }

        public override double CalculateArea()
        {
            return TopSide * LeftSide;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (TopSide + LeftSide);
        }
    }
}
