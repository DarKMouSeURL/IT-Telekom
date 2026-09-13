# 13. otázka ZABEZPEČENÍ KONCOVÝCH STANIC, ŠIFROVÁNÍ

---

- operační systémy a jejich zranitelnost, aktualizace, bezpečné přihlašování
- zranitelnosti a vulnerability management
- firewall, antivirus, systémy EDR – popis architektury EDR
- popis symetrického a asymetrického šifrování, použití šifrování při datové komunikaci
- popis architektury PKI, postup při vydávání certifikátu

---

# operační systémy a jejich zranitelnost, aktualizace, bezpečné přihlašování

- chyba ve vývoji OS, kdy útočník ji může využít k napadení systému
    - špatně implementovaná funkce, která vede k otevření zranitelnosti OS

## Windows vs Linux

- produkty od společnosti Microslop má mnohem větší počet zranitelností než linuxové systémy
- **žádný** systém není odolný proti útoku včetně Linuxu či MacOS/iOS

![data do roku 2022](13%20ot%C3%A1zka%20ZABEZPE%C4%8CEN%C3%8D%20KONCOV%C3%9DCH%20STANIC,%20%C5%A0IFROV%C3%81N%C3%8D/image.png)

data do roku 2022

## Typy zranitelností

### přetečení vyrovnávací paměti

- program píše do paměti více než má paměť kapacitu
- útočník má možnost spustit vlastní kód s právy programu
- EternalBlue

### eskalovaní práv

- útočník získá větší práva, než jsou mu udělena
- možnost spravovat systém jako administrátor
- PrintNightmare

### Chybné nastavení konfigurace OS

- je to kdy nevědomě vytvoří zranitelnost operačního systému
    - např. chybné nastavení firewallu

## Aktualizace OS

- MicroSlop vydává každé druhé úterý záplaty na Windows (Patch Tuesday)
- dobrá praktika udržovat OS aktuální

**linux**

```bash
sudo apt update
```

```bash
sudo apt upgrade
```

## Řízení přístupu

- dobrá praktika mít účet v PC s co nejmenšími právy v systému, ale tak abychom mohli systém používat
    - druhý účet s Admin právy, používat v případě potřeby
- řízení úpravy, smazaní či vytvoření souborů

![úprava práv pro soubory ve Windows](13%20ot%C3%A1zka%20ZABEZPE%C4%8CEN%C3%8D%20KONCOV%C3%9DCH%20STANIC,%20%C5%A0IFROV%C3%81N%C3%8D/image%201.png)

úprava práv pro soubory ve Windows

```bash
chmod 777 soubor.txt
```

## šifrování dat

- bitlocker od Microslopu
- vhodné při fyzické krádeži zařízení
- zašifrování dat na disku, které jsou čitelné pouze s klíčem
- můžeme šifrovat jednotlivé soubory nebo celý disk

## Fyzické zabezpečení

- politika čistého stolu a prázdné obrazovky
    
    na stole zaměstnance by v jeho nepřítomnosti neměl být žádný pracovní dokumenty a jeho počítač uzamčený
    
- ochrana proti krádeži a zapojení cizích zařízeních jako key-logger

## bezpečné přihlašování

- **základ je silné a dlouhé heslo**
    - min 12-16 znaků
    - používat velká písmena, číslice a speciální znaky
    - pro každou služby či účet používat jiné heslo
- **2 fázové ověření**
    - ověření přihlášení pomocí **jiného zařízení**
    - ověření pomocí **aplikace** (MS Authenticator, Google Authenticator)
    - ověření pomocí **SMS kód**
    - ověření pomocí **e-mail kód**
    - ověření pomocí **fyzického klíče USB/NFC**
- **Single Sing-On**
    - přihlášení do aplikací pomocí jednoho jména a hesla
    - Okta, Microslop Entra ID…

# zranitelnosti a vulnerability management

<aside>
📌

řízení zranitelnosti

</aside>

> zranitelnost = slabina v systému, kterou útočník může využít
> 
- cyklus detekce, identifikace a vyhodnocování rizik
- spadají do toho OS, síťové prostředky, software a infrastruktura;
- využívají se **sken zranitelností**
- snaha o co nejjednodušší a efektivní snížení hrozeb/zranitelností

## postup managementu

1. detekce
2. přiřazování závažnosti zranitelnosti
3. prioritizace zranitelností
4. vymýcení rizika

![image.png](13%20ot%C3%A1zka%20ZABEZPE%C4%8CEN%C3%8D%20KONCOV%C3%9DCH%20STANIC,%20%C5%A0IFROV%C3%81N%C3%8D/image%202.png)

## standarty

### Common Vulnerability and Exposure Systems (CVE)

- stránka pro potvrzené zranitelnosti v systémech
- mezinárodní
- každá zranitelnost má svůj unikátní kód (např. CVE-2026-123)
- od společnosti MITRE
- každý záznam má svůj kód, popis zranitelnosti a skóre zranitelnosti

#### **Stupně závažností zranitelnosti**

| **Závažnost** | **Skóre** | **Akce** |
| --- | --- | --- |
| **Critical** | 9.0–10.0 | Okamžitý patch / mitigace |
| **High** | 7.0–8.9 | Patch do 7–30 dní |
| **Medium** | 4.0–6.9 | Plánovaný patch |
| **Low** | 0.1–3.9 | Dle možností |

### National Vulnerability Database (NVD)

- rozšíření pro CVE
- od U.S.

### Known Exploited Vulnerabilities (KEV)

- od U.S. (CISA)
- podobné jako NVD

## nástroje pro správu zranitelností

- nessus
- OpenVAS
    - Green bone security management
- Qualys
- Microslop Defender Vulnerability Management

# firewall, antivirus, systémy EDR – popis architektury EDR

## Softwarový firewall (personální)

> **softwarový** = program v OS
> 
- filtruje provoz podle nastavených pravidel
- filtruje příchozí a odchozí provoz
- přichází s před nastavenými pravidly
- řešení od Mircoslopu → Windows defender

## Hardwarový firewall (síťový)

> **hardwarový** = fyzické zařízení v sítí
> 
- odděluje síťové prvky
- filtruje provoz podle nastavených pravidel
- nutné nastavit si vlastní pravidla
- drahé zařízení a drahá licence
- výrobce např. Forinet, Cisco…

### **Packet Filter (Stateless)**

- základní firewall
- pracuje na 3. a 4. vrstvě ISO/OSI
- kontroluje IP adresu, protokol, porty

### **Applications proxy/firewall**

- může nahlížet až do aplikační vrstvy
- filtruje na 3, 4, 5 a 7 vrstvě ISO/OSI
- proxy: umí přesměrovat, prostředník

### **Stateful Inspection**

- kontroluje spojení mezi zařízeními
- nejběžnější
- kotroluje podle stavové tabulky

### NEXT-GEN

![image.png](13%20ot%C3%A1zka%20ZABEZPE%C4%8CEN%C3%8D%20KONCOV%C3%9DCH%20STANIC,%20%C5%A0IFROV%C3%81N%C3%8D/image%203.png)

## antivirus

- software pro sken programů a souborů
- lehké nasazení a škálování
- běží na počítači lokálně
- používá se databáze známých virů
- v minulosti se používala signatura stringů
    
    **signatura** = unikátní otisk viru
    
- dnes se používá emulace kódu, heuristika a analýzu chován
- jsou placené nebo zdarma
- např. Windows Defender, Eset, Norton…

## systémy EDR

<aside>
📌

***E**ndpoint **D**etection and **R**esponse*

</aside>

- je to systém pro zabezpečení koncových stanic
- monitoruje koncové zařízení a dělá automatické akce na základě požadavků
    
    > **konocové body** = PC, IoT, servery i viruální PC
    > 
- příchozí data od zařízeních se analyzují → odhalení kybernetické hrozby (potřebuje agenta EDR)
- řešení pro firmy a velké organizace s hodně koncovými zařízeními
- řešení bezpečnostních incidentů v reálném čase
- např. **BitDefender GravityZone**

### popis architektury EDR

1. máme koncové zařízení na kterých běží EDR-agenti
2. server na kterém běží řešení EDR

![Tento obrázek bude na maturitě ](13%20ot%C3%A1zka%20ZABEZPE%C4%8CEN%C3%8D%20KONCOV%C3%9DCH%20STANIC,%20%C5%A0IFROV%C3%81N%C3%8D/1_KzUvLo6cfGJ2UiKyw_HXLw.jpg)

Tento obrázek bude na maturitě 

# popis symetrického a asymetrického šifrování, použití šifrování při datové komunikaci

<aside>
⚠️

šifrování ≠ kódování

</aside>

## Symetrické šifrování (konveční)

- pro šifrování a odšifrování se používá **stejný klíč**
- šifruje a od-šifrovává se **stejným klíčem**
- výměna klíče přes **Diffieho-Hellmanova** procesu
    - **bezpečná** výměna klíčů přes internet
    - použití asymetrické šifry
    - bez toho aby si klíč mohl někdo odposlouchávat
    - dobrá praktika použití **elektronických podpisů** (pro ověření účastníků)
- obecně **jednodužší** než asymetrická
- menší výpočetní náročnost
- nutnost sdílet klíč skrz internet

#### bezpečnost

- jsou náchylné na “known-plaintext”, “chosen-plaintext” útoky
- čím **větší** klíč, tím větší **bezpečnost**
    - ale **větší** výpočetní náročnost
- moderní šifry jsou **odolnější** vůči post kvantovému dešifrování s dlouhým klíčem

![image.png](13%20ot%C3%A1zka%20ZABEZPE%C4%8CEN%C3%8D%20KONCOV%C3%9DCH%20STANIC,%20%C5%A0IFROV%C3%81N%C3%8D/image%204.png)

### proudové symetrické šifry

- šifrování po jednotlivých bitech

> RC4, CHACHA20
> 

### blokové symetrické šifry

- obsah zprávy se rozdělí na stejné bloky
    - bloky se šifrují

> AES-128/AES-256, RC2, RC5, Blowfish…
> 

### použití

- TLS
- šifrování disku a souborů

## Asymetrické šifrování

- pro šifrování a odšifrování se používá **dva klíče**
    - **veřejný** a **privátní**
    - správnost klíčů je ověřena pomocí digitálního certifikátu
    - **šifruje** se **veřejným** klíčem volně dostupný na internetu
- **jednosměrná funkce** → nelze použít na dešifrování stejný klíč
- náchylné na kvantové dešifrování
- náročnější na výpočetní výkon
- použití pro **digitální certifikáty…**
- zajišťuje důvěrnost, autenticitu a integritu zprávy
    
    **důvěrnost** - znemožnění čtení neoprávněné osobě
    
    **autenticita** - zpráva pochází od autora
    
    **integrita** - nemožnost pozměnit zprávu
    

### postup

1. generace dvou klíčů
    1. jeden je veřejný
    2. druhý je privátní
2. zveřejnění veřejného klíče
3. šifrování zprávy pomocí veřejného klíče příjemce
4. dešifrování zprávy pomocí privátního klíče příjemce

> např. RSA, ECDSA
> 

![image.png](13%20ot%C3%A1zka%20ZABEZPE%C4%8CEN%C3%8D%20KONCOV%C3%9DCH%20STANIC,%20%C5%A0IFROV%C3%81N%C3%8D/image%205.png)

### bezpečnost

- útočník nemůže pomocí veřejných klíčů dešifrovat zprávu

#### Man-in-the-middle útok

- může nastat útok man-in-the-middle útok
- útočník “stojí” mezi stranami a odposlouchává komunikaci
- útočník předstíraje že je druhá strana

---

1. útočník rozešle stranám svůj veřejný klíč
2. svým privátním klíčem rozšifrovává komunikaci

![mitm útok](13%20ot%C3%A1zka%20ZABEZPE%C4%8CEN%C3%8D%20KONCOV%C3%9DCH%20STANIC,%20%C5%A0IFROV%C3%81N%C3%8D/image%206.png)

mitm útok

## Hybridní šifrování (symetrické + asymetrické)

- kombinace dvou šifrovacích metod
- pro lepší efektivnost komunikace
    - symetrická šifra → menší nároky na výkon
1. dohodnutý symetrický klíč je přenes pomocí asymetriké šifry
2. data pak jsou šifrována pomocí symetrické šifry

---

# popis architektury PKI, postup při vydávání certifikátu

<aside>
📌

***P**ublic **K**ey **I**nfrastructure*

</aside>

- použití pro ověření účastníků komunikace
- mitigace mitm útoku
- asymetrické šifrování
- používá se pro HTTPS-SSL/TLS

### certifikační autorita (CA)

- vydává, odvolává a obnovuje certifikáty
- uchovává veřejné klíče a ověřuje účastníky komunikace

### registrační autorita (RA)

- zpracovává požadavek na založení certifikátu
- zpracovává požadavek na odvolání certifikátu

### validační autorita (VA)

- ověření platnosti certifikátu

## postup při vydávání certifikátu

1. správce webové domény odešle požadavek(CSR) na vydání certifikátu u RA
    1. **CSR** - ***C**ertifikate **S**igning **R**equest*
2. RA zpracuje požadavek a odešle jej CA
3. CA vydá certifikát správci webové domény pro použití a předá informace VA
4. uživatel použije certifikát pro svou webovou stránku (shop.com)
5. kontrola certifikátu u VA

![tento obrázek bude na maturitě](13%20ot%C3%A1zka%20ZABEZPE%C4%8CEN%C3%8D%20KONCOV%C3%9DCH%20STANIC,%20%C5%A0IFROV%C3%81N%C3%8D/Public-Key-Infrastructure.svg)

tento obrázek bude na maturitě