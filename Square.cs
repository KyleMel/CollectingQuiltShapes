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
        public void DefineSquare()
        {
            Console.Write("Square Selected!\n Enter Color: ");
            Name = "Square";
            Color = Console.ReadLine();
            Console.Write(" Enter Length: ");
            int side = int.Parse(Console.ReadLine());
            Area = side * side;
            //need to add exceptions for impossible shape
        }
    }
}
