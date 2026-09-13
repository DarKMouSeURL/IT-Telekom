// See https://aka.ms/new-console-template for more information

Random nahoda = new Random();

//1) Generujte a vypisujte pod sebe čísla od -20 do 20ti tak dlouho
//dokud vygenerujete číslo 0.
//Číslo 0 se na konci VYPÍŠE!

int los;    
do
{    
    los = nahoda.Next(-20, 21);
    Console.WriteLine(los);

} while (los != 0);


//2) Generujte a vypisujte pod sebe čísla od -20 do 20ti tak dlouho
//dokud vygenerujete číslo 0.
//Číslo 0 se na konci NEVYPÍŠE!

int los2 = nahoda.Next(-20, 21);
while (los2 !=0)
{
    Console.WriteLine(los2);
    los2 = nahoda.Next(-20, 21);
}

//3) Celočíselné dělení vys =  x / y realizované pomocí odečítání
Console.Write("Dělenec: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Dělitel: ");
int y = int.Parse(Console.ReadLine());

int vysledek = 0;
while (x >= y)
{
    x = x - y;
    vysledek++;
}
Console.WriteLine($"Celočíselný podíl: {vysledek}, zbytek: {x}");


//4) Vypište malou násobilku čísla 6 pozpátku pomocí cyklu while (ne for). 
//Vypisujte vedle sebe.
// 60    54     48    ...   6

int nasobitel = 10;
int zaklad = 6;
do
{
    Console.Write(zaklad * nasobitel+", ");
    nasobitel--;

} while (nasobitel > 0);

//5) Vypisujte na vyzvání jména tak dlouho, dokud nenapíšete slovo end,
//potom se program ukončí

string slovo;
do
{
    Console.Write("napiš slovo: ");
    slovo = Console.ReadLine().ToLower().Trim();

} while (!slovo.Equals("end"));


do
{
} while (!Console.ReadLine().Equals("end"));


//6)  Generujte náhodná čísla od -100 do 100 tak dlouho, dokud se vylosují
//3 čísla celočíslně dělitelná 17ti. 
//Tato čísla vypište vedle sebe a pod ně napište počet pokusů, které jste
//na generování potřebovali. 

int pocet = 3;
int delitel = 17;
int pocetPokusu = 0;
int losovaneCislo;

do
{
    losovaneCislo = nahoda.Next(-100, 101);
    pocetPokusu++;

    if (losovaneCislo % delitel == 0)
        {
        Console.WriteLine(losovaneCislo);
        pocet--;
    }

} while (pocet >0);
Console.WriteLine("Počet pokusů pro losování: " + pocetPokusu);


Console.ReadLine();

