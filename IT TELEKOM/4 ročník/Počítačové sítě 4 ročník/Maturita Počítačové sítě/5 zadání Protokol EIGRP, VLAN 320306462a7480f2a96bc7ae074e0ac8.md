# 5. zadání Protokol EIGRP, VLAN

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
router(config-router)#network {*network-IP*} {*wild-card-Mask*}
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
**D       3.0.0.0/30 [90/3072] via 4.0.0.1, 00:17:15, GigabitEthernet0/1
                   [90/3072] via 2.0.0.1, 00:16:50, GigabitEthernet0/0**
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

**D    1.0.0.0/8 [90/130816] via 4.0.0.2, 00:17:45, GigabitEthernet0/0
     2.0.0.0/30 is subnetted, 1 subnets
D       2.0.0.0/30 [90/3072] via 4.0.0.2, 00:17:45, GigabitEthernet0/0
                   [90/3072] via 3.0.0.1, 00:17:14, GigabitEthernet0/1**
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

**D    1.0.0.0/8 [90/130816] via 2.0.0.2, 00:17:40, GigabitEthernet0/0
     2.0.0.0/8 is variably subnetted, 2 subnets, 2 masks**
C       2.0.0.0/30 is directly connected, GigabitEthernet0/0
L       2.0.0.1/32 is directly connected, GigabitEthernet0/0
     3.0.0.0/8 is variably subnetted, 2 subnets, 2 masks
C       3.0.0.0/30 is directly connected, GigabitEthernet0/1
L       3.0.0.1/32 is directly connected, GigabitEthernet0/1
     4.0.0.0/30 is subnetted, 1 subnets
**D       4.0.0.0/30 [90/3072] via 3.0.0.2, 00:17:44, GigabitEthernet0/1
                   [90/3072] via 2.0.0.2, 00:17:40, GigabitEthernet0/0**
```

# propagace výchozí statické cesty

<aside>
📌

R1(config)#ip route 0.0.0.0 0.0.0.0 {*next-hop | interface}*

</aside>

```jsx
R1(config)#ip route 0.0.0.0 0.0.0.0 loopback 1 //nastavení jako výchozí bod z Autonomního systému
R1(config-router)#**redistribute static**
```

```jsx
R2#sh ip route
Codes: L - local, C - connected, S - static, R - RIP, M - mobile, B - BGP
       **D - EIGRP, EX - EIGRP external**, O - OSPF, IA - OSPF inter area
       N1 - OSPF NSSA external type 1, N2 - OSPF NSSA external type 2
       E1 - OSPF external type 1, E2 - OSPF external type 2, E - EGP
       i - IS-IS, L1 - IS-IS level-1, L2 - IS-IS level-2, ia - IS-IS inter area
       *** - candidate default**, U - per-user static route, o - ODR
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
**D*EX 0.0.0.0/0 [170/1282816] via 4.0.0.2, 00:00:10, GigabitEthernet0/0**
```

```jsx
R3#sh ip route
Codes: L - local, C - connected, S - static, R - RIP, M - mobile, B - BGP
       **D - EIGRP, EX - EIGRP external**, O - OSPF, IA - OSPF inter area
       N1 - OSPF NSSA external type 1, N2 - OSPF NSSA external type 2
       E1 - OSPF external type 1, E2 - OSPF external type 2, E - EGP
       i - IS-IS, L1 - IS-IS level-1, L2 - IS-IS level-2, ia - IS-IS inter area
       *** - candidate default**, U - per-user static route, o - ODR
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
**D*EX 0.0.0.0/0 [170/1282816] via 2.0.0.2, 00:00:40, GigabitEthernet0/0**
```

---

# konfigurace VLAN a směrování mezi nimi

# Router on stick

- je způsob směrování provozu mezi VLAN
- všechen provoz jde přes router
- musí se nastavit *sub-interface* na routeru
- přepínače pracují na vrstvě L2

![image.png](8%20ot%C3%A1zka%20P%C5%98EP%C3%8DNAN%C3%89%20S%C3%8DT%C4%9A/image%204.png)

# Konfigurace

![image.png](8%20ot%C3%A1zka%20P%C5%98EP%C3%8DNAN%C3%89%20S%C3%8DT%C4%9A/image%205.png)

[VLAN-router-on-stick.pkt](8%20ot%C3%A1zka%20P%C5%98EP%C3%8DNAN%C3%89%20S%C3%8DT%C4%9A/VLAN-router-on-stick.pkt)

## Konfigurace switch

```jsx
S1(config)#int range fa0/1-2
S1(config-if)#switchport mode access
S1(config-if)#switchport access vlan 10
S1(config-if)#int fa0/3
S1(config-if)#switchport mode access
S1(config-if)#switchport access vlan 20
S1(config-if)#int g0/1
S1(config-if)#switchport mode trunk
```

```jsx
S2(config)#int fa0/1
S2(config-if)#switchport mode access
S2(config-if)#switchport access vlan 10
S2(config-if)#int fa0/2
S2(config-if)#switchport mode access
S2(config-if)#switchport access vlan 20
S2(config-if)#int g0/1
S2(config-if)#switchport mode trunk
S2(config-if)#int g0/2
S2(config-if)#switchport mode trunk
```

## konfigurace router

```jsx
R1(config)#int g0/1
R1(config-if)#no sh
R1(config-if)#int g0/1.10
R1(config-if)#encapsulation dot1Q 10
R1(config-if)#ip add 23.1.10.1 255.255.255.0
R1(config-if)#int g0/1.20
R1(config-if)#encapsulation dot1Q 20
R1(config-if)#ip add 23.1.20.1 255.255.255.0
```

---

# DHCP

```jsx
R1(config)#ip dhcp excluded-address 3.0.0.1
R1(config)#ip dhcp pool DHCP
R1(dhcp-config)#network 3.0.0.0 255.0.0.0
R1(dhcp-config)#default-router 3.0.0.1
R1(dhcp-config)#dns-seever 8.8.8.8
```

```jsx
R1#show ip dhcp binding
IP address       Client-ID/              Lease expiration        Type
                 Hardware address
3.0.0.2          0001.4256.D43B           --                     Automatic
```

![image.png](../konfigurace%20maturita/image.png)

# SSH

```jsx
R1(config)#ip domain-name example.com
R1(config)#username admin password cisco.123
R1(config)#crypto key generate rsa
The name for the keys will be: R1.example.com
Choose the size of the key modulus in the range of 360 to 4096 for your
  General Purpose Keys. Choosing a key modulus greater than 512 may take
  a few minutes.

How many bits in the modulus [512]:**2048**
% Generating 2048 bit RSA keys, keys will be non-exportable...[OK]
R1(config)#line vty 0 4
R1(config-line)#login local
R1(config-line)#transport input ssh
R1(config-line)#exit
R1(config)#enable secret heslo
R1(config)#line con 0
R1(config-line)#password heslo
R1(config-line)#login
```

```jsx
C:\>ssh admin@3.0.0.1
```

---

# Vybrání více interfaců

- výběr více portů pro konfiguraci

```jsx
S1(config)#int range fa0/1-24
S1(config-if-range)#
```

# Přihlašovací zpráva

```jsx
S1(config)#banner login #zpráva#
```

![image.png](../zabezpe%C4%8Den%C3%AD%20SWITCH/image.png)

### Message of the day

```jsx
S1(config)#banner motd #zpráva#
```

![image.png](../zabezpe%C4%8Den%C3%AD%20SWITCH/image%201.png)

# Dokumentace

## Zobrazit zařízení, které si vyžádali IP adresu od routeru

```jsx
Router#show ip dhcp binding
```

## Zobrazit zkrácený výpis rozhraní router

```jsx
Router#show ip interface brief
```

## Výpis běhové konfigurace

```jsx
Router#show run
```

## Zobrazení cest do vzdálených a přímo připojených sítích

```jsx
Router#show ip route
```

## Výpis nastavení VLAN

```jsx
Router#sh vlan
```

## výsledek SSH

```jsx
C:/ssh admin@8.0.0.1
Router>
```

## screen konfigurace tp-link