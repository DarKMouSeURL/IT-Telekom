// See https://aka.ms/new-console-template for more information


gargamel:

//DIAGNOSTIKA CELÉHO ČÍSLA NA VSTUPU
Console.Write("Zadej číslo: ");
int cislo = int.Parse(Console.ReadLine());

//KLADNÉ / ZÁPORNÉ / NULA (použití složeného větvení)
if (cislo > 0)
    Console.WriteLine("kladné");
else if (cislo < 0)
    Console.WriteLine("záporné");
else
    Console.WriteLine("nula");


//SUDÉ/LICHÉ (úplné větvení)
if (cislo % 2 == 0)
    Console.WriteLine("sudé");
else
    Console.WriteLine("liché");

//if (cislo % 2 == 1 || cislo % 2 == -1)
//    Console.WriteLine("liché");
//else
//    Console.WriteLine("sudé");

//ABS HODNOTA (neúplné větvení)
int cisloAbs = cislo;
if (cisloAbs < 0)
    cisloAbs *= -1; //cisloAbs = -1 * cisloAbs;
Console.WriteLine($"absolutní hodnota čísla je: {cisloAbs}");

Console.Write("Chceš pokračovat dalším číslem (a/n): ");
string odpoved = Console.ReadLine().Trim().ToLower();
if (odpoved == "a")
    goto gargamel;

Console.ReadLine();