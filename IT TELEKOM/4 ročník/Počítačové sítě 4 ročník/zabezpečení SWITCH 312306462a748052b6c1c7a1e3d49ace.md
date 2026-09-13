# zabezpečení SWITCH

# PORT Security

- konfigurace na *ACCESS* vrstvě
- povolení provozu podle MAC adresy

```jsx
S1(config)#int fa0/1
S1(config-if)#switchport mode access (porty musí být v access)
S1(config-if)#switchport port-security (zapnutí port-security)
S1(config-if)#switchport port-security maximum 1 (max. počet mac adres na daný port)
S1(config-if)#switchport port-security mac-address sticky (způsob učení MAC)
```

```jsx
S1#sh port-security
Secure Port MaxSecureAddr CurrentAddr SecurityViolation Security Action
               (Count)       (Count)        (Count)
--------------------------------------------------------------------
        Fa0/1        1          0                 0         Shutdown
        --------------------------------------------------------------------

```

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

![image.png](zabezpe%C4%8Den%C3%AD%20SWITCH/image.png)

### Message of the day

```jsx
S1(config)#banner motd #zpráva#
```

![image.png](zabezpe%C4%8Den%C3%AD%20SWITCH/image%201.png)