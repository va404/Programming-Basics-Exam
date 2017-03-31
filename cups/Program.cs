using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cups
{
    class Program
    {
        static void Main(string[] args)
        {
            int cupsToMake = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int workingDays = int.Parse(Console.ReadLine());

            int hours = workers * workingDays * 8;
            double cups =  hours / 5;
            var profit = (cupsToMake-cups) * 4.20;
            var loses = (cupsToMake - cups) * 4.20;
            if (Math.Floor(cups)>cupsToMake)
            {
                Console.WriteLine("{0:f2} extra money", Math.Abs( profit));
            }
            else
            {
                Console.WriteLine("Losses: {0:f2}", Math.Abs(loses));
            }
            

        }
    }
}
