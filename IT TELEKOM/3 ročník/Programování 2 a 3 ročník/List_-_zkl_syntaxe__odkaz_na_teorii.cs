// See https://aka.ms/new-console-template for more information

//INDEXOVANÝ SEZNAM
//TEORIE: https://www.itnetwork.cz/csharp/oop/c-sharp-tutorial-list-pridavani-mazani-polozek


//statická metoda (podprogram) pro vypisování seznamu
static void VypisSeznam(List<string> seznam)
{
    for (int i = 0; i < seznam.Count; i++)
        Console.WriteLine($"{i}. {seznam[i]}");   //i .. index, jmena[i] .. hodnota na indexu
}


//ZDE JAKOBY ZAČÍNÁ METODA MAIN - ZDE ZAČÍNÁ PROGRAM
//**************************************************

//deklarace seznamu
List<string> jmena = new List<string>() {"Magda","Ondřej", "Jan", "Magda", "Alena", "Magda","Magda" }; //indexy 0..4
VypisSeznam(jmena);

Console.WriteLine("Add - přidej prvek ALOIS na konec seznamu");
jmena.Add("Alois");
VypisSeznam(jmena);

Console.WriteLine("Insert - přidej prvek ŽANETA dovnitř seznamu na index 1");
int index = 1;
if (jmena.Count >= index)
    jmena.Insert(1, "Žaneta");
VypisSeznam(jmena);

Console.WriteLine("Přepiš prvek v poli - JAN na index 1. Nezvýší počet prvků v poli!");
jmena[1] = "Jan";
VypisSeznam(jmena);

Console.WriteLine("Remove - smaže POUZE první výskyt prvku MAGDA v seznamu");
jmena.Remove("Magda");
VypisSeznam(jmena);

Console.WriteLine("Contains - vrací true / false dle toho, zda se v seznamu vyskytuje prvek JAN");
string hledneJmeno = "Jan";
if (jmena.Contains(hledneJmeno))
    Console.WriteLine($"{hledneJmeno} je v seznamu");
else
    Console.WriteLine($"{hledneJmeno} není v seznamu");

Console.WriteLine("Smaž všechny výskyty jména MAGDA");
while (jmena.Contains("Magda"))
    jmena.Remove("Magda");
//for (int i = 0; i < jmena.Count; i++)
//{
//    if (jmena[i].Equals("Magda"))
//    {
//        jmena.RemoveAt(i);
//        i--;
//    }
//}
VypisSeznam(jmena);

Console.WriteLine("IndexOf - vrať index seznamu, na kterém se nachází ALOIS");
Console.WriteLine("Pozn. Pokud se slovo v seznamu nevyskytuje, metoda vrátí hodnotu -1");
int hledanyIndex = jmena.IndexOf("Alois");
if (hledanyIndex != -1) //pokud prvek existuje
    Console.WriteLine(hledanyIndex);
else
    Console.WriteLine("Prvek neexistuje");


Console.WriteLine("removeat - smaž prvek na indexu 3");
jmena.RemoveAt(3);
VypisSeznam(jmena);

Console.WriteLine("Sort - seřaď seznam vzestupně");
jmena.Sort();
//jmena.Reverse(); // sestupně
VypisSeznam(jmena);

//Převod na pole
String[] poleJmen = jmena.ToArray();

Console.ReadLine();


//ukol:
//1) Generujte indexovaný seznam s nazvem cisla a uložte do něj
//   50 náhodných hodnot mezi -20 a 20ti. 
//2) Vytvořte metodu Vypis_seznam, která Vám tato čísla vypíše VEDLE SEBE oddělené
//   čárkou na consoli. Metodu v programu průběžně používejte.



 



