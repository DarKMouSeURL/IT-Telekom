# 9. otázka IP TELEFONIE

---

- základní pojmy IP telefonie a VOIP, rozdíl mezi klasickou a IP telefonií
- sítě s přepojováním paketů, protokolová sada TCP/IP, popis základních protokolů
- zpracování hlasu – základní popis konverze zvuku na digitální signál
- kodeky používané v IP telefonii – detailní popis kodeku G.711 (PCM)
- protokoly SIP a RTP – základní prvky, popis architektury, sestavení spojení

---

# základní pojmy IP telefonie a VOIP, rozdíl mezi klasickou a IP telefonií

- přenos hlasu pomocí protokolu IP

### QOS

<aside>
📌

***Q**uality **O**f **S**ervice*

</aside>

- zajištění správné a rychlé komunikaci po sítí
- obsahuje přenos hlasu(zvuk) i videa

### IP

<aside>
📌

***I**nternet **P**rotocol*

</aside>

- pro přenos od zařízení do zařízení
- adresace buď jako *IPv4* nebo *IPv6*
- přidání IP telefonie na existující síť bez nutnosti navrhovat novou síť

### Kodek

- zakódování dat do datového proudu
- kodek může být MP3 a jiné formáty
- kodeky jsou většiny jsou standardizovány
    - pod organizací ITU
- v maturitní otázce je G.711
- jsou i jiné jako G.722, SPEEX(patentované)…

### UDP

- na vrstvě L4 transportní
- UDP nezajišťuje správné doručení dat
- používá se pro videa a zvuk
- pro co nejrychlejší doručení dat

### SIP

<aside>
📌

***S**ession **I**nitiation **P**rotocol*

</aside>

- protokol aplikační vrstvy L7
- zakládá, udržuje a ukončuje multimediální spojení
- port 5060

### IP telefon

- fyzické zařízení pro VoIP
- má svou IP adresu

### SoftPhone

- softwarový telefon
- buď v PC nebo mobilu

### VLAN Voice

- druh VLAN určen pro přenos hlasu
- *VoIP*
- pro zajištění plynulého provozu hlasu

### VoIP

- možnost přenášet hlas přes internet

# rozdíl mezi klasickou a IP telefonií

# PSTN (Public Switched Telephony Network)

- předchůdce IP telefonie
- každý telefon musí být propojený s každým telefonem
    - s postupem času, se přidal Switch, přepojovatel který přepojoval hovory
- přenos zprvu analogového signálu, dnes už digitálního
- nutné vlastní kabely
- přepínání okruhů
    - data putují pouze po určené části a nemění se po bodu hovoru

![image.png](9%20ot%C3%A1zka%20IP%20TELEFONIE/image.png)

# IP telefonie

- přenos digitálního signálu
- funguje už na již položených sítích LAN
- komunikuje se pomocí IP protokolu
- přepínání paketů
    - data mohou putovat po jiné cestě k příjemci

![image.png](9%20ot%C3%A1zka%20IP%20TELEFONIE/image%201.png)

---

# sítě s přepojováním paketů, protokolová sada TCP/IP, popis základních protokolů

<aside>
📌

dnešní sítě pracují na přepojování paketů

</aside>

![topologie přepínání paketů, s 2 přenosy (modrá a zelená)](9%20ot%C3%A1zka%20IP%20TELEFONIE/image%202.png)

topologie přepínání paketů, s 2 přenosy (modrá a zelená)

- tato síť funguje na *L3* vrstvě síťová
- přepíná pakety dokud nedosáhnou cíle nebo se vyplýtvá *TTL* nebo *HOP-COUNT*
- obsahuje hlavičku a náklad (*header and payload*)
- vytvořená z *routrů*
- data se dělí do paketů, které se snadno přenáší

[Počítačové sítě 01 Síťové vrstvy](https://youtu.be/S7hmLdccKgc?list=PLlCofy2_-CY6LE07-QN7VGWSObqj7oT7J&t=1667)

# protokolová sada TCP/IP

| **vrstva** | **TCP/IP** | **PDU** | **služby** |
| --- | --- | --- | --- |
| **L4** | aplikační | data | HTTPS, DNS… |
| **L3** | transportní | segment, datagram | TCP, UDP |
| **L2** | síťová | packet | IPv4, IPv6 |
| **L1** | internetový přístup | bit, rámec | Ethernet, WI-FI |

# popis základních protokolů

## HTTP (Hyper Text Transfer Protocol)

- Protokoly aplikační vrstvy se používají pro výměnu dat mezi programy běžícími na zdrojovém a cílovém hostu (PC)
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

# DNS (Domain Name Server)

- TCP/UDP L4 OSI
- PORT 53
- quary (dotaz)
- response (odpověď)
- je 13 ROOT DNS serverů

<aside>
💡

Překlad doménových jmen na IP adresy

</aside>

> [cisco.com](http://cisco.com) → 72.163.4.185
> 
- Nastavení DNS do config souboru
    - staticky
    - dynamicky DHCP

| www. | cisco. | com.(root servery, ta tečka) |
| --- | --- | --- |
| 3 řád | 2 řád | 1 řád | TLD (Top Level Domain) |

## 1. řád

- **generické**: .com, .org, .edu
- **country**: .cz, .eu, .de

![image.png](2%20ot%C3%A1zka%20TCP%20IP%20%E2%80%93%20APLIKA%C4%8CN%C3%8D%20VRSTVA%20A%20TRANSPORTN%C3%8D%20V/image%201.png)

## Config soubor

```jsx
SOA start of Authority
domenove.jmeno A 1.2.3.4
domenove.jmeno AAAA 3003::1
domenove.jmeno CNAME jmeno.domenove
domenove.jmeno MX mx1.domenove.jmeno
```

### Software pro DNS

- BIND - linux

**záznam** - resource record(RR)

**A** - IPv4

**AAAA** - IPv6

**MX** - mail exchange

**CNAME** - alias server name

**NS** - jmenný server

# POP3, IMAP, SMTP

<aside>
💡

pro výměnu dat, mezi email klienty

</aside>

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

# FTP (File Transfer Protocol)

<aside>
💡

pro ukládání souborů na vzdálený server pomocí internetu

</aside>

- PUT - dává data na server
- GET - stahuje data ze serveru
- PORT 21 - spojení
- PORT 20 - pro přenos dat

![image.png](2%20ot%C3%A1zka%20TCP%20IP%20%E2%80%93%20APLIKA%C4%8CN%C3%8D%20VRSTVA%20A%20TRANSPORTN%C3%8D%20V/6d4c2823-36c0-4f76-a767-8c1632bddda2.png)

## Windows config DHCP

```jsx
ipconfig /release (uvolní parametry z DHCP)
ipconfig /renew (znovu získání parametrů)
```

# HTTPs (Hyper Text Transfer Protocol Secure)

<aside>
⚠️

nástavba pro protokol HTTP

</aside>

- bezpečné připojení mezi webovým server a klientem
- ověřuje identitu protistrany (autenticita)
- šifrování pomocí **SSL** (Secure Socket Layer) nebo **TLS** (Transport Layer Security)

---

# zpracování hlasu – základní popis konverze zvuku na digitální signál

> akustická vlna → elektromagnetický signál
způsob převodu analogového signálu na digitální
> 

# PCM

<aside>
📌

***P**ulse **C**ode **M**odulation*

</aside>

## Vzorkování (Sampling)

> vzorkovací frekvence
> 
- rozdělení signálu na separátní body v čase (délka vždy stejně dlouhá)
- minimálně 2x vyšší než nejvyšší frekvence
    - 3400Hz = 6800Hz vzorkování (zaokrouhleno na 8KHz)

![pouze ilustrativní obrázek](9%20ot%C3%A1zka%20IP%20TELEFONIE/image%203.png)

pouze ilustrativní obrázek

## Kvantování (**Quantizing**)

- zaokrouhlení na nejbližší hodnotu  toho kde je měřená hodnota z vzorkování

![pouze ilustrativní obrázek](9%20ot%C3%A1zka%20IP%20TELEFONIE/image%204.png)

pouze ilustrativní obrázek

## Kódování (Encoding)

- Přiřazení číselné hodnoty každému vzorku
- používá se 8 bitů (256) úrovní/hodnot **při G.711**
- přenos jednotlivých bitů za sebou

![pouze ilustrativní obrázek](9%20ot%C3%A1zka%20IP%20TELEFONIE/image%205.png)

pouze ilustrativní obrázek

---

# kodeky používané v IP telefonii – detailní popis kodeku G.711 (PCM)

- použitý kodek rozhoduje o kvalitě audia, šířce pásma a kompresi dat
- každý kodek jinak zpracovává hlas
- G.729, G.726, OPUS (*Open-Source*)

![základní rozdělení podle kvality hlasu ](9%20ot%C3%A1zka%20IP%20TELEFONIE/image%206.png)

základní rozdělení podle kvality hlasu 

# detailní popis kodeku G.711 (PCM)

- nejběžnější a nejjednodušší standard pro digitalizaci signálu
- od roku 1972
- 64 Kbp/s
- standard od 1988 ITU-T
- nejméně úsporný na přenosovou rychlost
- vzorkovací frekvence 8Khz, rozlišení 8 bitů
- používá logaritmickou kompresi
    - A-law(PCMA) používá EU a Austrálie
    - μ-law(PCMB) používaná v USA a Japonsku
- 300-3400 Hz
- přibližné zpoždění 125ms
- použití PCM, logaritmická komprese

## Verze

### G.711.0

- bezztrátová komprese

### G.711.1

- větší šířka pásma

---

# protokoly SIP a RTP – základní prvky, popis architektury, sestavení spojení

# SIP

<aside>
📌

***S**ession **I**nitiation **P**rotocol*

</aside>

<aside>
⚠️

slouží pouze pro navázání spojení, **ne** pro přenos hlasu

</aside>

- UDP, 5060 port
- navazuje, řídí a ukončuje komunikaci
- společně pracuje s RTP
- aplikační protokol

### činnosti

1. **lokalizace účastníka**
    1. spojení s koncovým zařízením
2. **stav účastníka**
    1. jestli jde navázat spojení s účastníkem
    2. jestli není obsazen nebo přesměrován
3. **schopnosti účastníka**
    1. typ kodeku
    2. maximální přenosová rychlost…
4. **navázání spojení**
    1. RTP datový tok
5. **řízení spojení**
    1. propis změn během hovoru
        1. kodek, porty

### metody

1. ***REGISTER***
    1. registrace účastníka na SIP serveru
2. ***INVITE***
    1. zahájení komunikace
3. ***Trying/Ringing***
    1. pokus o navázání hovoru
4. ***ACK***
    1. potvrzení
5. ***CANCEL***
    1. přerušení relace před jejím začátkem
6. ***BYE***
    1. ukončení hovoru
7. ***OPTIONS***
    1. požadavek informací od druhé strany

# RTP

<aside>
📌

***R**eal-time **T**ransport **P**rotocol*

</aside>

- **UDP**
- přenos datového toku (hlasu a videa)
- s co nejmenším zpožděním
- end-end, real-time (v reálném čase)
- umírňuje *jitter*, detekuje ztrátu paketů a příchod paketů v nesprávném pořadí
    - *jitter* = kolísání zpoždění paketů
- SRTP = **Secure RTP**
- pakety jsou očíslované (časové značky), pro pozdější znovu složení v pořadí
- udržuje správné pořadí paketů

---

# Sestavení spojení

![SIP navázání komunikace, RTP probíhá pouze u koncových zařízeních, **ne** přes SIP severu](9%20ot%C3%A1zka%20IP%20TELEFONIE/image%207.png)

SIP navázání komunikace, RTP probíhá pouze u koncových zařízeních, **ne** přes SIP severu

# kodek G.729

- úsporný hlasový kodek
- efektivnější využití limitovaného pásma
- použití PCM
- umožňuje snížit využití na 8kbit/s (ztrátová komprese)

# popis architektury

## SIP server

- User Agent se přihlásí k SIP severu pomocí jména a IP adresy
- mezi krok k navázání spojení mezi koncovými hosty
- kontroluje dostupnost hostů

## User agent

- koncové zařízení pro hovory
- příjem i odchozí hovor
- IP telephone, softphone

### Registrar SIP server

- udržuje záznamy o nově připojených
- udržuje jména a IP adresy hostů

### Proxy SIP server

- přeposílá dál SIP požadavky buď další proxy nebo serveru nebo User agentu
- může zastupovat roli bezpečnosti, autentizace a autorizace

### Redirect SIP server

- liší se od Proxy
- server vrátí adresu hosta
- hosta si musíme sami zkontaktovat pomocí ip adresy od redirect **SIP** Server

---

# Zdroje

[cdn.ttgtmedia.com](https://cdn.ttgtmedia.com/searchVoIP/downloads/Building_a_VoIP_Network_Ch%5B1%5D._8.pdf)

[is.muni.cz](https://is.muni.cz/el/fi/jaro2012/PV235/6_IP_Telefonie_SIP.pdf)

[Session Initiation Protocol](https://cs.wikipedia.org/wiki/Session_Initiation_Protocol)

[Real-time Transport Protocol](https://cs.wikipedia.org/wiki/Real-time_Transport_Protocol)

[Pulse Code Modulation (PCM) - EDN](https://www.edn.com/pulse-code-modulation-pcm/)

[10. Pulse Code Modulation - Digital Audio Fundamentals](https://youtu.be/wn71QBApCRg)