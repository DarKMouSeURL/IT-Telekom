# konfigurace VLAN na SWITCH

- lepší bezpečnost

- omezení broadcast domain

## tabulka rozdělení VLAN

| **VLAN 10** (finance) | 111.0.10.0/24 |
| --- | --- |
| **VLAN 20** (sklad) | 111.0.20.0/24 |
| **VLAN 30** (ředitelství) | 111.0.30.0/24 |

# VLAN 10

# VLAN 20

```jsx
S1(config)#int g1/1
S1(config-if)#switchport mode access
S1(config-if)#switchport access vlan 10
S1(config-if)#int g1/5
S1(config-if)#switchport mode access
S1(config-if)#switchport access vlan 10
S1(config-if)#int g1/16
S1(config-if)#switchport mode access
S1(config-if)#switchport access vlan 10
```

# VLAN 30

```jsx
S2(config)#int g1/1
S2(config-if)#switchport mode access
S2(config-if)#switchport access vlan 20
S2(config-if)#int g1/7
S2(config-if)#switchport mode access
S2(config-if)#switchport access vlan 20
```

```jsx
S1(config)#int g1/2
S1(config-if)#switchport mode access
S1(config-if)#switchport access vlan 30
S1(config-if)#int g1/6
S1(config-if)#switchport mode access
S1(config-if)#switchport access vlan 30
```

# Trunk mezi SWITCHema

```jsx
S1(config)#int g1/24
S1(config-if)#switchport mode trunk
```

```jsx
S1(config)#int g0/24
S1(config-if)#switchport mode trunk
```

# ROUTER ON STICK

```jsx
R1(config)#int g1/0/1.10
R1(config-if)#encapsulation dot1q 10
R1(config-if)#ip address 111.0.10.1 255.255.255.0
R1(config-if)#int g1/0/1.20
R1(config-if)#encapsulation dot1q 20
R1(config-if)#ip address 111.0.20.1 255.255.255.0
R1(config-if)#int g1/0/1.30
R1(config-if)#encapsulation dot1q 30
R1(config-if)#ip address 111.0.30.1 255.255.255.0
R1(config-if)#int g1/0/1
R1(config-if)#no shutdown
```

```jsx
S1(config)#int g1/0/24
S1(config-if)#switchport mode trunk
```

![topologie](konfigurace%20VLAN%20na%20SWITCH/output-onlinepngtools_(7).png)

topologie

# konfigurace SVI částečná

```jsx
S1(config)#vlan 20
S1(config-vlan)#name sklad
S1(config-vlan)#exit
S1(config)#int vlan 20
S1(config-if)#ip address 111.0.20.99 255.255.255.0
S1(config-if)#no shutdown
S1(config-if)#exit
S1(config)#ip default-gateway 111.0.20.1
```