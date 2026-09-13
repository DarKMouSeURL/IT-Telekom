# Řazení výsledků - ORDER BY

- Slouží k seřazení výsledků
- Za ORDER BY můžeme umístit doplněk:
    - **ASC** - vzestupně (výchozí)
    - **DESC** - sestupně

### Výchozí řazení **ASC**:

- Numerické hodnoty zobrazeny od nejnižší po nejvyšší
- Hodnoty pro datum od nejstaršího po nejnovějšího
- Text hodnoty v abecedním pořadí
- Hodnoty NULL se řadí jako poslední

```sql
SELECT * FROM zamestnanec
ORDER BY jmeno DESC
```