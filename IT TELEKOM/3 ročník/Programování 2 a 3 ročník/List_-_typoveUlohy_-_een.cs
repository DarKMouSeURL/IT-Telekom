// See https://aka.ms/new-console-template for more information

static void VypisSeznam(List<int> seznam)
{
    Console.WriteLine("--------------------------");
    Console.WriteLine("Výpis seznamu:");
    for (int i = 0; i < seznam.Count; i++)
        Console.Write("{0} ", seznam[i]);
    Console.WriteLine("\n--------------------------\n ");
}


Console.WriteLine("1. Vytvořte seznam celých čísel s názvem cisla a uložte do něho na začátku hodnoty 10,18,15,-5");
List<int> cisla = new List<int>() { 10, 18, 15, -5 };
VypisSeznam(cisla);


Console.WriteLine("2. Do tohoto seznamu nalosujte navíc dalších 100 čísel od -20 do 20");
Random nahoda = new Random();
for (int i = 0; i < 100; i++)
    cisla.Add(nahoda.Next(-20, 21));
VypisSeznam(cisla);


Console.WriteLine("4. Poslední prvek nahraďte (přepište) číslem 20");
cisla[cisla.Count - 1] = 20;
VypisSeznam(cisla);


Console.WriteLine("5. Na konec seznamu přidejte prvek -20");
cisla.Add(-20);
VypisSeznam(cisla);


Console.WriteLine("6. První prvek nahraďte (přepište) číslem 20");
cisla[0] = 20;
VypisSeznam(cisla);

Console.WriteLine("7. Na začátek seznamu přidejte prvek -20");
cisla.Insert(0, -20);
VypisSeznam(cisla);


Console.WriteLine("8. Vymažte první výskyt čísla 20 ze seznamu");
cisla.Remove(20);
VypisSeznam(cisla);


Console.WriteLine("9. Vymažte všechny výskyty čísla 0");
while (cisla.Contains(0))
    cisla.Remove(0);
VypisSeznam(cisla);


Console.WriteLine("10. Vymažte všechny výskyty záporných dvouciferných čísel");
for (int i = 0; i < cisla.Count; i++)
{
    if (-99 <= cisla[i] && cisla[i] <= -10)
    {
        cisla.RemoveAt(i);
        i--;
    }
}
VypisSeznam(cisla);


Console.WriteLine("11.Vymaže prvek, který je aktuálně na indexu č. 4");
cisla.RemoveAt(4);
VypisSeznam(cisla);


Console.WriteLine("12. Prohoďte mezi sebou první 2 prvky seznamu (použijte pomocnou proměnnou pom)");
int pom = cisla[0];
cisla[0] = cisla[1];
cisla[1] = pom;
VypisSeznam(cisla);


Console.WriteLine("13. Prohoďte mezi sebou první 2 prvky seznamu (použijte již hotové metody indexovaného seznamu)");
cisla.Insert(0, cisla[1]);
cisla.RemoveAt(2);
//cisla.Reverse(0, 2);
VypisSeznam(cisla);


Console.WriteLine("14. Prvek z indexu 3 přemístěte na konec seznamu");
cisla.Add(cisla[3]);
cisla.RemoveAt(3);
VypisSeznam(cisla);

Console.WriteLine("14.1 Prvek z indexu 3 přemístěte na začátek seznamu");
int index = 3;
cisla.Insert(0, cisla[index]);
cisla.RemoveAt(index+1); //!!došlo k posunu hodnot na indexech


Console.WriteLine("15. Předposlední prvek seznamu přemístěte na začátek seznamu");
cisla.Insert(0, cisla[cisla.Count - 2]);
cisla.RemoveAt(cisla.Count - 2); //došlo sice k posunu hodnot, ale aktuálně tento index
                   //přepočítávám vzhledem k poslednímu prvku (relativně), takže 
                   //výraz pro výpočet indexu je stejné, ne jako ve 14.1
VypisSeznam(cisla);


Console.WriteLine("16. Vymažte každý 5. prvek (počínaje prvkem na indexu 4)");
for (int i = 4; i < cisla.Count; i += 5)
{
    cisla.RemoveAt(i);
    i--;
}
VypisSeznam(cisla);


Console.WriteLine("17.Vypište číslo indexu, na kterém leží 1. hodnota 10, pokud v seznamu hodnota není, napište NENALEZENO");
index = cisla.IndexOf(10);
if (index != -1)
    Console.WriteLine("Index: " + index);
else
    Console.WriteLine("NENALEZENO");
Console.WriteLine();


Console.WriteLine("18.Vypište aritmetický průměr hodnot v poli - na 3 desetinná místa");
int suma = 0;
for (int i = 0; i < cisla.Count; i++)
    suma += cisla[i];
double prumer = (double)suma / cisla.Count;
prumer = Math.Round(prumer, 3);
Console.WriteLine("Průměr: " + prumer);
Console.WriteLine();

//NEBO POUŽIJEME HOTOVOU METODU double prum = cisla.Average();

Console.WriteLine("19.Vypište , kolik hodnot v seznamu je nezáporných");
int pocet = 0;
foreach (int cislo in  cisla )
{
    if (!(cislo < 0))
        pocet++;
}   
Console.WriteLine("Počet nezáporných čísel: " + pocet);
Console.WriteLine();


//20.Vytvořte pole s názvem cisla2 a uložte do něj hodnoty ze seznamu cisla
int[] cisla2 = cisla.ToArray();



