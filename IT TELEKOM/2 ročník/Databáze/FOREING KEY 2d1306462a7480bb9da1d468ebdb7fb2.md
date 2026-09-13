# FOREING KEY

- Vytvoření cizího klíče
- Klíčová slova **FOREING KEY**

```sql
CREATE TABLE zamestnanec(
id INT NOT NULL AUTO_INCREMENT,
jmeno VARCHAR(30) DEFAULT "" NOT NULL,
prijmeni VARCHAR(45) DEFAULT "" NOT NULL,
mzda DECIMAL(10,2) DEFAULT 0 NOT NULL,
poznamka TEXT,
Oddelení_id INT NULL,
PRIMARY KEY (id),
FOREINGH KEY (oddeleni_id) REFERENCES (id)
);
```