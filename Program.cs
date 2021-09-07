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
                }
                if (choice == 2)
                {
                }
                if (choice == 3)
                {
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
