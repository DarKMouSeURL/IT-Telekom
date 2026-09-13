using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto a = new Auto();

            a.Tachometr = 50;
            Console.WriteLine(a.Tachometr);

            a.Znacka = "Porsche";
            Console.WriteLine(a.Znacka);

            a.SetMaxRychlost(180);
            Console.WriteLine(a.GetMaxRychlost());
        }


        internal class Auto
        {
            //1. možnost get set
            private int tachometr;
            public int Tachometr { get { return tachometr; } set { tachometr = value; } }

            //2. možnost get set
            public string Znacka { get; set; }

            //3. možnost get set - pomocí metod - jediná přístupná možnost v JAVA
            private int maxRychlost;

            public int GetMaxRychlost()
            {
                return maxRychlost;
            }

            public void SetMaxRychlost(int novaHodnota)
            {
                maxRychlost = novaHodnota;
            }
        }
    }
}
