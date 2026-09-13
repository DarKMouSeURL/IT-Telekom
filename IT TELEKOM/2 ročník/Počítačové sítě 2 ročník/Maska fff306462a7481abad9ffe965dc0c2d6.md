# Maska

- souvislý proud jedniček z leva  ←——
- [32 bitové číslo](P%C5%99evody%20mezi%20soustavami%20fff306462a7481a0a466ef702d6ebdb0.md)

## příklady

- 255.0.0.0
- 11111111.00000000.00000000.00000000

- 255.255.0.0
- 11111111.11111111.00000000.00000000

**net portion**: samé 1 ——> 255
**host portion**: samé 0 ——> 0

- jeden byte masky sítě může nabývat pouze 8 hodnot, podle toho kde končí jedničky

| 00000000 | 0 |
| --- | --- |
| 10000000 | 128 |
| 11000000 | 192 |
| 11100000 | 224 |
| 11110000 | 240 |
| 11111000 | 248 |
| 11111100 | 252 |
| 11111110 | 254 |
| 11111111 | 255 |

**čísla, která mohou být v masce**