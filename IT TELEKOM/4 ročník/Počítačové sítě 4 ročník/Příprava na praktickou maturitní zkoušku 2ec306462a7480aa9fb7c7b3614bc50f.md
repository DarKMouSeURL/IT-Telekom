# Příprava na praktickou maturitní zkoušku

- konfigurace interface na routrech
- nastavení VLAN
- nastavení loopback na routru
- nastavení subinterfacu na routru
- konfigurace trunk a access linek

---

# Konfigurace IPv4 na všech interface

## Nastavení PC

![image.png](P%C5%99%C3%ADprava%20na%20praktickou%20maturitn%C3%AD%20zkou%C5%A1ku/image.png)

![image.png](P%C5%99%C3%ADprava%20na%20praktickou%20maturitn%C3%AD%20zkou%C5%A1ku/image%201.png)

![image.png](P%C5%99%C3%ADprava%20na%20praktickou%20maturitn%C3%AD%20zkou%C5%A1ku/image%202.png)

## Nastavení SWITCH

```jsx
switch>en
switch#conf t
switch(config)#hostname S11
S11(config)#int VLAN1
S11(config-if)#ip add 18.19.20.99 255.255.255.0
S11(config-if)#no sh
```

```jsx
switch>en
switch#conf t
switch(config)#hostname S12
S12(config)#vlan 10
S12(config-vlan)#vlan 20
S12(config-vlan)#ex
S12(config)#int g1/0/24
S12(config-if)#switchport mode trunk
S12(config-if)#int g1/0/1
S12(config-if)#switchport mode access
S12(config-if)#switchport access vlan 10
S12(config-if)#int g1/0/3
S12(config-if)#switchport mode trunk
~~S12(config-if)#switchport nonegotiate~~
```

```jsx
switch>en
switch#conf t
switch(config)#hostname S13
S13(config)#vlan 10
S13(config-vlan)#vlan 20
S13(config-vlan)#ex
S13(config)#int g1/0/1
S13(config-if)#switchport mode access
S13(config-if)#switchport access vlan 20
S13(config-if)#int g1/0/3
S13(config-if)#switchport mode trunk
~~S12(config-if)#switchport nonegotiate~~
```

## Nastavení ROUTER

```jsx
router>en
router#conf t
router(config)#hostname R11
R11(config)#int g0/0/1
R11(config-if)#ip add 18.19.20.1 255.255.255.0
R11(config-if)#no sh
R11(config-if)#int loop 0
R11(config-if)#ip add 1.0.0.1 255.0.0.0
R11(config-if)#int g0/0/0
R11(config-if)#ip add 4.0.0.1 255.255.255.252
R11(config-if)#no sh
```

```jsx
router>en
router#conf t
router(config)#hostname R12
R12(conig)#int g0/0/1
R12(config-if)#ip add 4.0.0.2 255.255.255.252
R12(config-if)#no sh
R12(config-if)#int loop 0
R12(config-if)#ip add 2.0.0.1 255.0.0.0
R12(config-if)#int g0/0/0
R12(config-if)#ip add 4.0.0.5 255.255.255.252
R12(config-if)#no sh
```

```jsx
router>en
router#conf t
router(config)#hostname R13
R13(config)#int g0/0/1
R13(coinfig-if)#ip add 4.0.0.6 255.255.255.252
R13(coinfig-if)#no sh
R13(coinfig-if)#int loop 0
R13(coinfig-if)#ip add 3.0.0.1 255.0.0.0
R13(coinfig-if)#int loop 1
R13(coinfig-if)#ip add 13.0.0.1 255.0.0.0
R13(coinfig-if)#int g0/0/0
R13(coinfig-if)#no sh
R13(coinfig-if)#int g0/0/0.10
R13(coinfig-if)#encapsulation dot1Q 10
R13(coinfig-if)#ip add 25.0.10.1 255.255.255.0
R13(coinfig-if)#int g0/0/0.20
R13(coinfig-if)#encapsulation dot1Q 20
R13(coinfig-if)#ip add 25.0.20.1 255.255.255.0
```

# Konfigurace OSPF

```jsx
R11(config)#router ospf 1
R11(config-router)#network 18.19.20.0 0.0.0.255 area 0
R11(config-router)#network 1.0.0.0 0.255.255.255 area 0
R11(config-router)#network 4.0.0.0 0.0.0.3 area 0
R11(config-router)#end
R11#sh ip route
Codes: L - local, C - connected, S - static, R - RIP, M - mobile, B - BGP
       D - EIGRP, EX - EIGRP external, O - OSPF, IA - OSPF inter area
       N1 - OSPF NSSA external type 1, N2 - OSPF NSSA external type 2
       E1 - OSPF external type 1, E2 - OSPF external type 2, E - EGP
       i - IS-IS, L1 - IS-IS level-1, L2 - IS-IS level-2, ia - IS-IS inter area
       * - candidate default, U - per-user static route, o - ODR
       P - periodic downloaded static route

Gateway of last resort is not set

     1.0.0.0/8 is variably subnetted, 2 subnets, 2 masks
C       1.0.0.0/8 is directly connected, Loopback0
L       1.0.0.1/32 is directly connected, Loopback0
     2.0.0.0/32 is subnetted, 1 subnets
O       2.0.0.1/32 [110/2] via 4.0.0.2, 00:13:16, GigabitEthernet0/0/0
     3.0.0.0/32 is subnetted, 1 subnets
O       3.0.0.1/32 [110/3] via 4.0.0.2, 00:12:42, GigabitEthernet0/0/0
     4.0.0.0/8 is variably subnetted, 3 subnets, 2 masks
C       4.0.0.0/30 is directly connected, GigabitEthernet0/0/0
L       4.0.0.1/32 is directly connected, GigabitEthernet0/0/0
O       4.0.0.4/30 [110/2] via 4.0.0.2, 00:12:52, GigabitEthernet0/0/0
     13.0.0.0/32 is subnetted, 1 subnets
O       13.0.0.1/32 [110/3] via 4.0.0.2, 00:12:42, GigabitEthernet0/0/0
     18.0.0.0/8 is variably subnetted, 2 subnets, 2 masks
C       18.19.20.0/24 is directly connected, GigabitEthernet0/0/1
L       18.19.20.1/32 is directly connected, GigabitEthernet0/0/1
     25.0.0.0/24 is subnetted, 2 subnets
O       25.0.10.0/24 [110/3] via 4.0.0.2, 00:12:10, GigabitEthernet0/0/0
O       25.0.20.0/24 [110/3] via 4.0.0.2, 00:12:10, GigabitEthernet0/0/0
```

```jsx
R12(config)#router ospf 1
R12(config-router)#network 4.0.0.0 0.0.0.3 area 0
R12(config-router)#network 2.0.0.0 0.255.255.255 area 0
R12(config-router)#network 4.0.0.4 0.0.0.3 area 0
R12(config-router)#end
R12#sh ip route
Codes: L - local, C - connected, S - static, R - RIP, M - mobile, B - BGP
       D - EIGRP, EX - EIGRP external, O - OSPF, IA - OSPF inter area
       N1 - OSPF NSSA external type 1, N2 - OSPF NSSA external type 2
       E1 - OSPF external type 1, E2 - OSPF external type 2, E - EGP
       i - IS-IS, L1 - IS-IS level-1, L2 - IS-IS level-2, ia - IS-IS inter area
       * - candidate default, U - per-user static route, o - ODR
       P - periodic downloaded static route

Gateway of last resort is not set

     1.0.0.0/32 is subnetted, 1 subnets
O       1.0.0.1/32 [110/2] via 4.0.0.1, 00:13:50, GigabitEthernet0/0/1
     2.0.0.0/8 is variably subnetted, 2 subnets, 2 masks
C       2.0.0.0/8 is directly connected, Loopback0
L       2.0.0.1/32 is directly connected, Loopback0
     3.0.0.0/32 is subnetted, 1 subnets
O       3.0.0.1/32 [110/2] via 4.0.0.6, 00:13:15, GigabitEthernet0/0/0
     4.0.0.0/8 is variably subnetted, 4 subnets, 2 masks
C       4.0.0.0/30 is directly connected, GigabitEthernet0/0/1
L       4.0.0.2/32 is directly connected, GigabitEthernet0/0/1
C       4.0.0.4/30 is directly connected, GigabitEthernet0/0/0
L       4.0.0.5/32 is directly connected, GigabitEthernet0/0/0
     13.0.0.0/32 is subnetted, 1 subnets
O       13.0.0.1/32 [110/2] via 4.0.0.6, 00:13:15, GigabitEthernet0/0/0
     18.0.0.0/24 is subnetted, 1 subnets
O       18.19.20.0/24 [110/2] via 4.0.0.1, 00:13:50, GigabitEthernet0/0/1
     25.0.0.0/24 is subnetted, 2 subnets
O       25.0.10.0/24 [110/2] via 4.0.0.6, 00:12:47, GigabitEthernet0/0/0
O       25.0.20.0/24 [110/2] via 4.0.0.6, 00:12:47, GigabitEthernet0/0/0
```

```jsx
R13(config)#router ospf 1
R13(config-router)#network 4.0.0.4 0.0.0.3 area 0
R13(config-router)#network 3.0.0.0 0.255.255.255 area 0
R13(config-router)#network 13.0.0.0 0.255.255.255 area 0
R13(config-router)#network 25.0.10.0 0.0.0.255 area 0
R13(config-router)#network 25.0.20.0 0.0.0.255 area 0
R13(config-router)#end
R13#sh ip route
Codes: L - local, C - connected, S - static, R - RIP, M - mobile, B - BGP
       D - EIGRP, EX - EIGRP external, O - OSPF, IA - OSPF inter area
       N1 - OSPF NSSA external type 1, N2 - OSPF NSSA external type 2
       E1 - OSPF external type 1, E2 - OSPF external type 2, E - EGP
       i - IS-IS, L1 - IS-IS level-1, L2 - IS-IS level-2, ia - IS-IS inter area
       * - candidate default, U - per-user static route, o - ODR
       P - periodic downloaded static route

Gateway of last resort is not set

     1.0.0.0/32 is subnetted, 1 subnets
O       1.0.0.1/32 [110/3] via 4.0.0.5, 00:13:48, GigabitEthernet0/0/1
     2.0.0.0/32 is subnetted, 1 subnets
O       2.0.0.1/32 [110/2] via 4.0.0.5, 00:13:48, GigabitEthernet0/0/1
     3.0.0.0/8 is variably subnetted, 2 subnets, 2 masks
C       3.0.0.0/8 is directly connected, Loopback0
L       3.0.0.1/32 is directly connected, Loopback0
     4.0.0.0/8 is variably subnetted, 3 subnets, 2 masks
O       4.0.0.0/30 [110/2] via 4.0.0.5, 00:13:48, GigabitEthernet0/0/1
C       4.0.0.4/30 is directly connected, GigabitEthernet0/0/1
L       4.0.0.6/32 is directly connected, GigabitEthernet0/0/1
     13.0.0.0/8 is variably subnetted, 2 subnets, 2 masks
C       13.0.0.0/8 is directly connected, Loopback1
L       13.0.0.1/32 is directly connected, Loopback1
     18.0.0.0/24 is subnetted, 1 subnets
O       18.19.20.0/24 [110/3] via 4.0.0.5, 00:13:48, GigabitEthernet0/0/1
     25.0.0.0/8 is variably subnetted, 4 subnets, 2 masks
C       25.0.10.0/24 is directly connected, GigabitEthernet0/0/0.10
L       25.0.10.1/32 is directly connected, GigabitEthernet0/0/0.10
C       25.0.20.0/24 is directly connected, GigabitEthernet0/0/0.20
L       25.0.20.1/32 is directly connected, GigabitEthernet0/0/0.20
```

# Konfigurace EIGRP

```jsx
R11(config)#no router ospf 1
R11(config)#router eigrp 1
R11(config-router)#network 18.19.20.0 0.0.0.255
R11(config-router)#network 1.0.0.0 0.255.255.255
R11(config-router)#network 4.0.0.0 0.0.0.3
R11(config-router)#end
R11#sh ip route
Codes: L - local, C - connected, S - static, R - RIP, M - mobile, B - BGP
       D - EIGRP, EX - EIGRP external, O - OSPF, IA - OSPF inter area
       N1 - OSPF NSSA external type 1, N2 - OSPF NSSA external type 2
       E1 - OSPF external type 1, E2 - OSPF external type 2, E - EGP
       i - IS-IS, L1 - IS-IS level-1, L2 - IS-IS level-2, ia - IS-IS inter area
       * - candidate default, U - per-user static route, o - ODR
       P - periodic downloaded static route

Gateway of last resort is not set

     1.0.0.0/8 is variably subnetted, 2 subnets, 2 masks
C       1.0.0.0/8 is directly connected, Loopback0
L       1.0.0.1/32 is directly connected, Loopback0
D    2.0.0.0/8 [90/130816] via 4.0.0.2, 00:06:03, GigabitEthernet0/0/0
D    3.0.0.0/8 [90/131072] via 4.0.0.2, 00:05:14, GigabitEthernet0/0/0
     4.0.0.0/8 is variably subnetted, 4 subnets, 3 masks
D       4.0.0.0/8 is a summary, 00:06:48, Null0
C       4.0.0.0/30 is directly connected, GigabitEthernet0/0/0
L       4.0.0.1/32 is directly connected, GigabitEthernet0/0/0
D       4.0.0.4/30 [90/3072] via 4.0.0.2, 00:05:56, GigabitEthernet0/0/0
D    13.0.0.0/8 [90/131072] via 4.0.0.2, 00:05:02, GigabitEthernet0/0/0
     18.0.0.0/8 is variably subnetted, 3 subnets, 3 masks
D       18.0.0.0/8 is a summary, 00:06:48, Null0
C       18.19.20.0/24 is directly connected, GigabitEthernet0/0/1
L       18.19.20.1/32 is directly connected, GigabitEthernet0/0/1
D    25.0.0.0/8 [90/28672] via 4.0.0.2, 00:04:27, GigabitEthernet0/0/0
```

```jsx
R12(config)#no router ospf 1
R12(config)#router eigrp 1
R12(config-router)#network 4.0.0.0 0.0.0.3
R12(config-router)#network 2.0.0.0 0.255.255.255
R12(config-router)#network 4.0.0.4 0.0.0.3
R12(config-router)#end
R12#sh ip route
Codes: L - local, C - connected, S - static, R - RIP, M - mobile, B - BGP
       D - EIGRP, EX - EIGRP external, O - OSPF, IA - OSPF inter area
       N1 - OSPF NSSA external type 1, N2 - OSPF NSSA external type 2
       E1 - OSPF external type 1, E2 - OSPF external type 2, E - EGP
       i - IS-IS, L1 - IS-IS level-1, L2 - IS-IS level-2, ia - IS-IS inter area
       * - candidate default, U - per-user static route, o - ODR
       P - periodic downloaded static route

Gateway of last resort is not set

D    1.0.0.0/8 [90/130816] via 4.0.0.1, 00:07:16, GigabitEthernet0/0/1
     2.0.0.0/8 is variably subnetted, 2 subnets, 2 masks
C       2.0.0.0/8 is directly connected, Loopback0
L       2.0.0.1/32 is directly connected, Loopback0
D    3.0.0.0/8 [90/130816] via 4.0.0.6, 00:06:11, GigabitEthernet0/0/0
     4.0.0.0/8 is variably subnetted, 5 subnets, 3 masks
D       4.0.0.0/8 is a summary, 00:06:59, Null0
C       4.0.0.0/30 is directly connected, GigabitEthernet0/0/1
L       4.0.0.2/32 is directly connected, GigabitEthernet0/0/1
C       4.0.0.4/30 is directly connected, GigabitEthernet0/0/0
L       4.0.0.5/32 is directly connected, GigabitEthernet0/0/0
D    13.0.0.0/8 [90/130816] via 4.0.0.6, 00:05:58, GigabitEthernet0/0/0
D    18.0.0.0/8 [90/3072] via 4.0.0.1, 00:07:16, GigabitEthernet0/0/1
D    25.0.0.0/8 [90/28416] via 4.0.0.6, 00:05:23, GigabitEthernet0/0/0
```

```jsx
R13(config)#no router ospf 1
R13(config)#router eigrp 1
R13(config-router)#network 4.0.0.4 0.0.0.3
R13(config-router)#network 3.0.0.0 0.255.255.255
R13(config-router)#network 13.0.0.0 0.255.255.255
R13(config-router)#network 25.0.10.0 0.0.0.255
R13(config-router)#network 25.0.20.0 0.0.0.255
R13#sh ip route
Codes: L - local, C - connected, S - static, R - RIP, M - mobile, B - BGP
       D - EIGRP, EX - EIGRP external, O - OSPF, IA - OSPF inter area
       N1 - OSPF NSSA external type 1, N2 - OSPF NSSA external type 2
       E1 - OSPF external type 1, E2 - OSPF external type 2, E - EGP
       i - IS-IS, L1 - IS-IS level-1, L2 - IS-IS level-2, ia - IS-IS inter area
       * - candidate default, U - per-user static route, o - ODR
       P - periodic downloaded static route

Gateway of last resort is not set

D    1.0.0.0/8 [90/131072] via 4.0.0.5, 00:06:35, GigabitEthernet0/0/1
D    2.0.0.0/8 [90/130816] via 4.0.0.5, 00:06:35, GigabitEthernet0/0/1
     3.0.0.0/8 is variably subnetted, 2 subnets, 2 masks
C       3.0.0.0/8 is directly connected, Loopback0
L       3.0.0.1/32 is directly connected, Loopback0
     4.0.0.0/8 is variably subnetted, 4 subnets, 3 masks
D       4.0.0.0/8 is a summary, 00:06:28, Null0
D       4.0.0.0/30 [90/3072] via 4.0.0.5, 00:06:35, GigabitEthernet0/0/1
C       4.0.0.4/30 is directly connected, GigabitEthernet0/0/1
L       4.0.0.6/32 is directly connected, GigabitEthernet0/0/1
     13.0.0.0/8 is variably subnetted, 2 subnets, 2 masks
C       13.0.0.0/8 is directly connected, Loopback1
L       13.0.0.1/32 is directly connected, Loopback1
D    18.0.0.0/8 [90/3328] via 4.0.0.5, 00:06:35, GigabitEthernet0/0/1
     25.0.0.0/8 is variably subnetted, 5 subnets, 3 masks
D       25.0.0.0/8 is a summary, 00:05:40, Null0
C       25.0.10.0/24 is directly connected, GigabitEthernet0/0/0.10
L       25.0.10.1/32 is directly connected, GigabitEthernet0/0/0.10
C       25.0.20.0/24 is directly connected, GigabitEthernet0/0/0.20
L       25.0.20.1/32 is directly connected, GigabitEthernet0/0/0.20
```

![b54e4c92-06c3-4a10-8b3d-52a20ed9641b.jpg](P%C5%99%C3%ADprava%20na%20praktickou%20maturitn%C3%AD%20zkou%C5%A1ku/cd72d0bd-772e-44af-974f-5dc9e65898cc.png)

[priprava_na_maturitu.pkt](P%C5%99%C3%ADprava%20na%20praktickou%20maturitn%C3%AD%20zkou%C5%A1ku/priprava_na_maturitu.pkt)