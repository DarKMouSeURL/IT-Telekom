// See https://aka.ms/new-console-template for more information

//POLE - ZÁKLADNÍ SYNTAXE

//vytvoření pole stringů o 5ti prvcích
string[] poleJmen = new string[5];     //[] - alt + f,g
                                       //indexy 0..4

//Vypiš počet prvků pole na consoli
Console.WriteLine(poleJmen.Length);

//Na index č. 0 vlož jméno Jana
poleJmen[0] = "Jana";

//Na index č. 3 vlož jméno Petr
poleJmen[3] = "Petr";

//Na poslední prvek vložte jméno Ota
poleJmen[poleJmen.Length-1] = "Ota";

//Vypište prvek z pole na indexu 3
Console.WriteLine(poleJmen[3]);

//vypište prvky pole na consoli
//výpis pomocí foreach
//prochází prvky přesně od 0 do posledního indexu
//pouze pro ReadOnly účely!!
foreach (string xyz in poleJmen)
    Console.WriteLine(xyz);


//vypište prvky pole na consoli (včetně indexů)
for (int i = 0; i < poleJmen.Length; i++)
{
    Console.WriteLine($"{i}. {poleJmen[i]}");  //i - index   pole[i] - hodnota na indexu
}

//do pole s názvem znaky uložte všechny samohlásky
char[] samohlasky = new char[] { 'a', 'e', 'i', 'o', 'u' };

//vytvořte 100 prvkové pole a uložte do něj náhodná čísla od -50,50
Random nahoda = new Random();
int[] cisla = new int[100];
for (int i = 0; i < cisla.Length; i++)
{
    cisla[i] = nahoda.Next(-50, 51);
}

//vypište pole cisla pozpátku
//tedy nelze použít foreach
for (int i = cisla.Length-1 ; i >= 0; i--)
{
    Console.WriteLine(cisla[i]);

}


Console.ReadLine();