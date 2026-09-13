# kybernetické útoky DOS a DDOS

# DDOS/DOS

- **UDP flood** - typ DDOS/DOS, používá velký počet UDP datagramů
    - hlavní problém je že server musí při každém požadavku kontrolovat jestli není nějaká aplikace, která zrovna využívá příslušný port
    - server nadále musí odpovědět ICMP Destination unreachable
- **ICMP flood** - **ping flood** attack, snaha narušit server pomocí ping requestů
    - hlavní problém tohoto útoku je, že oběť je nucena při každém pingu odpovědět zpátky, co zatěžuje výkon (proto je někdy zakázáno ping v politice sítě)

**ICMP** - internetový protokol, Internet Control message, je vygenerován na základě nějaké události (host unreachable) výjimka je ping

- **SYN flood** - velký počet SYN požadavků - TCP spojení, three-way handshake, nedokončí handshake, neodešle zpátky ACK, poté začíná nový požadavek na TCP request
- **SLOWLORIS(nástroj)** - hodně otevřených spojeních přes HTTP, tím pádem zamezuje otevření nových spojení, je to aplikace
    - nepotřebuje tolik odeslaných dat, těžko se detekuje, protože to vypadá jako normální trafic
    - aby server nezahodil spojení, jednou za čas pokračuje v komunikaci na to spojení
- **ping of death**
    - DDOS - útok, kdy se odešle veliký packet, větší než 65535 bajtů(Max velikost)
    - to vede k přetečení zásobníku a selhání systému
    - dnes už jsou systémy vůči tomuto odolné
- **smurf attack**
    - útočník posílá packety upravené, tak aby vypadalo zdrojová IP adresa oběti
    - packety posílá jako broadcast, tím pádem všechny zařízení odpoví na síti
    - pokud je na síti hodně zařízení a dotazy se posílají často, může to mít za následek DOS
    - většinou DOS
- **teardrop attack**
    - posíláni fragmentovaných packetů, neposílají se celé
    - další fragmenty z ostatních packetů se začnou překrývat, kdy u starých systému vyvolá zhroucení
    - jedná se o starý útok, dnes už nepoužívaný

---

# Útoky na sítě

## ARP Spoofing

- používá se v interních sítích
    - lze pouze v síti, kde jsou L2 switche
- stojí mezi switchem/routrem a koncovým uživatelem
- zjistí IP adresu své oběti
- následně odesílá na router či switch ARP odpovědi s IP adresou oběti a svou MAC adresou
- Dynamic ARP inspection - L2 switchi
- útočník může zastavit nebo snifovat packety otevírat packety a číst z nich

## DNS Spoofing

<aside>
☝

DNS cache poison

</aside>

- mění záznam, aby uživatele přesměroval na jinou stránku, než bylo míněno

### proces

- útočník, čeká než oběť odešle požadavek na DNS resolution
    - poté útočník odešle falešnou odpověď DNS, která přesměruje na jinou stránku
    - při tomhle útoku se může použít ARP spoofing, Man-In-Middle attack

---

- útočník uloží falešný záznam do cache serveru

### Obrana

- **DNSSEC (DNS Security Extensions):** k odpovědím se přidává digitální podpis
- **HTTPS**: šifrování komunikace mezi prohlížečem a serverem
- **Firewall, IPS, IDS**

# **Session Hijacking**

- převezme relaci mezi klientem a serverem
- tento útok je možný protože, weby používají session tokeny
    - když útočník ukrade token, tak může se přihlásit za uživatele

### Proces

1. **vytvoření session tokenu od webu**
2. **získání tokenu**
    1. odposlech komunikace (MiM attack)
    2. scross-site scripting (XSS)
        1. útočník vloží škodlivý kód na stránku, která ukrade tokeny
    3. Session Fixation
        1. útočník, donutí oběť použít známý token
    4. ukradení cookie souborů
        1. kde může být uložen token
3. **po úspěšném ukradení tokenu, útočník převezme relaci**

[Kyberneticke_utoky_komplet.pptx](kybernetick%C3%A9%20%C3%BAtoky%20DOS%20a%20DDOS/Kyberneticke_utoky_komplet.pptx)