# 1. otázka SÍŤOVÉ MODELY ISO/OSI A TCP/IP

---

- popis a porovnání modelů ISO/OSI a TCP/IP
- PDU, typy datových částí na jednotlivých vrstvách
- rozdělení a charakteristika počítačových sítí
- struktura počítačové sítě, zařízení a média potřebná pro komunikaci
- význam adresace v síťové komunikaci

---

# TCP/IP vs. ISO/OSI

## ISO/OSI

- 7 vrstev
- **referenční model (teoretický)**
- vytvořeno organizací ISO, vytváří standardy

## TCP/IP

- 4 vrstvy
- **praktický model**
    - vychází z reálné implementace

| **ISO/OSI** | **PDU** | **TCP/IP** | **služby** |
| --- | --- | --- | --- |
| aplikační | data | aplikační | DNS, DHCP, FTP, HTTP, POP3 |
| prezentační | data | aplikační | - |
| relační | data | aplikační | - |
| transportní | segment, datagram | transportní | TCP, UDP |
| síťová | paket | internet | IPv4, IPv6 |
| linková | rámec | network access | Ethernet, PPP, DSL |
| fyzická | bit | network access | Ethernet, WI-FI |
- port - 16 bitů
- IPv4 - 32 bitů
- MAC adresa - 48 bitů
- IPv6 - 128 bitů
- network access a linková a fyzická vrstva jsou hardwarově závislé
    - ostatní nejsou hardwarově závislé

# rozdělení sítí

## podle velikosti

1. **PAN** (***P**ersonal **A**rea **N**etwork*)
    1. okruh cca. 10 metrů
    2. např. bluetooth
2. **LAN** (***L**ocal **A**rea **N**etwork*)
    1. Domácí/firemní síť klidně i s několika budovami
3. **MAN** (***M**etropolitan **A**rea **N**etwork*)
    1. pokrývá město
4. **WAN** (***W**ide **A**rea **N**etwork**)
    1. velká vzdálenost
    2. např. VŠB (velká organizace, několik budov)

## podle účastníků komunikace

1. **client-server**
    1. nejběžnější
    2. klient odesílá požadavky
    3. server je zpracovává
2. **peer-to-peer**
    1. služba kdy jsou dva klienti k sobě navzájem propojení
    2. např. torrent

# Charakteristika

1. dnes sítě s **přepínáním paketů** (*packet switching*)
    1. pakety si mohou vybírat jinou cestu k cíli
2. dříve s **přepínáním okruhů** (*circuit switching*)
    1. komunikace probíhala pouze přes předem určený okruh
    2. např. dial-up internet

![přepínání okruhů](1%20ot%C3%A1zka%20S%C3%8D%C5%A4OV%C3%89%20MODELY%20ISO%20OSI%20A%20TCP%20IP/image.png)

přepínání okruhů

![Přepínání paketů](1%20ot%C3%A1zka%20S%C3%8D%C5%A4OV%C3%89%20MODELY%20ISO%20OSI%20A%20TCP%20IP/image%201.png)

Přepínání paketů

# struktura počítačové sítě, zařízení a média potřebná pro komunikaci

## struktury PC sítí

> hvězda(star), sběrnice(bus), bod bod(point to point), kruh(ring), mesh
> 

### hvězda (star)

- dnes nejpoužívanější
- koncové zařízení jsou propojené skrz přepínač (L2/L3)
- lehká škálovatelnost a údržba

![Star](1%20ot%C3%A1zka%20S%C3%8D%C5%A4OV%C3%89%20MODELY%20ISO%20OSI%20A%20TCP%20IP/output-onlinepngtools_(1).png)

Star

### sběrnice (BUS)

- zastaralé a dnes nepoužívané
- koncové zařízení sdílejí jedno přenosové médium (koaxal)
- princip spočíval na **CSMA/CD**
    
    ***C**arrier **S**ense **M**ultiple **A**ccess / **C**ollision **D**etection*
    
- při střetu rámců se komunikace zastavila a každé zařízení počkalo náhodně dlouhou dobu poté komunikace pokračovala
- špatně škálovatelné
    - více zařízení, více kolizí

![BUS](1%20ot%C3%A1zka%20S%C3%8D%C5%A4OV%C3%89%20MODELY%20ISO%20OSI%20A%20TCP%20IP/image%202.png)

BUS

### bod do bodu (point to point)

- přímé propojení dvou koncových zařízení
- používané pro propojení router - router

![Point to Point](1%20ot%C3%A1zka%20S%C3%8D%C5%A4OV%C3%89%20MODELY%20ISO%20OSI%20A%20TCP%20IP/image%203.png)

Point to Point

### kruh (ring)

- zařízení jsou propojené v kruhu
- princip spočíval na předávání tokenu
- token umožňoval zařízení komunikaci
- špatná škálovatelnost
    - více zařízení, delší doba než zařízení dostane token

![Ring](1%20ot%C3%A1zka%20S%C3%8D%C5%A4OV%C3%89%20MODELY%20ISO%20OSI%20A%20TCP%20IP/image%204.png)

Ring

### mesh

- každé zařízení je propojené s ostatními zařízeními
- špatná škálovatelnost
    - více zařízení - větší komplexnost sítě

![Mesh](1%20ot%C3%A1zka%20S%C3%8D%C5%A4OV%C3%89%20MODELY%20ISO%20OSI%20A%20TCP%20IP/image%205.png)

Mesh

## média a zařízení

### média

- **metalická** - UTP(Unshielded Twisted Pair), STP(Shield Twisted Pair), koaxiální kabel
    
    
    ![UTP](1%20ot%C3%A1zka%20S%C3%8D%C5%A4OV%C3%89%20MODELY%20ISO%20OSI%20A%20TCP%20IP/image%206.png)
    
    UTP
    
    ![STP](1%20ot%C3%A1zka%20S%C3%8D%C5%A4OV%C3%89%20MODELY%20ISO%20OSI%20A%20TCP%20IP/image%207.png)
    
    STP
    
    ![koaxial](1%20ot%C3%A1zka%20S%C3%8D%C5%A4OV%C3%89%20MODELY%20ISO%20OSI%20A%20TCP%20IP/image%208.png)
    
    koaxial
    
- **optická** - vlákno, single-mode, multi-mode
    
    
    ![single vs multi mode](1%20ot%C3%A1zka%20S%C3%8D%C5%A4OV%C3%89%20MODELY%20ISO%20OSI%20A%20TCP%20IP/image%209.png)
    
    single vs multi mode
    
    ![optický kabel](1%20ot%C3%A1zka%20S%C3%8D%C5%A4OV%C3%89%20MODELY%20ISO%20OSI%20A%20TCP%20IP/image%2010.png)
    
    optický kabel
    
- **bezdrátová** - rádiové vlny, 2.4GHz, 5GHz
    
    ![image.png](1%20ot%C3%A1zka%20S%C3%8D%C5%A4OV%C3%89%20MODELY%20ISO%20OSI%20A%20TCP%20IP/image%2011.png)
    

### zařízení

- PC, server (zařízení na L7 vrstvě)
- přepínač(Switch) (na L2 až L3 vrstvě)
- směrovač(router) (na L3 vrstvě)
- přístupový bod(access point) (na L2 až L3)

# význam adresace v síťové komunikaci

## Základní význam

- **adresa** jednoznačně určuje umístění adresovatelného prvku v počítačové síti
    - bez adresace by nebylo možné doručit data příjemci

## Typy adres v síťové komunikaci

### MAC adresa (Media Access Control)

- identifikátor síťového zařízení na **linkové vrstvě** (vrstva 2 OSI)
- **48 bitů** - fyzická adresa přiřazená síťové kartě při výrobě
- umožňuje komunikaci v lokální síti (LAN)
- zůstává stále stejná (na rozdíl od IP adresy)

#### příklad

> 33:c9:7d:51:4d:d6
> 

### IP adresa

- primární identifikátor každého počítače připojeného v počítačové síti
- umožňuje směrování dat mezi různými sítěmi na **síťové vrstvě** (vrstva 3 OSI)
- **IPv4**: 32 bitů
- **IPv6**: 128 bitů
- maska rozděluje IP adresu na **network portion** (síťová část) a **host portion** (hostitelská část)
- směrování probíhá podle network portion

#### příklad

> 10.70.1.58
> 

### Port

- **16 bitů** - identifikuje konkrétní aplikaci nebo službu na **transportní vrstvě**

#### příklad

> 80 (HTTP)
>