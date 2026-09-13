# 6. otázka SMĚROVACÍ PROTOKOL EIGRP

---

- popis a vlastnosti směrovacího protokolu EIGRP (verze 2 a 6)
- formát zprávy a typy EIGRP zpráv, parametry metriky
- algoritmus DUAL, tabulka sousedů, tabulka topologie,
- pojmy: Successor, Feasible Successor, Feasible Distance, Feasible Condition
- základní konfigurace a ověření protokolu EIGRP, propagace výchozí statické cesty

---

# popis a vlastnosti směrovacího protokolu EIGRP (verze 2 a 6)

<aside>
💡

***E**nhanced **I**nterior **G**ateway **R**outing **P**rotocol*

</aside>

- dynamický směrovací protokol od Cisco
    - protokol lze používat i na ne-Cisco zařízeních
- automaticky propočítává nejlepší cestu do vzdálených sítí
- **Distance Vector** směrovací protokol
    - do vzdálených sítí ukazuje směr a vzdálenost
- navazuje sousedství se sousedícími směrovači (**adjacency**)
    - směrovač posílá periodicky *hello* pakety
- neposílá periodické aktualizace = menší zátěž sítě

### **AD**

- EIGRP summary route = 5
- **Internal EIGRP = 90**
- External EIGRP = 170

## verze 2

> **pro IPv4**
> 

## verze 6

> **pro IPv6**
> 

# formát zprávy a typy EIGRP zpráv, parametry metriky

![image.png](6%20ot%C3%A1zka%20SM%C4%9AROVAC%C3%8D%20PROTOKOL%20EIGRP/image.png)

### paket header

- u hlavičky paketu v sekci *Protocol* je hodnota 88
- u *DESTINATION ADDRESS* se používá 224.0.0.10 (multicast)
- hlavička paketu
    
    ![1737094971957751345231497965827.png](6%20ot%C3%A1zka%20SM%C4%9AROVAC%C3%8D%20PROTOKOL%20EIGRP/1737094971957751345231497965827.png)
    

### rámec header

- *DESTINATION MAC* má hodnotu **01-00-5E**-XX-XX-XX
    - prvních 6 hexadecimálních čísel musí začínat **01-00-5E**-00-00-0A
- hlavička rámce
    
    ![image.png](6%20ot%C3%A1zka%20SM%C4%9AROVAC%C3%8D%20PROTOKOL%20EIGRP/image%201.png)
    

## hlavička EIGRP paketu

### opcode

- 1 - **aktualizace** (update)
- 2 – **potvrzení** (acknowledgment)
- 3 – **dotaz** (query)
- 4 – **odpověď** (reply)
- 5 – **kontaktní** (hello)

### Autonomous System numbers

- určuje směrovací proces (určitá relaci)
- na routru může běžet zároveň několik relací

### TLV (Type/Lenght/Values)

> obsah podle typu zprávy
> 
- ***EIGRP parametry***

- **IP vnitřní cesty (IP internal routes)**

- **IP vnější cesty (IP external routes)**

![image.png](6%20ot%C3%A1zka%20SM%C4%9AROVAC%C3%8D%20PROTOKOL%20EIGRP/image%202.png)

# typy EIGRP zpráv

### Hello paket

<aside>
💡

soused pro EIGRP je směrovač přímo připojený a nakonfigurovaný s EIGRP se stejnou AS

</aside>

- objevení sousedství
- příjem od sousedů hello pakety = linka je aktivní
- ***HOLD TIME*** = čas čekání na hello paket
    - většinou 3x hello interval
    - překročení času = linka je neaktivní
    - hledá se nová cesta do vzdálené sítě
- odesílání paket multicast 224.0.0.10
- **ne**spolehlivé doručení

### Update paket

> propagace směrovacích informací
> 
- posílají se při změně topologie nebo změně metriky

**bounded** (neposílají se všem směrovačům)

**partial** (neposílají se všechny cesty, ale jenom potřebné)

- spolehlivé doručení

### Acknowledgement paket

- odpověď na spolehlivé doručení
- použití pro (*update, query a reply*)
- unicast
- obsahuje potvrzovací číslo

### **Reply paket**

- spolehlivé doručení
- odpověď s informacemi o sítich
- unicast
- potvrzení o doručení (Ackowledgement paket)

### **Query paket**

- spolehlivé doručení
- žádost o informace o sítích
- multicast

# parametry metriky

**počítá se z:**

1. ***bandwidth** *(šířka pásma)
    1. rychlost nejpomalejší linky do cílové sítě
2. ***delay*** (zpoždění)
    1. zpoždění linek do cílové sítě
3. *reliability* (spolehlivost)
4. *load* (zátěž linky)

> defaultně se používá pouze **bandwidth a delay,** ostatní metriky se nepoužívají
> 

## Změna metriky

- změna počítání metriky se počítá pomocí vah (***weights***)
- je doporučeno nechat na výchozích hodnotách

| **váha** | **výchozí hodnota** |
| --- | --- |
| **K1** | 1 |
| K2 | 0 |
| **K3** | 1 |
| K4 | 0 |
| K5 | 0 |

## počítání metriky

> výchozí počítání
> 

$$
metric = [K1*bandwidth + K3*delay]
$$

$$
(10,000,000/bandwidth)*256+(\sum_{}^{}delay/10)*256
$$

- při nastavení všech vah na ‘1’
    
    $$
    metric =[k1*bandwidth + (K2*bandwidth)/(256-delay)+K3*delay]*[K5/(realibility+K4)]
    $$
    

---

# algoritmus DUAL, tabulka sousedů, tabulka topologie,

## algoritmus DUAL (Diffusing Update ALgorithm)

> **best loop-free path
best loop-free backup paths**
> 
- určení nejlepší cesty do vzdálené sítě
- rychlá konvergence
    - kvůli před-vypočítaných záložních cest
    - kvůli **partial** (neposílají se všechny cesty, ale jenom potřebné)

## Tabulka směrovací

- směrovací tabulka se záznamy EIGRP (**D**)
- nejlepší cesty do vzdálených sítí

## tabulka sousedů

> informace o sousedících routrech (**adjacency**)
> 

```jsx
Router#show ip eigrp neighbors
IP-EIGRP Neighbors for process 1
Address                 Interface     Holdtime Uptime   Q      Seq  SRTT  RTO
                                      (secs)   (h:m:s)  Count  Num  (ms)  (ms)
160.89.81.28            Ethernet1     13       0:00:41  0      11   4     20
160.89.80.28            Ethernet0     14       0:02:01  0      10   12    24
160.89.80.31            Ethernet0     12       0:02:02  0      4    5     20
```

## tabulka topologie

- obsahuje všechny ohlášené cesty

![image.png](6%20ot%C3%A1zka%20SM%C4%9AROVAC%C3%8D%20PROTOKOL%20EIGRP/image%203.png)

---

# pojmy: Successor, Feasible Successor, Feasible Distance, Feasible Condition

# Successor (následník)

- směrovač, přes něhož bude posílána komunikace do cílové sítě
- ve **směrovací** tabulce jako *next hop*

# Feasible Successor (přípustný následník)

- sousedící směrovač, který má *loop-free* cestu do stejné cílové sítě jako *successor*
- musí splňovat podmínky přípustnosti (***feasibility condition***)

# FEASIBLE Distance (přípustná vzdálenost)

- nejnižší **metrika** do cílové sítě
- je ve **směrovací** i **topologické** tabulce

# FEASIBLE CONDITION (podmínka přípustnosti)

- podmínka, když sousední směrovač má menší vzdálenost (*reported distance*) než moje *feasible distance*
    
    *reported distance* - je metrika, kterou jsme dostali od souseda
    
- pokud není *feasible successor*, v tabulce topologie nevytvoří se záložní cesta
- důležité pro vytvoření loop-free záložní cestu

---

# základní konfigurace a ověření protokolu EIGRP, propagace výchozí statické cesty

<aside>
📌

maska se píše jako wild karta
255.255.255.252 → 0.0.0.3

</aside>

<aside>
⚠️

pro všechny směrovače musí být stejné číslo AS (*Autonomous system*)

</aside>

```jsx
router(config)#router eigrp 1
router(config-router)#network {network-IP} {wild-card-Mask}
```

```jsx
R1(config)#router eigrp 1
R1(config-router)#network 1.0.0.0 0.255.255.255
R1(config-router)#network 2.0.0.0 0.0.0.3
R1(config-router)#network 3.0.0.0 0.0.0.3
```

```jsx
R2(config)#router eigrp 1
R2(config-router)#network 3.0.0.0 0.0.0.3
R2(config-router)#network 4.0.0.0 0.0.0.3
```

```jsx
R3(config)#router eigrp 1
R3(config-router)#network 2.0.0.0 0.0.0.3
R3(config-router)#network 3.0.0.0 0.0.0.3
```

![topologie EIGRP](6%20ot%C3%A1zka%20SM%C4%9AROVAC%C3%8D%20PROTOKOL%20EIGRP/image%204.png)

topologie EIGRP

[EIGRP.pkt](6%20ot%C3%A1zka%20SM%C4%9AROVAC%C3%8D%20PROTOKOL%20EIGRP/EIGRP.pkt)

# ověření protokolu EIGRP

### Pomocí ip route

```jsx
R1>en
R1#sh ip route
Codes: L - local, C - connected, S - static, R - RIP, M - mobile, B - BGP
       D - EIGRP, EX - EIGRP external, O - OSPF, IA - OSPF inter area
       N1 - OSPF NSSA external type 1, N2 - OSPF NSSA external type 2
       E1 - OSPF external type 1, E2 - OSPF external type 2, E - EGP
       i - IS-IS, L1 - IS-IS level-1, L2 - IS-IS level-2, ia - IS-IS inter area
       * - candidate default, U - per-user static route, o - ODR
       P - periodic downloaded static route

Gateway of last resort is not set

     1.0.0.0/8 is variably subnetted, 2 subnets, 2 masks
C       1.0.0.0/8 is directly connected, Loopback1
L       1.0.0.1/32 is directly connected, Loopback1
     2.0.0.0/8 is variably subnetted, 2 subnets, 2 masks
C       2.0.0.0/30 is directly connected, GigabitEthernet0/0
L       2.0.0.2/32 is directly connected, GigabitEthernet0/0
     3.0.0.0/30 is subnetted, 1 subnets
D       3.0.0.0/30 [90/3072] via 4.0.0.1, 00:17:15, GigabitEthernet0/1
                   [90/3072] via 2.0.0.1, 00:16:50, GigabitEthernet0/0
     4.0.0.0/8 is variably subnetted, 2 subnets, 2 masks
C       4.0.0.0/30 is directly connected, GigabitEthernet0/1
L       4.0.0.2/32 is directly connected, GigabitEthernet0/1
```

```jsx
R2>en
R2#sh ip route
Codes: L - local, C - connected, S - static, R - RIP, M - mobile, B - BGP
       D - EIGRP, EX - EIGRP external, O - OSPF, IA - OSPF inter area
       N1 - OSPF NSSA external type 1, N2 - OSPF NSSA external type 2
       E1 - OSPF external type 1, E2 - OSPF external type 2, E - EGP
       i - IS-IS, L1 - IS-IS level-1, L2 - IS-IS level-2, ia - IS-IS inter area
       * - candidate default, U - per-user static route, o - ODR
       P - periodic downloaded static route

Gateway of last resort is not set

D    1.0.0.0/8 [90/130816] via 4.0.0.2, 00:17:45, GigabitEthernet0/0
     2.0.0.0/30 is subnetted, 1 subnets
D       2.0.0.0/30 [90/3072] via 4.0.0.2, 00:17:45, GigabitEthernet0/0
                   [90/3072] via 3.0.0.1, 00:17:14, GigabitEthernet0/1
     3.0.0.0/8 is variably subnetted, 2 subnets, 2 masks
C       3.0.0.0/30 is directly connected, GigabitEthernet0/1
L       3.0.0.2/32 is directly connected, GigabitEthernet0/1
     4.0.0.0/8 is variably subnetted, 2 subnets, 2 masks
C       4.0.0.0/30 is directly connected, GigabitEthernet0/0
L       4.0.0.1/32 is directly connected, GigabitEthernet0/0
```

```jsx
R3>en
R3#sh ip route
Codes: L - local, C - connected, S - static, R - RIP, M - mobile, B - BGP
       D - EIGRP, EX - EIGRP external, O - OSPF, IA - OSPF inter area
       N1 - OSPF NSSA external type 1, N2 - OSPF NSSA external type 2
       E1 - OSPF external type 1, E2 - OSPF external type 2, E - EGP
       i - IS-IS, L1 - IS-IS level-1, L2 - IS-IS level-2, ia - IS-IS inter area
       * - candidate default, U - per-user static route, o - ODR
       P - periodic downloaded static route

Gateway of last resort is not set

D    1.0.0.0/8 [90/130816] via 2.0.0.2, 00:17:40, GigabitEthernet0/0
     2.0.0.0/8 is variably subnetted, 2 subnets, 2 masks
C       2.0.0.0/30 is directly connected, GigabitEthernet0/0
L       2.0.0.1/32 is directly connected, GigabitEthernet0/0
     3.0.0.0/8 is variably subnetted, 2 subnets, 2 masks
C       3.0.0.0/30 is directly connected, GigabitEthernet0/1
L       3.0.0.1/32 is directly connected, GigabitEthernet0/1
     4.0.0.0/30 is subnetted, 1 subnets
D       4.0.0.0/30 [90/3072] via 3.0.0.2, 00:17:44, GigabitEthernet0/1
                   [90/3072] via 2.0.0.2, 00:17:40, GigabitEthernet0/0
```

### Pomocí ip eigrp neighbors

> ověření, že sousední směrovače jsou ve stejném AS
> 

```jsx
R1#sh ip eigrp neighbors 
IP-EIGRP neighbors for process 1
H   Address         Interface      Hold Uptime    SRTT   RTO   Q   Seq
                                   (sec)          (ms)        Cnt  Num
0   4.0.0.1         Gig0/1         13   00:00:10  40     1000  0   6
1   2.0.0.1         Gig0/0         13   00:00:10  40     1000  0   8

```

## Pomocí ip protocols

```jsx
R1#sh ip protocols 
Routing Protocol is "eigrp  1 " 
  Outgoing update filter list for all interfaces is not set 
  Incoming update filter list for all interfaces is not set 
  Default networks flagged in outgoing updates  
  Default networks accepted from incoming updates 
  Redistributing: eigrp 1
  EIGRP-IPv4 Protocol for AS(1)
    Metric weight K1=1, K2=0, K3=1, K4=0, K5=0
    NSF-aware route hold timer is 240
    Router-ID: 1.0.0.1
    Topology : 0 (base)
      Active Timer: 3 min
      Distance: internal 90 external 170
      Maximum path: 4
      Maximum hopcount 100
      Maximum metric variance 1

  Automatic Summarization: disabled
  Automatic address summarization: 
  Maximum path: 4
  Routing for Networks:  
     1.0.0.0
     4.0.0.0/30
     2.0.0.0/30
  Routing Information Sources:  
    Gateway         Distance      Last Update 
    4.0.0.1         90            0          
    2.0.0.1         90            101        
  Distance: internal 90 external 170
```

# propagace výchozí statické cesty

<aside>
📌

R1(config)#ip route 0.0.0.0 0.0.0.0 {*next-hop | interface}*

</aside>

```jsx
R1(config)#ip route 0.0.0.0 0.0.0.0 loopback 1 //nastavení jako výchozí bod z Autonomního systému
R1(config)#router eigrp 1
R1(config-router)#redistribute static
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

D    1.0.0.0/8 [90/130816] via 4.0.0.2, 00:11:30, GigabitEthernet0/0
     2.0.0.0/30 is subnetted, 1 subnets
D       2.0.0.0/30 [90/3072] via 3.0.0.1, 00:11:30, GigabitEthernet0/1
                   [90/3072] via 4.0.0.2, 00:11:30, GigabitEthernet0/0
     3.0.0.0/8 is variably subnetted, 2 subnets, 2 masks
C       3.0.0.0/30 is directly connected, GigabitEthernet0/1
L       3.0.0.2/32 is directly connected, GigabitEthernet0/1
     4.0.0.0/8 is variably subnetted, 2 subnets, 2 masks
C       4.0.0.0/30 is directly connected, GigabitEthernet0/0
L       4.0.0.1/32 is directly connected, GigabitEthernet0/0
D*EX 0.0.0.0/0 [170/1282816] via 4.0.0.2, 00:00:10, GigabitEthernet0/0
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

D    1.0.0.0/8 [90/130816] via 2.0.0.2, 00:12:00, GigabitEthernet0/0
     2.0.0.0/8 is variably subnetted, 2 subnets, 2 masks
C       2.0.0.0/30 is directly connected, GigabitEthernet0/0
L       2.0.0.1/32 is directly connected, GigabitEthernet0/0
     3.0.0.0/8 is variably subnetted, 2 subnets, 2 masks
C       3.0.0.0/30 is directly connected, GigabitEthernet0/1
L       3.0.0.1/32 is directly connected, GigabitEthernet0/1
     4.0.0.0/30 is subnetted, 1 subnets
D       4.0.0.0/30 [90/3072] via 3.0.0.2, 00:12:00, GigabitEthernet0/1
                   [90/3072] via 2.0.0.2, 00:12:00, GigabitEthernet0/0
D*EX 0.0.0.0/0 [170/1282816] via 2.0.0.2, 00:00:40, GigabitEthernet0/0
```