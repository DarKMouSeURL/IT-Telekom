# Převody mezi soustavami

# Obecný zápis čísla (10 soustava)

$$
Σ an * Zˆn =  a3 * Zˆ3 + a2 * Zˆ2 + a1 * Zˆ1 + a0 * Zˆ0
$$

# Obecný zápis čísla (16 soustava)

$$
Σ = c * 16^3 + E * 16^2 + 2 * 16^1 + A * 16^0 = (CE2A)16 \newline 12 * 4094 + 14 * 256 + 2 * 16 + 10 * 1 = (52778)10
$$

---

# IPv4

| 1 | 2 | 3 | 4 |
| --- | --- | --- | --- |
| 1 byte | 1 byte | 1 byte | 1 byte |
- bit = binary digit
- 1 byte = 8 bittů
- 256 možností
    - <0,255>
    - min (00000000)
    - max (11111111)

---

# Dvojoka soustava

| decimální |           1. |            2. |            3. |           4. |
| --- | --- | --- | --- | --- |
| binární | 00000001 | 00000010 | 00000011 | 00000010 |

(101010)2 = 1 * 2^5 + 0 * 2^4 + 1 * 2^3 + 0 * 2^2 + 1 * 2^1 + 0 * 2^0 = 42

(100001)2 = 1 * 2^6 + 1 * 2^0 = 42

---

# Šestnáctková soustava

$2^4 = 16$

MAC adresa síťové karty = 48 bitová

(AF-07-81-00-14-11)16

1010111100000111-1000000100000000…

[převody mezi soustavami.pdf](P%C5%99evody%20mezi%20soustavami/pevody_mezi_soustavami.pdf)

## 🐒cvičená opička

| 16ková | 2ková |
| --- | --- |
| 0 | 0000 |
| 1 | 0001 |
| 2 | 0010 |
| 3 | 0011 |
| 4 | 0100 |
| 5 | 0101 |
| 6 | 0110 |
| 7 | 0111 |
| 8 | 1000 |
| 9 | 1001 |
| A | 1010 |
| B | 1011 |
| C | 1100 |
| D | 1101 |
| E | 1110 |
| F | 1111 |

## příklady

(AF07)16 = (1010111100000111)2

(BEEF)16 = (1011111011101111)2

(101011011010)2 = (ADA)16

(1001010110110)2 = (6B21)16

(1010111)2 = (75)10

| 2ková | 1 | 0 | 1 | 0 | 1 | 1 | 1 |       |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| 10ková | 64 | 32 | 16 | 8 | 4 | 2 | 1 |      = | 87 |

    sečítáme tam, kde jsou jedničky

# 1 bitové číslo

![Untitled](P%C5%99evody%20mezi%20soustavami/Untitled.png)

$2^1 = 2$  možnosti

# 2 bitové číslo

![Untitled](P%C5%99evody%20mezi%20soustavami/Untitled%201.png)

$2^2 = 4$ možnosti

# 3 bitové číslo

![Untitled](P%C5%99evody%20mezi%20soustavami/Untitled%202.png)

$2^3 = 8$ možností

# 4 bitové číslo

![Untitled](P%C5%99evody%20mezi%20soustavami/Untitled%203.png)

$2^4 = 16$ možností

# 5 bitové číslo

$2^5 = 32$ možností

# 8 bitové číslo

$2^8 = 256$ možností

|     0 | ←—— | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
|    255 | ←—— | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 |