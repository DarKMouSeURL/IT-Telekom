# Dynamické směrovací protokoly

<aside>
⚠️

použití ve velkých sítích

</aside>

> **RIP v2(Routing Information Protocol):** používá se v malých sítích
> 

> **OSPF (Open Shortest path First):** používá se ve velkých sítích
> 

> **EIGRP (Enhanced Interior Gateway Routing Protocol):** ve velkých sítích (od CISCO)
> 

- dynamické p. jsou užity pro usnadnění výměny směrovacích informacích mezi routry
- umožnují získávat a sdílet info o vzdálených sítích
- směrovače si předají aktuální informace, kdykoliv kdy se něco změní
- učení se o vzdálených sítích
- přizpůsobení změnám v síti

![image.png](Dynamick%C3%A9%20sm%C4%9Brovac%C3%AD%20protokoly/image.png)

![image.png](Dynamick%C3%A9%20sm%C4%9Brovac%C3%AD%20protokoly/image%201.png)

# Vnitřní směrovací protokoly

## IGP (Interior Gateway Procol)

- pro vnitřní směrování
- v síti
- pro směrovače co mají společného admina

# Vnější směrovací protokoly

## EGP (Exterior Gateway Protocol)

- pro směrování autonomními sítěmi
- pod správou různých adminů

---

# Distance vektor

- každá cesta je oznamovaná jako vektor
    - vektor: velikost a směr
    - vzdálenost = metrika do cílové sítě
    - směr = next hop IP adresa, exit interface
- některé protokoly periodický posílají kompletní směrovací tabulky všem sousedním směrovačům (může zatížit síť)
- nelze získat kompletní topologii sítě

# Link state

- směrovač získá informace, na kterých si vytváří komplet mapu sítě
- vyměňují si info o RT tabulkách do té doby než dojde ke konvergenci
    - **konvergence** = všechny směrovače znají cesty do všech *R* sítích

# Třídní classfull směrovací protokoly (RIPv1, IGRP)

- **ne**posílají ve směrovacích updatech info o subnet maskách
- nelze použít s VLSM

# Beztřídní classless směrovací protokoly (RIPv2, EIGRP, OSPF, IS-IS, BGP)

- posílají kompletní info o směrovací podsítě masky
- podporuje VLSM

# Metrika

<aside>
🔢

metrika je číslo

</aside>

- značení ceny/kvality cesty pro dosažení cílové sítě
- směrovač si do směrovací tabulky zapíše cestu do R sítě s **nejmenší** metrikou
- algoritmus Bellman-ford, Dijkstra
- každý protokol si počítá metriku jinak

## RIP

- pro výpočet metriky používá HOP COUNT

```jsx
R 192.168.8.0/24 [120/2] via 192.168.4.1, 00:00:26, Serial 0/0/1
```

## EIGRP

- používá BANDWIDTH, delay, reliabity a load

```jsx
O 8.0.0.0/8 [-/1572] next hop
```

## OSPF

- používá cenu na základě bandwidth

```jsx
D 8.0.0.0/8 [administrative distance/2781924] next hop
```

# Load balancing

- snaha vyvážit zatížení na sítí
- do cílové sítě kde jsou 2 a více cest se stejnou cenou
- equal-cost cestaa

![image.png](Dynamick%C3%A9%20sm%C4%9Brovac%C3%AD%20protokoly/image%202.png)

# Administrativní vzdálenost (AD)

- parametr sloužící k odlišení metriky u cest získaných z různých dynamických protokolů
- vyjadřuje kvalitu/důvěryhodnost cesty z dynamických protokolů
- AD <0,255> 8 bitů
- čím je číslo nižší číslo je více důvěryhodnější
    
    

| Source | AD |
| --- | --- |
| Connected | 0 |
| Static | 1 |
| EIGRP | 90 |
| OSPF | 110 |
| RIP | 120 |

<aside>
⚠️

protokoly zjišťují info o vzdálenosti sítích a nejlepších cesty do vzdálené sítě zapisují do RT

</aside>

<aside>
📢

Link State Protocol - zná celou mapu topologie sítě

</aside>

<aside>
📢

DV - znají vzdálenost, směr, ale neznají celou mapu topologie

</aside>

<aside>
☎️

metrika - cena cesty do sítě

</aside>

<aside>
⏰

RIP - počet přeskoků do vzd. sítě

</aside>

<aside>
🗣

AD - důvěryhodnost cesty

</aside>