# Kyberprostor (cyberspace)

> "fiktivní prostředí, dochází v něm ke komunikaci přes síť"
> 

**ČR kyberprostor:** "kyberprostor pod jurisdikcí České republiky"

- tvoří informační/komunikační technologie, protokol TCP/IP

# Vrstvy kyberprostoru

- **fyzické**
    - síťové komponenty
    - kabely, switche...
- **logické**
    - logické propojení mezi uzly
    - přes protokoly
    - PC, tel...
- **sociální**
    - **kyberosobnost** a osobnost
    - identifikace osob (email/IP adresa)
    - může být i více kyberosobností, více emailů

# Úrovně kyberprostoru

1. **surface web** – veřejný prostor
2. **deep web** – zaheslované, kde není přístup pro všechny
3. **dark web** - TOR

---

- hlavní priorita v politice, společnosti

> “bezpečnost jako vlastnost nějakého objektu nebo subjektu, která určuje stupeň, míru jeho ochrany proti možným škodám a hrozbám”
> 

**Bezpečnost**: vlastnost, chrání proti ztrátám

- ideální stav je **absolutní bezpečnost**, není dosažitelná

# Body podle bezpečnosti

1. o čí bezpečnost se jedná (organizace...)
2. co se chrání (osoba, data...)
3. před čím je chráněno (fyzické, kybernetické)
4. co musíme udělat, aby jsme ochránili data

# Principy kybernetické bezpečnosti

<aside>
📌

principy = zásady

</aside>

1. CIA (Confidentiality, Integrity, Availability)
2. prvky kybernetické bezpečnosti (lidé, technologie, procesy)
3. cyklus kybernetické bezpečnosti (Prevence, Detekce, Reakce)

## **CIA**

- **Confidentiality (C):** pouze pověření lidé nebo objekty mohou přistoupit k informacím
- **Integrity (I):** zabezpečuje data proti změnění/neoprávněným přístupům
    - AES – enkripce (celistvost)
- **Availability (A):** přístup k informacím bez omezení lidmi s oprávněním (dostupnost)

## Traffic light protocol

- potřeba sdílet info a data s citlivou povahou
- National Infrastructure Security Coordination Centre
- protokol TLP (Traffic light protocol) od 2000
- zdroj informací, označuje data barvou, jak má příjemce nakládat s daty

## **Red**

- nezveřejňovat (pouze pro **účastníky**)
- info nejlépe předávat pouze **osobně**

## **Amber**

- omezené zveřejnění (jen v **organizaci**)
- příjemce může stanovit **pravidla sdílení**

## **Green**

- omezené zveřejnění (pouze **komunita**)
- **nesmí** být mimo komunitu

## **White**

- není nijak omezeno
- bez omezení
- nežádoucí zveřejnění neboli narušení jejich **důvěrnosti/únik**

## Prvky kybernetické bezpečnosti

> "nejslabším článkem v bezpečnostním řetězci je člověk - jsou odpovědni za selhání bezpečnostního systému"
> 

### **Pozice**

- **strůjce** bezpečnosti (osoby, které se rozhodly implementovat řád)
- **příjemce** pravidel (rozhodly nebo jsou nuceny dodržovat řád)
- subjekty je potřeba chránit
- subjekty je potřeba proškolit
- riziko/hrozba v rámci vytváření/udržování kyberbezpečnosti

### **Technologie**

- je to prostředek, který nám umožní **se připojit** k internetu, popř. sítím
- koncové zařízení (PC, tablet, mobilní tel.)
- celá škála zařízení
- infrastruktura (LAN), aktivní prvky
- služby (server, aplikace)
- bezpečnost: firewall (IDS/IPS)
- prvky určené k autentikaci/autorizaci, monitoringu (analýze)
    
    **IDS** = Intrusion Detection System
    **IPS** = Intrusion Prevention System
    
- centrální správa uživatelů/rolí
- ochrana před škodlivým bodem (např. firewall, antivirové, anti spam)
- technologie pro záznam činností jednotlivých prvků ICT, admin a uživatelů (log system)
- aktivní a offline zálohovací systém, zálohy vitálních serverů, databáze (recovery system)
- správa síťové bezpečnosti (VLAN, DMZ, firewall)
    
    **VLAN** – virtuální segment sítě
    
    **DMZ** – demilitarized zone
    
- nešetříme na technologiích
- musíme udržovat sys. aktivní (HW a SW)

### **Lidé**

- musí **respektovat** pravidla
- pochopit pravidla
- základní porozumění **PC a technologiemi**
- vzdělávat se v oblasti kybernetické bezpečnosti

### Procesy

- bezpečnost není produkt, ale proces, navrhnout systém tak, aby všechna bezpečnostní opatření, mezi sebou spolupracovaly
- činnost, která slouží lidem

## řízení aktiv/rizik

- definice a kategorizace aktiv
- analýza a kategorizace rizik
- implementace ICT a aplikací
- správa uživatelů/rolí
- autorizace/autentizace
- údržba (aktualizace) systémů/služeb
- pravidelné zabezpečení jednotlivých PC systémů a služeb
- realizace nápravných opatření
- analýza nápravných opatření

---

- audit kybernetické bezpečnosti
- detekce anomálií či kybernetických útoků
- **reakce** na kybernetické útoky či jiné incidenty
- procesy k udržení kontinuity
- školení a cvičení
- provádět **simulace** kybernetických útoků (phishing, business e-mail compromise)
- organizace by měla mít nastavené pravidla ohledně lidských zdrojů
- **penetrační testování** zároveň umožňuje odhalit chyby

## Cyklus kybernetické bezpečnosti

![Diagram bez názvu.drawio (1).svg](Kyberprostor%20(cyberspace)/Diagram_bez_nzvu.drawio_(1).svg)

### Riziko, aktivum, zranitelnost

- nebezpečí, možnost škody, ztráty
- **tři otázky**
    1. Co špatného se může stát?
    2. Jaká je možnost/pravděpodobnost, že se to stane?
    3. Jak vážné (intenzita, velikost) mohou být účinky (dopady)?
- cokoliv, co má hodnotu
- může být **hmotné** (budova, systém) nebo **nehmotné** (informace)
- aktivem však může být i **vlastnost** (dostupnost/funkčnost), **dobré jméno a reputace**, **lidé** (uživatelé, admini) – jejich znalosti jsou také aktivem