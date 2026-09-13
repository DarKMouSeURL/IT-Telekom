# Podsíťování IPv4 s konstantní maskou

| 150. | 7. | 8. | 9. | /24 | IPv4 |
| --- | --- | --- | --- | --- | --- |
| 255. | 255. | 255. | 0 |  | maska |

---

199.2.3.0/24

255.255.255.0

- 24 bitů pro síť
- 8 bitů pro host (256 IPv4)

<aside>
📢 /25 rozděleno na 2 sítě

</aside>

![Untitled](Pods%C3%AD%C5%A5ov%C3%A1n%C3%AD%20IPv4%20s%20konstantn%C3%AD%20maskou/Untitled.png)

Přesuneme **2** bity z host do net

199.2.3.0/25

255.255.255.128

- 25 bitů pro síť
- 7 bitů pro host
- 00000000 —> 199.2.3.0/25
- 10000000 —> 199.2.3.128/25

---

<aside>
📢 /26 rozděleno na 4 sítě

</aside>

![image.png](Pods%C3%AD%C5%A5ov%C3%A1n%C3%AD%20IPv4%20s%20konstantn%C3%AD%20maskou/image.png)

Přesuneme **2** bity z host do net

199.2.3.0/26

255.255.255.192

- 26 bitů pro síť
- 6 bitů pro host
- 199.2.3.00000000/26
- 199.2.3.01000000/26
- 199.2.3.10000000/26
- ;/26

---

<aside>
📢 /27 rozděleno na 8 sítí

</aside>

![image.png](Pods%C3%AD%C5%A5ov%C3%A1n%C3%AD%20IPv4%20s%20konstantn%C3%AD%20maskou/image%201.png)

přesuneme **3** bity z host do net

199.2.3.0/27

255.255.255.224

- 27 bitů pro net
- 5 bitů pro host
- 199.2.3.00000000/27
- 199.2.3.00100000/27
- 199.2.3.01000000/27
- 199.2.3.01100000/27
- 199.2.3.10000000/27
- 199.2.3.11000000/27
- 199.2.3.10100000/27
- 199.2.3.11100000/27

---

<aside>
📢 /28 rozděleno na 16 sítí

</aside>

![image.png](Pods%C3%AD%C5%A5ov%C3%A1n%C3%AD%20IPv4%20s%20konstantn%C3%AD%20maskou/image%202.png)

- v každém bloku je 16 IPv4 address
- přesuneme 4 bity z host do net
- 199.2.3.0/28
- 255.255.255.248

---

<aside>
📢 /29 rozděleno na 32 sítí

</aside>

![image.png](Pods%C3%AD%C5%A5ov%C3%A1n%C3%AD%20IPv4%20s%20konstantn%C3%AD%20maskou/image%203.png)

- v každém bloku je 8 IPv4 address
- přesuneme 5 bitů z host do net
- 199.2.3.0/29
- 255.255.255.252

---

<aside>
📢 /30 rozděleno na 64 sítí

</aside>

![image.png](Pods%C3%AD%C5%A5ov%C3%A1n%C3%AD%20IPv4%20s%20konstantn%C3%AD%20maskou/image%204.png)

- dvou bodový spoj
- 4 IPv4
    - 2 jako host
    - 2 nepoužitelné (servisní)
        - 1 adresa podsítě, 1 adresa sítě
- 15.20.30.0/30
- maska /30
    - 30 jedniček z leva
    - 5 nul z prava
    - 255.255.255.252
    

---

# 2 linkový spoj

![image.png](Pods%C3%AD%C5%A5ov%C3%A1n%C3%AD%20IPv4%20s%20konstantn%C3%AD%20maskou/image%205.png)