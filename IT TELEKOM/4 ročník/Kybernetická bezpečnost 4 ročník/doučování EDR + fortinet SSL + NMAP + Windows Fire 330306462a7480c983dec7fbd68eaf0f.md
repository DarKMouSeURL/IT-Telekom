# doučování EDR + fortinet SSL + NMAP + Windows Firewall | 3

> doučování bylo March 27, 2026
> 

<aside>
📌

na doučování jsme dělali body 15., 17. až 20.

</aside>

## Zadání

## Část 1: Firewall

**1.** Podle přiloženého diagramu zapojte síťovou infrastrukturu.

**2.** Pojmenujte oba firewally v souladu s topologií.

**3.** Na obou firewallech změňte standardní port pro šifrovanou webovou správu – nově použijte port 20443.

**4.** Nakonfigurujte na obou firewallech požadavky na složitost hesla administrátora: minimální délka 18 znaků, přičemž heslo musí obsahovat alespoň 2 malá písmena, 2 velká písmena, 2 číslice a 1 speciální znak.

**5.** Nastavte časový limit relace na 10 minut – po uplynutí této doby nečinnosti bude uživatel automaticky odhlášen.

**6.** Na firewallu EDGE-FW-local založte účet administrátora s přihlašovacím jménem `vpn_admin` (heslo libovolné). Tento účet musí mít oprávnění ke správě VPN a ke čtení firewall pravidel (bez možnosti jejich úprav).

**7.** Na firewallu EDGE-FW-remote založte účet administrátora s přihlašovacím jménem `_admin` (heslo libovolné). Oprávnění jsou stejná jako v předchozím bodě – správa VPN a čtení firewall pravidel.

**8.** Rozhraní WAN nakonfigurujte tak, aby IP adresa byla přidělována automaticky přes DHCP.

**9.** Rozhraním LAN3 na obou firewallech přiřaďte adresy odpovídající topologii ze sítě  – EDGE-FW-local dostane nižší adresu, EDGE-FW-remote vyšší. Hodnoty AA a BB sdělí vyučující.

**10.** Rozhraní LAN2 na firewallu EDGE-FW-local nakonfigurujte s první dostupnou adresou ze sítě.

**11.** Rozhraní LAN1 na firewallu EDGE-FW-remote nakonfigurujte s první dostupnou adresou ze sítě.

**12.** Na rozhraní LAN1 firewallu EDGE-FW-local vytvořte VLANy podle schématu a každé z nich přidělte první adresu z příslušného rozsahu.

**13.** Vytvořte následující pravidla pro provoz firewallem:

**a.** Každé pondělí mezi 12:00 a 13:00 zablokujte provoz z VLAN XX a VLAN YY na server SRV1 (v LAN2) – v tomto čase probíhá plánovaná údržba.

**b.** Z obou VLAN (XX i YY) zablokujte nešifrované poštovní protokoly SMTP, POP3 a IMAP.

**c.** Z VLAN XX povolte přístup na SRV1 výhradně přes protokoly HTTP a HTTPS.

**d.** Přístup na SRV1 z internetu umožněte pouze přes HTTPS a zajistěte jeho dostupnost prostřednictvím vhodného NAT překladu.

**e.** Server SRV2 zpřístupněte pouze pro SRV1, a to výhradně skrze Site-to-Site VPN tunel mezi oběma firewally.

**14.** Nakonfigurujte Site-to-Site VPN mezi EDGE-FW-local a EDGE-FW-remote s těmito parametry (ostatní nastavení jsou na vašem uvážení):

**a.** Sdílený klíč (preshared key): `Maturita2026-IT*`

**b.** Mezi firewally nebude aplikován NAT; VPN bude fungovat v režimu On Demand.

**c.** Směrování mezi podsítěmi zajistěte site-to-site VPN metodou Route-based VPN.

**d.** Ověřte funkčnost konfigurace.

**15.** Na firewallu EDGE-FW-local nakonfigurujte vzdálený přístup přes Remote-Access VPN (ostatní parametry jsou na vašem uvážení):

**a.** Proveďte základní nastavení SSL VPN.

**b.** Uživatel `student` (heslo `FortiGate123*`) bude mít přístup výhradně přes webový portál s jednou záložkou umožňující SSH připojení na linuxovou stanici s adresou 172.16.0.20.

**c.** Uživatel `ucitel` (heslo `FortiNet987*`) bude používat tunelový režim a bude mít neomezený přístup kdykoli a kamkoli.

**d.** Pro všechna VPN připojení vypněte split tunneling.

**e.** Otestujte funkčnost připojení pro oba uživatele.

**16.** Uložte a exportujte konfiguraci, poté ji nahrajte na síťové úložiště pod názvem příslušného síťového prvku.

![KB.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/KB.png)

[kb.drawio](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/kb.drawio)

109.49.67.32

172.16.80.0

10.0.40.0

10.0.60.0

---

## Část 2: Zabezpečení koncových stanic a analýza sítě

Zabezpečení PC1 a PC2 proveďte pomocí EDR nástroje Bitdefender GravityZone dostupného na adrese [https://edr.teleinformatika.eu/](https://edr.teleinformatika.eu/) (přihlašovací údaje obdržíte od vyučujícího).

**17.** Vytvořte instalační balíček pro Windows s názvem `PMZ-2026` zahrnující všechny dostupné moduly. Nastavte heslo pro odinstalaci na `CyberDay2026`. Balíček stáhněte a nainstalujte na obě stanice.

**18.** Vytvořte bezpečnostní politiku s názvem `PMZ-2026-PRIJMENI` (PRIJMENI = vaše příjmení bez diakritiky, velkými písmeny) s následujícím nastavením:

**a.** Ikona aplikace se bude zobrazovat ve skrytých ikonách systémové lišty Windows, notifikace budou ve formě pop-up oken.

**b.** Nastavte heslo Power User na `EdRPAss999*`.

**c.** Skenování při přístupu a spuštění souborů (On-Access, On-Execute) nastavte na normální režim.

**d.** Plánované skenování(On-Demand): úplný sken jednou týdně vždy v pondělí ve 12:15, rychlý sken každý den v 7:30 – pokud některý sken proběhnout nestihne, spustí se co nejdříve.

**e.** Firewall musí blokovat ping z koncové stanice a zakázat používání DNS serveru 8.8.8.8.

**f.** Uživatelům zablokujte Bluetooth zařízení a USB flash disky.

**g.** Zablokujte přístup na webové stránky seznam.cz a teleinformatika.eu.

**h.** Politiku nasaďte na svůj počítač a ověřte, že všechna nastavení fungují správně.

Pomocí nástroje Nmap spuštěného na linuxové stanici (login: `student`, heslo: `student`) proveďte síťový sken infrastruktury dle vlastního uvážení.

**19.** Na PC1 a PC2 nastavte Windows Firewall tak, aby prohlížeč Google Chrome mohl komunikovat výhradně šifrovaně (pouze HTTPS).

**20.** Povolte odpovědi na ping (ICMP) pouze pro provoz pocházející ze sítě 10.100.102.0/24.

---

## Část 3: Dokumentace

Vypracujte technickou dokumentaci v textovém editoru a uložte ji na `\\FS1\MATURITA\IKT\Odevzdání` pod názvem `KB_příjmení_jméno.docx`. Dokument musí obsahovat:

- **a.** Schéma síťové topologie (podklad je k dispozici na `\\FS1\MATURITA\IKT\Zadání`)
- **b.** Výsledky a zjištěné informace z bodů 14 a 15
- **c.** Printscreeny zachycující nastavení z bodů 12–13 a 16–17

## Část 1: Firewall

**1.** Podle přiloženého diagramu zapojte síťovou infrastrukturu.

**2.** Pojmenujte oba firewally v souladu s topologií.

**3.** Na obou firewallech změňte standardní port pro šifrovanou webovou správu – nově použijte port 20443.

**4.** Nakonfigurujte na obou firewallech požadavky na složitost hesla administrátora: minimální délka 18 znaků, přičemž heslo musí obsahovat alespoň 2 malá písmena, 2 velká písmena, 2 číslice a 1 speciální znak.

**5.** Nastavte časový limit relace na 10 minut – po uplynutí této doby nečinnosti bude uživatel automaticky odhlášen.

**6.** Na firewallu EDGE-FW-local založte účet administrátora s přihlašovacím jménem `vpn_admin` (heslo libovolné). Tento účet musí mít oprávnění ke správě VPN a ke čtení firewall pravidel (bez možnosti jejich úprav).

**7.** Na firewallu EDGE-FW-remote založte účet administrátora s přihlašovacím jménem `_admin` (heslo libovolné). Oprávnění jsou stejná jako v předchozím bodě – správa VPN a čtení firewall pravidel.

**8.** Rozhraní WAN nakonfigurujte tak, aby IP adresa byla přidělována automaticky přes DHCP.

**9.** Rozhraním LAN3 na obou firewallech přiřaďte adresy odpovídající topologii ze sítě  – EDGE-FW-local dostane nižší adresu, EDGE-FW-remote vyšší. Hodnoty AA a BB sdělí vyučující.

**10.** Rozhraní LAN2 na firewallu EDGE-FW-local nakonfigurujte s první dostupnou adresou ze sítě.

**11.** Rozhraní LAN1 na firewallu EDGE-FW-remote nakonfigurujte s první dostupnou adresou ze sítě.

**12.** Na rozhraní LAN1 firewallu EDGE-FW-local vytvořte VLANy podle schématu a každé z nich přidělte první adresu z příslušného rozsahu.

**13.** Vytvořte následující pravidla pro provoz firewallem:

**a.** Každé pondělí mezi 12:00 a 13:00 zablokujte provoz z VLAN XX a VLAN YY na server SRV1 (v LAN2) – v tomto čase probíhá plánovaná údržba.

**b.** Z obou VLAN (XX i YY) zablokujte nešifrované poštovní protokoly SMTP, POP3 a IMAP.

**c.** Z VLAN XX povolte přístup na SRV1 výhradně přes protokoly HTTP a HTTPS.

**d.** Přístup na SRV1 z internetu umožněte pouze přes HTTPS a zajistěte jeho dostupnost prostřednictvím vhodného NAT překladu.

**e.** Server SRV2 zpřístupněte pouze pro SRV1, a to výhradně skrze Site-to-Site VPN tunel mezi oběma firewally.

**14.** Nakonfigurujte Site-to-Site VPN mezi EDGE-FW-local a EDGE-FW-remote s těmito parametry (ostatní nastavení jsou na vašem uvážení):

**a.** Sdílený klíč (preshared key): `Maturita2026-IT*`

**b.** Mezi firewally nebude aplikován NAT; VPN bude fungovat v režimu On Demand.

**c.** Směrování mezi podsítěmi zajistěte site-to-site VPN metodou Route-based VPN.

**d.** Ověřte funkčnost konfigurace.

**15.** Na firewallu EDGE-FW-local nakonfigurujte vzdálený přístup přes Remote-Access VPN (ostatní parametry jsou na vašem uvážení):

**a.** Proveďte základní nastavení SSL VPN.

**b.** Uživatel `student` (heslo `FortiGate123*`) bude mít přístup výhradně přes webový portál s jednou záložkou umožňující SSH připojení na linuxovou stanici s adresou 172.16.0.20.

**c.** Uživatel `ucitel` (heslo `FortiNet987*`) bude používat tunelový režim a bude mít neomezený přístup kdykoli a kamkoli.

**d.** Pro všechna VPN připojení vypněte split tunneling.

**e.** Otestujte funkčnost připojení pro oba uživatele.

**16.** Uložte a exportujte konfiguraci, poté ji nahrajte na síťové úložiště pod názvem příslušného síťového prvku.

![KB.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/KB.png)

[kb.drawio](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/kb.drawio)

109.49.67.32

172.16.80.0

10.0.40.0

10.0.60.0

---

## Část 2: Zabezpečení koncových stanic a analýza sítě

Zabezpečení PC1 a PC2 proveďte pomocí EDR nástroje Bitdefender GravityZone dostupného na adrese [https://edr.teleinformatika.eu/](https://edr.teleinformatika.eu/) (přihlašovací údaje obdržíte od vyučujícího).

**17.** Vytvořte instalační balíček pro Windows s názvem `PMZ-2026` zahrnující všechny dostupné moduly. Nastavte heslo pro odinstalaci na `CyberDay2026`. Balíček stáhněte a nainstalujte na obě stanice.

**18.** Vytvořte bezpečnostní politiku s názvem `PMZ-2026-PRIJMENI` (PRIJMENI = vaše příjmení bez diakritiky, velkými písmeny) s následujícím nastavením:

**a.** Ikona aplikace se bude zobrazovat ve skrytých ikonách systémové lišty Windows, notifikace budou ve formě pop-up oken.

**b.** Nastavte heslo Power User na `EdRPAss999*`.

**c.** Skenování při přístupu a spuštění souborů (On-Access, On-Execute) nastavte na normální režim.

**d.** Plánované skenování(On-Demand): úplný sken jednou týdně vždy v pondělí ve 12:15, rychlý sken každý den v 7:30 – pokud některý sken proběhnout nestihne, spustí se co nejdříve.

**e.** Firewall musí blokovat ping z koncové stanice a zakázat používání DNS serveru 8.8.8.8.

**f.** Uživatelům zablokujte Bluetooth zařízení a USB flash disky.

**g.** Zablokujte přístup na webové stránky seznam.cz a teleinformatika.eu.

**h.** Politiku nasaďte na svůj počítač a ověřte, že všechna nastavení fungují správně.

Pomocí nástroje Nmap spuštěného na linuxové stanici (login: `student`, heslo: `student`) proveďte síťový sken infrastruktury dle vlastního uvážení.

**19.** Na PC1 a PC2 nastavte Windows Firewall tak, aby prohlížeč Google Chrome mohl komunikovat výhradně šifrovaně (pouze HTTPS).

**20.** Povolte odpovědi na ping (ICMP) pouze pro provoz pocházející ze sítě 10.100.102.0/24.

---

## Část 3: Dokumentace

Vypracujte technickou dokumentaci v textovém editoru a uložte ji na `\\FS1\MATURITA\IKT\Odevzdání` pod názvem `KB_příjmení_jméno.docx`. Dokument musí obsahovat:

- **a.** Schéma síťové topologie (podklad je k dispozici na `\\FS1\MATURITA\IKT\Zadání`)
- **b.** Výsledky a zjištěné informace z bodů 14 a 15
- **c.** Printscreeny zachycující nastavení z bodů 12–13 a 16–17

---

---

# 15. Na firewallu EDGE-FW-local nakonfigurujte vzdálený přístup přes Remote-Access VPN (ostatní parametry jsou na vašem uvážení):

## **a.** Proveďte základní nastavení SSL VPN.

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2045.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2046.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2047.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2048.png)

## **b.** Uživatel `student` (heslo `FortiGate123*`) bude mít přístup výhradně přes webový portál s jednou záložkou umožňující SSH připojení na linuxovou stanici s adresou 172.16.0.20.

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2049.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2050.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2051.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2052.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2053.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2054.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2055.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2056.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2057.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2058.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2059.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2060.png)

## **c.** Uživatel `ucitel` (heslo `FortiNet987*`) bude používat tunelový režim a bude mít neomezený přístup kdykoli a kamkoli.

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2061.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2062.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2063.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2064.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2065.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2066.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2067.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2068.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2069.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2070.png)

---

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2071.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2072.png)

## **d.** Pro všechna VPN připojení vypněte split tunneling.

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2073.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2074.png)

## **e.** Otestujte funkčnost připojení pro oba uživatele.

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2075.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2076.png)

---

# Část 2: Zabezpečení koncových stanic a analýza sítě

> Zabezpečení PC1 a PC2 proveďte pomocí EDR nástroje Bitdefender GravityZone dostupného na adrese [https://edr.teleinformatika.eu/](https://edr.teleinformatika.eu/) (přihlašovací údaje obdržíte od vyučujícího).
> 

# 17. Vytvořte instalační balíček pro Windows s názvem `PMZ-2026` zahrnující všechny dostupné moduly. Nastavte heslo pro odinstalaci na `CyberDay2026`. Balíček stáhněte a nainstalujte na obě stanice.

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2077.png)

![image (1).png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image_(1)%202.png)

![image (4) (1).png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image_(4)_(1).png)

![image (5).png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image_(5)%202.png)

# 18. Vytvořte bezpečnostní politiku s názvem `PMZ-2026-PRIJMENI` (PRIJMENI = vaše příjmení bez diakritiky, velkými písmeny) s následujícím nastavením:

![image (6).png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image_(6)%202.png)

![image (7).png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image_(7)%202.png)

## **a.** Ikona aplikace se bude zobrazovat ve skrytých ikonách systémové lišty Windows, notifikace budou ve formě pop-up oken.

![image (8).png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image_(8)%202.png)

## **b.** Nastavte heslo Power User na `EdRPAss999*`.

![image (9).png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image_(9)%201.png)

## **c.** Skenování při přístupu a spuštění souborů (On-Access, On-Execute) nastavte na normální režim.

![image (10).png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image_(10).png)

![image (11).png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image_(11).png)

## **d.** Plánované skenování: úplný sken jednou týdně vždy v pondělí ve 12:15, rychlý sken každý den v 7:30 – pokud některý sken proběhnout nestihne, spustí se co nejdříve.

![image (17).png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image_(17).png)

![image (18).png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image_(18).png)

![image (19).png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image_(19).png)

![image (20).png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image_(20).png)

## **e.** Firewall musí blokovat ping z koncové stanice a zakázat používání DNS serveru 8.8.8.8.

![image (21).png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image_(21).png)

![image (22).png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image_(22).png)

![image (23).png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image_(23).png)

![image (24).png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image_(24).png)

## **f.** Uživatelům zablokujte Bluetooth zařízení a USB flash disky.

![image (25).png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image_(25).png)

![image (26).png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image_(26).png)

![image (27).png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image_(27).png)

![image (28).png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image_(28).png)

## **g.** Zablokujte přístup na webové stránky seznam.cz a teleinformatika.eu.

![image (29).png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image_(29).png)

## **h.** Politiku nasaďte na svůj počítač a ověřte, že všechna nastavení fungují správně.

![image (30).png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image_(30).png)

![image (31).png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image_(31).png)

![image (32).png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image_(32).png)

---

# NMAP (6 b.)

> Pomocí nástroje Nmap spuštěného na linuxové stanici (login: `student`, heslo: `student`) proveďte síťový sken infrastruktury dle vlastního uvážení.
> 

## počet stanic (na síti 10.60.63.33)

```jsx
nmap **-sn** 10.60.63.0/24
```

## kolik stanic má otevřený port pro alternativní HTTP

```jsx
nmap **-sV -p http-alt** 10.60.63.0/24
```

## všechny otevřené porty na serveru 10.60.63.232

```jsx
nmap **-sV** 10.60.63.232
```

---

# Windows Defender

# 19. Na PC1 a PC2 nastavte Windows Firewall tak, aby prohlížeč Google Chrome mohl komunikovat výhradně šifrovaně (pouze HTTPS).

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2078.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2079.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2080.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2081.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2082.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2083.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2084.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2085.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2086.png)

# 20. Povolte odpovědi na ping (ICMP) pouze pro provoz pocházející ze sítě 10.100.102.0/24.

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2087.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2088.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2089.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2090.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2091.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2092.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2093.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2094.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2095.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2096.png)

![image.png](Maturita%20Kybernetick%C3%A1%20bezpe%C4%8Dnost/7%20zad%C3%A1n%C3%AD%20Kybernetick%C3%A9%20zabezpe%C4%8Den%C3%AD%20po%C4%8D%C3%ADta%C4%8Dov%C3%A9%20s%C3%ADt%C4%9B/image%2097.png)