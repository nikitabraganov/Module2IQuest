using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> ListOfMyShapes = new List<Shape>();
            int OptionSelected;
            do
            {
                OptionSelected = Int32.Parse(Console.ReadLine());
                switch (OptionSelected)
                {
                    case 1:
                        Console.WriteLine("Specify the circle radius");
                        double RadiusOfTheCircle = Int32.Parse(Console.ReadLine());
                        ListOfMyShapes.Add(new Circle(RadiusOfTheCircle));
                        break;
                    case 2:
                        Console.WriteLine("Specify the size of the top side and left side");
                        double TopSideOfRectangle = double.Parse(Console.ReadLine());
                        double LeftSideOfRectangle = double.Parse(Console.ReadLine());
                        ListOfMyShapes.Add(new Rectangle(TopSideOfRectangle, LeftSideOfRectangle));
                        break;
                    case 3:
                        Console.WriteLine("Select the id of the shape");
                        foreach (var Shape in ListOfMyShapes)
                        {
                            Console.WriteLine(Shape.ShapeId + ": " + Shape.GetType());
                        }
                        var PerimeterShapeId = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("The perimeter of the shape is: " + ListOfMyShapes.FirstOrDefault(ShapeId => ShapeId.ShapeId == PerimeterShapeId).CalculatePerimeter());
                        break;
                    case 4:
                        Console.WriteLine("Select the id of the shape");
                        foreach (var Shape in ListOfMyShapes)
                        {
                            Console.WriteLine(Shape.ShapeId + ": " + Shape.GetType());
                        }
                        var AreaShapeId = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("The area of the shape is: " + ListOfMyShapes.FirstOrDefault(ShapeId => ShapeId.ShapeId == AreaShapeId).CalculateArea());
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            } while (OptionSelected != 5);
        }
    }
}
