using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int lecturesCount = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            int jelevC = 0;
            int RoYaLC = 0;
            int RoliC = 0;
            int TrofonC = 0;
            int SinoC = 0;
            int other = 0;

            double forEachLecture = budget / lecturesCount;
            for (int i = 1; i <= lecturesCount; i++)
            {
                var lectorName = Console.ReadLine();
                switch (lectorName)
                {
                    case "Jelev":
                        jelevC++;
                        break;
                    case "RoYaL":
                        RoYaLC++;
                        break;
                    case "Roli":
                        RoliC++;
                        break;
                    case "Trofon":
                        TrofonC++;
                        break;
                    case "Sino":
                        SinoC++;
                        break;
                    default:
                        other++;
                        break;
                }
            }
            Console.WriteLine("Jelev salary: {0:f2} lv", forEachLecture * jelevC);
            Console.WriteLine("RoYaL salary: {0:f2} lv", forEachLecture * RoYaLC);
            Console.WriteLine("Roli salary: {0:f2} lv", forEachLecture * RoliC);
            Console.WriteLine("Trofon salary: {0:f2} lv", forEachLecture * TrofonC);
            Console.WriteLine("Sino salary: {0:f2} lv", forEachLecture * SinoC);
            Console.WriteLine("Others salary: {0:f2} lv", forEachLecture * other);
        }
    }
}
