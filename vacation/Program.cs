using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";

            var place = "";
            double winterPrice = 0.0;
            double summerPrice = 0.0;

            switch (season)
            {
                case "Summer":
                    destination = "Alaska";
                    break;
                case "Winter":
                    destination = "Morocco";
                    break;

            }
            if (budget <= 1000)
            {

                summerPrice = budget - budget * 0.35;
                winterPrice = budget - budget * 0.55;
                place = "Camp";
            }
           else if (budget > 1000 && budget <= 3000)
            {

                place = "Hut";
                winterPrice = budget - budget * 0.40;
                summerPrice = budget - budget * 0.20;
            }
           else if (budget > 3000)
            {

                place = "Hotel";
                winterPrice = budget - budget * 0.10;
                summerPrice = budget - budget * 0.10;
            }

            if (season == "Summer")
            {
                Console.WriteLine("{0} - {1} - {2:f2}", destination, place, summerPrice);
            }
            else
            {
                Console.WriteLine("{0} - {1} - {2:f2}", destination, place, winterPrice);
            }

        }
    }
}
