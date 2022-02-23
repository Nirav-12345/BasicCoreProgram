using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotientReminder
{
    public class QuioRemind
    {
        public static void FindingQuiotRemind()
        {
            int Divident = 50; int divisor = 8;

            int Quiotent = Divident / divisor;

            int Reminder = Divident % divisor;

            Console.WriteLine("Divident" +Divident+ "divisor" + divisor);

            Console.WriteLine("Quiotnet" + Quiotent);

            Console.WriteLine("Reminder" + Reminder);
        }
    }
}
