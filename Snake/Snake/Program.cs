using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            HorizontalLine hl = new HorizontalLine(0, 20, 1, '*');

            hl.Drow();

            VerticalLine vl = new VerticalLine(1, 20, 0, '*');
            vl.Drow();

        
         //   p1.Draw();
            Console.ReadKey();
        }
        
    }
}
