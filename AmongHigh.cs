using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestAmongThree
{
    public class AmongHigh
    {

        public static void LaNum()
        {
            int x = Convert.ToInt32(Console.ReadLine());

            int y = Convert.ToInt32(Console.ReadLine());

            int z = Convert.ToInt32(Console.ReadLine());

            if (x > y)
            {
                





             if (x> z)

                {
                    Console.WriteLine("The greatest int " + x);
                }

                else
                {
                    Console.WriteLine("The greatest int " + z);
                }
            }

            else if(y>z)
            {
                Console.WriteLine("2nd is greatest");
            }

            else
            {
                Console.WriteLine("3rd is greatest among three");
            }

        }
    }
}
