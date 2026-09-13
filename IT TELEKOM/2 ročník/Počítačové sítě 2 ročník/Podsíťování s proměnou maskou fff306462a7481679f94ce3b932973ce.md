# Podsíťování s proměnou maskou

![image.png](Pods%C3%AD%C5%A5ov%C3%A1n%C3%AD%20s%20prom%C4%9Bnou%20maskou/image.png)

- variabilní maska
- VLSM - Variable Lenght Subnet Mask

---

# Podsíťování s konstantní maskou VS VLSM

![Untitled](Pods%C3%AD%C5%A5ov%C3%A1n%C3%AD%20s%20prom%C4%9Bnou%20maskou/Untitled.png)

## VLMS

- dynamické podle velikosti sítí
- lepší pro úsporu tabulky

---

## konstantní maska

- musíme vymezit co největší prostor pro VLAN nejmenší
- méně úsporné na tabulku
- Všechny LAN sítě mají stejnou velikost, i když ji nepotřebují

---

![image.png](Pods%C3%AD%C5%A5ov%C3%A1n%C3%AD%20s%20prom%C4%9Bnou%20maskou/image%201.png)

| **číslo** | **adresa podsítě** | **1 použitelná adresa** | **poslední p. adresa** | **broadcast** | **maska** |
| --- | --- | --- | --- | --- | --- |
| LAN1 | 2.3.4.0/**26** | 2.3.4.1 | 2.3.4.62 | 2.3.4.63 | 255.255.255.192 |
| LAN2 | 2.3.4.64/**27** | 2.3.4.65 | 2.3.4.94 | 2.3.4.95 | 255.255.255.224 |
| LAN3 | 2.3.4.96/**28** | 2.3.4.97 | 2.3.4.110 | 2.3.4.111 | 255.255.255.240 |

---

![image.png](Pods%C3%AD%C5%A5ov%C3%A1n%C3%AD%20s%20prom%C4%9Bnou%20maskou/image%202.png)

| **označení sítě** | **adresa podsítě** | **1 použitelná** | **poslední použitelná** | **broadcast** | **maska** |
| --- | --- | --- | --- | --- | --- |
| LAN1 | 192.168.21.0/26 | 192.168.21.1 | 192.168.21.62 | 192.168.21.63 | 255.255.255.192 |
| LAN2 | 192.168.21.64/26 | 192.168.21.65 | 192.168.21.126 | 192.168.21.127 | 255.255.255.192 |
| LAN3 | 192.168.21.128/27 | 192.168.21.129 | 192.168.21.158 | 192.168.21.159 | 255.255.255.224 |
| LAN4 | 192.168.21.160/28 | 192.168.21.161 | 192.168.21.174 | 192.168.21.175 | 255.255.255.240 |

---

![image.png](Pods%C3%AD%C5%A5ov%C3%A1n%C3%AD%20s%20prom%C4%9Bnou%20maskou/image%203.png)

| **označení sítě** | **adresa podsítě** | **1 použitelná** | **poslední použitelná** | **broadcast** | **maska** |
| --- | --- | --- | --- | --- | --- |
| LAN1 | 3.3.3.0/26 | 3.3.3.1 | 3.3.3.62 | 3.3.3.63 | 255.255.255.192 |
| LAN2 | 3.3.3.64/27 | 192.168.21.65 | 3.3.3.94 | 3.3.3.95 | 255.255.255.224 |
| LAN3 | 3.3.3.96/28 | 3.3.3.97 | 3.3.3.110 | 3.3.3.111 | 255.255.255.240 |
| LAN4 | 3.3.3.112/28 | 3.3.3.113 | 3.3.3.126 | 3.3.3.127 | 255.255.255.240 |
| LAN5 | 3.3.3.127/28 | 3.3.3.128 | 3.3.3.142 | 3.3.3.143 | 255.255.255.240 |
| LAN6 | 3.3.3.144 | 3.3.3.145 | 3.3.3.150 | 3.3.3.151 | 255.255.255.248 |