# 15. otázka SÍŤOVÉ PROSTŘEDKY KYBERNETICKÉ BEZPEČNOSTI

---

- fyzické zabezpečení počítačové sítě
- základní typy útoků na počítačovou síť a její služby
- proxy server – definice, použití a význam
- IDS a IPS – popis a vysvětlení rozdílů, dělení a typy IDS/IPS
- detekce anomálií v síťovém provozu, NetFlow, protokol SNMP

---

# fyzické zabezpečení počítačové sítě

> zabránění přístupu nepovolané osobě ve fyzickém světe
> 

## Důležité prvky zabezpečení

1. mít dedikovanou místnost pro servery (serverovna)
2. do serverovny mít přistup jenom povolaní lidé
    1. zabezpečení proti tailgating
        1. neoprávněná osoba projde do serverovny pomocí oprávněné osoby
    - pomocí klíčů / bezpečnostních RFID karet
        
        ![image.png](15%20ot%C3%A1zka%20S%C3%8D%C5%A4OV%C3%89%20PROST%C5%98EDKY%20KYBERNETICK%C3%89%20BEZPE%C4%8CNOS/image.png)
        
    - popřípadě mít jednotlivé racky taky zamčené
        
        ![image.png](15%20ot%C3%A1zka%20S%C3%8D%C5%A4OV%C3%89%20PROST%C5%98EDKY%20KYBERNETICK%C3%89%20BEZPE%C4%8CNOS/image%201.png)
        
- 3. u velkých komerčních data centrech je nutné aby jednotlivý zákazníci měly samostatné klece a měli přístup k nim pouze oni
    
    ![image.png](15%20ot%C3%A1zka%20S%C3%8D%C5%A4OV%C3%89%20PROST%C5%98EDKY%20KYBERNETICK%C3%89%20BEZPE%C4%8CNOS/image%202.png)
    
1. mít CCTV
2. mít laptopy zamčené pomocí biometrických zabezpečeních (Windows Hello)
    1. u stolních PC mít FIDO klíčenky pro přístup do PC
- 6. u přístupových a distribučních přepínačů jsou zabezpečené proti fyzickému připojení zařízení
    
    ![image.png](15%20ot%C3%A1zka%20S%C3%8D%C5%A4OV%C3%89%20PROST%C5%98EDKY%20KYBERNETICK%C3%89%20BEZPE%C4%8CNOS/image%203.png)
    

---

# základní typy útoků na počítačovou síť a její služby

## VLAN hopping

- obcházení virtuálního rozdělení sítě (VLAN)

### Double-tagging

- v rámci se poskládají 2 VLAN-ID
    - první VLAN-ID = útočníkova aktuální VLAN
    - druhá VLAN-ID = cílová VLAN
    
    ![image.png](15%20ot%C3%A1zka%20S%C3%8D%C5%A4OV%C3%89%20PROST%C5%98EDKY%20KYBERNETICK%C3%89%20BEZPE%C4%8CNOS/image%204.png)
    
- přes první SWITCH, který rámec projde se odstraní první VLAN-ID
- přes druhý SWITCH, se směruje podle druhého VLAN-ID
- je nutné aby komunikace procházela přes Trunk
- **řešení je vypnout DTP, vypnout TRUNK na portech**

## MAC address table flooding

- zaplavení rámců na switch přes všechny MAC adresy
- SWITCH se naučí že všechny MAC adresy jsou na jednom portu, kde je útočník
- SWITCH posílá veškerou komunikaci k útočníkovi
- útočník může nahlížet nebo upravovat komunikaci
- použití programu macof
- **řešení je nastavit [PORT-SECURITY](../../Po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B%204%20ro%C4%8Dn%C3%ADk/zabezpe%C4%8Den%C3%AD%20SWITCH%20312306462a748052b6c1c7a1e3d49ace.md) na SWITCH**

## DHCP starvation

- využití všech adres v DHCP poolu
- uživatelé se nebudou schopni připojit k síti, pokud nezbydou adresy
- **řešení je nastavit [PORT-SECURITY](../../Po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B%204%20ro%C4%8Dn%C3%ADk/zabezpe%C4%8Den%C3%AD%20SWITCH%20312306462a748052b6c1c7a1e3d49ace.md)**

## DHCP spoofing

- přiřazením neautorizovaným DHCP serverem
- poskytnutí falešného DNS serveru
- DNS může mít špatné záznamy pro kyb. útok
- taky jako default-gateway může útočník nastavit sama sebe, může nahlížet do komunikace
- **řešení je nastavit *ip dhcp snooping***

## ARP spoofing

- MITM útok
    - odposlouchávání komunikace
- útočník se vydává za uživatele u routeru
- útočník se vydává za router u uživatele
- útočník odesílá rámce s IP adresou cíle a svou MAC adresu
- použití programu arpspoof
- **řešení je nastavit [PORT-SECURITY](../../Po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B%204%20ro%C4%8Dn%C3%ADk/zabezpe%C4%8Den%C3%AD%20SWITCH%20312306462a748052b6c1c7a1e3d49ace.md), IP Source Guard**

![image.png](15%20ot%C3%A1zka%20S%C3%8D%C5%A4OV%C3%89%20PROST%C5%98EDKY%20KYBERNETICK%C3%89%20BEZPE%C4%8CNOS/image%205.png)

---

# proxy server – definice, použití a význam

## definice

- je to brána mezi uživatelem a internetem
- přes proxy jde veškerá komunikace mezi uživatelem a internet
- schovává uživatele a jeho IP adresu a sám vystupuje jako klient
- řídí provoz mezi uživatelem a internetem

![image.png](15%20ot%C3%A1zka%20S%C3%8D%C5%A4OV%C3%89%20PROST%C5%98EDKY%20KYBERNETICK%C3%89%20BEZPE%C4%8CNOS/image%206.png)

## použití

### Filtrovací proxy

- filtrace obsahu na webových stránkách
- hlavně použití pro firmy

### Cachovací proxy

> snižuje provoz, při opakovaných dotazech
> 
- odpověď na dotaz od uživatele se uloží do cache
- při stejném dotazu, třeba i od jiného uživatele, se stáhne odpověď z proxy

### Logovací proxy

- udržování záznamů o připojeních

### veřejné proxy

- proxy, která je dostupná pro všechny
- bez nutnosti platit

### SSL proxy

<aside>
📌

***S**ecure **S**ocket **L**ayer*

</aside>

- připojení je šifrované
    - uživatel ——SSL—→ proxy
    - proxy ——SSL—→ server služby

### Reverse proxy

- je umístěn před webovým serverem
- je vlastněný tou firmou co má webový sever
- pomáhá s zátěží webového serveru
- často cílem kybernetických útoků
    - nutnost lépe zabezpečit proti penetračnímu skenování

## využití

1. zvýšení zabezpečení
    1. může být použitý jako firewall
2. filtrování obsahu
3. zpřístupnění obsahu v jiné zemi
4. anonymita

---

# IDS a IPS – popis a vysvětlení rozdílů, dělení a typy IDS/IP

- fyzicky umístěn v síti
    - **monitoruje** síť v **reálném** čase
- často součástí Next-Generation firewallu
- detekce pomocí signatury nebo anomálně statistická detekce
    - **signatura** = jednoznačná identifikace hrozby
    - **anomálně statistická detekce** = odebrání vzorků z provozu sítě a porovnání s normálním provozem
- stejně jako u firewallu, měl by IPS být jako jediny uzel, přes který jde komunikace ze sítě a do sítě

## IPS

<aside>
📌

***I**ntrusion **P**revention **S**ystem*

</aside>

> taky někdy nazýván jako ***IPDS*** (***I**ntrusion **P**revention **D**etection **S**ystem*)
> 
- systém pro zachytávání a odstraňování kybernetických hrozeb a útoku
- automatické řešení bezpečnostních incidentů
- hlášení o kybernetických incidentech
- použití pro velké organizace a data centra

### síťově-orientovaná IPS

<aside>
📌

***N**etwork-based **I**ntrusion **P**revention **S**ystem *(NIPS**)

</aside>

- fyzické zařízení v síti
- jediný uzel, přes který jde komunikace ze sítě a do sítě

### Host-based IPS

<aside>
📌

***H**ost-based **I**ntrusion **P**revention **S**ystem *(HIPS**)

</aside>

- na koncových zařízeních

### bezdrátová IPS

<aside>
📌

***W**ireless **I**ntrusion **P**revention **S**ystem *(WIPS**)

</aside>

- pro monitorování bezdrátového přenosu

### analýza síťového chování

<aside>
📌

***N**etwork **B**ehavior **A**nalysis *(NBA**)

</aside>

- detekce DDOS útoku pomocí monitorování sítě

### útoky proti kterým brání IPS

- ARP spoofing
    - MitM útok
    - nahrazení záznamu v ARP tabulce oběti svou adresou
- DDoS
    
    > ***D**istributed **D**enial **o**f **S**ervice*
    > 
    - přehlcení systému hodně požadavky
    - použití vícero zařízení na útok (botnet)
- IP fragmentace
    - využití mechanismu fragmentace paketů pro zmatení systému jak má poskládat data zpátky
- OS fingerprinting
    - využití zranitelnosti OS
- sken portů
    - např. nmap
- Smurf
    - DDoS použití ICMP
    - ***ICMP*** = ***I**nternet **C**ontrol **M**essage **P**rotocol*

a více…

## IDS

<aside>
📌

***I**ntrusion **D**etection **S**ystem*

</aside>

- pouze detekce hrozeb
- hlášení o kybernetických útocích administrátorovy sítě

### síťově-orientovaná IDS

<aside>
📌

***N**etwork-based **I**ntrusion **D**etection **S**ystem *(NIDS**)

</aside>

- fyzické zařízení v síti
- jediný uzel, přes který jde komunikace ze sítě a do sítě

### Host-based IDS

<aside>
📌

***H**ost-based **I**ntrusion **D**etection **S**ystem *(HIDS**)

</aside>

- na koncových zařízeních

### Perimeter IDS

<aside>
📌

***P**erimeter **I**ntrusion **D**etection **S**ystem *(PIDS**)

</aside>

- umístěn na okraji sítě
- nejčastěji kvůli DMZ
    
    <aside>
    📌
    
    ***D**e**m**ilitarized **Z**one*
    
    </aside>
    
    - část sítě, kde organizace má svoje servery, které poskytují služby napříč internetem
    - segmentuje fyzicky síť na 2 části
    
    ![image.png](15%20ot%C3%A1zka%20S%C3%8D%C5%A4OV%C3%89%20PROST%C5%98EDKY%20KYBERNETICK%C3%89%20BEZPE%C4%8CNOS/image%207.png)
    

---

# detekce anomálií v síťovém provozu, NetFlow, protokol SNMP

## detekce anomálií v síťovém provozu

- detekce neobvyklého chování v reálném čase, které může být
    - kybernetická hrozba
    - špatně nastavené zařízení, které posílá příliš požadavků
- sběr telemetrických dat
    - záznamy o toku dat, pakety a logy
- vyhodnocení normálního “toku” dat v intranetu, podle kterého se vyhodnocuje aktuální provoz

### SYSLOG

- zaznamenání systémových zpráv ze síťových zařízených
- dělí se podle rizika
    
    
    | 7 | debug |
    | --- | --- |
    | 6 | informační |
    | 5 | notifikace |
    | 4 | upozornění |
    | 3 | chyba |
    | 2 | kritické |
    | 1 | hlášení |
    | 0 | pohotovost |

```jsx
logging userinfo
logging history debugging
logging trap debugging
logging origin-id hostname
logging host {ip-syslogServeru} transport udp port {port}
```

**Software pro logování**

1. Kiwi SYSLOG server
2. Splunk Light
3. Greylog

![image.png](15%20ot%C3%A1zka%20S%C3%8D%C5%A4OV%C3%89%20PROST%C5%98EDKY%20KYBERNETICK%C3%89%20BEZPE%C4%8CNOS/image%208.png)

## NetFlow

[](https://www.samuraj-cz.com/clanek/zarizeni-v-siti-pod-kontrolou/)

- protokol od Cisco
- sbírá data IP průtoku od zařízení (Flow Exporters)
    - routery, switche, firewally a hosti
- posbírané data se posílají ***kolektorovi***
- měří spotřebu pásma od jednotlivých aplikací
- sbírá meta-data
    - SOURCE/DESTINATION IP
    - porty
    - použitý protokol
    - rozhraní na zařízeních
    - počet přenesených bytů
- používá se pro analýzu provozu, bezpečnostní monitoring a výkonnostní problémy
- software *NTOP*

```jsx
ip flow-export source GigabitEthernet1/0/7
ip flow-export version 9
ip flow-export destination {ip-collector} {UDP-port}
```

![image.png](15%20ot%C3%A1zka%20S%C3%8D%C5%A4OV%C3%89%20PROST%C5%98EDKY%20KYBERNETICK%C3%89%20BEZPE%C4%8CNOS/image%209.png)

## protokol SNMP

<aside>
📌

***S**imple **N**etwork **M**anagement **P**rotocol*

</aside>

[](https://www.samuraj-cz.com/clanek/snmp-simple-network-management-protocol/)

- sada protokolů pro **správu sítě** / zařízení
- UDP 161
- sběr dat pro správu sítě
    - zátež linek, zátež hardwaru u zařízení, přenesené bity
- SNMPv3 - šifrování
- složena ze 2 částí
    - **Agent** - zařízení, které je monitorována
    - **Manager** - zařízení, kde se posílají a shromažďují data
- manager posílá požadavky na agenty

### SNMP TRAP

- je to podmínka nastavená u agenta
- kdy sám odešle managerovi SNMP data
- může to být výpade, kolize…

![image.png](15%20ot%C3%A1zka%20S%C3%8D%C5%A4OV%C3%89%20PROST%C5%98EDKY%20KYBERNETICK%C3%89%20BEZPE%C4%8CNOS/image%2010.png)

### OID

<aside>
📌

***O**bject **ID**entifier*

</aside>

- jednoznačné označení objektů v MIB
- každá vlastnost je definována jako OID

> **Iso(1).org(3).dod(6).internet(1).private(4).transition(868).products(2).chassis(4).card(1).slotCps(2)cpsSlotSummary(1).cpsModuleTable(1).cpsModuleEntry(1).cpsModuleModel(3).3562.3**
> 

> **1.3.6.1.4.868.2.4.1.2.1.1.1.3.3562.3**
> 

### MIB

<aside>
📌

***M**anagement **I**nformation **B**ase*

</aside>

- kolekce informací o objektech
- definuje objekty a jejich vlastnosti
- databáze objektů
- stromová struktura
- software → MIB manager

---