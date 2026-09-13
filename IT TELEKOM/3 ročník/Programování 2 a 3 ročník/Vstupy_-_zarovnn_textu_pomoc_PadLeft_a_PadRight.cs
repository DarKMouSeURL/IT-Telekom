using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jm1 = "Eva";
            int vek1 = 25;
            string poz1 = "Chodí včas do práce";
            double plat1 = 52478;

            string jm2 = "Rostislav";
            int vek2 = 35;
            string poz2 = "Chodí pozdě do práce";
            double plat2 = 465;

            Console.WriteLine($"{jm1.PadRight(12)}{vek1.ToString().PadRight(5)}{poz1.PadRight(40)}{plat1.ToString().PadLeft(8)} Kč");
            Console.WriteLine($"{jm2.PadRight(12)}{vek2.ToString().PadRight(5)}{poz2.PadRight(40)}{plat2.ToString().PadLeft(8)} Kč");

            Console.ReadLine();
        }
    }
}
