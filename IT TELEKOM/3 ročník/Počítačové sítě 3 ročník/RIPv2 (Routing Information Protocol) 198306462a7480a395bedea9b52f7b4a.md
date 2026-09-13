# RIPv2 (Routing Information Protocol)

Loopback → softwarové rozhraní na směrovači. Jakoby síťová karta. Defaultně vždy zapnuté.

RFC 1918 - adresy specifikované v doporučení.

**Statická cesta a rozhraní null:**

- R2(config)#ip route 192.168.0.0 255.255.0.0 null0
- Chceme simulovat statickou cestu a výstupní rozhraní neexistuje.
- Nesměruje, nepřijímá žádný provoz. Pakety určené pro null rozhraní jsou směrovačem zahozeny (discarted).

**Redistribuce cest:**

- R2(config)#redistribute static

## Debug ip rip

- vypis, aktualizace

**jak vypnout debug ip rip:**

```jsx
no debug ip rip
undebug all
```

## autentizace

- je možné riziko, kdy se příjme neplatné směrovací aktualizaci
- možné nastavit heslo na směrovacích aktualizací
- útočník může chtít narušit síť, přijímat packety man-in-midlle attack…

# Shrnutí

```jsx
R(config)#route rip
R(config)#vernison 2
R(config)#no autosummary
R(config)#network x.x.x.x
R(config)#passive interface g0/0/0
R(config)#default information originate
```

# Konfigurace

```jsx
R1(config)#router rip
R1(config)#version 2
R1(config)#no auto-summary
R1(config)#network 1.0.0.0
R1(config)#network 2.0.0.0
R1(config)#network 55.0.0.0

R2(config)#router rip
R2(config)#version 2
R2(config)#no auto-summary
R2(config)#network 55.0.0.0
R2(config)#network 3.0.0.0
```