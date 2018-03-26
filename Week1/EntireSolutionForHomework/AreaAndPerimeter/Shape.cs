using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaAndPerimeter
{
    public abstract class Shape
    {
        public int ShapeId { get; protected set;}
        public abstract double CalculatePerimeter();
        public abstract double CalculateArea();
    }
}
