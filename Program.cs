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
            while (true)
            {
                Console.Write("Choose a shape:\n 1.Square\n 2.Rectangle\n 3.Triangle\n 4.Show Quilt\n Enter: ");
                var choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Square square = new Square();
                    square.DefineSquare();
                }
                if (choice == 2)
                {
                    Rectangle rectangle = new Rectangle();
                    rectangle.DefineRectangle();
                }
                if (choice == 3)
                {
                    Triangle triangle = new Triangle();
                    triangle.DefineTriangle();

                }
                if (choice == 4)
                    Console.WriteLine();


                Console.Write("Continue?\nEnter Y/N: ");
                var end = Console.ReadLine().ToUpper();
                if (end != "Y")
                    break;
            }
            Console.Write("Done");
        }
    }
}

/* TO DO
 * Need to actually store variables in Name, Color, Side/1/2/3
 * Need to add collections to store shapes/colors/area
 * Need to display list
 * Need to add math to calculate area/length
 * Need to add exceptions for incorrect variable assignment from user
*/
