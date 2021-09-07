using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectingQuiltShapes
{
    // Derived Class
    class Square : Shape
    {
        public Shape DefineSquare()
        {
            Console.Write("Square Selected!\n Enter Color: ");
            Name = "Square";
            Color = Console.ReadLine();
            Console.Write(" Enter Length: ");
            Side = int.Parse(Console.ReadLine());
            // return brings it back to public Shape which repeats Console Out.
            return new Shape();
        }
    }
}
