using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandClock
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}", new string('*', n * 2 +1));
            Console.WriteLine(".*{0}*.", new string(' ', (n * 2 +1)-4));
            var dots = 2;
            var asign = (n * 2 + 1) - 6;
            for (int i = 1; i <= n - 2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', dots), new string('@', asign));
                dots++;
                asign-=2;
            }
            Console.WriteLine("{0}*{0}", new string('.',n));
            dots = (n*2+1-3)/2;
            var spaces = 0;
            for (int i = 1; i <=n-2; i++)
            {
                Console.WriteLine("{0}*{1}@{1}*{0}",new string('.',dots), new string(' ',spaces));
                dots --;
                spaces ++ ;
            }
            Console.WriteLine(".*{0}*.", new string('@', (n * 2 + 1) - 4));
            Console.WriteLine("{0}", new string('*', n * 2 + 1));

        }
    }
}
