# 2. otázka TCP/IP – APLIKAČNÍ VRSTVA A TRANSPORTNÍ VRSTVA

---

- funkce a protokoly aplikační vrstvy (HTTP, HTTPs, DNS, DHCP, FTP, SMTP, POP3, IMAP)
- funkce transportní vrstvy, pojmy segmentace a multiplexace
- popis protokolu TCP a způsob navazování spojení
- popis protokolu UDP
- význam a rozdělení portů

---

# funkce a protokoly aplikační vrstvy (HTTP, HTTPs, DNS, DHCP, FTP, SMTP, POP3, IMAP)

## HTTP (Hyper Text Transfer Protocol)

- Protokoly **aplikační vrstvy** se používají pro **výměnu dat mezi programy běžícími na zdrojovém a cílovém hostu** (PC)
- 1991 vznik
    - CERN, LEE

### Požadavky

- 8 požadavků
- **HTTP-GET**
    - požadavek k dostání dat
    - GET /wiki/wikipedie HTTP/1.1
    - HTTP/1.0 200 OK (server response)
- **POST**
    - odesílá uživatelská data na server, třeba formulář
- **PUT**
    - nahrání dat na server
- **DELETE**
    - smaže data ze serveru
- HEAD
- TRACE
- OPTIONS
- CONNECT

![image.png](2%20ot%C3%A1zka%20TCP%20IP%20%E2%80%93%20APLIKA%C4%8CN%C3%8D%20VRSTVA%20A%20TRANSPORTN%C3%8D%20V/image.png)

---

## HTTPs (Hyper Text Transfer Protocol Secure)

<aside>
⚠️

nástavba nad protokolem HTTP

</aside>

- **bezpečné připojení mezi webovým server a klientem**
- **ověřuje identitu** protistrany (autencita)
- šifrování pomocí **SSL** (Secure Socket Layer) nebo **TLS** (Transport Layer Security)
- Port **443**

---

## DNS (Domain Name System)

- **TCP/UDP L4 OSI**
- PORT **53**
- query (**dotaz**)
- response **(odpověď)**
- je 13 ROOT DNS serverů

<aside>
💡

**Překlad doménových jmen na IP adresy**

</aside>

> [cisco.com](http://cisco.com) → 72.163.4.185
> 
- Nastavení DNS do config souboru
    - staticky
    - dynamicky DHCP

| www. | cisco. | com.(root servery, ta tečka) |
| --- | --- | --- |
| 3 řád | 2 řád | 1 řád | TLD (Top Level Domain) |

### 1. řád

- generické: .com, .org, .edu
- zeměpisné: .cz, .eu, .de

![image.png](2%20ot%C3%A1zka%20TCP%20IP%20%E2%80%93%20APLIKA%C4%8CN%C3%8D%20VRSTVA%20A%20TRANSPORTN%C3%8D%20V/image%201.png)

---

## DHCP (Dynamic Host Configuration Protocol)

<aside>
💡

slouží pro konfigurace připojení hosta do sítě (drátově i bezdrátově)

</aside>

- Automaticky přiděluje
    1. **IP adresu**
    2. **defaultní bránu**
    3. **masku**
    4. **IP adresa DNS serveru**
- IP adresa se zapůjčuje na určenou dobu (**lease time**)
- **klient** používá **68**
- **server** poslouchá na požadavek **67**

### Postup (DORA)

1. **Discover** (objevení)
    1. objevení DHCP servery
    2. klient používá broadcast
2. **Offer** (nabídka)
    1. DHCP server nabízí parametry připojení
3. **Request** (požadavek)
    1. client požádá DHCP server
4. **Acknowledge** (potvrzení)
    1. DHCP potvrdí volbu clienta

![image.png](2%20ot%C3%A1zka%20TCP%20IP%20%E2%80%93%20APLIKA%C4%8CN%C3%8D%20VRSTVA%20A%20TRANSPORTN%C3%8D%20V/image%202.png)

### Config soubor

```jsx
SOA start of Authority
domenove.jmeno A 1.2.3.4
domenove.jmeno AAAA 3003::1
domenove.jmeno CNAME jmeno.domenove
domenove.jmeno MX mx1.domenove.jmeno
```

**záznam** - resource record(RR)

**A** - IPv4

**AAAA** - IPv6

**MX** - mail exchange

**CNAME** - alias server name

**NS** - jmenný server

### Windows config DHCP

```jsx
ipconfig /release (uvolní parametry z DHCP)
ipconfig /renew (znovu získání parametrů)
```

### Software pro DNS

- BIND - linux

---

## FTP (File Transfer Protocol)

<aside>
💡

pro ukládání souborů na vzdálený server pomocí internetu

</aside>

- **PUT** - dává data na server
- **GET** - stahuje data ze serveru
- **PORT 21** - spojení
- **PORT 20** - pro přenos dat

![image.png](2%20ot%C3%A1zka%20TCP%20IP%20%E2%80%93%20APLIKA%C4%8CN%C3%8D%20VRSTVA%20A%20TRANSPORTN%C3%8D%20V/6d4c2823-36c0-4f76-a767-8c1632bddda2.png)

---

## POP3, IMAP, SMTP

<aside>
📌

***P**ost **O**ffice **P**rotocol **3***

</aside>

<aside>
📌

***I**nternet **M**essage **A**ccess **P**rotocol*

</aside>

<aside>
📌

***S**imple **M**ail **T**ransfer **P**rotocol*

</aside>

<aside>
💡

pro výměnu dat, mezi email klienty

</aside>

### struktura adresy

> adresát@doména.cz
> 
- na bázi klient-server
- klient používá MUA (Mail User Agent)
    - Outlook…
- odesílaná pošta - **SMTP(Simple Mail Transfer Protocol)**
    - SMTP - port 25
- přijatá pošta - **POP3(Post Office Protocol), IMAP(Internet Message Access Protocol)**
    - POP3 - se stahuje pošta do zařízení - port 110
        - pošta se smaže z email serveru
    - IMAP - se stahují pouze hlavičky - port 143
        - pošta se uchovává na serveru tak i u klienta

![image.png](2%20ot%C3%A1zka%20TCP%20IP%20%E2%80%93%20APLIKA%C4%8CN%C3%8D%20VRSTVA%20A%20TRANSPORTN%C3%8D%20V/image%203.png)

---

# něco navíc

![síť, která funguje :)](2%20ot%C3%A1zka%20TCP%20IP%20%E2%80%93%20APLIKA%C4%8CN%C3%8D%20VRSTVA%20A%20TRANSPORTN%C3%8D%20V/image%204.png)

síť, která funguje :)

- client PC0 odešle rámec požadavek HTTP-get, která je v DATA
    - rámec obsahuje MAC adresy, kontrolní součet, typ

![image.png](2%20ot%C3%A1zka%20TCP%20IP%20%E2%80%93%20APLIKA%C4%8CN%C3%8D%20VRSTVA%20A%20TRANSPORTN%C3%8D%20V/ffdf702f-fa7a-423c-8eb8-ce2efbe286a0.png)

- rámec se vypouzdří do packetu, který jde po síti, až k PC1
    - packet obsahuje TTL, IP adresy a kontrolní součet
    - snižuje se TTL a přepočítává se kontrolní součet packetu

![image.png](2%20ot%C3%A1zka%20TCP%20IP%20%E2%80%93%20APLIKA%C4%8CN%C3%8D%20VRSTVA%20A%20TRANSPORTN%C3%8D%20V/119a0c4a-8eeb-4142-9ba3-1f5dc8fc8ac1.png)

- Switch1 zapouzdří packet znovu do rámce

![image.png](2%20ot%C3%A1zka%20TCP%20IP%20%E2%80%93%20APLIKA%C4%8CN%C3%8D%20VRSTVA%20A%20TRANSPORTN%C3%8D%20V/ffdf702f-fa7a-423c-8eb8-ce2efbe286a0.png)

- PC1 zkontroluje rámec a vypouzdří do packetu

![image.png](2%20ot%C3%A1zka%20TCP%20IP%20%E2%80%93%20APLIKA%C4%8CN%C3%8D%20VRSTVA%20A%20TRANSPORTN%C3%8D%20V/119a0c4a-8eeb-4142-9ba3-1f5dc8fc8ac1.png)

- PC1 zkontroluje packet a vypouzdří do segmentu
    - segment obsahuje PORT adresy
        - cílovou adresu předá aplikaci, co poslouchá na daném portu
        - zdrojovou adresu si zapamatuje pro komunikaci s uživatelem
    - sekvenční číslo, potvrzovací číslo a vlajky

![image.png](2%20ot%C3%A1zka%20TCP%20IP%20%E2%80%93%20APLIKA%C4%8CN%C3%8D%20VRSTVA%20A%20TRANSPORTN%C3%8D%20V/image%205.png)

- Následně, se čtou data (HTTP-GET požadavek)

![Bez názvu.png](2%20ot%C3%A1zka%20TCP%20IP%20%E2%80%93%20APLIKA%C4%8CN%C3%8D%20VRSTVA%20A%20TRANSPORTN%C3%8D%20V/1b0995ab-a2f9-4ee9-bb8f-a30005311797.png)

> komunikace mezi serverem a uživatelem jde od zdola až navrch
> 

<aside>
❗

proces funguje stejně i nazpět

</aside>

---

# Telnet (TELetype NETwork)

<aside>
💡

Vzdálenou zprávu různých systému

</aside>

- nejstarší aplikační protokol
    - 1969
- PORT 23
- SSH (Secure Shell)
    - encryption
    - ověřování a přihlášení
    - shell (mušle)

---

# funkce transportní vrstvy, pojmy segmentace a multiplexace

## funkce transportní vrstvy

- použití **portů** 0 až 65535
- jasné označení **služby**
- pro účastníky komunikace
- může zaručovat úplnost přenosu
- máme buď **TCP** nebo **UDP**

## Multiplexace

<aside>
💡

segmentování **TCP** / **UDP**

</aside>

- síťová karta posílá jednotlivě
- **prokládání segmentů** do **jednoho** komunikačního kanálu
    - veškerá komunikace PC se musí rozdělit do jednoho přenosového média (NIC - Network Interface Card)
- přenos více signálů jedním médiem
- **Demultiplexace** - opačný postup

![image.png](2%20ot%C3%A1zka%20TCP%20IP%20%E2%80%93%20APLIKA%C4%8CN%C3%8D%20VRSTVA%20A%20TRANSPORTN%C3%8D%20V/image%206.png)

## Segmentace

- rozdělení komunikace na menší celky
- síť má omezené prostředky pro přenos dat
- **MTU** (***M**aximum **T**ransfer **U**nit*)
    - ETHERNET má maximálně 1500 bajtů

---

# popis protokolu UDP

## UDP (User Datagram Protocol)

- **jednoduchý**
- **nespojově orientovaný** (nenavazuje spojeni jako TCP)
- **nezajišťuje** spolehlivé doručení dat
- RFC 768
- **DHCP, TFTP, hlas a video (realtime)**
- datový celek - **datagram**
- **Socket** - IPaddress:Port
    
    1.2.3.4:80
    

## Výhoda

- **malá hlavička** (8 byte)
- **maximální možná rychlost**
    - Best Effort
    

![image.png](2%20ot%C3%A1zka%20TCP%20IP%20%E2%80%93%20APLIKA%C4%8CN%C3%8D%20VRSTVA%20A%20TRANSPORTN%C3%8D%20V/image%207.png)

![image.png](2%20ot%C3%A1zka%20TCP%20IP%20%E2%80%93%20APLIKA%C4%8CN%C3%8D%20VRSTVA%20A%20TRANSPORTN%C3%8D%20V/3b72a61e-8bae-45cd-859d-e64ca308655f.png)

---

# popis protokolu TCP a způsob navazování spojení

## TCP (Transmission Control Protocol)

- **navazuje spojení**
- **zajišťuje spolehlivé doručení dat**
- RFC 793
- **větší** hlavička 20 Byte
- datový celek - **Segment**
- **HTTP, FTP, SMTP, POP3, Telnet, SSH**
- **Socket** - IPaddress:Port
    
    1.2.3.4:80
    

<aside>
💡

- jednoznačná komunikace na internetu zdrojový socket + TCP/UDP + cílový socket
    
        **1.2.3.4:1889      TCP       1.2.3.5:80**
    
</aside>

## Hlavička

- **source port address**: port odesílatele, většinou náhodně generovaný 1024-56000
- **destination port address**: port příjemce, služba která běží na serveru, HTTP - 80
- **sequence number:** číslo po zahájení komunikace je náhodné
    - kolik dat je odesláno
- **acknowledgement number**: navazuje na sequence number
    - sekvenční číslo je o 1 větší
    - potvrzuje správné doručení dat
- **HLEN (Header Length)**: velikost hlavičky
- Reserved: rezervováno, vždy hodnota 0
- **vlajky/příznaky**: 1 nebo 0 hodnota
    - URG (urgent): když data musí být prioritizována
    - **ACK** **(acknowledged):** když 1 - potvrzení dorozumění mezi stranami
    - **SYN** **(synchronized):** když 1 - navázaní spoje
    - **FIN** **(Finished):** když 1 - ukončení spoje
- **Window size (velikost)**: kolik dat může příjemce obdržet
- **Checksum (kontrolní součet)**: součet pro ověření integrity segmentu
- Urgent pointer: když vlajka URG == 1, je počet kde data s vysokou prioritou končí

![image.png](2%20ot%C3%A1zka%20TCP%20IP%20%E2%80%93%20APLIKA%C4%8CN%C3%8D%20VRSTVA%20A%20TRANSPORTN%C3%8D%20V/image%208.png)

## Three-way handshake

- pomocí vlajek/flagu

![navázání komunikace](2%20ot%C3%A1zka%20TCP%20IP%20%E2%80%93%20APLIKA%C4%8CN%C3%8D%20VRSTVA%20A%20TRANSPORTN%C3%8D%20V/output-onlinepngtools_(2).png)

navázání komunikace

![ukončování komunikace](2%20ot%C3%A1zka%20TCP%20IP%20%E2%80%93%20APLIKA%C4%8CN%C3%8D%20VRSTVA%20A%20TRANSPORTN%C3%8D%20V/image%209.png)

ukončování komunikace

---

# význam a rozdělení portů

## Porty

<aside>
⚠️

označeni a rozlišeni současně probíhajících **služeb** na jednom zařízení

</aside>

- značí **serverové a uživatelské** služby
- **16 bitové** číslo rozsah (**0-65535**)
    - **well known** (0-1023)
        - na portech naslouchají servery na dotazy klienta
        - **HTTP** 80
        - **DNS** 53
        - **Telnet** 23
        - SSH 22
        - **HTTPS** 443
        - **FTP** 20/21
        - **IMAP** 143
        - **POP3** 110
    - **Registrovaná** (**1024-49151**)
    - **dynamické** (**49152-65535**)
        - označení služeb běžící na klientově straně