# IP RT - směrovací tabulka

- R - rip
- C - connected
- S - static
- O - OSPF
- D - EIGRP

```bash
R2#sh ip route
...
		172.16.0.0/24 is subnetted, 3 subnets <- L1
R     172.16.1.0 [120/1] via 172.16.2.1, 00:00:12, Serial0/0 <- L2
C     172.16.2.0 [120/1] is direcly connected, Serial0/0 <- L2
C     172.16.1.0 [120/1] is direcly connected, FastEthernet0/0 <- L2
C  192.168.1.0/24 is direcly connected, Serial0/0 <- L1
```

---

- rozdělena na levely
    - **1 level**, (parent) není subnetován
        - maska =< třídní maska
        - suppernet
        - definování cesty: **ultimate**(má next hop)**, parent**(child záznamy obstáravájí next hop)
    - **2 level**, (child) je subnetován
        - je ultimate (má next-hop)
- když adresa nesedí s level 1 záznamem, neprochází se child záznamy

## Směrovací režim

### Classfull behavior

```bash
R2(config)#no ip classless
```

### Classless behavior

```bash
R2(config)#ip classless
```

![image.png](IP%20RT%20-%20sm%C4%9Brovac%C3%AD%20tabulka/image.png)

## VLSM

R1#sh ip route

![IP RT - s VLSM záznamy](IP%20RT%20-%20sm%C4%9Brovac%C3%AD%20tabulka/image%201.png)

IP RT - s VLSM záznamy

# Prohledávání IP RT

1. Prohledá level 1 cesty
    1. třídní síť
    2. suppernety (nadsíťování)
    3. pokud se des. ip == záznam, odešle se přes daný interface
2. Prohledává se child cesty
    1. musí sedět s parent cestou
    
- cesty seřazené podle masky

# Longest match

> Level 1 route
> 

|  | adresa | maska |
| --- | --- | --- |
| cesta 1 | 172.16.0.0/12 | 10101100.00010000.00000000.00000000 |
| cesta 2 | 172.16.0.0/18 | 10101100.00010000.00000000.00000000 |
| cesta 3 | 172.16.0.0/26 | 10101100.00010000.00000000.00000000 |
- vybere cestu 3, bo odpovídá nejdéle z leva

# Nastavení směrování

> Classfull nebo classless
> 

```bash
R1(config)#ip classless
R1(config)#no ip classless
```