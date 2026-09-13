using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.IsolatedStorage;

namespace _3Ca_praceSeSoubory
{
    internal static class PraceSeSoubory
    {
        public static void ZapisDoSouboruUExe(string nazev, string radek)
        {
            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter(nazev, true, Encoding.UTF8);
                sw.WriteLine("Jablko");
                sw.WriteLine("Hruška");
                sw.WriteLine(radek);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Chyba v zápisu do souboru " + ex);
            }
            finally
            {
                if (sw !=null)
                {
                    sw.Flush();
                    sw.Close();
                }
            }
        }

        public static void ZapisDoSouboruUExe2(string nazev, string radek)
        {
            using (StreamWriter sw = new StreamWriter(nazev, true, Encoding.UTF8))
            {              
                sw.WriteLine(radek);
                sw.Flush();                   
            }
        }


        public static string CteniZeSouboruUExe(string nazev)
        {
            StreamReader sr = null;

            try
            {
                sr = new StreamReader(nazev, Encoding.UTF8);
                string text = "";
                //return sr.ReadLine();
                return sr.ReadToEnd();
            }
            catch (FileNotFoundException)
            {
                return "Chyba - soubor neexistuje";
            }
            catch (Exception ex)
            {
                return "Chyba při čtení ze souboru " + ex;
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }


        public static string CteniZeSouboruUExe2(string nazev)
        {

            using (StreamReader sr = new StreamReader(nazev, Encoding.UTF8))
            {
                //return sr.ReadToEnd();

                //po řádcích
                StringBuilder sb = new StringBuilder();
                while (!sr.EndOfStream)
                {
                    sb.Append("* "+sr.ReadLine()+"\n");
                }
                return sb.ToString();
            }
               
        }

        //***********************************************************************

        static public string cestaDoSlozky;

        static public void TvorbaDefaultSlozkyVAppDatech()
        {
            cestaDoSlozky = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Složka mého programu");
            //vytvoř složku, pokud ještě neexistuje
            if (!Directory.Exists(cestaDoSlozky))
                Directory.CreateDirectory(cestaDoSlozky);
        }

        static public void ZapisRadekDoSouboruAppData(string nazevSouboru, string radek)
        {
            string cestaDoSouboru = Path.Combine(cestaDoSlozky, nazevSouboru);

            using (StreamWriter sw = new StreamWriter(cestaDoSouboru, true, Encoding.UTF8))
            {
                sw.WriteLine(radek);
                sw.Flush();
            }

        }

        static public string CteniSouboruAppData(string nazevSouboru)
        {
            string cestaDoSouboru = Path.Combine(cestaDoSlozky, nazevSouboru);

            using (StreamReader sr = new StreamReader(cestaDoSouboru, Encoding.UTF8))
            {
                return sr.ReadToEnd();
            }

        }

        static public string[] VratPoleZeSouboruAppData(string nazevSouboru)
        {
            string cestaDoSouboru = Path.Combine(cestaDoSlozky, nazevSouboru);
            return File.ReadAllLines(cestaDoSouboru);
           

        }
    }
}
