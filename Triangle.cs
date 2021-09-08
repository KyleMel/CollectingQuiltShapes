using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectingQuiltShapes
{
    // Derived Class
    class Triangle : Shape
    {
        public void DefineTriangle()
        {
            Console.Write("Triangle Selected!\n Enter Color: ");
            Name = "Triangle";
            Color = Console.ReadLine();
            Console.Write(" Enter first length: ");
            int side = int.Parse(Console.ReadLine());
            Console.Write(" Enter second length: ");
            int side2 = int.Parse(Console.ReadLine());
            Console.Write(" Enter third length: ");
            int side3 = int.Parse(Console.ReadLine());
            int x = (side + side2 + side3) / 2;
            int a = x - side;
            int b = x - side2;
            int z = x - side3;
            Area = Convert.ToInt32(Math.Sqrt(x * a * b * z));
            //need to add exceptions for impossible shape
        }
    }
}
