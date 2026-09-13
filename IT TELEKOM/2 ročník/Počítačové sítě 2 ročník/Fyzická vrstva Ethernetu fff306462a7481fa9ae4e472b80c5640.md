# Fyzická vrstva Ethernetu

# **Rychlosti**

- 10 Mbps
- 100 Mbps (Fast-ethernet)
- 1000 Mbps (Gigabit ethernet)
- 10 Gbps (10 Gigabit ethernet)

| **Types of Ethernet** | **Bandwidth** | **Cable Type** | **Duplex** | **Max. distance** |
| --- | --- | --- | --- | --- |
| **10Base-5** | 10Mbps | Thicknet Coaxial | half | 500m |
| **20Base-2** | 10Mbps | Thinnet Coaxial | half | 200m |
| **10BaseT(twisted)** | 10Mbps | Cat 5e UTP | full | 100m |
| **100BaseTX(switch)** | 100Mbps | Cat 5e UTP | full | 100m |
| **100BaseTF(fiber)** | 100Mbps | multimode fiber | full | 550m |

# Switch - internet bez kolizí

<aside>
🔂

Nejdůležitější úkolem switche je předat (forward) rámec z příchozího portu na správný odchozí port.

</aside>

## **Metody**

### **Store and Forward**

- celý rámec se načte do paměti, kontrola rámce

### **Cut trough**

- na začátku je cílová mac adresa
- co nejrychleji odchází
- NEkontroluje rámec
- neukládá

# pracuje v pěti fázích

1. learning (učení ze zdrojových MAC adres v rámci)
2. aging (záznamy z MAC tabulky se smažou)
3. flooding (záplava rámců na všechny porty switch, když cílová mac adresa není v MAC tabulce)
4. selective forwarding (předání rámce na správný port)
5. filtering (zahazování vadných rámců)

# ARP proces

<aside>
📢 namapování MAC adres na IP adresu

</aside>

- V LAN → PC na základě známé IPv4 zjišťuje MAC adresu PC v LAN
- adress resolution protocol

# Routing

<aside>
📢 na síťové vrstvě se směrují packety do přímo připojených sítích

</aside>

PDU = packet

# Charakteristika IP protocolu

**Connectionless** - nenavazuje se spojení

**Best effort** - pracuje nejvyšší snahy o doručení packety do cíle

IP protocol nezaručuje spolehlivé doručení do cíle

**Media Independent -** není závislý na médiu

<aside>
📢 hlavička protokolu IPv4 je v Cisco

</aside>

### Co se má znát

- verze IPv4
- total lenght
- TTL - time to leave
- protocol nižší vrstvy
- kompletní součet hlavičky IPv4
- zdrojová IPv4
- cílová IPv4