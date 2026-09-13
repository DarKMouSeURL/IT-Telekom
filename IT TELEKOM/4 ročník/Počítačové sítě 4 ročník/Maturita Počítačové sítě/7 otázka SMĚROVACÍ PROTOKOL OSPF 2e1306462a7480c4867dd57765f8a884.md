# 7. otázka SMĚROVACÍ PROTOKOL OSPF

---

- popis a vlastnosti směrovacího protokolu OSPF (verze 2 a 3)
- charakteristika protokolů typu Link-state
- typy OSPF paketů, formát paketu směrovací aktualizace, metrika
- základní konfigurace protokolu, propagace defaultní statické cesty, ověření
- pojmy: router ID, designated router, backup designated router

---

# popis a vlastnosti směrovacího protokolu OSPF (verze 2 a 3)

<aside>
📌

**O**pen **S**hortest **P**ath **F**irst

</aside>

- následník RIP
- [link-state](../../../3%20ro%C4%8Dn%C3%ADk/Po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B%203%20ro%C4%8Dn%C3%ADk/Link-state%20dynamick%C3%A9%20protokoly%20199306462a7480e4bd8be8778feb80e7.md)
- bez-třídní směrovací protokol
- rychlá konvergence
- použití ve velkých sítích
- použití uvnitř autonomních systémech (*IGP*)

### verze 2

> **pro IPv4**
> 

### verze 3

> **pro IPv6**
> 

## Administrativní vzdálenost

<aside>
📌

Důvěryhodnost směrovacího protokolu

</aside>

> **AD** = 110
> 

---

# charakteristika protokolů typu Link-state

- sestavení celkové mapy sítě (**mapa topologie**)
    - sestavení cest do vzdálených sítí
- každý směrovač používá tuto mapu, pro určení cest
- směrovače posílají informace o linkách svým sousedům → navázání *link-state*
    - **info**: přímo připojené sítě, typ sítě, sousední směrovače
- každý směrovač si vytvoří vlastní mapu topologie
    - vypočítá si nejkratší cesty do vzdálených sítí
- použití ***E**dsger **D**ijkstra shortest path **F**irst* (SPF) algoritmus
- odeslání aktualizací, pouze při změně topologie
    - ***paranoid update***: každých 30 min. posílání aktualizací

### protokoly:

1. OSPF
2. IS-IS

## OSPF algoritmus

- databáze, obsahující ***Link state Advertisement*** od ostatních směrovačů
- po přijetí všech *Link state Advertisement, si směrovač vytvoří SPF strom*
    - *Link state Advertisement* = obsahuje linky uvnitř Link state Update
- podle SPF **stromu** si směrovač vybírá nejlepší cestu do vzdálené sítě

![image.png](7%20ot%C3%A1zka%20SM%C4%9AROVAC%C3%8D%20PROTOKOL%20OSPF/image.png)

---

# typy OSPF paketů, formát paketu směrovací aktualizace, metrika

## Hello (0x01)

- pro navázání a udržení sousedství (***adjacency***)

## Database Description (0x02)

- zkrácený (*abbreviated*) databázi linek
- kontrola linek příjemce
- synchronizace databází mezi směrovači

## Link state Request (0x03)

- žádost o doplnění k *Database Description (*specifický záznam*)*

## Link state Update (0x04)

- odpověď na Link *state Request paket*
- jsou různé typy Update paketu
- 11 typu ***link state Advertisement***
    - obsahují informace o linkách

## Link state Acknowledgment (0x05)

- potvrzení o přijetí Link *state Update* paketu

# formát paketu směrovací aktualizace

### záhlaví IP paketu

- ***Protocol field*** = **89** (OSPF)
- ***DESTINATION ADDRESS*** = multicast **224.0.0.5** nebo **224.0.0.6**
- záhlaví IP paketu
    
    ![image.png](7%20ot%C3%A1zka%20SM%C4%9AROVAC%C3%8D%20PROTOKOL%20OSPF/image%201.png)
    

### záhlaví rámce

- ***DESTINATION MAC*** = **01-00-5E**-00-00-05 nebo **01-00-5E**-00-00-06
- záhlaví rámce
    
    ![image.png](7%20ot%C3%A1zka%20SM%C4%9AROVAC%C3%8D%20PROTOKOL%20OSPF/image%202.png)
    

![image.png](7%20ot%C3%A1zka%20SM%C4%9AROVAC%C3%8D%20PROTOKOL%20OSPF/image%203.png)

# metrika

<aside>
⚠️

metrika = *cost*

</aside>

- počítá se podle ***bandwidth***

$$
10^{8}/bandwidth
$$

### stanovení ceny cesty

- součet všech cen na linkách mezi směrovačem a vzdálenou sítí
    
    ![image.png](7%20ot%C3%A1zka%20SM%C4%9AROVAC%C3%8D%20PROTOKOL%20OSPF/77d43a86-1498-4d1f-88fd-111598466bb2.png)
    

---

# základní konfigurace protokolu, propagace defaultní statické cesty, ověření

<aside>
📌

maska se píše jako wild karta
255.255.255.252 → 0.0.0.3

</aside>

<aside>
⚠️

pro všechny směrovače musí být stejné číslo *OSPF area* 

</aside>

```jsx
router(config)#router ospf 1
router(config-router)#network {network-IP} {wild-card-Mask} area {OSPF area}
```

```jsx
R1(config)#router ospf 1
R1(config-router)#network 1.0.0.0 0.255.255.255 area 1
R1(config-router)#network 2.0.0.0 0.0.0.3 area 1
R1(config-router)#network 3.0.0.0 0.0.0.3 area 1
```

```jsx
R2(config)#router ospf 1
R2(config-router)#network 3.0.0.0 0.0.0.3 area 1
R2(config-router)#network 4.0.0.0 0.0.0.3 area 1
```

```jsx
R3(config)#router ospf 1
R3(config-router)#network 2.0.0.0 0.0.0.3 area 1
R3(config-router)#network 3.0.0.0 0.0.0.3 area 1
```

![topologie OSPF](7%20ot%C3%A1zka%20SM%C4%9AROVAC%C3%8D%20PROTOKOL%20OSPF/image%204.png)

topologie OSPF

[OSPF.pkt](7%20ot%C3%A1zka%20SM%C4%9AROVAC%C3%8D%20PROTOKOL%20OSPF/OSPF.pkt)

# propagace defaultní statické cesty

```jsx
R1(config-router)#default-information originate
```

```jsx
R2#sh ip route
Codes: L - local, C - connected, S - static, R - RIP, M - mobile, B - BGP
       D - EIGRP, EX - EIGRP external, O - OSPF, IA - OSPF inter area
       N1 - OSPF NSSA external type 1, N2 - OSPF NSSA external type 2
       E1 - OSPF external type 1, E2 - OSPF external type 2, E - EGP
       i - IS-IS, L1 - IS-IS level-1, L2 - IS-IS level-2, ia - IS-IS inter area
       * - candidate default, U - per-user static route, o - ODR
       P - periodic downloaded static route

Gateway of last resort is 4.0.0.2 to network 0.0.0.0

     1.0.0.0/32 is subnetted, 1 subnets
O       1.0.0.1/32 [110/2] via 4.0.0.2, 00:05:54, GigabitEthernet0/0
     2.0.0.0/30 is subnetted, 1 subnets
O       2.0.0.0/30 [110/2] via 3.0.0.1, 00:05:54, GigabitEthernet0/1
                   [110/2] via 4.0.0.2, 00:05:54, GigabitEthernet0/0
     3.0.0.0/8 is variably subnetted, 2 subnets, 2 masks
C       3.0.0.0/30 is directly connected, GigabitEthernet0/1
L       3.0.0.2/32 is directly connected, GigabitEthernet0/1
     4.0.0.0/8 is variably subnetted, 2 subnets, 2 masks
C       4.0.0.0/30 is directly connected, GigabitEthernet0/0
L       4.0.0.1/32 is directly connected, GigabitEthernet0/0
O*E2 0.0.0.0/0 [110/1] via 4.0.0.2, 00:05:54, GigabitEthernet0/0
```

```jsx
R3#sh ip route
Codes: L - local, C - connected, S - static, R - RIP, M - mobile, B - BGP
       D - EIGRP, EX - EIGRP external, O - OSPF, IA - OSPF inter area
       N1 - OSPF NSSA external type 1, N2 - OSPF NSSA external type 2
       E1 - OSPF external type 1, E2 - OSPF external type 2, E - EGP
       i - IS-IS, L1 - IS-IS level-1, L2 - IS-IS level-2, ia - IS-IS inter area
       * - candidate default, U - per-user static route, o - ODR
       P - periodic downloaded static route

Gateway of last resort is 2.0.0.2 to network 0.0.0.0

     1.0.0.0/32 is subnetted, 1 subnets
O       1.0.0.1/32 [110/2] via 2.0.0.2, 00:07:28, GigabitEthernet0/0
     2.0.0.0/8 is variably subnetted, 2 subnets, 2 masks
C       2.0.0.0/30 is directly connected, GigabitEthernet0/0
L       2.0.0.1/32 is directly connected, GigabitEthernet0/0
     3.0.0.0/8 is variably subnetted, 2 subnets, 2 masks
C       3.0.0.0/30 is directly connected, GigabitEthernet0/1
L       3.0.0.1/32 is directly connected, GigabitEthernet0/1
     4.0.0.0/30 is subnetted, 1 subnets
O       4.0.0.0/30 [110/2] via 2.0.0.2, 00:07:28, GigabitEthernet0/0
                   [110/2] via 3.0.0.2, 00:07:28, GigabitEthernet0/1
O*E2 0.0.0.0/0 [110/1] via 2.0.0.2, 00:07:28, GigabitEthernet0/0
```

# ověření

## ověření show ip ospf neighbor

```jsx
R1#sh ip ospf neighbor 

Neighbor ID     Pri   State           Dead Time   Address         Interface
3.0.0.1           1   FULL/DR         00:00:33    2.0.0.1         GigabitEthernet0/0
4.0.0.1           1   FULL/DR         00:00:33    4.0.0.1         GigabitEthernet0/1
```

## ověření show ip protocols

```jsx
R1#sh ip protocols 

Routing Protocol is "ospf 1"
  Outgoing update filter list for all interfaces is not set 
  Incoming update filter list for all interfaces is not set 
  Router ID 1.0.0.1
  It is an autonomous system boundary router
  Redistributing External Routes from,
  Number of areas in this router is 1. 1 normal 0 stub 0 nssa
  Maximum path: 4
  Routing for Networks:
    1.0.0.0 0.255.255.255 area 1
    4.0.0.0 0.0.0.3 area 1
    2.0.0.0 0.0.0.3 area 1
  Routing Information Sources:  
    Gateway         Distance      Last Update 
    1.0.0.1              110      00:05:00
    3.0.0.1              110      00:05:00
    4.0.0.1              110      00:05:00
  Distance: (default is 110)
```

## ověření show ip ospf

```jsx
R1#show ip ospf 
 Routing Process "ospf 1" with ID 1.0.0.1
 Supports only single TOS(TOS0) routes
 Supports opaque LSA
 SPF schedule delay 5 secs, Hold time between two SPFs 10 secs
 Minimum LSA interval 5 secs. Minimum LSA arrival 1 secs
 Number of external LSA 1. Checksum Sum 0x000ec2
 Number of opaque AS LSA 0. Checksum Sum 0x000000
 Number of DCbitless external and opaque AS LSA 0
 Number of DoNotAge external and opaque AS LSA 0
 Number of areas in this router is 1. 1 normal 0 stub 0 nssa
 External flood list length 0
    Area 1
        Number of interfaces in this area is 3
        Area has no authentication
        SPF algorithm executed 2 times
        Area ranges are
        Number of LSA 6. Checksum Sum 0x028a1d
        Number of opaque link LSA 0. Checksum Sum 0x000000
        Number of DCbitless LSA 0
        Number of indication LSA 0
        Number of DoNotAge LSA 0
        Flood list length 0
```

---

# pojmy: router ID, designated router, backup designated router

# Router ID

<aside>
📌

jednoznačná identifikace routeru (IP adresa)

</aside>

### nastavení router ID

1. nastavením pomocí příkazu (manuálně)

```jsx
R1(config-router)#router-id {IP ADDRESS}
```

1. nejvyšší adresa nastavená na *LoopBack* (automaticky)
    1. pokud není nastavená pomocí příkazu *router-id*
2. nejvyšší adresa nastavená na aktivním fyzickém rozhraní
    1. pokud není nastaven žádný *LoopBack*

# designated router (DR)

- pověřený router pro sdílení aktualizací při změně topologie
- ostatní routery komunikují pro výměnu aktualizací pouze s DR
- rychlejší a snazší konvergence sítě
- předcházení zahlcení sítě

## proces výběru DR

> určuje se podle největší priority (0 - 255)
> 
- každý router má prioritu nastavenou no hodnotě 1
    - když je router nastavený na hodnotu 0 je ignorován v procesu
- pokud jsou některé routery shodné rozhodne Router ID

# backup designated router (BDR)

- záloha ***Designated router***
- 2. nejvyšší router s prioritou se stane BDR