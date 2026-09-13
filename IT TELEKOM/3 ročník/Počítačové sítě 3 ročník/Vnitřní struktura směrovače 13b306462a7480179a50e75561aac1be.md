# Vnitřní struktura směrovače

<aside>
💻

podstatě PC

CPU

PSU

RAM

energeticky závislá, soubor running-config, IP směrovací tabulka, ARP cache, packet buffer

ROM

energeticky nezávislá, bootstrap, POST (Power-On Self Test), základní verze IOS

Flash

energeticky nezávislá, cisco IOS → po zapnutí se převádí do RAM

NVRAM(NonVolatileRAM)

energeticky nezávislá, startup confing → po zapnutí do run-confing

INTERFACE

console

gigabit ethernet/fast ethernet

BOOT

post → bootstrap → vyhledání a zavedení cisco IOS → zavedení  startup-confing

CISCO IOS

IOS je nabootován z flash do RAM

</aside>

- každé rozhraní směrovače náleží do jiné IP sítě
- **směruje packety do přímo připojených(C) sítích a vzdálených(remote) sítích podle směrové tabulky (RT)**
- staticky

```notion
R1# ip route (ip adresa)
```

- dynamicky
    - DSP - RIP(R), OSPF(O), EIGRP(D)

![image.png](Vnit%C5%99n%C3%AD%20struktura%20sm%C4%9Brova%C4%8De/image.png)

## Ověření bootup procesu

```notion
Router> show verison
```

- verze IOS
- poslední řádek zobrazuje hodnotu konfiguračního registru - defaultní hodnota je 0x2102
- 0x(2102)16
- (0010|0001|0000|0010)2

## Rozhraní směrovače

### managment porty

- **konzolový port**(Putty)
- **interface** - fyzická zásuvka sloužící pro příjem a směrování paketů
- **FastEthernet** - WAN(Wide Area Network) / LAN(Large Area Network) / DSL / ISDN / serial
- ke každému rozhraní na směrovači se připojuje síť s vlastním rozsahem IP adres
- na směrovači nebudou fungovat dvě rozhraní které mají přidělenou ip adresu stejného rozsahu

## Statické směrovaní

- NIC - network interface card
- v sítích obsahuji malý počet směrovačů
- když je síť připojena do internetu přes jednoho ISP

```notion
R1(config)#ip route 192.168.3.0 255.255.255.0 192.168.2.2
```

## dynamické směrování

- používají se pro výměnu informací mezi směrovači o dosažitelnosti a stavu sítí

## RFC 791 (Request For Command)

![image.png](Vnit%C5%99n%C3%AD%20struktura%20sm%C4%9Brova%C4%8De/image%201.png)

záhlaví má 20 bajtů

MTU - MAX Transfer Unit

## Frame header

![image.png](Vnit%C5%99n%C3%AD%20struktura%20sm%C4%9Brova%C4%8De/image%202.png)

**metrika** = číslo, vzdálenost do cílové sítě

## RIP

![nejkratší cesta do cíle](Vnit%C5%99n%C3%AD%20struktura%20sm%C4%9Brova%C4%8De/image%203.png)

nejkratší cesta do cíle

## OSPF

![nejkratší cesta, ale zároveň nejrychlejší linka](Vnit%C5%99n%C3%AD%20struktura%20sm%C4%9Brova%C4%8De/image%204.png)

nejkratší cesta, ale zároveň nejrychlejší linka

### směrovač provádí tři kroky

1. vybalí paket, odsraní záhlaví a zápatí rámce L2
2. prozkoumá cílovou IP adresu paketu a najde nejlepší cestu ve směrovací tabulce
3. zabalí paket do rámce L2 a odešle ho výchozím rozhraní