using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snacke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 1;
            p1.y = 3;
            p1.symb = '*';
            p1.Draw();

            Point p2 = new Point();
            p2.x = 4;
            p2.y = 7;
            p2.symb = '#';
            p2.Draw();
            
            Console.ReadLine();

        }
 
    }
}
