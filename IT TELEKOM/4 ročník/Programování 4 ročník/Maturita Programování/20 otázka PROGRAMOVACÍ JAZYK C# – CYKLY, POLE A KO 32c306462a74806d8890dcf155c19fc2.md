# 20. otázka PROGRAMOVACÍ JAZYK C# – CYKLY, POLE A KOLEKCE

---

- porovnání pole a indexovaného seznamu, deklarace
- práce s polem a se seznamem prakticky
- typy cyklů, ukázky na příkladech
- algoritmus pro nalezení největšího čísla v seznamu celých čísel
- statické metody

---

## Porovnání pole a indexovaného seznamu, deklarace

Pole má **přesný počet** prvků.

indexovaný seznam “List” **se zvětšuje** dynamicky. 

| **Vlastnost** | **Pole (T[])** | **Seznam (List<T>)** |
| --- | --- | --- |
| **Velikost** | **Fixní** – musíš ji znát při vytvoření | **Dynamická** – roste a zmenšuje se automaticky |
| **Rychlost** | Mírně rychlejší (přímý přístup do paměti) | O trochu pomalejší (kvůli režii dynamiky) |
| **Metody** | Jen základní (`Length`, `Clone`) | Bohatá výbava (`Add`, `Remove`, `Sort`, `Find`...) |
| **Namespace** | Zabudováno v .NET (není třeba `using`) | `System.Collections.Generic` |
| **Kdy použít** | Pevný počet prvků, maximální výkon | Neznámý nebo měnící se počet prvků |

### Pole (Array)

```csharp
// Deklarace s určením velikosti (všechny prvky budou 0)
int[] cisla = new int[5];

// Deklarace s přímým naplněním hodnotami
string[] dnyVTydnu = { "Pondělí", "Úterý", "Středa" };

// Přístup k prvku (přes index)
Console.WriteLine(dnyVTydnu[0]); // Vypíše: Pondělí
```

### Indexovaný seznam (List)

Seznam je v C# nejpoužívanější kolekce. 

```csharp
using System.Collections.Generic; // Nutné pro práci s Listem

// Deklarace prázdného seznamu
List<string> nakupniSeznam = new List<string>();

// Deklarace s inicializací 
List<int> skore = [10, 20, 30]; 

// Přidávání a odebírání prvků
nakupniSeznam.Add("Chleba");
nakupniSeznam.Add("Mléko");
nakupniSeznam.Remove("Chleba");

// Počet prvků (u Listu používáme Count, u Pole Length)
Console.WriteLine(nakupniSeznam.Count);
```

## Práce s polem a se seznamem prakticky

V praxi se práce s kolekcemi točí kolem několika základních úkonů: jak data do struktury dostat, jak je změnit, jak je najít a jak je vypsat.

Zatímco pole je omezené jeho velikostí, seznam má volné ruce.

## Práce s Polem (Array)

Pole je skvělé na data, která se nemění .

```csharp
// 1. Inicializace
string[] ovoce = { "Jablko", "Banán", "Pomeranč" };

// 2. Změna hodnoty (přepsání)
ovoce[1] = "Jahoda"; // Banán zmizel, je tam Jahoda

// 3. Zjištění délky
int pocet = ovoce.Length; // Vrací 3

// 4. Procházení polem (Cyklus)
for (int i = 0; i < ovoce.Length; i++)
{
    Console.WriteLine($"Na indexu {i} je {ovoce[i]}");
}
```

## Práce se Seznamem (List)

```csharp
List<string> hraci = new List<string> { "Pepa", "Alena" };

// 1. Přidávání prvků
hraci.Add("Karel");
hraci.AddRange(new[] { "Lucka", "Mirek" }); // Přidá více prvků najednou

// 2. Odebírání prvků
hraci.Remove("Pepa"); // Odstraní konkrétní shodu
hraci.RemoveAt(0);    // Odstraní prvek na první pozici

// 3. Vyhledávání
bool existuje = hraci.Contains("Alena"); // Vrací true/false
int pozice = hraci.IndexOf("Karel");    // Najde index (pokud neexistuje, vrací -1)

// 4. Seřazení
hraci.Sort(); // Seřadí seznam abecedně
```

# typy cyklů, ukázky na příkladech

## Cyklus `for`

- používá se, když **víme předem, kolikrát** se cyklus opakuje
- struktura: `for (inicializace; podmínka; krok)`

```csharp
// Výpis čísel 1 až 5
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}

// Procházení pole přes index
string[] ovoce = { "Jablko", "Hruška", "Banán" };
for (int i = 0; i < ovoce.Length; i++)
{
    Console.WriteLine($"{i}: {ovoce[i]}");
}
```

## Cyklus `while`

- opakuje blok kódu **dokud je podmínka pravdivá**
- podmínka se kontroluje **před** každým průchodem
- pokud podmínka není splněna hned, cyklus se nevykoná ani jednou

```csharp
int i = 1;
while (i <= 5)
{
    Console.WriteLine(i);
    i++;
}

// Čtení vstupu dokud uživatel nezadá "konec"
string vstup = "";
while (vstup != "konec")
{
    Console.Write("Zadej text (nebo 'konec'): ");
    vstup = Console.ReadLine();
}
```

## Cyklus `do-while`

- podmínka se kontroluje **až po** prvním průchodu
- tělo cyklu se vždy vykoná **alespoň jednou**
- vhodný pro vstup od uživatele (opakuj, dokud nezadá správně)

```csharp
int cislo;
do
{
    Console.Write("Zadej číslo > 0: ");
    cislo = int.Parse(Console.ReadLine());
} while (cislo <= 0);

Console.WriteLine("Zadal jsi: " + cislo);
```

## Cyklus `foreach`

- slouží k procházení **pole nebo kolekce** prvek po prvku
- jednodušší než `for` – bez potřeby indexu
- nelze měnit hodnotu prvků přímo přes proměnnou cyklu

```csharp
List<string> jmena = new List<string> { "Pepa", "Alena", "Karel" };

foreach (string jmeno in jmena)
{
    Console.WriteLine("Ahoj, " + jmeno + "!");
}

// Funguje i pro pole
int[] cisla = { 10, 20, 30 };
foreach (int c in cisla)
{
    Console.WriteLine(c);
}
```

## Porovnání cyklů

| **Cyklus** | **Kdy použít** | **Min. průchodů** |
| --- | --- | --- |
| `for` | Znám počet opakování předem | 0 |
| `while` | Nevím kolikrát, podmínka na začátku | 0 |
| `do-while` | Alespoň jeden průchod nutný | **1** |
| `foreach` | Procházení kolekce bez indexu | 0 |

---

## Algoritmus pro nalezení největšího čísla v seznamu celých čísel

Klasický cyklus (Nejrychlejší výkon)

Tento způsob je nejlepší, pokud jde o čistý výkon 

```csharp
List<int> cisla = new List<int> { 3, 15, 8, 20, 2 };

// Předpokládáme, že první číslo je největší
int max = cisla[0]; 

foreach (int cislo in cisla)
{
    if (cislo > max)
    {
        max = cislo; // Našli jsme nové největší číslo
    }
}

Console.WriteLine($"Největší číslo je: {max}");
```

## Metoda Max()

Tento způsob je v praxi nejpoužívanější 

```csharp
using System.Linq;

List<int> cisla = new List<int> { 3, 15, 8, 20, 2 };
int max = cisla.Max(); 

Console.WriteLine(max);
```

## Statické metody

Statické metody (označené klíčovým slovem `static`) představují v C# a v celém konceptu OOP metody, které **patří samotné třídě**, nikoliv její konkrétní objekt.

Statická metoda je spojena s definicí typu. K jejímu vyvolání nepotřebujete operátor `new` ani instanci třídy. Volá se přímo přes název třídy.

- **Instance (Běžná):** `mojeAuto.Jed();` (Každé auto jede svou rychlostí).
- **Statická:** `Math.Sqrt(16);` (Výpočet odmocniny je univerzální algoritmus, nepotřebuje "vlastnit" data konkrétního objektu).

### Omezení přístupu (Statický kontext)

Toto je nejdůležitější pravidlo: **Statická metoda nemá přístup k instančním (nestatickým) proměnným a metodám.**

- Nemůže používat klíčové slovo `this`, protože neexistuje žádná konkrétní instance, na kterou by odkazovalo.
- Může přistupovat pouze k jiným **statickým** členům třídy.
- Nestatická metoda naopak **může** volat statické metody i přistupovat ke statickým polím.

```csharp
public class Vypocet
{
    private int _cisloInstance = 10;
    private static int _statickeCislo = 5;

    public static void MojeStatickaMetoda()
    {
        // Console.WriteLine(_cisloInstance); // CHYBA: statická metoda nevidí instanční data
        Console.WriteLine(_statickeCislo);    // OK: statická metoda vidí statická data
    }
}
```

### Vlastní utility třída se statickými metodami

- v praxi se statické metody seskupují do **pomocných (utility) tříd**
- třída obsahuje jen statické metody, není třeba vytvářet její instanci
- voláme přímo přes název třídy: `MatHelper.Odmocnina(16)`

```csharp
public class MatHelper
{
    // Statická metoda bez návratné hodnoty
    public static void VypisPozdrav(string jmeno)
    {
        Console.WriteLine("Ahoj, " + jmeno + "!");
    }

    // Statická metoda s návratným typem
    public static double Odmocnina(double cislo)
    {
        return Math.Sqrt(cislo);
    }

    // Statická metoda používající jiné statické metody
    public static bool JePrvocislo(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
}

// Použití – BEZ vytváření objektu:
MatHelper.VypisPozdrav("Pepo");          // Ahoj, Pepo!
Console.WriteLine(MatHelper.Odmocnina(16)); // 4
Console.WriteLine(MatHelper.JePrvocislo(7)); // True
```