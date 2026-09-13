# Funkce pro datum a čas

# **ADDDATE()**

- Přidá hodnotu k datu
- Píše se původní datum spolu INTERVAL, jednotky času (SECOND, MINUTE, DAY, MONTH, YEAR)

```sql
SELECT ADDDATE("2017-06-15", INTERVAL 10 DAY);      ///2017-06-25
```

# **ADDTIME()**

- Přidá čas k datu a času
- Píšeme původní čas, který chci dostat

```sql
SELECT ADDTIME("11:34:21", "15");            //11:34:36
```

# **CURRENT_DATE()**

- Aktuální datum
- Formát YYYY-MM-DD jako string
- Formát YYYYMMDD jako int
- Alternativa **CURDATE()**

```sql
SELECT CURRENT_DATE();         //2024-02-13
```

# **CURRENT_TIME()**

- Vrací čas
- HH-MM-SS jako string
- HHMMSS jako int
- Alternativa **CURTIME()**

```sql
SELECT CURRENT_TIME();         //10:26:42
```

# **CURRENT_TIMESTAMP()**

- Vrátí datum a čas
- YYYY-MM-DD HH:MM:SS

```sql
SELECT CURRENT_TIME() + 1;        //102643
```

# **DATE()**

- Vrací YYYY-MM-DD
- Vráti NULL pokud není v Datetime/Date

```sql
SELECT CURRENT_TIMESTAMP();       //2024-05-13 20:23:45
```

# **YEAR()**

- Vrací rok v int
- Od 1000 - 9999

```sql
SELECT YEAR("1996-02-06");          //1996
```

# **MONTH()**

- Vrací mesíc jako INT (1-12)

```sql
SELECT MONTH("1996-02-06");           //2
```

# **DAY()**

- Vrací den jako číslo

```sql
SELECT DAY("1996-02-06");        //6
```

# **HOUR():**

- Vrátí hodnotu času
- Formát HH:MM:SS

```sql
SELECT HOUR("12:59:59");        //12
```

# **MINUTE()**

- Vrací minuty
- Od 0 do 59

```sql
SELECT MINUTE("12:59:59");       //59
```

# **SECOND()**

- Od 0 do 59

```sql
SELECT SECOND("12:59:59");     //59
```

# **TIME()**

- Z DateTime vrací čas

```sql
SELECT TIME("2017-08-15 19:30:10");       //19:30:10
```

# **NOW()**

- Vrátí aktuální čas
- YYYY-MM-DD HH:MM:SS

```sql
SELECT NOW();            //2024-05-13 10:32:22
```

# **DATEDIFF()**

- Vrací rozdíl mezi daty
- YYYY-MM-DD, YYYY-MM-DD

```sql
SELECT DATEDIFF("2017-06-25 09:34:21", "2017-06-15 15:25:35")          //10
```

# **DAYOFYEAR()**

- Vrátí pořadí dne v roce
- Výstup je číslo

```sql
SELECT DAYOFYEAR("2017-06-15");       //116
```

# **DAYOFWEEK()**

- Vrací den v týdnu jako číslo
- 1=pondělí
- 7=sobota

```sql
SELECT DAYOFWEEK("2017-06-15");         //5
```

# **WEEKOFYEAR()**

- Vrátí týden v roce
- Od 1 do 53

```sql
SELECT WEEKOFYEAR("2017-06-15");              //24
```

# **SYSDATE()**

- Funkce vrací čas a datum systému
    
    ```sql
    SELECT SYSDATE();          //2023-04-25 08:29:08
    ```