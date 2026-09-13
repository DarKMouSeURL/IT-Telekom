# Koexistence IPv6

# Dual Stack

- Dovoluje koexistovat protokolům na stejném síťovém segmentu. DS zařízení dokážou provozovat oba dva protokoly zároveň.
- **Nativní IPv6** - uživatel má připojení na IPv6 připojení k ISP a je schopen se připojit k věcem na internetu přes IPv6

![Untitled](Koexistence%20IPv6/Untitled.png)

# Tunneling

Je metoda přepravy IPv6 packetů po IPv4 síti. IPv6 je encapsulován do IPv4  packetu podobného jiným typům dat. (Packet v Packetu) 

## Pamatuj:

<aside>
📢 *Tunelování a překlad slouží k přechodu na nativní IPv6 a měly by se používat pouze tam, kde je to potřeba. Cílem by měla být nativní komunikace IPv6 od zdroje k cíli.*

</aside>

![Untitled](Koexistence%20IPv6/Untitled%201.png)

# Translation

- Network Address Translation 64 (NAT64) dovoluje povoleným IPv6 zařízením komunikovat s povolenými IPv4 zařízeními za překládací techniky podobné NAT pro IPv4.
- Zjednodušeně IPv6 se přeloží na IPv4 a naopak

![Untitled](Koexistence%20IPv6/Untitled%202.png)