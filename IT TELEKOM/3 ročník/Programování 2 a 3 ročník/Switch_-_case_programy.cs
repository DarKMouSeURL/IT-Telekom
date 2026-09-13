// See https://aka.ms/new-console-template for more information

using System.Linq.Expressions;

Console.Write("Zadej známku: ");
int znamka = int.Parse(Console.ReadLine());

switch (znamka)
{
    case 1: Console.WriteLine("Výborně"); break;
    case 2: Console.WriteLine("Chvalitebně"); break;
    case 3: Console.WriteLine("Dobře"); break;
    case 4: Console.WriteLine("Dostatečně"); break;
    case 5: Console.WriteLine("Nedostatečně"); break;
    default: Console.WriteLine("Známka neexistuje"); break;
}

Console.Write("Zadej den v týdnu: ");
string den = Console.ReadLine().Trim().ToLower();
switch (den)
{
    case "po":
    case "pondeli":
    case "ut":
    case "utery":
    case "st":
    case "streda":
    case "ct":
    case "ctvrtek":
    case "pa":
    case "patek":
        Console.WriteLine("Všední den"); break;
    case "so":
    case "sobota":
    case "ne":
    case "nedele":
        Console.WriteLine("Víkend"); break;
    default:
        Console.WriteLine("Den v týdnu neexistuje"); break;
}

Console.WriteLine("Zadej číslo");
int cislo = int.Parse(Console.ReadLine());
switch (cislo % 2)
{
    case 0:
        Console.WriteLine("sudé"); break;
    case 1:
    case -1:
        Console.WriteLine("liché"); break;
}

Console.Write("Zadej a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Zadej b: ");
int b = int.Parse(Console.ReadLine());
int vysledek = 0;
Console.Write("Zadej operaci: ");
switch (Console.ReadKey())
{
    case Key:
        vysledek = a + b; break;
}



Console.ReadLine();
