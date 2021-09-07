using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectingQuiltShapes
{
    // Base Class
    class Shape
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Side { get; set; }
       
        public Shape()
        {
            //Entry point from any choice in program
            Console.Write("");
        }
    }
}
