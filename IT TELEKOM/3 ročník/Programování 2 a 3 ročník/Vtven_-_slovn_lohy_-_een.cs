using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;

namespace _2C_vetveni_slovniUlohy
{
    internal class Program
    {
        static void Main(string[] args)
        {

//1) V proměnné zustatek je celkem 20000.
//v proměnné cenaZbozi je uložená hodnota. (vstup z console)

//Pokud jsou na účtu prostředky pro nákup, tak na consoli
//vypište "ok" a ze zůstatku odečtěte cenu zboží.
//V opačném případě vypište na consoli "transakce nebyla provedena"

            double zustatek = 20000;

            Console.Write("Cena zboží: ");
            double cenaZbozi = double.Parse(Console.ReadLine());

            if (zustatek >= cenaZbozi)
            {
                zustatek -= cenaZbozi;
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Transakce nebyla provedena");
            }
            Console.ReadLine();


//2) Firma dostane zakázku v ceně double zakazka = ?; (vstup z console)
//- Pokud je zakázka do ceny 50000 Kč, na zakázce nebude poskytnuta sleva
//- Pokud je zakázka od 50000 Kč(včetně) do ceny 150000 Kč,
//  na zakázce bude poskytnuta sleva 5000 Kč.
//- Pokud je zakázka za 150000(včetně) a vyšší, sleva bude
//  ve výši 3 % z celkové zakázky.
//Vypište na consoli konečnou cenu zakázky(neměňte původní proměnnou)

            Console.Write("Cena zakázky: ");
            double cenaZakazky = double.Parse(Console.ReadLine());

            if (cenaZakazky < 50000)
                Console.WriteLine(cenaZakazky);
            else if (cenaZakazky < 150000)
                Console.WriteLine(cenaZakazky - 5000);
            else
                Console.WriteLine(cenaZakazky * 0.97);

            Console.ReadLine();

        }
    }
}