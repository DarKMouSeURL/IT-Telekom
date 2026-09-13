# Textové a znakové funkce

# **CHAR_LENGHT()**

- Vrací délku znakové řetězce

```sql
SELECT CHAR_LENGHT('Abeceda');
```

# **CONCAT()**

- Spojuje více výrazů dohromady

```sql
SELECT CONCAT('Jan', ' ', 'Novak');
```

# **FORMAT()**

- U numerckých datových upravuje počet desetinných míst
- Hodnoty zaokrouhluje

# **INSERT()**

- Vkládá zadaný výraz do znakového řetězce
- Zadaným výrazem je nahrazen vymezený rozsah
- Neplést si funkci a příkaz **INSERT**

```sql
SELECT INSER('example.eu', 1, 7, 'teleinformatika.eu');
```

# **INSTR():**

- Vrátí číslo, kde je hledaný výraz

```sql
SELECT INSTR('example.eu', '.eu');

```

# **SUBSTRIBNG():**

- Vybere část ze znakovaného řetězce v zadaném rozsahu

```sql
SELECT SUBSTRING('MySQL', 3, 5);              //SQL
```

# **TRIM()**:

- Odebere mezery znakového řetězce z levé i pravé strany
    - LTRIM(): levá strana
    - RTRIM(): pravá strana

```sql
SELECT TRIM('       MySQL       ');        //MySQL
```

# **UPPER () a LOWER()**:

- UPPER() převede písmena na VELKÁ
- LOWER() převede písmena na malá

```sql
SELECT UPPER('example.eu');             //EXAMPLE.EU
```

# **REPEAT():**

- Zopakuje znakový řetězec několikrát

```sql
SELECT REPEAT('example.eu',3);                //example.eu example.eu example.eu
```

# **REPLACE():**

- Ve znakovém řetězci nahradí hledaný výraz jiným zadaným výrazem

```sql
SELECT REPLACE('Mam mozek', 'mozek', 'strojovnu');          // Mam strojovnu
```

# **REVERSE():**

- Obrátí text pozpátku

```sql
SELECT REVERSE('Mam mozek');        //Kezom maM
```

# LEFT() a RIGHT():

- Vybere určitý počet znaků řetězce zleva či zprava

```sql
SELECT LEFT('Mam mozek', 3);         //Mam
```