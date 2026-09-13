// See https://aka.ms/new-console-template for more information

using _3Ca_praceSeSoubory;

//PraceSeSoubory.ZapisDoSouboruUExe("ovoce.txt", "meloun");
//Console.WriteLine(PraceSeSoubory.CteniZeSouboruUExe("ovoce.txt"));

//try
//{
//	PraceSeSoubory.ZapisDoSouboruUExe2("zamestnanci.txt", "Martin Novák - 20 let");
//}
//catch (Exception)
//{
//	Console.WriteLine("Chyba zápisu do souboru");
//}

//try
//{
//	Console.WriteLine(PraceSeSoubory.CteniZeSouboruUExe2("ovoce.txt"));
//}
//catch (Exception)
//{
//    Console.WriteLine("Chyba čtení ze souboru");
//}

PraceSeSoubory.TvorbaDefaultSlozkyVAppDatech();

try
{
	PraceSeSoubory.ZapisRadekDoSouboruAppData("houby.txt", "bedla");
}
catch (Exception ex)
{
	Console.Error.WriteLine("Chyba zápisu " + ex.Message);
}

try
{
    Console.WriteLine(PraceSeSoubory.CteniSouboruAppData("houby.txt"));
}
catch (Exception ex)
{
    Console.Error.WriteLine("Chyba čtení: "+ex.Message);
}

try
{
    string[] pole = PraceSeSoubory.VratPoleZeSouboruAppData("houby.txt");
    foreach (string r in pole)
    {
        Console.WriteLine(r);
    }
}
catch (Exception ex)
{
    Console.Error.WriteLine("Chyba čtení: " + ex.Message);
}