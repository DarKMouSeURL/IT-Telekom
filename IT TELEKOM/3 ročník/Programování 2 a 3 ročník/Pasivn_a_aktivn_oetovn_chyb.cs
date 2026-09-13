using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Da_maturita17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ošetřování chybových stavů
            // - vstupy od uživatele
            // - jakýkoli vstup/výstupní prvek
            //   práce se souborem, databází, po síti..

            //Jak ošetřujeme chyby: 
            //aktivní
            //  cíleně ošetřuji konkrétní možnou chybu (např. pomocí if)
            //pasivní
            //  komplexní ošetření složitějšího kódu
            //  používáme nejčasteji výjimky (try-catch blok)
            //ideální je kombinovat pasivní a aktivní ošetřování chyb


            //********************************************************************************
           
            int delenec, delitel;
            
                       //Možnost použití metody TryParse
                       //Validace vstupních dat pro potřeby konverze mezi datovými typy


                       ///pasivní ověřování vstupu 
                       Console.WriteLine("Dělenec: ");
                       bool delenecOk = int.TryParse(Console.ReadLine(), out delenec);
                       Console.WriteLine("Dělitel ");
                       bool delitelOk = int.TryParse(Console.ReadLine(), out delitel);

                       if (delenecOk && delitelOk)
                       {
                           //aktivní ověřování dělení 0
                           if (delitel != 0)
                               Console.WriteLine((double)delenec / (double)delitel);
                           else
                               Console.WriteLine("ERROR: Nulou nepodělíš!");
                       }
                       else
                       {
                           Console.WriteLine("ERROR: Chyba na vstupu!");
                       }
                       
            //***********************************************************************************

            //pasivní ošetřování téhož příkladu - LEPŠÍ ŘEŠENÍ
            try
            {
                //kód se poprvé provede nanečisto v oddělené části paměti
                Console.WriteLine("Dělenec: ");
                delenec = int.Parse(Console.ReadLine());
                Console.WriteLine("Dělitel ");
                delitel = int.Parse(Console.ReadLine());


                //Máme 3 možnosti., jak zde řešit dělení 0:
                //1) buď to v tomto případě neřešíme, protože c# nespadne
                //2) nebo použijeme existující exception (aktivně)
                if (delitel == 0)
                    throw new DivideByZeroException();

                //3) nebo vytvoříme vlastní exception (aktivně) - tady použití u uměle vytvořené chyby
                if (delitel >= 1000)
                    throw new Exception("Pozor, máš přece zakázáno dělit číslem větším než 999");

                Console.WriteLine((double)delenec / delitel);
            }
            catch (FormatException)
            {
                Console.WriteLine("Vstupní řetězec nemá správný formát, ty můj uživateli..");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Tvoje číslo je příliš dlouhé, ty můj uživateli..");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Nulou nepodělíš");
            }

            catch (Exception ex) //zachytává na závěr všechny ostatní chyby
            {
                Console.WriteLine("ERROR " + ex.Message);
            }
          

           
           
            Console.ReadLine();

        }
    }
}
