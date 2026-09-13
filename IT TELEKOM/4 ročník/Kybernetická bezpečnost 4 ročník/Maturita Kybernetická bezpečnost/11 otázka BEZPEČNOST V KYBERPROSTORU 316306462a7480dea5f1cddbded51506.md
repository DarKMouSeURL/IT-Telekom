# 11. otázka BEZPEČNOST V KYBERPROSTORU

---

- základní pojmy: kyberprostor, kybernetická bezpečnost, zranitelnost, digitální stopa, kybernetický bezpečnostní incident a událost, triáda CIA, prvky LTP
- zákon a vyhláška o kybernetické bezpečnosti
- analýza aktiv a rizik, management kybernetické bezpečnosti, bezpečnostní politiky
- ochrana autorských práv v kyberprostoru
- hlášení bezpečnostních útoků, CERT/CSIRT týmy

---

# základní pojmy: kyberprostor, kybernetická bezpečnost, zranitelnost, digitální stopa, kybernetický bezpečnostní incident a událost, triáda CIA, prvky LTP

# Kyberprostor

- Kyberprostor je **virtuálním** prostorem technologických zařízení.
- Slouží k propojení mezi lidmi přes internet.
- složen ze 3 vrstev
    - Fyzické, Logické a Sociální
- rozdělen podle dohledatelnosti
    1. Surface Web
    2. Deep Web
    3. Dark Web

> „Digitální prostředí umožňující vznik, zpracování a výměnu informací, tvořené informačními systémy, a službami a sítěmi elektronických komunikací“
> 

# kybernetická bezpečnost

- ochrana sítě, informací a dat před kyb. útoky a hrozbami
- snaha zachovat bezpečnost informací
- může být sada procesů, postupů a technologické řešení, které chrání před útoky
- ochrana prvku proti ztrátám
- ochrana CIA triády

> „Souhrn právních, organizačních, technických a vzdělávacích prostředků směřujících k zajištění ochrany kybernetického prostoru."
> 

# zranitelnost

- Slabé místo v systému, které může být zneužito útočníkem.
- Může to být chyba v softwaru nebo lidský faktor.
    - nesprávná konfigurace, zranitelnost kódu...

### Dělení

1. **známé (publikované CVE)**
    1. **opravené**
    2. **neopravené**
2. **neznámé**

# digitální stopa

- zanechání stopy na internetu vlastní činností
- zanechání stopy je buď chtěně nebo nechtěně
    - chtěně = vědomě uživatelem
    - nechtěně = sbírání informací při prohlížení webových stránek
- dig. stopy jsou uložené na zařízení uživatele nebo na serverech
    - uložené na zařízení = historie vyhledávání lokálně
    - uložené na severech = logy

# kybernetický bezpečnostní incident

- narušení bezpečnosti informací v kyberprostoru
- narušení počítačových systémů
- incident = potvrzené zneužití systému

> podařený pokud o přihlášení k účtu útočníkem
> 

# kybernetická bezpečnostní událost

- jedná se o podezřelou aktivitu, která nevyústila k incidentu

> **ne**podařený pokud o přihlášení k účtu útočníkem
> 

# triáda CIA

<aside>
📌

***C**onfidentiality, **I**ntegrity, **A**vailability*

</aside>

<aside>
🇨🇿

*důvěrnost, celistvost, dostupnost*

</aside>

- souhrn rizik pro data a informace
- univerzální standart pro hodnocení rizik
- **Confidentiality (důvěrnost)**
    - pouze oprávněné osoby mají přístup k informacím
- **Integrity (celistvost)**
    - informace jsou bez úprav a jsou nepozměněna nikým jiným
    - kontrolní součty, hash funkce…
- **Availability (dostupnost)**
    - informace jsou dostupné a lze je získat
    - když data nejsou dostupná, označuje se jako DOS/DDOS útok

![image.png](11%20ot%C3%A1zka%20BEZPE%C4%8CNOST%20V%20KYBERPROSTORU/image.png)

![tento obrázek bude na maturitě](11%20ot%C3%A1zka%20BEZPE%C4%8CNOST%20V%20KYBERPROSTORU/301cd154-07c9-4f2d-8c35-41b64d53fb99.png)

tento obrázek bude na maturitě

# prvky LTP

<aside>
📌

***L**idé **T**echnologie **P**rocesy*

</aside>

- řízení organizace a činnosti ve firmě v kybernetické bezpečnosti
- propojený systém, části ovlivňují celek
- **Lidé**
    - zaměstnanci/uživatelé systému
        - napadnutelní sociálním inženýrstvím (phishing…)
    - nejslabší článek v řetězci
    - přijímají a vytváří pravidla kyb. bezpečnosti
- **Technologie**
    - označuje dostupné technologie nejen pro kybernetickou bezpečnost v rámci firmy
    - veškeré IT zařízení (PC, mobil…)
        - Firewally, IDS/IPS, antiviry na koncových zařízeních, sys logování…
- **Procesy**
    - činnost pro interakci s technologiemi
    - řízení aktiv a rizik
    - procedury, bezpečnostní politiky pro zachování bezpečnosti ve firmě
    - správa rolí, aktualizace systému…
    
    ![image.png](11%20ot%C3%A1zka%20BEZPE%C4%8CNOST%20V%20KYBERPROSTORU/image%201.png)
    

---

# zákon a vyhláška o kybernetické bezpečnosti

# **Zákon č. 264/2025 Sb.**

> *Zákon o kybernetické bezpečnosti*
> 
- uplatnění směrnice NIS2 od EU
- nové požadavky na bezpečnostní opatření
- nové požadavky při hlášení incidentu

---

- detail opatření
- dokumentace
- incident

# **Vyhláška č. 410/2025 Sb.**

> *O bezpečnostních opatřeních poskytovatele regulované služby v režimu nižších povinností*
> 
- doplňuje zákon 264/2025
- povinnost zavést **kybernetické opatření**
- **zdokumentované, aktualizované a přezkoumané**
- pravidlo pro **přístup, školení, řízení incidentů a testování bezpečnosti**

---

- kdo co musí dělat
- co se musí dělat

---

# analýza aktiv a rizik, management kybernetické bezpečnosti, bezpečnostní politiky

# Aktivum

- cokoliv co má hodnotu pro firmu nebo osobu
- může být
    - **hmotná** (Počítačová síť, budova…)
    - **nehmotná** (informace, znalosti…)
    - vlastnost, dobré jméno firmy, lidé…
- analýza aktiv se dělá pomocí CIA triády

# Riziko

> “nebezpečí, možnost škody, ztráty…”
> 
- je to možnost výskytu incidentu
- popisuje jak moc je velká pravděpodobnost útoku

# analýza aktiv a rizik

- analýza všech aktiv a zařazení
    - hardware, software, infrastruktura…
- analýza všech rizik týkajících se aktiv
- vytváření doporučení pro zmírnění rizik
- postupy a metody: NIST, ISO 27000

### Postup

1. identifikace rizik
2. posouzení rizik - vážnost a dopad rizik
3. prioritizování rizik - věnování se rizik s větší hrozbou
4. odstranění rizik

### typy

1. kvalitativní
2. kvantitativní

# management kybernetické bezpečnosti

- implementace řešení pro kybernetickou bezpečnost
- tvoření bezpečnostních politik, řízení rizik a monitorování kyb. bezpečnosti

## Frameworky

### OWASP

<aside>
📌

***O**pen **W**eb **A**pplication **S**ecurity **P**roject top 1O*

</aside>

- zabezpečení webových aplikací
- otevřený standart pro všechny
- soustředí se na nejčastější a nejvýznamnější bezpečnostní hrozby

### NIST

<aside>
📌

**N**ational **I**nstitute of **S**tandarts and **T**echnology program

</aside>

### ISO 27000

<aside>
📌

***I**nternational **O**rganization for **S**tandarts 27000 series*

</aside>

- soubor pravidel pro kybernetickou bezpečnost

# bezpečnostní politiky

- soubor principů a postupu pro zajištění kybernetické bezpečnosti
- snižuje riziko pro kybernetický incident
- určuje co je povoleno a co ne v počítačové síti
- politiky se mění podle aktuálních hrozeb

### Příklady

- použití pouze programů v rámci firmy, které jsou schválené IT oddělením
- 2 fázové ověření

---

# ochrana autorských práv v kyberprostoru

- ochrana autorských děl
    - duševní vlastnictví
- autor díla má právo jak bude s dílem nakládáno
- grafické díla, počítačové programy…

## CopyLeft

- “některá práva vyhrazena”
- GNU (General Public License)
- creative commons

## CopyRight

- autor má exkluzivní práva na dílo

## DMCA

<aside>
📌

***D**igital **M**illennium **C**opyright **A**ct*

</aside>

![image.png](11%20ot%C3%A1zka%20BEZPE%C4%8CNOST%20V%20KYBERPROSTORU/image%202.png)

- americký zákon ohledně krádeže duševního vlastnictví
- vyšel v platnost 1998

---

# hlášení bezpečnostních útoků, CERT/CSIRT týmy

- hlášení o útocích je zakotveno v legislativě
- nahlašujeme když se poruší CIA
- zamezení budoucích kybernetických útoků
- podpora kultury bezpečnosti
- hlášení pomocí formuláře na NÚKIB nebo ÚOOÚ
    
    [Portál NÚKIB](https://portal.nukib.gov.cz/chci-vyridit/hlaseni-kybernetickeho-bezpecnostniho-incidentu/hlaseni-incidentu-dle-noveho-zakona-o-kyberneticke-bezpecnosti)
    
    [Úřad pro ochranu osobních údajů](https://uoou.gov.cz/profesional/poruseni-zabezpeceni-osobnich-udaju)
    

---

# CERT/CSIRT týmy

- skupiny zabývající se kybernetickými incidenty
- skupiny mohou být národní, mezinárodní nebo soukromé
- vznik 80. léta
- mají jasně stanovené pole působnosti
- sdílení informací o kybernetických incidentech

## CERT

<aside>
📌

***C**omputer **E**mergency **R**esponse **T**eam*

</aside>

- podpora při kybernetických incidentech
- CERT - EU
    - podpora všech evropských institucí
- vydávání ročních zpráv o kybernetické bezpečnosti
- většina zemí má svůj CERT tým
- větší firmy mohou mít svůj CERT tým
- tým se nasazuje při podezření na incident nebo potvrzený incident

## CSIRT

<aside>
📌

***C**omputer **S**ecurity **I**ncident **R**esponse **T**eam*

</aside>

- analýza incidentu
- podpora při incidentech
    - nalezení zranitelnosti v systému
    - obnova systému při incidentu
    - analýza incidentu
- podobné jako CERT