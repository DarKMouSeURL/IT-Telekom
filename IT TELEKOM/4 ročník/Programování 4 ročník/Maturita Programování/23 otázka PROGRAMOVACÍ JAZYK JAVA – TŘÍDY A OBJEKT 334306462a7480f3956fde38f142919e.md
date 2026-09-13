# 23. otázka PROGRAMOVACÍ JAZYK JAVA – TŘÍDY A OBJEKTY

---

- pojmy OOP: třída, objekt, konstruktor, dědičnost, polymorfismus
- práce s atributy objektu – zapouzdření, modifikátory přístupu, metody get, set
- metody bezparametrické, s parametry, návratová hodnota metody, přetížená metoda
- nadefinování třídy Zboží a její použití
- statická třída a práce s ní

---

# pojmy OOP: třída, objekt, konstruktor, dědičnost, polymorfismus

## OOP – Objektově orientované programování

<aside>
📌

***O**bject **O**riented **P**rogramming*

</aside>

<aside>
🇨🇿

Objektově orientované programování

</aside>

- programovací paradigma (styl programování) postavené na **objektech**
- program se skládá ze **tříd** a **objektů**, které spolu komunikují a vzájemně si předávají data
- tři základní pilíře OOP: **zapouzdření**, **dědičnost**, **polymorfismus**

---

### Třída (Class)

- **šablona / vzor** – popisuje, jak bude objekt vypadat a co umí
- definuje **atributy** (proměnné) a **metody** (funkce objektu)
- samotná třída není objekt – je to jen předpis, v paměti nezabírá místo

```java
public class Zbozi {
    String nazev;
    double cena;
}
```

### Objekt (Object)

- **konkrétní instance třídy** – skutečná entita vytvořená v paměti
- vytváříme pomocí klíčového slova `new`
- každý objekt má **vlastní hodnoty** atributů

```java
Zbozi jablko = new Zbozi();
jablko.nazev = "Jablko";
jablko.cena = 12.5;
```

### Konstruktor (Constructor)

- speciální metoda volaná **při vytváření objektu** (`new`)
- má **stejné jméno jako třída**
- nemá návratový typ – ani `void`
- slouží k **inicializaci atributů** objektu hned při jeho vzniku
- pokud ho nedefinujeme, Java vytvoří **výchozí bezparametrický** konstruktor automaticky

```java
public class Zbozi {
    String nazev;
    double cena;

    // Konstruktor
    public Zbozi(String nazev, double cena) {
        this.nazev = nazev;
        this.cena = cena;
    }
}

// Vytvoření objektu přes konstruktor:
Zbozi jablko = new Zbozi("Jablko", 12.5);
```

> `this` odkazuje na aktuální objekt – rozlišuje atribut třídy od parametru metody se stejným jménem
> 

---

### Dědičnost (Inheritance)

- umožňuje vytvořit **novou třídu** na základě třídy existující
- nová (potomek) třída **zdědí** atributy a metody rodičovské třídy
- klíčové slovo: `extends`
- Java podporuje pouze **jednoduchou dědičnost** – třída může dědit jen z jedné třídy
- rodičovská třída = **superclass**, odvozená třída = **subclass**

```java
public class Zbozi {
    String nazev;
    double cena;
}

// Potravina dědí ze Zbozi
public class Potravina extends Zbozi {
    String datumSpotreby;

    public void vypisPlatnost() {
        System.out.println("Spotřebovat do: "
            + datumSpotreby);
    }
}
```

### Polymorfismus (Polymorphism)

- doslova **„mnohoforemnost"**
- umožňuje volat **stejnou metodu** na různých objektech, které se ale chovají každý jinak
- klíčové slovo `@Override` – přepsání (překrytí) metody z rodičovské třídy v potomkovi
- nutná podmínka: dědičnost nebo rozhraní (`interface`)

```java
public class Zbozi {
    public void vypis() {
        System.out.println("Jsem zboží.");
    }
}

public class Potravina extends Zbozi {
    @Override
    public void vypis() {
        System.out.println("Jsem potravina.");
    }
}

// Polymorfní volání:
Zbozi z = new Potravina();
z.vypis(); // → "Jsem potravina."
```

---

# práce s atributy objektu – zapouzdření, modifikátory přístupu, metody get, set

## Zapouzdření a modifikátory přístupu

### Zapouzdření (Encapsulation)

- základní princip OOP: **skryj vnitřní data** objektu a dovol k nim přístup jen přes definované metody
- atributy se označují jako `private` – nikdo zvenčí k nim nemůže přímo přistupovat ani je měnit
- přístup probíhá přes metody **getter** a **setter** → bezpečnější a kontrolovaný přístup k datům
- setter může **validovat vstup** (např. cena nesmí být záporná)

---

### Modifikátory přístupu

| **Modifikátor** | **Přístupnost** |
| --- | --- |
| `public` | Přístupný odkudkoliv – z jakékoliv třídy i balíčku |
| `private` | Přístupný **pouze** uvnitř dané třídy – nejpřísnější omezení |
| `protected` | Přístupný v dané třídě a ve všech třídách, které z ní dědí (`extends`) |
| *(bez klíčového slova)* | Výchozí (package-private) – přístupný pouze v rámci stejného balíčku |

---

### Metody get a set (gettery a settery)

- **getter** – vrací hodnotu soukromého atributu, název začíná `get`
- **setter** – nastavuje hodnotu soukromého atributu, název začíná `set`, může obsahovat validaci

```java
public class Zbozi {
    private String nazev;
    private double cena;

    // Getter – vrátí hodnotu atributu
    public String getNazev() {
        return nazev;
    }

    // Setter – nastaví hodnotu, validace: cena nesmí být záporná
    public void setCena(double cena) {
        if (cena >= 0) {
            this.cena = cena;
        }
    }
}
```

---

# metody bezparametrické, s parametry, návratová hodnota metody, přetížená metoda

## Metody v Javě

#### Bezparametrická metoda

- metoda **bez vstupních parametrů**
- pokud nevrací žádnou hodnotu → návratový typ `void`

```java
public void pozdrav() {
    System.out.println("Ahoj!");
}
```

#### Metoda s parametry

- přijímá **vstupní hodnoty** při volání (argumenty)
- parametry jsou definovány v závorce s jejich datovým typem

```java
public void nastav(String nazev, double cena) {
    this.nazev = nazev;
    this.cena = cena;
}
```

#### Metoda s návratovou hodnotou

- místo `void` se uvede **datový typ**, který metoda vrací
- klíčové slovo `return` vrátí výsledek volajícímu kódu

```java
public double getCena() {
    return cena;
}

public double getCenaSDPH() {
    return cena * 1.21;
}
```

#### Přetížená metoda (Overloading)

- více metod se **stejným jménem**, ale různými parametry
- Java rozlišuje, kterou verzi zavolat podle **počtu nebo typů argumentů**
- přetížení se liší od přepsání (`@Override`) – přetěžujeme uvnitř jedné třídy

```java
public void vypisInfo() {
    System.out.println(nazev + " – " + cena + " Kč");
}

public void vypisInfo(boolean zobrazSkladem) {
    System.out.println(nazev + " – " + cena + " Kč"
        + (zobrazSkladem
            ? " (skladem: " + skladem + " ks)"
            : ""));
}
```

---

# nadefinování třídy Zboží a její použití

## Třída Zboží – kompletní příklad

```java
public class Zbozi {

    // Atributy – private (zapouzdření)
    private String nazev;
    private double cena;
    private int skladem;

    // Bezparametrický konstruktor – výchozí hodnoty
    public Zbozi() {
        this.nazev = "Neznámé";
        this.cena = 0.0;
        this.skladem = 0;
    }

    // Parametrický konstruktor – přetížení konstruktoru
    public Zbozi(String nazev, double cena, int skladem) {
        this.nazev = nazev;
        this.cena = cena;
        this.skladem = skladem;
    }

    // Gettery
    public String getNazev()  { return nazev; }
    public double getCena()   { return cena; }
    public int getSkladem()   { return skladem; }

    // Settery s validací
    public void setNazev(String nazev)   { this.nazev = nazev; }
    public void setCena(double cena)     { if (cena >= 0) this.cena = cena; }
    public void setSkladem(int skladem)  { if (skladem >= 0) this.skladem = skladem; }

    // Metoda s návratovou hodnotou
    public double getCenaSDPH() {
        return cena * 1.21;
    }

    // Přetížená metoda
    public void vypisInfo() {
        System.out.println(nazev + " – " + cena + " Kč");
    }

    public void vypisInfo(boolean zobrazSkladem) {
        System.out.println(nazev + " – " + cena + " Kč"
            + (zobrazSkladem ? " (skladem: " + skladem + " ks)" : ""));
    }
}
```

### Použití třídy Zboží v main

```java
public class Main {
    public static void main(String[] args) {

        // Bezparametrický konstruktor
        Zbozi neznamy = new Zbozi();
        neznamy.vypisInfo(); // Neznámé – 0.0 Kč

        // Parametrický konstruktor
        Zbozi jablko = new Zbozi("Jablko", 12.5, 100);

        // Výpis přes getter
        System.out.println(jablko.getNazev());     // Jablko
        System.out.println(jablko.getCena());      // 12.5
        System.out.println(jablko.getCenaSDPH());  // 15.125

        // Setter – změna hodnoty
        jablko.setCena(14.0);

        // Přetížené metody
        jablko.vypisInfo();         // Jablko – 14.0 Kč
        jablko.vypisInfo(true);     // Jablko – 14.0 Kč (skladem: 100 ks)
    }
}
```

---

# statická třída a práce s ní

## Statické prvky v Javě

### Statická metoda / atribut

- klíčové slovo `static`
- patří **třídě, ne konkrétnímu objektu** – nepotřebujeme vytvářet instanci
- volají se přímo přes název třídy: `ZboziHelper.formatujCenu(100.0)`
- statické atributy jsou **sdíleny všemi instancemi** třídy (např. počítadlo objektů)

```java
public class Zbozi {
    private static int pocetZbozi = 0; // sdílený čítač

    public Zbozi(String nazev, double cena) {
        this.nazev = nazev;
        this.cena = cena;
        pocetZbozi++; // zvýší se při každém new
    }

    public static int getPocetZbozi() {
        return pocetZbozi;
    }
}

// Použití:
new Zbozi("Jablko", 12.5);
new Zbozi("Hruška", 15.0);
System.out.println(Zbozi.getPocetZbozi()); // 2
```

### Utility třída (pomocná statická třída)

- třída obsahující **pouze statické metody**
- konstruktor označen jako `private` → nelze vytvořit instanci (objekt)
- slouží jako sada pomocných / výpočetních funkcí

```java
public class ZboziHelper {

    // Privátní konstruktor – třída nejde instanciovat
    private ZboziHelper() {}

    public static double vypocitejDPH(double cena) {
        return cena * 0.21;
    }

    public static boolean jeNaSkladě(int kusu) {
        return kusu > 0;
    }

    public static String formatujCenu(double cena) {
        return String.format("%.2f Kč", cena);
    }
}

// Použití – BEZ vytváření objektu:
double dph = ZboziHelper.vypocitejDPH(100.0);
// → 21.0
boolean dostupne = ZboziHelper.jeNaSkladě(5);
// → true
System.out.println(ZboziHelper.formatujCenu(149.9));
// → 149,90 Kč
```

> Statická třída v Javě = třída s `private` konstruktorem a pouze `static` metodami. Nelze vytvořit objekt, voláme ji přímo přes název třídy.
>