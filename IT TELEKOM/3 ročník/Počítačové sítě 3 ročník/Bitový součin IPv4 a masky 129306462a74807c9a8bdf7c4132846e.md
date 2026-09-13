# Bitový součin IPv4 a masky

## Aritmetický operátory

9+4 = 13

7-12 = -5

121*0 = 0

## logické operátory:

TRUE AND FALSE = FALSE

FALSE OR FALSE = FALSE

NOT TRUE = FALSE

### Pravdivostní tabulka

| X | Y | AND
(součin) | OR
(součet) | NOTx
(negace) | NOTy
(negace) | NOT AND (NAND) | NOR |
| --- | --- | --- | --- | --- | --- | --- | --- |
| 0 | 0 | 0 | 0 | 1 | 1 | 1 | 1 |
| 0 | 1 | 0 | 1 | 1 | 0 | 1 | 0 |
| 1 | 0 | 0 | 1 | 0 | 1 | 1 | 0 |
| 1 | 1 | 1 | 1 | 0 | 0 | 0 | 0 |

# **Bitové operace:**

- Bitové číslo.
- Negace, součet, součin.

## **Negace:**

- **Čtyřbitové číslo: (max. 15)**
    - (5)10 = (0101)2 = **¬**(1010) = (10)10
    - (14)10 = (1110)2 = **¬**(0001) = (1)10
    - (1111)2 = 15 (Vždy součet začátku a konce u 4 bitových čísel)
- **Osmibitové číslo: (max. 255)**
    - (226)10 = (1110 0010)2 = **¬**(0001 1101) = (29)10
    - (3)10 = (0000 0011)2 = **¬**(1111 1100) = (252)10

## Bitový součet

- (7)10 + (10)10 = (15)10

(0111)2

(1010)2

………….

(1111)2 = 15

(208)10 + (6)10 = (214)10

(1101 0000)2

(0000 0110)2

………………………..

(1101 0110)2 = 214

(254)10 + (128)10 = (254)10

(1111 1110)2

(1000 0000)2

………………………..

(1111 1110)2 = 254

# Bitový součet

![image.png](Bitov%C3%BD%20sou%C4%8Din%20IPv4%20a%20masky/image.png)

![image.png](Bitov%C3%BD%20sou%C4%8Din%20IPv4%20a%20masky/image%201.png)

# Bitový součin a negace

![image.png](Bitov%C3%BD%20sou%C4%8Din%20IPv4%20a%20masky/image%202.png)

![image.png](Bitov%C3%BD%20sou%C4%8Din%20IPv4%20a%20masky/image%203.png)

---

# přímé směrování

![image.png](Bitov%C3%BD%20sou%C4%8Din%20IPv4%20a%20masky/image%204.png)

# nepřímé směrování

![image.png](Bitov%C3%BD%20sou%C4%8Din%20IPv4%20a%20masky/image%205.png)

---

# Přímé směrování s VLSM

![image.png](Bitov%C3%BD%20sou%C4%8Din%20IPv4%20a%20masky/image%206.png)

# Nepřímé směrování s VLSM

![image.png](Bitov%C3%BD%20sou%C4%8Din%20IPv4%20a%20masky/image%207.png)