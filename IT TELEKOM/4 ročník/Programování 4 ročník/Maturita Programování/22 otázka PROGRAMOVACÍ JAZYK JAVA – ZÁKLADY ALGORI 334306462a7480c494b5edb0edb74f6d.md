# 22. otázka PROGRAMOVACÍ JAZYK JAVA – ZÁKLADY ALGORITMIZACE

---

- vstupy z klávesnice, výstupy na monitor
- datové typy, deklarace proměnných, konverze mezi datovými typy
- typy větvení, podmínky, ukázky na příkladech
- typy cyklů
- ukázky na příkladech

---

# vstupy z klávesnice, výstupy na monitor

## Vstup z klávesnice – Scanner

- pro čtení vstupu se používá třída **Scanner** ze standardní knihovny `java.util`
- nejprve ji musíme **importovat** a vytvořit její objekt napojený na `System.in`
- po skončení práce se Scanner uzavírá metodou `scanner.close()`

```java
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Zadej jméno: ");
        String jmeno = scanner.nextLine();

        System.out.print("Zadej věk: ");
        int vek = scanner.nextInt();

        System.out.println("Ahoj " + jmeno + ", je ti " + vek + " let.");
        scanner.close();
    }
}
```

**Nejčastěji používané metody Scanneru:**

| **Metoda** | **Načte** |
| --- | --- |
| `nextLine()` | Celý řádek jako `String` |
| `next()` | Jedno slovo (po mezeru) jako `String` |
| `nextInt()` | Celé číslo jako `int` |
| `nextDouble()` | Desetinné číslo jako `double` |
| `nextBoolean()` | Logickou hodnotu `true`/`false` |

> Po `nextInt()` nebo `nextDouble()` zůstane v bufferu nový řádek – před dalším `nextLine()` je nutné zavolat `scanner.nextLine()` navíc pro vyčištění bufferu.
> 

## Výstup na monitor – System.out

- pro výstup se používá třída **System** a její statický atribut `out`
- tři hlavní metody:

```java
// Vypíše text BEZ zalomení řádku
System.out.print("Ahoj ");
System.out.print("světe");
// → Ahoj světe

// Vypíše text A přidá nový řádek
System.out.println("Ahoj světe");
// → Ahoj světe
//   (kurzor přeskočí na další řádek)

// Formátovaný výstup (jako printf v C)
double cena = 149.9;
System.out.printf("Cena: %.2f Kč%n", cena);
// → Cena: 149,90 Kč
```

**Formátovací specifikátory pro `printf`:**

| **Specifikátor** | **Typ** |
| --- | --- |
| `%d` | Celé číslo (`int`, `long`) |
| `%f` | Desetinné číslo (`double`) |
| `%.2f` | Desetinné číslo na 2 místa |
| `%s` | Řetězec (`String`) |
| `%c` | Znak (`char`) |
| `%b` | Boolean (`true`/`false`) |
| `%n` | Nový řádek (přenositelná alternativa `\n`) |

---

# datové typy, deklarace proměnných, konverze mezi datovými typy

## Datové typy v Javě

Java rozlišuje dva druhy datových typů: **primitivní** a **referenční**.

### Primitivní datové typy

- uloženy přímo v paměti *(zásobník / stack)*
- kopírování vytvoří nezávislou kopii hodnoty
- název začíná **malým písmenem**

**Celá čísla:**

| **Typ** | **Velikost** | **Rozsah** |
| --- | --- | --- |
| `byte` | 8 bitů | –128 až 127 |
| `short` | 16 bitů | –32 768 až 32 767 |
| `int` | 32 bitů | –2,1 mld. až +2,1 mld. **(nejpoužívanější)** |
| `long` | 64 bitů | ±9,2 trilionů (přípona `L`) |

**Desetinná čísla:**

| **Typ** | **Velikost** | **Přesnost** |
| --- | --- | --- |
| `float` | 32 bitů | 6–7 cifer (přípona `f`) |
| `double` | 64 bitů | 15–17 cifer **(výchozí)** |

**Ostatní:**

- `char` – jeden znak v Unicode (apostrofy: `'A'`)
- `boolean` – logická hodnota: pouze `true` nebo `false`

### Referenční datové typy

- uloženy v paměti *(halda / heap)*, proměnná obsahuje pouze **odkaz (referenci)**
- kopírování zkopíruje jen odkaz, ne samotná data
- název začíná **velkým písmenem**

**Nejdůležitější referenční typy:**

- **`String`** – textový řetězec (neměnný / immutable)
    
    ```java
    String pozdrav = "Ahoj světe";
    ```
    
- **Pole** (`arrays`) – kolekce prvků stejného typu
    
    ```java
    int[] cisla = {1, 2, 3, 4, 5};
    ```
    
- **Třídy** – vlastní objekty (viz otázka 23)
- **Rozhraní** (`interface`)
- **Výčtové typy** (`enum`)

> `null` – speciální hodnota referenčního typu, která říká, že proměnná nikam neodkazuje. U primitivních typů `null` použít nelze.
> 

---

## Deklarace proměnných

```java
// Základní deklarace (bez hodnoty)
int vek;

// Deklarace s inicializací
int vek = 18;
String jmeno = "Jan";
double cena = 99.9;
boolean aktivni = true;
char pismeno = 'A';

// Více proměnných stejného typu najednou
int x = 5, y = 10, z = 0;
```

**Pravidla pro pojmenování proměnných:**

- musí začínat písmenem, `$` nebo `_` (ne číslicí)
- nesmí být klíčovým slovem Javy (`int`, `class`, `if`...)
- Java rozlišuje velká a malá písmena – `vek` a `Vek` jsou různé proměnné
- konvence: **camelCase** – `pocetStudentu`, `celkovaCena`

---

## Konverze mezi datovými typy

### Implicitní konverze *(widening)*

- probíhá **automaticky** – Java to udělá sama
- převod z **menšího** typu do **většího** (bez ztráty dat)
- směr: `byte → short → int → long → float → double`

```java
int cele = 42;
double desetinne = cele; // automaticky: 42 → 42.0
System.out.println(desetinne); // 42.0

long velke = 1_000_000L;
double d = velke; // int → long → double (bez ztráty)
```

### Explicitní konverze *(casting)*

- musíme ji **napsat ručně** pomocí cast operátoru `(typ)`
- převod z **většího** do **menšího** → může dojít ke **ztrátě dat** nebo zaokrouhlení
- u `String` se používají pomocné metody

```java
double pi = 3.14159;
int zaokrouhleno = (int) pi; // explicitní cast → 3 (ořízne desetiny!)

// String → int
String text = "42";
int cislo = Integer.parseInt(text); // → 42

// int → String
int hodnota = 100;
String s = String.valueOf(hodnota); // → "100"
// nebo:
String s2 = Integer.toString(hodnota);
```

---

# typy větvení, podmínky, ukázky na příkladech

## Podmínky

- podmínka je výraz, který vrací hodnotu **`boolean`** – tedy `true` nebo `false`
- v podmínce se používají **relační** a **logické** operátory

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

| **Operátor** | **Význam** | **Výsledek** |
| --- | --- | --- |
| `&&` | AND (a zároveň) | `true` jen pokud obě podmínky platí |
| `||` | OR (nebo) | `true` pokud alespoň jedna podmínka platí |
| `!` | NOT (negace) | obrátí hodnotu – `!true` = `false` |

> U Stringu nepoužívej `==` pro porovnání obsahu – použij `.equals()`: `jmeno.equals("Jan")`
> 

---

## Typy větvení

### if / if-else / if-else if

- základní větvení na základě **podmínky**
- `else` není povinný
- lze řetězit více podmínek pomocí `else if`

```java
int vek = 17;

// Jednoduché if
if (vek >= 18) {
    System.out.println("Dospělý");
}

// if-else
if (vek >= 18) {
    System.out.println("Dospělý");
} else {
    System.out.println("Nezletilý");
}

// if-else if-else
int znamka = 2;
if (znamka == 1) {
    System.out.println("Výborně");
} else if (znamka == 2) {
    System.out.println("Chvalitebně");
} else if (znamka == 3) {
    System.out.println("Dobře");
} else {
    System.out.println("Nedostatečně nebo horší");
}
```

### switch

- větvení podle **hodnoty jedné proměnné** (int, char, String, enum)
- každá větev oddělena `case`, ukončena `break`
- `default` = výchozí větev (obdoba `else`)

```java
String den = "Pondělí";

switch (den) {
    case "Pondělí":
    case "Úterý":
    case "Středa":
    case "Čtvrtek":
    case "Pátek":
        System.out.println("Pracovní den");
        break;
    case "Sobota":
    case "Neděle":
        System.out.println("Víkend!");
        break;
    default:
        System.out.println("Neznámý den");
        break;
}
```

### Ternární operátor

- zkrácený zápis `if-else` na jeden řádek
- formát: `podmínka ? hodnota_když_true : hodnota_když_false`

```java
int vek = 20;
String status = (vek >= 18) ? "Dospělý" : "Nezletilý";
System.out.println(status); // → Dospělý
```

---

# typy cyklů

### Cyklus `for`

- používá se když **víme předem, kolikrát** se cyklus opakuje
- struktura: `for (inicializace; podmínka; krok)`

```java
// Výpis čísel 1 až 5
for (int i = 1; i <= 5; i++) {
    System.out.println(i);
}

// Sestupně
for (int i = 10; i >= 1; i--) {
    System.out.print(i + " ");
}
// → 10 9 8 7 6 5 4 3 2 1
```

#### Cyklus `for-each` *(rozšířený for)*

- slouží k procházení **pole nebo kolekce** prvek po prvku
- jednodušší zápis, bez indexu

```java
int[] cisla = {10, 20, 30, 40, 50};

for (int c : cisla) {
    System.out.println(c);
}
// → 10, 20, 30, 40, 50
```

### Cyklus `while`

- opakuje blok kódu **dokud je podmínka pravdivá**
- podmínka se kontroluje **před** každým průchodem
- pokud podmínka není splněna hned na začátku, cyklus se nevykoná ani jednou

```java
int i = 1;
while (i <= 5) {
    System.out.println(i);
    i++;
}
// → 1 2 3 4 5
```

### Cyklus `do-while`

- podmínka se kontroluje **až po** prvním průchodu
- tělo cyklu se vždy vykoná **alespoň jednou**
- vhodný pro vstup od uživatele (opakuj, dokud nezadá správnou hodnotu)

```java
Scanner sc = new Scanner(System.in);
int cislo;

do {
    System.out.print("Zadej číslo > 0: ");
    cislo = sc.nextInt();
} while (cislo <= 0);

System.out.println("Zadal jsi: " + cislo);
```

**Porovnání cyklů:**

| **Cyklus** | **Kdy použít** | **Kontrola podmínky** | **Min. průchodů** |
| --- | --- | --- | --- |
| `for` | Známý počet opakování | Před průchodem | 0 |
| `for-each` | Procházení pole / kolekce | Před průchodem | 0 |
| `while` | Neznámý počet, podmínka na začátku | Před průchodem | 0 |
| `do-while` | Alespoň jeden průchod nutný | Po průchodu | **1** |

---

# ukázky na příkladech

## Komplexní příklady kombinující vše výše

### Příklad 1 – Kalkulačka (větvení + vstup)

```java
import java.util.Scanner;

public class Kalkulacka {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.print("Zadej první číslo: ");
        double a = sc.nextDouble();

        System.out.print("Zadej operaci (+, -, *, /): ");
        sc.nextLine(); // vyčistí buffer
        String op = sc.nextLine();

        System.out.print("Zadej druhé číslo: ");
        double b = sc.nextDouble();

        double vysledek;

        switch (op) {
            case "+": vysledek = a + b; break;
            case "-": vysledek = a - b; break;
            case "*": vysledek = a * b; break;
            case "/":
                if (b == 0) {
                    System.out.println("Nelze dělit nulou!");
                    return;
                }
                vysledek = a / b;
                break;
            default:
                System.out.println("Neznámá operace.");
                return;
        }

        System.out.printf("Výsledek: %.2f%n", vysledek);
        sc.close();
    }
}
```

### Příklad 2 – FizzBuzz (cyklus + větvení)

- klasická programátorská úloha
- pro čísla 1–20: dělitelné 3 → „Fizz", dělitelné 5 → „Buzz", obojí → „FizzBuzz"

```java
for (int i = 1; i <= 20; i++) {
    if (i % 3 == 0 && i % 5 == 0) {
        System.out.println("FizzBuzz");
    } else if (i % 3 == 0) {
        System.out.println("Fizz");
    } else if (i % 5 == 0) {
        System.out.println("Buzz");
    } else {
        System.out.println(i);
    }
}
```

### Příklad 3 – Největší číslo v poli (for-each)

```java
int[] cisla = {5, 12, 3, 47, 8, 21};
int nejvetsi = cisla[0]; // začínáme prvním prvkem

for (int c : cisla) {
    if (c > nejvetsi) {
        nejvetsi = c;
    }
}

System.out.println("Největší číslo: " + nejvetsi);
// → Největší číslo: 47
```

### Příklad 4 – Součet čísel (while + vstup)

```java
Scanner sc = new Scanner(System.in);
int soucet = 0;
int cislo;

System.out.println("Zadávej čísla (0 = konec):");

do {
    cislo = sc.nextInt();
    soucet += cislo;
} while (cislo != 0);

System.out.println("Součet: " + soucet);
sc.close();
```