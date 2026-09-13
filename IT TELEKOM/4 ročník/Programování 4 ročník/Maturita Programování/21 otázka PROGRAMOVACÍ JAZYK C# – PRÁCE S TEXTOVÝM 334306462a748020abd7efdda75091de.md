# 21. otázka PROGRAMOVACÍ JAZYK C# – PRÁCE S TEXTOVÝM SOUBOREM, VÝJIMKY

---

- jmenný prostor System.IO, třídy StreamReader a StreamWriter
- algoritmy pro čtení z textového souboru a pro zápis do textového souboru
- aktivní a pasivní ošetřování běhových chyb programu
- použití výjimek při práci se soubory
- algoritmus dělení

---

# jmenný prostor [System.IO](http://System.IO), třídy StreamReader a StreamWriter

## Jmenný prostor [System.IO](http://System.IO)

<aside>
📌

***System.I**nput/**O**utput*

</aside>

<aside>
🇨🇿

systémový Vstup / Výstup

</aside>

- **jmenný prostor** (namespace) obsahující třídy pro práci se soubory, adresáři a datovými proudy
- musíme ho přidat na začátek souboru pomocí direktivy `using`

```csharp
using System.IO;
```

**Přehled hlavních tříd v [System.IO](http://System.IO):**

| **Třída** | **Co dělá** |
| --- | --- |
| `StreamReader` | Čtení textových dat ze souboru |
| `StreamWriter` | Zápis textových dat do souboru |
| `File` | Statické metody pro práci se soubory (čtení, zápis, kopírování, mazání) |
| `FileInfo` | Informace o souboru (velikost, datum, atributy) – instanční metody |
| `Directory` | Statické metody pro práci s adresáři |
| `FileStream` | Práce se souborem jako s datovým proudem (i binární data) |
| `Path` | Manipulace s cestami k souborům (přípona, složka, název) |

---

## StreamReader – čtení z textového souboru

- slouží k **čtení textových dat** ze souboru nebo jiného datového proudu
- automaticky zpracovává kódování znaků (výchozí: **UTF-8**)
- po skončení práce je nutné objekt **uzavřít** – nejlépe pomocí `using` bloku

**Hlavní metody:**

| **Metoda** | **Popis** |
| --- | --- |
| `ReadLine()` | Přečte **jeden řádek** a vrátí ho jako `string` (nebo `null` na konci souboru) |
| `ReadToEnd()` | Přečte **celý zbytek souboru** jako jeden `string` |
| `Read()` | Přečte **jeden znak** (vrací `int`, –1 = konec souboru) |
| `EndOfStream` | Vlastnost (`bool`) – `true` pokud jsme na konci souboru |
| `Close()` | Uzavře proud a uvolní zdroje (nahrazeno `using` blokem) |

## StreamWriter – zápis do textového souboru

- slouží k **zápisu textových dat** do souboru nebo jiného datového proudu
- standardně **přepisuje** existující soubor; pro přidávání na konec slouží parametr `append: true`
- po skončení práce je nutné **uzavřít nebo vyprázdnit** proud (`Flush`, `Close`, nebo `using`)

**Hlavní metody:**

| **Metoda** | **Popis** |
| --- | --- |
| `Write(text)` | Zapíše text **bez** nového řádku na konci |
| `WriteLine(text)` | Zapíše text **a přidá** nový řádek (`\n`) |
| `Flush()` | Vyprázdní buffer – zapíše čekající data na disk |
| `Close()` | Uzavře proud (automaticky volá `Flush`) |

**Režimy otevření souboru:**

| **Konstruktor** | **Chování** |
| --- | --- |
| `new StreamWriter("soubor.txt")` | Přepíše celý obsah souboru (výchozí) |
| `new StreamWriter("soubor.txt", append: true)` | Přidává text na **konec** existujícího souboru |

---

# algoritmy pro čtení z textového souboru a pro zápis do textového souboru

## Čtení z textového souboru

### Pomocí StreamReader – řádek po řádku

- vhodné pro **velké soubory** – čte postupně, neplní celou paměť
- `using` blok zajistí **automatické uzavření** StreamReaderu i v případě chyby

```csharp
using System.IO;

string cesta = "vstup.txt";

using (StreamReader reader = new StreamReader(cesta))
{
    string radek;
    while ((radek = reader.ReadLine()) != null)
    {
        Console.WriteLine(radek);
    }
}
// StreamReader je po skončení using bloku automaticky uzavřen
```

### Pomocí StreamReader – celý soubor najednou

- vhodné pro **malé soubory**
- celý obsah je uložen do jednoho stringu

```csharp
using (StreamReader reader = new StreamReader("vstup.txt"))
{
    string obsah = reader.ReadToEnd();
    Console.WriteLine(obsah);
}
```

### Pomocí File.ReadAllText

- nejjednodušší způsob – jedním voláním načteme **celý soubor** do stringu
- nevhodné pro velmi velké soubory (celý obsah v paměti)

```csharp
string obsah = File.ReadAllText("vstup.txt");
Console.WriteLine(obsah);
```

### Pomocí File.ReadAllLines

- načte všechny řádky do **pole řetězců** (`string[]`)
- snadno přistupujeme k jednotlivým řádkům přes index

```csharp
string[] radky = File.ReadAllLines("vstup.txt");

foreach (string radek in radky)
{
    Console.WriteLine(radek);
}

// Přístup k prvnímu řádku:
Console.WriteLine(radky[0]);
```

> `File.ReadAllLines` načte **celý soubor** do paměti – nevhodné pro velmi velké soubory. Pro velké soubory použij `StreamReader` s `ReadLine()`.
> 

---

## Zápis do textového souboru

### Pomocí StreamWriter – přepisování

- přepíše celý obsah souboru
- pokud soubor neexistuje, **vytvoří ho**

```csharp
using (StreamWriter writer = new StreamWriter("vystup.txt"))
{
    writer.WriteLine("První řádek");
    writer.WriteLine("Druhý řádek");
    writer.Write("Bez nového řádku");
}
```

### Pomocí StreamWriter – přidávání (append)

- přidá text na **konec** souboru bez mazání existujícího obsahu

```csharp
using (StreamWriter writer = new StreamWriter("log.txt", append: true))
{
    writer.WriteLine("Nový záznam: " + DateTime.Now);
}
```

### Pomocí File.WriteAllText

- **přepíše** celý soubor zadaným textem (nebo vytvoří nový)
- nejjednodušší způsob zápisu

```csharp
string text = "Ahoj světe!\nDruhý řádek.";
File.WriteAllText("vystup.txt", text);
```

### Pomocí File.AppendAllText

- **přidá** text na konec souboru
- soubor vytvoří, pokud neexistuje

```csharp
File.AppendAllText("log.txt", "Nový záznam\n");
```

### Pomocí File.WriteAllLines

- zapíše **pole nebo seznam řádků** do souboru

```csharp
string[] radky = { "Řádek 1", "Řádek 2", "Řádek 3" };
File.WriteAllLines("vystup.txt", radky);
```

---

# aktivní a pasivní ošetřování běhových chyb programu

## Aktivní ošetřování

- programátor **předvídá** možné chyby a aktivně je zachytává a řeší
- chyba je zachycena, program **nepádá**, uživatel dostane srozumitelnou zprávu
- nástroje aktivního ošetřování:
    - **try-catch** bloky – zachytí výjimku za běhu
    - **validace vstupů** – kontrola dat před jejich zpracováním (např. `int.TryParse`)
    - **podmínky před operací** – např. `File.Exists()` před čtením souboru
    - **logování chyb** – zápis chyby do logu pro pozdější analýzu

```csharp
// Validace před operací
if (!File.Exists("vstup.txt"))
{
    Console.WriteLine("Soubor neexistuje!");
    return;
}

// TryParse místo Parse – nevyhodí výjimku
string vstup = Console.ReadLine();
if (int.TryParse(vstup, out int cislo))
{
    Console.WriteLine("Zadal jsi: " + cislo);
}
else
{
    Console.WriteLine("Neplatné číslo.");
}
```

## Pasivní ošetřování

- program **nekontroluje chyby** aktivně – spoléhá na to, že chyba se prostě nestane, nebo ji zachytí OS
- při výskytu chyby program **spadne** s neošetřenou výjimkou (runtime error)
- používalo se v jednoduchých nebo nízko úrovňových programech

```csharp
// Pasivní přístup – žádné ošetření
string obsah = File.ReadAllText("vstup.txt");
// Pokud soubor neexistuje → program spadne
// s výjimkou FileNotFoundException

int cislo = int.Parse(Console.ReadLine());
// Pokud uživatel zadá "abc" → program spadne
// s výjimkou FormatException
```

**Porovnání:**

|  | **Aktivní** | **Pasivní** |
| --- | --- | --- |
| Stabilita | Vysoká | Nízká |
| Uživatelský zážitek | Srozumitelná chybová hlášení | Pád programu |
| Složitost kódu | Vyšší | Nižší |
| Použití | Produkční aplikace | Prototypy, experimenty |

---

# použití výjimek při práci se soubory

## Výjimky (Exceptions)

- **výjimka** = chyba, která nastane za běhu programu (runtime error)
- pokud není zachycena, program se **ukončí** s chybovou zprávou
- zachytáváme je pomocí bloku **try-catch-finally**

### Struktura try-catch-finally

```csharp
try
{
    // Kód, který může vyvolat výjimku
}
catch (TypVýjimky ex)
{
    // Reakce na konkrétní typ chyby
    Console.WriteLine("Chyba: " + ex.Message);
}
finally
{
    // Tento blok se vykoná VŽDY – ať chyba nastala nebo ne
    // Vhodné pro: uzavření souboru, uvolnění zdrojů
}
```

> `finally` je volitelný, ale **doporučený** při práci se soubory – zajistí uzavření souboru i v případě chyby. Alternativou je `using` blok, který dělá totéž automaticky.
> 

---

### Nejčastější výjimky při práci se soubory

| **Výjimka** | **Kdy nastane** |
| --- | --- |
| `FileNotFoundException` | Soubor na zadané cestě neexistuje |
| `DirectoryNotFoundException` | Adresář v cestě neexistuje |
| `UnauthorizedAccessException` | Nemáme oprávnění číst nebo zapisovat soubor |
| `IOException` | Obecná vstupně-výstupní chyba (disk plný, soubor zamčený...) |
| `FormatException` | Data v souboru mají špatný formát (např. místo čísla text) |
| `OutOfMemoryException` | Soubor je příliš velký, nestačí paměť |

---

### Vícenásobné catch bloky

- zachycujeme od **nejkonkrétnější** výjimky po **nejobecnější** (`Exception`)
- pořadí je důležité – catch bloky se vyhodnocují shora dolů

```csharp
try
{
    string obsah = File.ReadAllText("vstup.txt");
    int cislo = int.Parse(obsah.Trim());
    Console.WriteLine("Číslo: " + cislo);
}
catch (FileNotFoundException)
{
    Console.WriteLine("Soubor nebyl nalezen.");
}
catch (FormatException)
{
    Console.WriteLine("Obsah souboru není platné číslo.");
}
catch (UnauthorizedAccessException)
{
    Console.WriteLine("Přístup odepřen – nemáme oprávnění.");
}
catch (IOException ex)
{
    Console.WriteLine("Chyba při práci se souborem: " + ex.Message);
}
catch (Exception ex)
{
    // Zachytí cokoliv ostatního
    Console.WriteLine("Neočekávaná chyba: " + ex.Message);
}
finally
{
    Console.WriteLine("Operace dokončena.");
}
```

---

### Blok `using` jako alternativa `finally`

- objekty implementující **IDisposable** (StreamReader, StreamWriter...) lze obalit `using` blokem
- `using` automaticky zavolá `Dispose()` (= uzavření souboru) i v případě výjimky
- čistší a bezpečnější než ruční `try-finally`

```csharp
// S using – automatické uzavření
using (StreamReader reader = new StreamReader("vstup.txt"))
{
    Console.WriteLine(reader.ReadToEnd());
}
// reader.Dispose() voláno automaticky i při výjimce
```

---

# algoritmus dělení

## Algoritmus dělení – čtení ze souboru, výpočet, zápis výsledku

- komplexní příklad spojující: čtení souboru, zápis souboru, výjimky, ošetření dělení nulou

**Vstupní soubor `vstup.txt`:**

```
20
4
```

**Program:**

```csharp
using System;
using System.IO;

class AlgortimusDivision
{
    static void Main()
    {
        string vstupniSoubor = "vstup.txt";
        string vystupniSoubor = "vystup.txt";

        StreamReader reader = null;
        StreamWriter writer = null;

        try
        {
            // 1. Otevření vstupního souboru
            reader = new StreamReader(vstupniSoubor);

            // 2. Načtení a parsování čísel
            string radek1 = reader.ReadLine();
            string radek2 = reader.ReadLine();

            int delenec = int.Parse(radek1);
            int delitel  = int.Parse(radek2);

            // 3. Kontrola dělení nulou
            if (delitel == 0)
            {
                throw new DivideByZeroException("Dělitel nesmí být nula!");
            }

            // 4. Výpočet
            int podil   = delenec / delitel;
            int zbytek  = delenec % delitel;

            // 5. Zápis výsledku do výstupního souboru
            writer = new StreamWriter(vystupniSoubor);
            writer.WriteLine($"Dělenec:  {delenec}");
            writer.WriteLine($"Dělitel:  {delitel}");
            writer.WriteLine($"Podíl:    {podil}");
            writer.WriteLine($"Zbytek:   {zbytek}");

            Console.WriteLine("Výsledek byl zapsán do souboru.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Chyba: soubor '{vstupniSoubor}' nebyl nalezen.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Chyba: soubor neobsahuje platná celá čísla.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Chyba: " + ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine("I/O chyba: " + ex.Message);
        }
        finally
        {
            // 6. Uzavření souborů – vždy, i při chybě
            if (reader != null) reader.Close();
            if (writer != null) writer.Close();
            Console.WriteLine("Soubory uzavřeny.");
        }
    }
}
```

**Výstupní soubor `vystup.txt` (pro vstup 20 a 4):**

```
Dělenec:  20
Dělitel:  4
Podíl:    5
Zbytek:   0
```

**Tok algoritmu:**

| **Krok** | **Co se děje** | **Možná výjimka** |
| --- | --- | --- |
| 1. Otevření souboru | `new StreamReader(cesta)` | `FileNotFoundException` |
| 2. Načtení řádků | `ReadLine()` pro každé číslo | `IOException` |
| 3. Parsování | `int.Parse(radek)` | `FormatException` |
| 4. Kontrola dělitele | Pokud `delitel == 0` → `throw` | `DivideByZeroException` |
| 5. Výpočet | `podil = delenec / delitel` | — |
| 6. Zápis výsledku | `StreamWriter.WriteLine()` | `IOException` |
| 7. Uzavření souborů | `finally` blok → `Close()` | — |