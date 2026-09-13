# statické směrování

## Cisco Discvery Protocol (CDP)

- na L2(linková) vrstva
- cisco směrovače a přepínače
- Používá se k získání informací o HW, IP adrese, názvu zařízení a rozhraní **sousedních** zařízeních

```notion
R3#Show CDP neighbors
```

## Statické směrování

1. Manuálně
2. automaticky

![image.png](statick%C3%A9%20sm%C4%9Brov%C3%A1n%C3%AD/image.png)

```notion
R1(config)#ip route 192.168.2.0 255.255.255.0 gigabitethernet0/1 172.16.2.2
```

## Agregace cest

<aside>
⚠️

Na směrovačích potřebujeme mít co nejkratší směrovací tabulky - rychlejší prohledávání RT

</aside>

- je možné nahradit několik statických cest jedinou cestou (agregace(sumarizace) cest)
- jednotlivé cílové sítě do jedné síťové adresy
- dané cílové sítě používají stejné odchozí rozhraní (exit interface)

![image.png](statick%C3%A9%20sm%C4%9Brov%C3%A1n%C3%AD/image%201.png)

## Last resort

**Statické směrování:**

- Defaultní statická cesta
- **Defaulte route, Gateway of last restort** = je speciální případ statické cesty, která se používá pro směrování paketů do libovolné sítě.
- Defaultní cesta je na posledním řádku směrovací tabulky - její prefix je /0.
- Maska defaultní statické cesty je 0.0.0.0.
- Příkaz: ip route 0.0.0.0 0.0.0.0 (maska)  exit-interface ip-adress (next hop).
- show ip route

ip route 1.0.0.0 255.0.0.0 12.0.0.2

ip route 2.0.0.0 255.0.0.0 20.0.0.2

ip route 3.0.0.0 255.0.0.0 23.0.0.1

ip route 13.0.0.0 255.255.255.0 12.0.0.2

ip route 10.0.0.0 255.255.255.0 12.0.0.2

ip route 30.0.0.0 255.255.255.0 23.0.0.1

![image.png](statick%C3%A9%20sm%C4%9Brov%C3%A1n%C3%AD/image%202.png)