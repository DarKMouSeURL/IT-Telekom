# DCL (Data Control Language)

- Pro přidělování/odebírání/úpravě oprávnění uživatelům
- CREATE USER, GRANT(přidání oprávnění), REVOKE(odebrání oprávnění)

**CREATE USER**

- Pro vytvoření uživatele
- Zadává se název, heslo, další nastavení pro přístup
- Uživatel se smí přihlašovat odkudkoliv

```sql
CREATE USER zdislav 
IDENTIFIED BY 'nereknu123'; uživatel 
```