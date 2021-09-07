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
        int Side2;
        public Shape DefineRectangle()
        {
            Console.Write("Rectangle Selected!\n Enter Color: ");
            Name = "Rectangle";
            Color = Console.ReadLine();
            Console.Write(" Enter Length: ");
            Side = int.Parse(Console.ReadLine());
            Console.Write(" Enter Width: ");
            Side2 = int.Parse(Console.ReadLine());
            // return brings it back to public Shape which repeats Console Out.
            return new Shape();
        }
    }
}
