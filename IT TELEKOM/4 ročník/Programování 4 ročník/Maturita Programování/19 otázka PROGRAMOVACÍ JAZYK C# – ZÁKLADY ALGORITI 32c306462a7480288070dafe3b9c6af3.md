# 19. otázka PROGRAMOVACÍ JAZYK C# – ZÁKLADY ALGORITIMIZACE A OOP

---

- console Application, třída Program, vstupy z klávesnice, výstupy na monitor
- datové typy, deklarace proměnných, konverze mezi datovými typy
- typy větvení, podmínky, kombinované podmínky
- pojmy OOP: zapouzdření, dědičnost, polymorfismus, třída, objekt, konstruktor
- nadefinování třídy Žák a její použití

---

# Console Application, třída Program, vstupy z klávesnice, výstupy na monitor

Console Application je projekt který se spustí v CMD. Jeho účelem je vykonat sadu zadaných instrukcí v kódu programu. 

![image.png](19%20ot%C3%A1zka%20PROGRAMOVAC%C3%8D%20JAZYK%20C#%20%E2%80%93%20Z%C3%81KLADY%20ALGORITI/image.png)

## Třída program

Třída program, z důvodu že C# je těžce objektově orientovaný jazyk musí být veškerý kód v třídách. Třída program je hlavní třída každého programu. 

```csharp
using System;

namespace MojeAplikace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tady to všechno začíná!");
        }
    }
}
```

## Vstup z klávesnice

Vstup slouží k získání dat od uživatel.

*Console.ReadLine*

Přečte celý řádek

```csharp
Console.ReadLine();
```

*Conole.Read*

Přečte řetězec a vezme první znak

```csharp
Console.Read();
```

# Datové typy, deklarace proměnných, konverze mezi datovými typy

Datové typy dělíme na jednoduché a složené (referenční )

## Jednoduché datové typy

Tyto typy obvykle žijí v rychlé paměti (na zásobníku/stacku). Když je zkopíruješ, vytvoří se jejich nezávislá kopie.
****

Intigers

| **Typ v C#** | **.NET Typ** | **Velikost v paměti** | **Rozsah** |
| --- | --- | --- | --- |
| **`sbyte`** | `SByte` | 8 bitů | -128 až 127 |
| **`byte`** | `Byte` | 8 bitů | 0 až 255 |
| **`short`** | `Int16` | 16 bitů | -32 768 až 32 767 |
| **`ushort`** | `UInt16` | 16 bitů | 0 až 65 535 |
| **`int`** | `Int32` | 32 bitů | cca -2,14 miliardy až +2,14 miliardy **(Nejpoužívanější)** |
| **`uint`** | `UInt32` | 32 bitů | 0 až cca 4,29 miliardy |
| **`long`** | `Int64` | 64 bitů | cca -9 trilionů až +9 trilionů |
| **`ulong`** | `UInt64` | 64 bitů | 0 až cca 18 trilionů |

Desetinné typy

| **Typ v C#** | **.NET Typ** | **Velikost** | **Přesnost** | **Hlavní využití** |
| --- | --- | --- | --- | --- |
| **`float`** | `Single` | 32 bitů | 6–9 cifer | 3D grafika, hry, fyzikální simulace (rychlý) |
| **`double`** | `Double` | 64 bitů | 15–17 cifer | Výchozí desetinný typ pro matematické výpočty |
| **`decimal`** | `Decimal` | 128 bitů | 28–29 cifer | **Finanční výpočty a účetnictví** (žádné zaokrouhlovací chyby) |

**Bool** (`Boolean`): Logická hodnota. Nabývá pouze stavů `true`  nebo `false`.

**Char** (`Char`): Jeden samostatný znak v kódování Unicode (např. `'A'`, `'ž'`, `'@'`). Zapisuje se výhradně do jednoduchých uvozovek.

**Struct** (Struktury): Uživatelsky definované menší kontejnery na data (např. souřadnice `X` a `Y`).

**Enum** (Výčtové typy): Množina pojmenovaných konstant (např. `enum Dny { Pondeli, Utery, Streda }`).

**Nullable typy** (zápis např. `int?` nebo `bool?`): Speciální obálka, která umožní hodnotovému typu obsahovat i prázdnou hodnotu `null`.

## Složené datové typy (referenční typy)

**String** (`String`): Textový řetězec (např. `"Ahoj, jak se máš?"`). Zapisuje se do dvojitých uvozovek. V C# je neměnný (*immutable*) – jakákoliv úprava textu vytvoří v paměti nový řetězec.

**Object** (`Object`): Praotec všech datových typů. Všechny typy v .NET (včetně čísel) z něj přímo nebo nepřímo dědí. Můžeš do něj uložit úplně cokoliv.

**Class** (Třídy): Základ objektově orientovaného programování. Tvoje vlastní definované objekty a komponenty.

**Pole (Arrays)**: Kolekce prvků stejného typu (např. `int[]` nebo `string[]`). I když pole obsahuje hodnotové typy, samotný kontejner (pole) je v paměti vždy referenčním typem.

---

## Konverze mezi datovými typy

### Implicitní konverze *(widening)*

- probíhá **automaticky** – kompilátor ji udělá sám
- převod z **menšího** typu do **většího** (bez ztráty dat)
- směr: `byte → short → int → long → float → double`

```csharp
int cele = 42;
double desetinne = cele; // automaticky: 42 → 42.0
```

### Explicitní konverze *(casting)*

- musíme ji **napsat ručně** pomocí cast operátoru `(typ)`
- převod z **většího** do **menšího** → může dojít ke **ztrátě dat**

```csharp
double pi = 3.14159;
int zaokrouhleno = (int) pi; // → 3 (ořízne desetiny!)
```

### Konverze pomocí Convert

- třída `Convert` nabízí bezpečné metody pro převody mezi typy
- při nekompatibilním vstupu vyhodí výjimku

```csharp
string text = "42";
int cislo = Convert.ToInt32(text);    // → 42
double d  = Convert.ToDouble("3.14"); // → 3.14
string s  = Convert.ToString(100);    // → "100"
```

### Parsování *(Parsing)*

- slouží k převodu **textového řetězce** na číslo nebo jiný typ
- `int.TryParse` je bezpečnější – nevyhodí výjimku, vrátí `bool`

```csharp
// Parse – vyhodí výjimku při chybě
int a = int.Parse("42");      // → 42
double b = double.Parse("3.14"); // → 3.14

// TryParse – bezpečná varianta
string vstup = Console.ReadLine();
if (int.TryParse(vstup, out int vysledek))
{
    Console.WriteLine("Zadal jsi: " + vysledek);
}
else
{
    Console.WriteLine("Neplatné číslo.");
}
```

---

## Typy větvení, podmínky, kombinované podmínky

větvení můžeme dělit na, if else, elseif a switch.

if else na podmínce.

```csharp
if(podmínka)
{
	něco se vykoná;
}
else
{
	kod se vyvede po opaku/rozdílu podmínky;
}
```

else if slouží pokud potřebujeme mít podmínek více.

```csharp
if(podmínka)
{
	něco se vykoná;
}
else if (pokud první podmínka není pravda je nařadě druhá podmínka)
{
	něco se vykoná;
}
else
{
	kod se vyvede po opaku/rozdílu oboud podmínek;
}

```

switch 

Na rozdíl od else if se switch píše mnohem jednodušeji a nemusí se přidávat další podmínka neustále.

```csharp
string barva = "modrá";

switch (barva)
{
    case "červená":
        Console.WriteLine("Zastavte! Svítí červená.");
        break;
    case "žlutá":
        Console.WriteLine("Připravte se, brzy pojedeme.");
        break;
    case "zelená":
        Console.WriteLine("Můžete jet, máte volno.");
        break;
    default:
        Console.WriteLine("Tuhle barvu na semaforu neznám.");
        break;
}
```

### Podmínky a kombinované podmínky

- podmínka je výraz, který se vyhodnotí jako `true` nebo `false`
- kombinované podmínky spojují více jednoduchých podmínek pomocí **logických operátorů**

**Relační operátory:**

| **Operátor** | **Význam** |
| --- | --- |
| `==` | rovná se |
| `!=` | nerovná se |
| `>` | větší než |
| `<` | menší než |
| `>=` | větší nebo rovno |
| `<=` | menší nebo rovno |

**Logické operátory:**

| **Operátor** | **Název** | **Pravdivý pokud...** |
| --- | --- | --- |
| `&&` | AND | obě podmínky platí |
| `||` | OR | alespoň jedna podmínka platí |
| `!` | NOT (negace) | podmínka NEplatí |

```csharp
int vek = 20;
bool maRidic = true;

// AND – obě podmínky musí platit
if (vek >= 18 && maRidic)
    Console.WriteLine("Může řídit.");

// OR – stačí jedna
if (vek < 18 || !maRidic)
    Console.WriteLine("Nemůže řídit.");
```

---

## Pojmy OOP: zapouzdření, dědičnost, polymorfismus, třída, objekt, konstruktor

### **Zapouzdření (Encapsulation)**

Princip, který říká, že data uvnitř objektu by měla být skrytá a přístupná jen přes definované rozhraní. Chráníme tím data před nechtěnou změnou zvenčí.

- *V praxi:* Používání klíčových slov `private` a `public`. Nechceš, aby ti kdokoli sahal přímo na vnitřnosti motoru, dáš mu k dispozici jen pedály a volant.

```csharp
public class BankovniUcet
{
    // Private field - nikdo zvenčí na něj nemůže přímo sahat
    private decimal _zustatek;

    public void VlozitPeníze(decimal castka)
    {
        if (castka > 0) 
            _zustatek += castka;
    }

    // Vlastnost pro čtení (vnější svět se dozví částku, ale nezmění ji jen tak)
    public decimal Zustatek => _zustatek;
}
```

### **Dědičnost (Inheritance)**

Umožňuje vytvořit novou třídu na základě třídy existující. Nová třída "zdědí" všechny vlastnosti a schopnosti té staré a může přidat něco navíc.

- *Příklad:* Máme třídu `Zvíře`. Od ní oddědíme třídu `Pes`. Pes umí vše co zvíře (dýchat, jíst), ale navíc umí štěkat.

```csharp
public class Zvire
{
    public string Jmeno;
    public void Jist() => Console.WriteLine("Zvíře jí...");
}

// Pes dědí ze Zvířete pomocí dvojtečky
public class Pes : Zvire
{
    public void Stekat() => Console.WriteLine("Haf! Haf!");
}

// Použití:
Pes alik = new Pes();
alik.Jmeno = "Alík"; // Zděděno
alik.Jist();         // Zděděno
alik.Stekat();       // Vlastní metoda psa
```

### **Polymorfismus (Polymorphism)**

Doslova "mnohoforemnost". Umožňuje používat různé objekty jednotným způsobem, i když se každý chová trochu jinak.

- *Příklad:* Máš seznam různých zvířat (pes, kočka, kráva) a všem řekneš "vydej zvuk". Pes štěkne, kočka mňoukne. Voláš stejný příkaz, ale výsledek závisí na typu objektu.

```csharp
public abstract class ZvireBase
{
    public abstract void VydatZvuk(); // Definujeme, ŽE zvíře zvučí
}

public class Pes : ZvireBase
{
    public override void VydatZvuk() => Console.WriteLine("Haf!");
}

public class Kocka : ZvireBase
{
    public override void VydatZvuk() => Console.WriteLine("Mňau!");
}

// Použití:
List<ZvireBase> maZvirata = new List<ZvireBase> { new Pes(), new Kocka() };

foreach (var zvire in maZvirata)
{
    zvire.VydatZvuk(); // Jednou to vypíše Haf, podruhé Mňau
}
```

### Třída (Class)

- **šablona / vzor** – popisuje, jak budou objekty vypadat a co umí
- definuje **atributy** (proměnné / pole) a **metody** (funkce)
- klíčové slovo `class`; název třídy začíná velkým písmenem *(PascalCase)*
- samotná třída není objekt – je to jen předpis, objekt se vytváří pomocí `new`

```csharp
public class Auto
{
    public string Znacka;  // atribut
    public int RokVyroby;  // atribut

    public void Zapni()    // metoda
    {
        Console.WriteLine(znacka + " nastartovala!");
    }
}
```

### Objekt (Object / Instance)

- **konkrétní instance třídy** – skutečná entita v paměti vytvořená podle šablony
- vytváříme pomocí klíčového slova `new`
- každý objekt má **vlastní hodnoty** atributů (i když pochází ze stejné třídy)
- zatímco třída je "plán", objekt je "výrobek" podle tohoto plánu

```csharp
Auto mojeAuto = new Auto();       // vytvoření objektu
mojeAuto.Znacka = "Škoda";        // nastavení atributu
mojeAuto.RokVyroby = 2020;
mojeAuto.Zapni();                  // volání metody

Auto jineAuto = new Auto();       // druhý objekt – jiné hodnoty
jineAuto.Znacka = "BMW";
```

### Konstruktor (Constructor)

- **speciální metoda** třídy, která se **automaticky volá** při vytváření objektu (`new`)
- slouží k **inicializaci atributů** objektu hned při jeho vzniku
- má **stejný název jako třída** a **nemá návratový typ** (ani `void`)
- lze definovat více konstruktorů s různými parametry (**přetížení konstruktoru**)
- pokud žádný konstruktor nedefinujeme, C# vytvoří **výchozí bezparametrický** automaticky

```csharp
public class Auto
{
    public string Znacka;
    public int RokVyroby;

    // Bezparametrický konstruktor
    public Auto()
    {
        Znacka = "Neznámá";
        RokVyroby = 2000;
    }

    // Parametrický konstruktor – přetížení
    public Auto(string znacka, int rok)
    {
        Znacka = znacka;
        RokVyroby = rok;
    }
}

// Použití:
Auto a1 = new Auto();                  // volá bezparametrický
Auto a2 = new Auto("Škoda", 2022);     // volá parametrický
Console.WriteLine(a2.Znacka);          // → Škoda
```

---

# nadefinování třídy Žák a její použití

## Třída Žák – kompletní příklad

```csharp
public class Zak
{
    // Atributy – private (zapouzdření)
    private string jmeno;
    private int vek;
    private double prumer; // průměrná známka

    // Bezparametrický konstruktor
    public Zak()
    {
        jmeno  = "Neznámý";
        vek    = 0;
        prumer = 0.0;
    }

    // Parametrický konstruktor
    public Zak(string jmeno, int vek, double prumer)
    {
        this.jmeno  = jmeno;
        this.vek    = vek;
        this.prumer = prumer;
    }

    // Gettery
    public string GetJmeno()  { return jmeno; }
    public int    GetVek()    { return vek; }
    public double GetPrumer() { return prumer; }

    // Settery s validací
    public void SetJmeno(string j)  { jmeno = j; }
    public void SetVek(int v)       { if (v >= 0) vek = v; }
    public void SetPrumer(double p) { if (p >= 1.0 && p <= 5.0) prumer = p; }

    // Metoda s návratovou hodnotou
    public string ZhodnotProspech()
    {
        if (prumer <= 1.5) return "Výborný prospěch";
        if (prumer <= 2.5) return "Dobrý prospěch";
        if (prumer <= 3.5) return "Průměrný prospěch";
        return "Nedostatečný prospěch";
    }

    // Metoda vypisující informace o žákovi
    public void VypisInfo()
    {
        Console.WriteLine($"Jméno: {jmeno}, Věk: {vek}, Průměr: {prumer:F1} – {ZhodnotProspech()}");
    }
}
```

## Použití třídy Žák v main

```csharp
class Program
{
    static void Main(string[] args)
    {
        // Vytvoření objektu – bezparametrický konstruktor
        Zak neznamyZak = new Zak();
        neznamyZak.VypisInfo();
        // → Jméno: Neznámý, Věk: 0, Průměr: 0,0 – Nedostatečný prospěch

        // Vytvoření objektu – parametrický konstruktor
        Zak jan = new Zak("Jan Novák", 18, 1.8);
        jan.VypisInfo();
        // → Jméno: Jan Novák, Věk: 18, Průměr: 1,8 – Dobrý prospěch

        // Změna hodnot přes setter
        jan.SetPrumer(1.2);
        Console.WriteLine(jan.ZhodnotProspech());
        // → Výborný prospěch

        // Více objektů stejné třídy – každý má vlastní data
        Zak petra = new Zak("Petra Svobodová", 17, 2.4);
        petra.VypisInfo();
        // → Jméno: Petra Svobodová, Věk: 17, Průměr: 2,4 – Dobrý prospěch

        // Práce se seznamem žáků (dědičnost + polymorfismus)
        List<Zak> trida = new List<Zak> { jan, petra };
        Console.WriteLine("\n--- Seznam třídy ---");
        foreach (Zak z in trida)
        {
            z.VypisInfo();
        }
    }
}
```