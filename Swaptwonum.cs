using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWaping_of_Two_Numbers
{
    public class Swaptwonum
    {
        public static void Swap()

        {
            int a = 5;
            int b = 10;

            a = a * b;
            b = a / b;
            a = a / b;

            Console.WriteLine("Swap" + a );
            Console.WriteLine("swap" + b);
        }
    }
}
