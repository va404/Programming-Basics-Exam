using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoNumSUm
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            bool yes = false;
            var combination = 0;
            bool exit = false;
            int i = 0;
            int j = 0;
            for ( i = start; i >= end; i--)
            {
                for (j = start; j >= end; j--)
                {
                    combination++;
                    if (i+j== magicNum)
                    {
                        yes = true;
                        exit = true;
                        break;
                    }
                }
                if (exit)
                {
                    break;
                }
            }
            if (yes)
            {
                Console.WriteLine("Combination N:{0} ({1} + {2} = {3}) ", combination, i, j, i + j);
            }
            else
            {
                Console.WriteLine("{0} combinations - neither equals {1}", combination,magicNum);
            }
           
        }
    }
}





