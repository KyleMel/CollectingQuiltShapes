using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectingQuiltShapes
{
    // Base Class
    public class Shape
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Side { get; set; }
       
        public Shape()
        {
            Console.WriteLine("First entry point");
        }
    }
}
