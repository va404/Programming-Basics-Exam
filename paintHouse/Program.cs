using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paintHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double door = 1.2 * 2;
            double window = 1.5 * 1.5;
            double frontWall = x * x + x * x - door;
            double sideWall = x * y + x * y - window * 2;
            double roofRect = x * y + x * y;
            double roofTriangle = 2 * (x * h / 2);
            double greenpaint = (frontWall + sideWall) / 3.4;
            double redPaint = (roofRect + roofTriangle) / 4.3;
            Console.WriteLine("{0:f2}",greenpaint);
            Console.WriteLine("{0:f2}",redPaint);
        }
    }
}
