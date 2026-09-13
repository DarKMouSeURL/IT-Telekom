# Numerické funkce

# **ABS()**

- Absolutní hodnota čísla

```sql
SELECT ABS(-235);   //235
```

# **AVG()**

- K výpočtu průměrné hodnoty
- Nepočítá Null

```sql
SELECT AVG(mzda) AS prumerna_mzda
FROM zamestnanec;
```

# **Count():**

- Spočítá hodnoty v sloupci

```sql
SELECT COUNT(cislo)FROM vstupenka;
```

# **SUM():**

- Součet všech čísel ve sloupci
- Můžeme používat základní mat. operace
- WHERE, AS…

```sql
SELECT SUM(vyska) FROM balik;
```

# **MIN():**

- Nejmenší hodnota ze sloupce
- Lze kombinovat s WHERE, AS…

```sql
SELECT MIN(mzda) FROM zamestnanec;
```

# **MAX():**

- Největší hodnota ze sloupce
- Lze použít s numerickými hodnotami, znakové nebo datum

```sql
SELECT MAX(pocet_osob) FROM letenka;
```

# **POW():**

- Hodnotu čísla umocněnou jiným číslem
- Také lze použít POWER()

```sql
SELECT POW(3,2);         //9
```

# **SQRT():**

- Odmocnina ze zadaného čísla
- Vyžaduje kladné číslo

```sql
SELECT SQRT(9);          //3
```

# **TRUNCATE():**

- Odřízne číslo podle čísla na počet desetinných míst

```sql
SELECT TRUNCATE(135.375, 2);             //135,37
```

# **ROUND():**

- Zaokrouhlí číslo
- Zaokrouhlí cele i desetinné číslo
- Desetinná čísla zaokrouhlí na určitý počet míst

```sql
SELECT ROUND(85.525644699, 3);           //85,526
```

# **RAND():**

- Náhodné číslo
- Od 0 do 1

```sql
SELECT RAND();
```

```sql
**SELECT RAND**()*(10-5)+5;           //náhodné číslo od 5 do 10
```