// See https://aka.ms/new-console-template for more information

//1.     Vypište vedle sebe malou násobilku 8mi.
using System.Security.Authentication.ExtendedProtection;

int zaklad = 8;

for (int i = 1; i <= 10; i++)
{
    Console.Write(i*zaklad+", ");
}

for (int i = zaklad; i <= zaklad *10; i=i+zaklad)
{
    Console.Write(i+", ");
}

//2.     Vypište pod sebe malou násobilku 8mi s tím, že budeme vypisovat i samotný postup výpočtu
//1 * 8 = 8
//2 * 8 = 16
//3 * 8 = 24
//    ...
//10 * 8 = 80

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{i} * {zaklad} = {i*zaklad}");
}

//3.     Vypište čísla od 20 do -20 sestupně
for (int i = 20; i >= -20; i--)
{
    Console.Write(i + " ");
}

//4.     Odečtěte od proměnné cislo 5x číslo 8
int cislo = 100;
for (int i = 0; i < 5; i++)
{
    cislo = cislo - 8;
}

//5.     Vypište vedle sebe tolikrát znak %, kolikrát zadá uživatel
Console.Write("Kolikrát se má vypsat znak %: ");
int pocet = int.Parse(Console.ReadLine());

for (int i = 0; i < pocet; i++)
{
    Console.Write("%");
}

//6.     Vypište pod sebe tolik náhodných čísel od -50 do 50, kolik zadá uživatel

Random nahoda = new Random(); //vytvoření generátoru náhodných čísel

Console.Write("Kolik se mávygenerovat čísel: ");
pocet = int.Parse(Console.ReadLine());

for (int i = 0; i < pocet; i++)
{
    Console.WriteLine(nahoda.Next(-50, 50+1)); 
}

//7.     Vypište všechna čísla od -200 do 200 dělitelné číslem,
//které zadá uživatel

Console.Write("Urči dělitele: ");
int delitel = int.Parse(Console.ReadLine());

for (int i = -200; i <= 200; i++)
{
    if (i % delitel == 0)
        Console.WriteLine(i);
}


//8.     Vypište všechny čísla z rozsahu, který zadá uživatel <od, do>, které jsou dělitelné číslem 17
Console.Write("Od: ");
int _od = int.Parse(Console.ReadLine());
Console.Write("Do: ");
int _do = int.Parse(Console.ReadLine());

for (int i = _od ; i <= _do ; i++)
{
    if (i % 17 == 0)
        Console.Write(i+" ");
}


//9.     Vypište vedle sebe 20 náhodných čísel od -15 do 15 a pod ně napište, 
//kolik z těchto čísel je sudých a kolik je lichých. 
int c;
int pocetLichych = 0;
int pocetSudych = 0;
for (int i = 0; i < 20; i++)
{
    c = nahoda.Next(-15, 16);
    Console.Write(c+" ");

    if (c % 2 == 0)
        pocetSudych++;
    else
        pocetLichych++;
}
Console.WriteLine($"\n\rpočet sudých: {pocetSudych}, počet lichých: {pocetLichych}");


//10.  Vypočítejte faktoriál čísla x zadaného uživatelem 5!
//Pozn. pokud x = 5, výsledek je 5*4*3*2*1 = 120
Console.Write("Vypočítejte faktoriál čísla: ");
UInt64 fak = UInt64.Parse(Console.ReadLine());

UInt64 vysledek = 1;
for (UInt64 i = 2; i <= fak; i++)
{    
    vysledek = vysledek * i;
}
Console.WriteLine(vysledek);

/*
//max faktorial pro UInt32
vysledek = 1;
UInt32 navysovaciPromenna = 2;
do
{
    
    navysovaciPromenna++;
    vysledek = vysledek * navysovaciPromenna;

} while (vysledek < UInt32.MaxValue);
Console.WriteLine("Maximálí faktoriál pro UInt32 je " + --navysovaciPromenna);
*/