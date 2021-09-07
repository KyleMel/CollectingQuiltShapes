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
        int Side2;
        int Side3;
        public Shape DefineTriangle()
        {
            Console.Write("Triangle Selected!\n Enter Color: ");
            Color = Console.ReadLine();
            Console.Write(" Enter first length: ");
            Side = int.Parse(Console.ReadLine());
            Console.Write(" Enter second Length: ");
            Side2 = int.Parse(Console.ReadLine());
            Console.Write(" Enter third Length: ");
            Side3 = int.Parse(Console.ReadLine());
            return new Shape();
        }
    }
}
