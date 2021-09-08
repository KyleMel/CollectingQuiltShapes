using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectingQuiltShapes
{
    // Derived Class
    class Rectangle : Shape
    {
        public void DefineRectangle()
        {
            Console.Write("Rectangle Selected!\n Enter Color: ");
            Name = "Rectangle";
            Color = Console.ReadLine();
            Console.Write(" Enter Length: ");
            int side = int.Parse(Console.ReadLine());
            Console.Write(" Enter Width: ");
            int side2 = int.Parse(Console.ReadLine());
            Area = side * side2;
            //need to add exceptions for impossible shape
        }
    }
}
