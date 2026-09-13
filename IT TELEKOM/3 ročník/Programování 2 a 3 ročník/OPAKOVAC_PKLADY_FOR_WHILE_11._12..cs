using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2C_cviceniCykly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vypočítejte aritmetický průměr všech sudých čísel od 30 do 130.
            int min = 29;
            int max = 131;

            //řešení 1 *********************************************************
            int soucet = 0;
            int pocet = 0;
            for (int i = min; i <= max ; i++)
            {
                if (i % 2 == 0)
                {
                    pocet++;
                    soucet += i;
                }
            }
            Console.WriteLine((double)soucet / (double)pocet);

            //řešení 2 ***********************************************************
            
            soucet = 0;
            pocet = 0;

            //zajištění, že začínám sudým číslem!
            if (min % 2 != 0)
                min++;

            for (int i = min; i <= max; i+=2)
            {
                    pocet++;
                    soucet += i;
            }
            Console.WriteLine((double)soucet / (double)pocet);

            //řešení 3 ***********************************************************
            soucet = 0;
            pocet = 0;

            int aktualniHodnota = min;
            if (min % 2 != 0)
                aktualniHodnota++;

            do
            {
                pocet++;
                soucet += aktualniHodnota;

                aktualniHodnota += 2;

            } while (aktualniHodnota<=max);

            Console.WriteLine((double)soucet / (double)pocet);

            Console.ReadLine();

            //Vypište vedle sebe právě tolik znaků x, kolik zadá uživatel
            //pokudu uživatel zapíše číslo nekladné, nevypíše se nic
            //řešte pomocí for i while

            //Uživetel zadá na vstupu číslo 1 
            //Číslo 2 se vygeneruje náhodně z rozmezí <-100, 100>
            //Vypíšou se všechna čísla mimo těchto 2 mezních čísel
            //př. 5  10   ->   6,7,8,9
            //př. 3   -3   ->  2,1,0,-1,-2
            //řeště pomocí for

            //Generujte náhodná čísla <-100, 100>
            //tak dlouho, dokud se nevygeneruje 3x číslo dělitelné 10ti
            //tato 3 čísla vypište a napište počet neúšpěšných generování
            //while

        }
    }
}
