# 5. otázka STATICKÉ A DYNAMICKÉ SMĚROVÁNÍ

---

- popis směrovače, jeho funkce, postup při směrování paketů
- směrovací tabulka, statické směrování, sumarizace cest
- nastavení a význam výchozí statické cesty
- rozdělení dynamických směrovacích protokolů, princip dynamického směrování
- pojmy: metrika, administrativní vzdálenost, konvergence a load balancing

---

# popis směrovače, jeho funkce, postup při směrování paketů

> směrovač = router
> 
- první použití ARPA-NET
- podstatě počítač
- router má několik rozhraní (interface)
- pracuje na síťové vrstvě (L3) a nižších vrstvách

### Hardware

1. **CPU**
2. **RAM (Random Access Memory)**
    1. energeticky závislá, **jde** měnit obsah
    2. ukládá IOS při bootování směrovače
    3. uložen running-config
    4. IP RT
    5. ARP cache
    6. paket buffer (vyrovnávací paměť)
3. **ROM (Read-Only Memory)**
    1. energeticky nezávislá, **nejde** měnit obsah paměti
    2. obsahuje bootstrap
    3. diagnostiku směrovače (Power-On Self Test)
    4. základní verzi IOS (backup IOS)
4. **Flash paměť**
    1. energeticky nezávislá, **jde** měnit obsah paměti
    2. aktuálně používaná IOS 
5. **NVRAM (Nonvolatile RAM)**
    1. energeticky nezávislá, **jde** měnit obsah paměti
    2. pro uložení startup-config
        1. po načtení systému, převeden od running-config v RAM

### Rozhraní

**Management port**

> konzolový port
> 
- pro konfiguraci směrovače
- neslouží pro směrování provozu

**Port pro provoz**

> FastEthernet / GigabitEthernet
> 
- pro indikaci stavu se používají LED diody
- každé rozhraní má svou IP adresu

### Bootstrap

- zavádění systému
    
    ![image.png](5%20ot%C3%A1zka%20STATICK%C3%89%20A%20DYNAMICK%C3%89%20SM%C4%9AROV%C3%81N%C3%8D/d9945880-b943-4875-ab7e-d774688c4802.png)
    
1. **POST (Power-on Self Test)**
    1. test hardwaru (CPU…)
2. **spuštění bootstrapu**
    1. bootstrap je zkopírován z ROM do RAM
    2. vyhledává IOS
3. **zavádění IOS**
    1. obvykle z ROM do RAM
    2. ale taky lze zavádět z TFTP serveru
4. **vyhledání a použití startup-config souboru**

### IOS (Internetwork Operating System)

- operační systém pro směrovače od Cisco
- rozdělen na *images*, **podle modelu routru
- hodně rozšířen **CLI** (Command Line Interface) - příkazový řádek
    - lze použít **GUI** (Graphic User Interface) - grafické nastavení

## jeho funkce

> směrování = routing
> 
- umožňuje komunikaci zařízení na jiných sítích
- směruje pakety na síťové vrstvě (L3)
- **směruje do přímo připojených a vzdálených sítích**
    - podle IP ROUTING TABLE (BEST MATCH)
- vybírá nejlepší cestu pro odesílání paketů

## postup při směrování paketů

1. **příjem rámce na rozhraní**
    1. zkontrolování checksum
    2. porovnání MAC adresy (DESTINATION ADDRESS) se svou MAC adresou
    3. vypouzdření do paketu
    4. přečtení IP adresy (DESTINATION ADDRESS)
2. **porovnání IP paketu oproti IP RT**
    1. záznam, který se shoduje, pošle na příslušné rozhraní
    2. pokud je to přímo připojená síť, odesílá se do přímo připojené sítě
    3. pokud je to vzdálená síť, odesílá se k dalšímu směrovači 
        1. [Dynamické směrovací protokoly](../../../3%20ro%C4%8Dn%C3%ADk/Po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B%203%20ro%C4%8Dn%C3%ADk/Dynamick%C3%A9%20sm%C4%9Brovac%C3%AD%20protokoly%20153306462a7480998f4ecb574b6828e1.md)
3. **směrovač zabalí paket do příslušného rámce, podle typu média**
4. **rámec je odesílán na fyzickém médiu (L1), bit po bitu**

![output-onlinepngtools.png](5%20ot%C3%A1zka%20STATICK%C3%89%20A%20DYNAMICK%C3%89%20SM%C4%9AROV%C3%81N%C3%8D/output-onlinepngtools.png)

---

## směrovací tabulka, statické směrování, sumarizace cest

- tabulka pravidel pro směrování
- řazena podle masky
    - na vrchu /32
    - na spod /0
- obsahuje různě velké sítě (/24, /16…)
- uložena v RAM
- každý směrovač se rozhoduje sám o směrování podle své tabulky
- **Ve směrovací tabulce jsou**:
    - levl. 1 (parent routes)
    - levl. 2 (child routes)
    - cesty (routes)

---

- **LEVEL 1** jsou cesty s maskou, která je rovna nebo menší než třídní maska
    - patří do ní default, [supernet](../../../3%20ro%C4%8Dn%C3%ADk/Po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B%203%20ro%C4%8Dn%C3%ADk/VLSM%20a%20CIDR%2018a306462a7480cc997eef47bab3e522.md) a network route
    - **Ultimate route** (konečná) - je next hop a IP adresu
        
        > C 172.16.0.0/24 is directly connected, Serial0/0/1
        > 
    - **Parent route**(rodič) - nemá next hop a IP adresu
        
        > 172.16.0.0/24 is subnetted, 1 subnets
        > 
        - automaticky vytvořena, když má větší masku než classful adresace (/25, /26…)
        - maska sítě je jen uvedena, pokud podsítě jsou stejně velké
- **LEVEL 2** je to child route z parent route
    
    > 172.16.3.0 is directly connected, Serial0/1/0
    > 
    - je to ultimate cesta (má next hop a IP adresu)
    

```jsx
R1#show ip route
Codes: I - IGRP derived, R - RIP derived, O - OSPF derived
       C - connected, S - static, E - EGP derived, B - BGP derived
       * - candidate default route, IA - OSPF inter area route
       E1 - OSPF external type 1 route, E2 - OSPF external type 2 route
Gateway of last resort is 131.119.254.240 to network 129.140.0.0
O E2 150.150.0.0 [160/5] via 131.119.254.6, 0:01:00, Ethernet2
E    192.67.131.0 [200/128] via 131.119.254.244, 0:02:22, Ethernet2
O E2 192.68.132.0 [160/5] via 131.119.254.6, 0:00:59, Ethernet2
O E2 130.130.0.0 [160/5] via 131.119.254.6, 0:00:59, Ethernet2
C    45.31.2.0 [1/0] is directly connected, GigabitEthernet0/0
```

### Přímo připojené (C)

- je síť, která je přímo fyzicky připojena k routru
- obsahuje adresu sítě, a rozhraní směrovače

### Vzdálená síť (S, D, R, O…)

- jsou cesty k sítím, které vedou přes další směrovače
- záznamy jsou z dynamického protokolu nebo staticky nastavena
- Dynamické cesty směrovacích protokolů… R (RIP), D (EIGRP), O (OSPF)

> Třídní směrovací režim (**classful** behaviour) a beztřídní směrovací režim (**classless** behaviour)
> 

```jsx
R1(config)#no ip classless //(třídní směrovací režim)
R1(config)#ip classless //(beztřídní směrovací režim)
```

# statické směrování

- manuální přidání cesty do vzdálené sítě

```jsx
R1#conf t
R1(config)#ip route 80.90.100.0 255.255.255.0 Gigabit 0/0/0
R1(config)#end
R1#show ip route
Codes: I - IGRP derived, R - RIP derived, O - OSPF derived
       C - connected, S - static, E - EGP derived, B - BGP derived
       * - candidate default route, IA - OSPF inter area route
       E1 - OSPF external type 1 route, E2 - OSPF external type 2 route
Gateway of last resort is not set
C   1.0.0.0 is directly connected, Gigabit 0/0/0
S   80.90.100.0 [1/0] via Gigabit 0/0/0
```

![Diagram bez názvu.jpg](5%20ot%C3%A1zka%20STATICK%C3%89%20A%20DYNAMICK%C3%89%20SM%C4%9AROV%C3%81N%C3%8D/Diagram_bez_nzvu.jpg)

# sumarizace cest (Agregace cest)

- čím menší směrovací tabulky, tím rychlejší je jejich prohledání
- můžeme nahradit několik cest, jednou cestou

### Můžeme nahradit pokud

1. sítě začínají stejně
2. používají stejné odchozí rozhraní

> ip route 172.16.1.0 255.255.255.0 Serial0/0/1
ip route172.16.2.0 255.255.255.0 Serial0/0/1
ip route172.16.3.0 255.255.255.0 Serial0/0/1
> 

> ip route 172.16.0.0 255.255.0.0, Serial0/0/1
> 

---

# nastavení a význam výchozí statické cesty

<aside>
⚠️

Gateway of last resort

</aside>

- speciální případ statické cesty
- cesta je využíván, pokud jiná cesta není schůdná

```jsx
R1#conf t
R1(config)#ip route 0.0.0.0 0.0.0.0 Gigabit 0/0/0
R1(config)#end
R1#show ip route
Codes: I - IGRP derived, R - RIP derived, O - OSPF derived
       C - connected, S - static, E - EGP derived, B - BGP derived
       * - candidate default route, IA - OSPF inter area route
       E1 - OSPF external type 1 route, E2 - OSPF external type 2 route
Gateway of last resort is 0.0.0.0 to network 0.0.0.0
C   1.0.0.0 is directly connected, Gigabit 0/0/0
```

# rozdělení dynamických směrovacích protokolů, princip dynamického směrování

## IGP (Interior Gateway Protocol)

> pro směrování v autonomních systémech
> 

### **Distance Vector**

1. **RIPv2**
2. **EIGRP**

### Link State

1. **OSPF**

## EGP (Exterior Gateway Protocol)

> pro směrování mezi autonomními systémy
> 
1. **BGP** (Border Gateway Protocol)

![image.png](5%20ot%C3%A1zka%20STATICK%C3%89%20A%20DYNAMICK%C3%89%20SM%C4%9AROV%C3%81N%C3%8D/image.png)

### IPv6 směrovací protokoly

RIPv2 → **RIPng**

EIGRP → **EIGRP for IPv6**

OSPF → **OSPFv3**

BGP → **BGP for IPv6**

# princip dynamického směrování

- pro snadnou a automatickou výměnu dat mezi routry
- automaticky se všechny routry vymění informace o nových cestách
- při změně topologie si routry přepočítají nejlepší cestu do vzdálené sítě

### směrovací protokoly dělají

1. objevení vzdálených sítí
2. údržba směrovacích tabulek
3. získání nejlepší cesty do vzdálených sítí
4. nalezení záložní cesty při výpadku stávající cesty

### komponenty

1. má svoji databázi v RAM paměti
2. algoritmus - matematický výpočet metriky
3. speciální zprávy pro sousední směrovače

### činnost

1. posílá a přijímá zprávy
2. sdílí informace o svých cestách a naučených cestách 
3. při zjištění změny, ohlásí změnu (advertise)

## princip IGP

- použití uvnitř směrovací domény
- pro výběr nejlepší cesty s metrikou

## princip EGP

- použití mezi směrovacími doménami
    - mezi ISP se používá BGP

## princip distance vektor

- každá cesta je ohlašována jako **vektor vzdálenosti**, **vzdálenost** a **směr**
- používá Bellman-Ford algoritmus
- nezná celou síť, ale zná vzdálenost a směr dané sítě
- použití pro jednodušší sítě
- pomalejší čas konvergence
- směrovače si periodicky posílají informace

## princip link-state

- směrovač si vytvoří celkovou mapu sítě
- všechny směrovače mají stejnou mapu sítě
- směrovače si posílají informace, pouze tehdy, když dojde k změně topologie
- použití pro hierarchické sítě
- rychlejší čas konvergence

---

# pojmy: metrika, administrativní vzdálenost, konvergence a load balancing

# Metrika

<aside>
💸

cena cesty do koncové sítě

</aside>

- mezi jednotlivými dynamickými protokoly nelze porovnávat metriky
    - RIP X OSPF
- pro případ, kdy má směrovač více záznamů do jedné koncové sítě
    - si vybere s nejnižší metrikou

### faktory pro vypočítaní metriky

- **RIP** = hop count
- **OSPF** (cost)=bandwidth
- **EIGRP** = bandwidth + delay + reliability + load
    - metrika se průběžně mění
    - **delay** = zpoždění linky
    - **reliability** = spolehlivost linky
    - **load** = zátěž linky

# Load balancing

- když do koncové sítě je více cest
- použijí se všechny cesty, aby se omezilo zátěže jedné linky
- mají stejnou metriku (**equal cost**)
- EIGRP umí používat linky, které nemají stejnou metriku (unequal cost)

# Administrativní vzdálenost (AD)

<aside>
⚠️

důvěryhodnost použitého protokolu do koncové sítě

</aside>

- odlišuje cesty, získané jinými směrovacími protokoly
- od 0 do 255
- když existuje do cílové sítě více cest, směrovač si vybere s nejnižším AD
- čím nižší, tím lepší
- **Connected** (přímo připojená) = 0
- **Static** = 1
- **EIGRP** = 90
- **OSPF** = 110
- **RIP** = 120

### použití statické cesty jako záložní cesty

- lze nastavit u statické cesty vyšší AD
- pokud používáme EIGRP (AD=90), můžeme nastavit STATIC (AD=150)
- pokud cesta získána EIGRP se odstraní, použije se záložní cesta s vyšším AD

```jsx
R1(config)#ip route 90.80.70.0 255.255.255.0 Serial 0/0/0 150
```

# Konvergence

- směrovače mají kompletní směrovací tabulky
- znají všechny cesty do přímo připojených a vzdálených sítí