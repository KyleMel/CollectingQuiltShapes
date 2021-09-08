using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectingQuiltShapes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();


            while (true)
            {
                Console.Write("Choose a shape:\n 1.Square\n 2.Rectangle\n 3.Triangle\n 4.Show Quilt\n Enter: ");
                var choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Square square = new Square();
                    square.DefineSquare();
                    shapes.Add(square);
                }
                if (choice == 2)
                {
                    Rectangle rectangle = new Rectangle();
                    rectangle.DefineRectangle();
                    shapes.Add(rectangle);
                }
                if (choice == 3)
                {
                    Triangle triangle = new Triangle();
                    triangle.DefineTriangle();
                    shapes.Add(triangle);
                }
                if (choice == 4)
                {
                    foreach(var shape in shapes)
                    {
                        Console.WriteLine($"Shape: {shape.Name}, Color: {shape.Color}, Area: {shape.Area}");
                    }
                }
                Console.Write("Continue?\nEnter Y/N: ");
                var end = Console.ReadLine().ToUpper();
                if (end != "Y")
                    break;
            }
            foreach(var shape in shapes)
            {
                Console.WriteLine($"Shape: {shape.Name}, Color: {shape.Color}, Area: {shape.Area}");
            }
            Console.Write("Done");
        }
    }
}

/* TO DO
 * Need to add exceptions for incorrect variable assignment from user
*/
