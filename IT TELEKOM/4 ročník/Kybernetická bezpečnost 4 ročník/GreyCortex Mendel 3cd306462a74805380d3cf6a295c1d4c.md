# GreyCortex Mendel

GREYCORTEX Mendel

Základní uživatelský trénink

Autoři: Michal
Šrubař                                                                                      Verze:
1.09

# 1. Úvod

Počítačové
systémy jsou v dnešním světě všude okolo nás. Tyto systémy
obsahují velké množství informací, které sdílí s dalšími
počítačovými systémy, které jsou navzájem propojeny pomocí
počítačových síti. Na jednotlivých zařízeních běží
software, který nám pomáhá v každodenní práci, zajišťuje zábavu,
dostupnost a mnoho dalších funkcí, které dnes považujeme za samozřejmost.
Software na těchto zařízeních si povídá se softwarem na jiných
zařízeních pomocí zpráv. Zprávy, které si tyto zařízení
vyměňují jsou součástí síťového provozu. Monitorováním a
uchováváním tohoto síťového provozu je možné získat vhled do toho, jaká
data si jednotlivá zařízení vyměňují, komu tyto data
předávají a taky kdy.

Sledování chování
zařízení a toku dat je dnes nezbytné pro zajištění bezpečnosti
samotných zařízení, ale také dat, která uchovávají. Existuje mnoho
nástrojů, které pomáhají řešit otázky monitorování síťového
provozu. Systém Mendel vyvíjený společností GREYCORTEX je jedním
z nich.

Tento školící
materiál je určený pro koncové uživatele, kteří se systémem Mendel
zatím nemají žádné praktické zkušenosti. Materiál uživateli nejprve
představí, jak systém Mendel zapadá do monitorování dnešních TCP/IP síti a
jak mu může pomoci s viditelností do jeho sítě. Uživatel se
naučí, jak systém pracuje se síťovými daty, jakým způsobem je
uchovává a jak z těchto dat vytěžuje informace, které jsou
užitečné pro analýzu a vizualizaci monitorované počítačové
sítě. Uživatel se dále seznámí s detekčními schopnostmi systému,
které mohou pomoci při ladění síťových problémů, detekci
anomálií na síti nebo hledání škodlivé komunikace. Vše je prezentováno na
síťových datech, které byly vytvořeny pro tento školící materiál. Data
jsou uložena v pcap souborech a jsou součástí školícího materiálu. Uživatel
se také naučí, jak sestavit testovací prostředí, ve kterém si
může jednotlivé části prakticky vyzkoušet a formou cvičení také
ověřit nově nabyté znalosti.

Školící materiál byl
vytvořen týmem CyberOps, na základě praktických zkušeností
s každodenním používáním systému pro monitorování počítačových
sítí a řešením provozních a bezpečnostních otázek. Pokud máte zájem o
pokročilejší uživatelské školení přímo od členů týmu
CyberOps, kontaktujte prosím naši zákaznickou podporu na emailu [support@greycortex.com](mailto:support@greycortex.com).

# 2. Monitorování síťového provozu

## 2.1.
TCP/IP Sítě

V dnešních sítích
postavených na TCP/IP protokolu se vyskytuje mnoho typů zařízení,
které komunikují za pomoci různých protokolů a jsou mezi sebou
propojeny různými technologiemi. Mezi tyto zařízení dnes mohou
patřit mobilní i desktopové počítače, které používají lidé pro každodenní
práci. Mohou sem spadat také další podpůrná zařízení, která jim v
práci pomáhají, jako např. tiskárny, telefony, televize a další. Dále
mohou síť tvořit servery, na kterých běží aplikace nebo
uchovávají velké množství dat. Všechny tyto koncová zařízení jsou propojeny
pomocí různých drátových i bezdrátových technologií k síťovým
prvkům, díky kterým mohou tyto zařízení komunikovat mezi sebou.

![image001.png](GreyCortex%20Mendel/image001.png)

Obrázek 1 Příklad infrastruktury a prvků, které obsahuje.

Na Obrázek 1 můžeme vidět schéma ukázkové infrastruktury,
kde se nacházejí síťové prvky, které se označují jako tzv. Access Switche.
K těmto prvkům jsou připojeny koncová zařízení. Tyto
switche mohou být dále připojeny k tzv. distribučním switchům a
ty jsou většinou připojeny ke core switchi. Core switch bývá
většinou srdcem celé sítě, jelikož zajišťuje mnoho funkcí pro
chod celé sítě a také vidí většinu důležité komunikace na síti.
Jednotlivá zařízení na síti komunikují pomocí zpráv, které se
označují jako *pakety*. Paket si můžeme představit jako posloupnost
bajtů. Těmto bajtům dávají význam protokoly, které jsou
během komunikace použity. Analýzou paketů je možné zjistit mnoho
informací nejenom o dané síti a její architektuře, ale také o samotných
zařízeních, které jsou k dané síti připojeny a také jak se daná
zařízení na síti chovají, s kým komunikují a jaké zprávy si během
této komunikace posílají. Vhodným místem pro získávání paketů ze sítě
za účelem monitorování komunikace je právě core switch. Přes
tento prvek projde většinou každý paket poslaný z koncového zařízení
do/z sítě Internet. Tento prvek také většinou provádí směrování
(routing) mezi jednotlivými VLANami. Existuje více způsobů, jak
získat pakety, které přes core switch procházejí. Nejčastěji
používaná technologie je označovaná jako SPAN, tj. [Swiched Port ANalyzer](https://www.cisco.com/assets/sol/sb/Switches_Emulators_v2_3_5_xx/help/250/index.html#page/tesla_250_olh/span_overview.html). Pomocí této technologie je možné
zrcadlit příchozí, odchozí nebo příchozí i odchozí pakety z
konkrétního portu switche na jiný port. Díky tomu dojde k přeposlání
každého paketu z jednoho portu na tzv. SPAN port. K SPAN portu poté může
být připojeno zařízení pro analýzu síťových paketů. Na
některých zařízeních je možné blíže specifikovat, jak by mělo k
přeposílání paketů na SPAN port docházet a je tak možné
přeposílat např. pouze konkrétní VLAN ID. Díky této technologii je
možné monitorovat všechny pakety, které core switchem projdou a získat tedy
pasivně přehled o tom, co se v dané síti ze síťového pohledu
odehrává.

## 2.2.
Typ souboru packet capture

Pokud bychom data
na druhé straně SPAN portu začali ukládat do souboru, pak
vytvoříme soubor typu *packet capture*, který bude obsahovat
jednotlivé pakety. Soubor obsahující síťové pakety má většinou
příponu **.pcap**. Soubory tohoto typu jsou obecně označovány
jako tzv. pcapy a budou takto označovány i v tomto školícím materiálu.
Pro čtení takové souboru můžeme využít program [Wireshark](https://www.wireshark.org/),
který je výborným nástrojem pro analýzu souborů obsahující síťové
pakety. Podívejme se nyní na pcap soubor [pcaps\download-vlc-merlin-http.pcap](http://reymond.greycortex.com/trraining.htm#_Pcap_soubory). Když zkušený analytik projde rychle
jednotlivé pakety, uvidí na začátku komunikace DNS dotazy a poté
komunikaci s webovým serverem na portu 80/tcp. Wireshark nabízí mnoho zobrazení
a funkcí k tomu, aby se analytik v dané komunikaci rychle zorientoval.
Můžeme například použít zobrazení *Endpoints* z menu *Statistics*,
které nám řekne, kolik IPv4 adres v daném pcapu komunikuje. Na Obrázek 2  můžeme vidět, že v pcapu komunikují
pouze tři IP adresy, z nichž je pouze jedna z privátního rozsahu a to
192.168.1.2.

![image002.png](GreyCortex%20Mendel/image002.png)

Obrázek 2 Seznam IP adres, které v zachycené komunikaci komunikovaly.

Dále nám program Wireshark
může říct, jak mezi sebou koncová zařízení komunikovaly. Zobrazení
můžeme vidět pro jednotlivé protokoly v pohledu *Conversations*
z menu Statistics. Z pohledu protokolu IPv4 můžeme na Obrázek 3 vidět, že privátní IP adresa
192.168.1.2 komunikovala se dvěma veřejnými IP adresami a to
83.240.0.135 a 147.229.176.19.

![image003.png](GreyCortex%20Mendel/image003.png)

Obrázek 3 Zobrazení konverzací na úrovni IPv4 protokolu.

Z pohledu
transportního protokolu UDP můžeme na Obrázek 4 vidět, že zařízení z privátní
sítě komunikovalo pouze s veřejnou IP adresou 83.240.0.135.

![image004.png](GreyCortex%20Mendel/image004.png)

Obrázek 4 Komunikace privátní IP adresy z pohledu transportního protokolu UDP.

Můžeme si také
všimnout, že program Wireshark je schopen v obou případech
přesně sdělit, kdo s kým komunikoval, na jakém transportním
protokolu, kolik se během komunikace přeneslo dat a také, kdo danou komunikaci
zahájil. Na Obrázek 5 můžeme vidět, že program Wireshark
je také schopen zobrazit a uložit soubory, které byly přeneseny na
některých protokolech. V námi analyzovaném souboru byl přenesen spustitelný
soubor se jménem **vlc-3.0.17-win64.exe**, jehož velikost byla 43 MB a byl
stažen ze serveru se jménem **merlin.fit.vutbr.cz**.

![image005.png](GreyCortex%20Mendel/image005.png)

Obrázek 5 Seznam souborů, které byly zachyceny v síťové komunikaci.

Nástroj nabízí
mnoho dalších statistik, které mohou významně ulehčit práci
analytikovi, který zkoumá síťový provoz. Pro analýzu malých pcap
souborů dnes nástroj Wireshark v podstatě nemá konkurenci. Co
když ovšem potřebujeme analyzovat velké množství dat? Nebo potřebujeme
data analyzovat za běhu? Nebo chceme s daty dělat další
pokročilejší analýzu? Zde přichází na řadu systém Mendel, který
je vyvíjený společnostní [GREYCORTEX](https://www.greycortex.com/).

## 2.3.
Mendel

Systém si
můžete představit jako Wireshark na steroidech. Mendel nejen že umí
analyzovat síťový provoz, umí také ukládat metadata o monitorovaném
provozu, které je možné použít pro zpětnou analýzu. Data o provozu si ukládá
do své interní databáze a díky tomu se můžeme kdykoliv vrátit k datům
např. z minulého týdne. Nad uloženými daty se provádí další analýza, díky
které je možné ze síťových dat získat mnoho užitečných informací.
Obecně se systém Mendel specializuje na tři problémové domény,
kterými jsou:

1.    viditelnost do počítačové sítě,

2.    detekce síťových anomálií a hrozeb a

3.    aktivní reakce na zjištěné události.

### 2.3.1.
Viditelnost do sítě

Za pomoci
sledování síťového provozu je systém Mendel schopen poskytnout velice detailní
úroveň viditelnosti do infrastruktury, kterou monitoruje. Systém je
schopen klasifikovat jednotlivá zařízení do skupin, se kterými poté
může pracovat nejenom uživatel, ale také detekční mechanismy
samotného systému. Systém je dále schopen zaznamenávat, analyzovat a zobrazovat
komunikační vektory napříč celou sítí bez definice profilů
nebo dalšího nastavování. Jak můžeme vidět na Obrázek 6, uživatel systému má detailní
přehled o tom, kdo s kým komunikuje, jakým způsobem a co se
během komunikace děje. Tato funkcionalita je vhodná nejen pro
ladění a hledání síťových problémů, ale také pro hledání
síťových hrozeb.

![image006.png](GreyCortex%20Mendel/image006.png)

Obrázek 6 Systém Mendel přináší detailní vhled do počítačové
sítě.

### 2.3.2.
Detekce problémů a hrozeb

V síťovém
provozu se dnes může skrývat mnoho komunikace, která může být pro
danou sít nežádoucí jak z bezpečnostního, tak provozního pohledu.
Systém Mendel disponuje několika detekčními moduly, které cílí na
hledání těchto provozních a bezpečnostních problémů. Díky této
detekci je systém schopen odhalit provozní problémy před tím, než
začnou být kritické. Dokáže odhalit malware nainstalovaný na
zařízení, které je v monitorované infrastruktuře zapojeno nebo
také cílené aktivity útočníka, který má do sítě přístup a
připravuje se zaútočit nebo je již v poslední fázi svého útoku.
Na Obrázek 7 můžeme vidět mnoho typů
síťových aktivit, které mohou být pro prvky na síti nežádoucí. Mezi tyto
aktivity patří například:

·        
Tunelování
provozu skrze jiné protokoly.

·        
Porušování
bezpečnostních politik.

·        
Průzkumné
aktivity v rámci sítě.

·        
Přenosy
nežádoucího software, tzv. *malware.*

·        
Nežádoucí
komunikace s neautorizovanými servery.

·        
Únik
citlivých dat a mnoho dalších.

![image007.png](GreyCortex%20Mendel/image007.png)

Obrázek 7 Systém Mendel detekuje provozní i bezpečnostní anomálie v
síťovém provozu.

### 2.3.3.
Reakce na hrozby

Samotný vhled do
sítě a detekční mechanismy vám o síti prozradí mnoho informací. Ovšem
v případě detekce provozních nebo bezpečnostních
problémů je většinou potřeba jednat. Akce může
spočívat v upravení konfigurace některého z monitorovaných
systémů, vytvoření nového ACL pravidla, přidání pravidla na
firewall, spuštění antivirového programu a mnoho dalších. Tyto akce
může provést samotný správce sítě, v takovém případě
ovšem vzniká prodleva detekcí samotné hrozby a akcí, která má problém odstranit
nebo snížit jeho riziko.

Systém Mendel je
možné propojit se systémy, které na síti mohou provést akci pro zmírnění
rizika nebo zablokování škodlivé aktivity. Díky této integraci uživatel systému
Mendel získá možnost některé z těchto akcí provést přímo
při zjištění daného problému nebo systém nastavit tak, aby tyto
prevence provedl zcela automaticky. Na Obrázek 8 můžeme vidět, že systém Mendel
můžeme propojit s firewally a vytvářet tak pravidla, která
blokují příchozí nebo odchozí provoz. Systém Mendel je možné také
integrovat s produkty, které jsou schopny provést izolaci jednotlivých
zařízení na síti.

![image008.png](GreyCortex%20Mendel/image008.png)

Obrázek 8 Systém Mendel umí komunikovat s dalšími síťovými a
bezpečnostními prvky.

Tento školící
materiál vás provede jednotlivými částmi systému Mendel, naučí vás jej
používat a podrobně vám v jednotlivých sekcích vysvětlí, jak se systémem
efektivně pracovat.

# 3. Testovací prostředí

Nejefektivnější
způsob, jak se naučit používat systém Mendel, je ručně si
projít jednotlivé případy použití. Pro jednotlivé příklady byla
vytvořena testovací data v podobě pcap souborů, podobných jako
jsme viděli v sekci 2.2. Každý testovací pcap bude použit pro
demonstraci konkrétní funkcionality systému Mendel nebo pro demonstraci
nějakého síťového problému. Tato data budeme přehrávat do
systému Mendel a budeme zkoumat a učit se reakce systému. Pro tyto
účely bude nezbytné mít nainstalován systém Mendel a také druhý systém, ze
kterého budeme přehrávat do systému Mendel data. Tomuto systému dáme jméno
REPLAY. Pro účely tohoto školícího materiálu byl jako testovací
prostředí vybrán software [VMware ESXi](https://www.vmware.com/products/esxi-and-esx.html). Stejného cíle je ovšem možné docílit i jinými
způsoby.

## 3.1.
VMware ESXi

### 3.1.1.
Popis cílového stavu

Naše testovací
prostředí budou tvořit dva virtuální switche a dva virtuální počítače:

1.    VM REPLAY – přehrávač paketů.

2.    VM Mendel – systém Mendel.

3.    Virtuální switch HUB – distribuce
paketů z VM REPLAY do VM Mendel.

4.    Virtuální switch vSwitch0 – management
switch.

První systém se
jménem REPLAY může být libovolná linuxová distribuce, na kterou může
být nainstalován nástroj [tcpreplay](https://github.com/appneta/tcpreplay).
Tento program umí posílat pakety ze souboru na vybrané síťové rozhraní. Program
je distribuován jako standardní balíček na většinu dnes používaných
linuxových distribucí. Systém REPLAY bude přes síťové rozhraní
posílat pakety z vybraného pcap souboru, do virtuálního switche
s názvem *HUB*. Virtuální switch bude nastaven takovým způsobem,
aby všechny pakety obdržené na jednom portu, přeposlal na všechny ostatní
porty, tj. bude se chovat jako [hub](https://en.wikipedia.org/wiki/Ethernet_hub).

TODO:
Chce to logické schéma toho cílové stavu.

Tyto pakety bude přijímat
druhý systém, kterým bude systém Mendel. Systém bude přijaté pakety
zpracovávat a tímto docílíme přehrávání paketů z pcap souboru do
systému Mendel. Druhý virtuální switch s názvem vSwitch0 bude sloužit jako
management switch. Síťová rozhraní, které k tomuto switchi budou
připojena budou mít IP adresu, přes kterou budeme daná zařízení
spravovat. V následující sekci se podíváme na vytvoření jednotlivých
switchů, skupin portů a virtuálních počítačů pro
systémy, které budeme instalovat.

### 3.1.2.
Vytvoření virtuálních
switchů a skupin portů

Nejprve provedeme
vytvoření a nastavení standardního virtuálního switche (vSwitch0), který
budeme používat pro management našich zařízení. Pokud již VMware ESXi
provozujete delší dobu a pro jiné účely, je dost pravděpodobné, že
tento switch již existuje. Důležité je, aby virtuální počítače,
které v dalších sekcích vytvoříme, měly přístup do
sítě Internet a byli jste schopni se k oběma systémům
připojit na porty 22/tcp a 443/tcp. V případě, že pracujete
s čerstvě nainstalovanou instancí VMware ESXi, pak můžete
vytvořit tento switch podle Obrázek 9. Na obrázku můžeme vidět, že
vSwitch0 má připojen uplink rozhraní vmnic0. Pomocí tohoto uplink rozhraní
a skupiny portů s názvem *Management Network,* se budeme moci
přes síť připojit k tomuto switchi.

![image009.png](GreyCortex%20Mendel/image009.png)

Obrázek 9 Vytvoření virtuálního switche pro management zařízení.

V dalším
kroku vytvoříme pro tento switch novou skupinu portů (port group), do
které později připojíme dále vytvořené virtuální
počítače. Jak můžeme vidět na Obrázek 10, tuto speciální skupinu portů jsme
pojmenovali GREYCORTEX. Této skupině jsme nenastavovali žádné speciální
vlastnosti a u parametrů, kde to bylo možné, jsme ponechali možnost
zdědit nastavení z virtuálního switche vSwitch0. Do této skupiny
později přiřadíme management síťová rozhraní virtuálních
počítačů REPLAY a Mendel, které budou mít IP adresu.

![image010.png](GreyCortex%20Mendel/image010.png)

Obrázek 10 Vytvoření nové skupiny portů s názvem GREYCORTEX.

Nyní
vytvoříme druhý virtuální switch (HUB), který bude sloužit pro posílání
paketů z našeho REPLAY zařízení do systému Mendel. Na Obrázek 11 můžeme vidět nastavení tohoto
switche. Zejména si všimněme nastavení bezpečnostní politiky, kdy je
potřeba pro switch nastavit promiskuitní režim, vypnout používání MAC
Address tabulky a povolit změny MAC adres. Pokud tyto volby nenastavíme na
hodnotu Ano, pak se switch bude chovat jako klasický L2 switch a bude zahazovat
většinu paketů, které budeme z pcap souboru posílat na jeho porty,
protože na portech tohoto switche nebudou zařízení ani MAC adresy z přehrávaných
paketů.

![image011.png](GreyCortex%20Mendel/image011.png)

Obrázek 11 Vytvoření a nastavení switchi HUB.

Jako poslední
krok vytvoříme pro tento switch novou skupinu portů, kterou
pojmenujeme *Mirroring.* Na Obrázek 12 můžeme vidět, že pro tuto
skupinu nastavujeme VLAN ID hodnotu 4096. Za pomoci této hodnoty bude možné
v této skupině přijímat a odesílat pakety s libovolným VLAN
ID. Skupinu připojujeme k našemu nově vytvořenému
virtuálnímu switchi s názvem HUB. Dále si všimněme, že
bezpečnostní politiku dědíme z virtuálního switche.

![image012.png](GreyCortex%20Mendel/image012.png)

Obrázek 12 Vytvoření nové skupiny portů s názvem Mirroring na switchi HUB.

Na Obrázek 13 můžeme vidět stav virtuálního
switche HUB po vytvoření a přidání nové skupiny portů s názvem
Mirroring. Do této skupiny v následujících sekcích připojíme síťová
rozhraní systémů REPLAY a Mendel, přes která budeme odesílat a
přijímat vybraný síťový provoz.

![image013.png](GreyCortex%20Mendel/image013.png)

brázek 13 Stav virtuálního switche HUB (packet replay) po vytvoření nové
skupiny portů.

Nyní máme všechny
virtuální switche a skupiny portů vytvořeny a nastaveny, a
můžeme přejít k instalaci virtuálních počítačů,
které následně připojíme do nově vytvořených skupin
portů.

### 3.1.3. Instalace systému REPLAY

Nejprve provedeme
vytvoření virtuálního počítače REPLAY. Tento systém bude sloužit
pro přehrávání pcap souborů do systému Mendel. Pro tento systém nám
budou stačit pouze minimální systémové požadavky, jelikož jeho jediný
účel bude přehrávání pcap souborů pomocí programu tcpreplay. Finální konfiguraci tohoto virtuálního stroje
před jeho samotným vytvořením můžeme vidět na Obrázek 14.

![image014.png](GreyCortex%20Mendel/image014.png)

Obrázek 14 Finální konfigurace počítače REPLAY, před jeho
vytvořením.

Pro instalaci byla zvolena distribuce Ubuntu ve
verzi 18.04, ale může být použita jiná distribuce dle vlastního
výběru. Samotná instalace vámi vybrané linuxové distribuce je nad rámec
tohoto školícího materiálu. Po dokončení instalace je potřeba doinstalovat
a nastavit SSH server pro vzdálený přístup a také samotný nástroj tcpreplay pro přehrávání pcapů.
V případě naší distribuce můžeme použít příkaz:

**sudo apt install openssh-server tcpreplay net-tools**

Pro
ověření, zda je SSH server správně nainstalován a nastaven
provedeme přesun testovacího pcap souboru [pcaps\test-icmp-ping.pcap](http://reymond.greycortex.com/trraining.htm#_Pcap_soubory) na nově nainstalovaný systém REPLAY
pomocí programu scp:

**scp
test-icmp-ping.pcap msrubar@172.29.10.103:~**

V příkazu
zaměňte uživatele **msrubar** a IP adresu **172.29.10.103** dle
parametrů zvolených při instalaci systému REPLAY. Zkopírovaný pcap
obsahuje přibližně 3 minuty síťové ICMP komunikace, kterou
použijeme v sekci 3.1.5 pro ověření, že systémy
v našem testovacím prostředí jsou správně nainstalovány a
propojeny. Pomocí následujícího příkazu můžeme ověřit, že je
správně nainstalován nástroj tcpreplay.

**sudo
tcpreplay -V**

**V systému Ubuntu dále
doporučujeme zakázat IPv6 konektivitu kvůli zbytečnému šumu
multicast a dalších protokolů. Zakázání IPv6 konektivity při každém
startu systému provedeme pomocí systémového zavaděče GRUB, kde
v souboru** /etc/default/grub **přidáme hodnotu** ipv6.disable=1 **do proměnných**
GRUB_CMDLINE_LINUX_DEFAULT **a** GRUB_CMDLINE_LINUX**. Editaci souboru** /etc/default/grub **můžete
provést podle vámi zvoleného editoru, např.** vim
**nebo** nano**.**

**sudo
vim /etc/default/grub**

**Na** Obrázek 15 **můžeme vidět obsah těchto proměnných pro
nainstalovaný systém.**

![image015.png](GreyCortex%20Mendel/image015.png)

Obrázek 15 Nastavení proměnných systému GRUB
pro zakázání IPv6.

**Pro aplikaci této změny je dále
potřeba vygenerovat nové nastavení pro zavaděč GRUB pomocí
příkazu:**

**sudo
update-grub**

**Nyní si můžeme pomocí nástroje** ifconfig  **zobrazit seznam síťových
rozhraní. Jak můžeme vidět na** Obrázek 16 **naše nainstalovaná distribuce Ubuntu má dvě síťová rozhraní.
Rozhraní s názvem** ens160 **dostalo IP adresu z DHCP serveru
a bude sloužit jako management rozhraní. Druhé rozhraní s názvem** ens192
**bude sloužit pro přehrávání paketů z pcap souborů přes
virtuální switch HUB do systému Mendel.**

![image016.png](GreyCortex%20Mendel/image016.png)

Obrázek 16 Síťová rozhraní na nainstalovaném
systému REPLAY.

**Aby přehrávání pcapů bylo
možné, musí být rozraní** ens192 **ve stavu** up***.* Jelikož toto rozhraní nemá IP adresu, naše instance Ubuntu jej po
startu systému nastavovala do stavu down. Abychom nemuseli po každém startu
systému rozhraní nastavovat do stavu up, uděláme změnu
v konfiguraci systému Ubuntu. Konfigurace se provádí v souboru** /etc/netplan/01-netcfg.yaml**, kde přidáme chybějící rozhraní** ens192
**a nastavíme u volby** dhcp **hodnoty na** No**. Výsledný obsah konfiguračního souboru můžeme vidět na** Obrázek 17**. Přidání tohoto rozhraní** ens192
**zajistí, že rozhraní bude po startu systému ve stavu** up**.**

![image017.png](GreyCortex%20Mendel/image017.png)

Obrázek 17 Obsah souboru 01-netcfg.yaml po
přidání rozhraní ens192.

**Nyní můžeme systém REPLAY
restartovat a po restartu ověřit, že síťové rozhraní pro
přehrávání pcapů je ve stavu up a nemá nastavenou IPv6 nebo IPv4
adresu. Ověření můžeme provést pomocí programů** ifconfig **nebo** ip**.** Systém
REPLAY je nyní připraven a můžeme přejít k instalaci
samotného systému Mendel.

### 3.1.4.
Instalace systému Mendel

#### 3.1.4.1. Vytvoření virtuálního
počítače

Instalace systému
Mendel je velice podobná běžné instalaci linuxové distribuce. Nejprve si
přichystáme virtuální počítač v prostředí VMware ESXi
a poté systém nainstalujeme z ISO souboru. Pro získání ISO souboru a
licence pro instalaci prosím kontaktujte svého partnera nebo distributora.

Nejprve opět
vytvoříme virtuální počítač podle následujících parametrů:

·        
Guest
OS family: Linux

·        
Guest
OS version: CentOS 7 (64-bit)

·        
CPU:
8 vCPUs

·        
RAM:
32 GB

·        
Hard
disk 1: 100 GB

·        
Network
adapter 1: VM Network

·        
Network
adapter 2: SPAN Port group

Finální
konfiguraci všech parametrů můžeme vidět na Obrázek 18. Verze systému Mendel, kterou budeme
v tomto školícím materiálu používat je 3.9.0 vydaná v červnu
roku 2022.

![image018.png](GreyCortex%20Mendel/image018.png)

Obrázek 18
Finální konfigurace virtuálního počítače pro systém Mendel.

#### 3.1.4.2. První část: Textový instalátor

Po prvním
spuštění virtuálního počítače se dostaneme do instalátoru
systému Mendel. Na Obrázek 19 můžeme vidět, že kromě
samotné instalace můžeme také otestovat vložené instalační médium
nebo začít zavádět systém z lokálního disku.

![image019.png](GreyCortex%20Mendel/image019.png)

Obrázek 19 Prvotní spuštění instalátoru systému Mendel.

V dalším kroku
nám instalátor ukazuje aktuálně nastavené hodnoty k instalaci. Na Obrázek 20 můžeme vidět, že systém
správně detekoval přítomnost jednoho disku a dvou síťových karet.
Pro samotnou instalaci ještě ovšem zbývá vyplnit několik informací.
Pokračujeme tedy volbou Next. V dalším kroku na Obrázek 21 můžeme vidět, že systém vypíná
podporu pro vícediskovou instalaci. Systém je možné pro zvýšení výkonu
instalovat na více diskových systémů, což pro potřeby tohoto školícího
materiálu nebudeme používat.

![image020.png](GreyCortex%20Mendel/image020.png)

Obrázek 20 Instalátor systému Mendel ukazuje aktuálně nastavené hodnoty.

![image021.png](GreyCortex%20Mendel/image021.png)

Obrázek 21 S jedním diskem je možné provést pouze jednodiskovou konfiguraci.

Pro běžné
instalace nejmenších senzorů ve virtuálním prostředí je
doporučeno používat diskový prostor o velikosti min. 400 GB. Pro účely
tohoto školícího materiálu si vystačíme s nastaveným diskovým
prostorem o velikosti 100 GB. Aby systém s tímto prostorem mohl pracovat
efektivně, musíme v expertním nastavení vybrat minimální rozložení
diskových svazků. V kroku pro výběr disků, který vidíme na Obrázek 22, zvolte volbu Expert, poté zvolte volbu
2, tj. *GPT developer (minimal) layout,* jak vidíme na Obrázek 23*.* Po uložení minimálního rozložení nás instalátor
vrátí na krok výběru disků, kde můžeme pokračovat volbou
OK.

![image022.png](GreyCortex%20Mendel/image022.png)

Obrázek 22 Výběr disku pro instalaci systému.

![image023.png](GreyCortex%20Mendel/image023.png)

Obrázek 23 Výběr minimálního rozložení diskových svazků.

V dalším kroku
nám instalátor zobrazí dostupná síťová rozhraní, jejich MAC adresy,
množství dat, které na rozhraní aktuálně přitéká a taky, zda je
rozhraní připojeno k nějakému aktivnímu prvku, se kterým se
slinkovalo na úrovni linkové vrstvy. Na Obrázek 24 můžeme vidět, že jako
management port vybíráme rozhraní s názvem ens192, které má MAC adresu 00:0c:29:a3:76:66. Toto
rozhraní je připojeno do skupiny portů s názvem GREYCORTEX,
která je definována na virtuálním switchi vSwitch0. Pro toto rozhraní volíme
volbu DHCP a požadujeme, aby se systém pokusil obdržet IP adresu od DHCP
serveru.

![image024.png](GreyCortex%20Mendel/image024.png)

Obrázek 24 Výběr síťového rozhraní pro management.

V dalším
kroku nám instalátor sdělí, zda se mu podařilo úspěšně
obdržet síťovou konfiguraci. Na Obrázek 25 můžeme vidět, že v našem
případě instalátor obdržel IP adresu 172.29.10.102/24. Přes tuto
IP adresu budeme později přistupovat k webovému rozhraní systému
nebo pomocí SSH k textového rozhraní *mshell* systému Mendel. Mshell
je [shell](https://en.wikipedia.org/wiki/Shell_(computing)), který se automaticky spustí po připojení na
port 22/tcp.

![image025.png](GreyCortex%20Mendel/image025.png)

Obrázek 25 Instalátor obdržel síťovou konfiguraci z DHCP serveru.

Během
instalace potřebuje systém ověřit licenční klíč
vůči serveru license.greycortex.com společnosti GREYCORTEX. Aby
k tomuto ověření mohlo dojít, je potřeba, aby měl
instalátor prostup k zmíněnému serveru na port 443/tcp.
V některých infrastrukturách je nezbytné pro připojení do
sítě Internet použít proxy server. Proto instalátor nabízí možnost proxy server
nakonfigurovat v dalším kroku. Na Obrázek 26 můžeme vidět, že možnost zadat
proxy je volitelná. Pokud proxy server není pro přístup do sítě
Internet nezbytný, můžete hodnoty pro nastavení proxy nechat prázdné a
pokračovat dále.

![image026.png](GreyCortex%20Mendel/image026.png)

Obrázek 26 Možnost specifikovat proxy server.

V dalším
kroku je uživatel vyzván k zadání hesla pro účet s názvem administrator.
Tento účet má maximální oprávnění v instalovaném systému a
měl by být používán pouze pro administrativní úkoly. Můžete si jej
představit jako uživatel root v unixových systémech nebo jako
uživatele Administrator ve světě Windows. Tento účet poté
může být použit pro vytvoření dalších lokálních účtů. Na Obrázek 27 můžeme vidět, že instalátor
vyzývá uživatele k zadání Admin hesla, ovšem pamatujme, že název účtu
je **administrator**.

![image027.png](GreyCortex%20Mendel/image027.png)

Obrázek 27 Vytvoření hesla pro lokálního uživatele administrator.

V dalším
kroku je potřeba zvolit tzv. senzor name. Toto jméno bude použito jako
hostname pro dané zařízení, zároveň bude použito jako CN během
generování certifikátu pro webový server a také jej budeme používat v rámci
systému Mendel. Pokud máme např. k systému Mendel připojeno více
senzorů, pak je toto jméno identifikátor pro jednotlivé senzory. Po
výběru a zadání jména během instalace není možné jméno v budoucnu
změnit. Zvolte tedy jméno, které bude jasně vystihovat dané
zařízení. Jelikož v našem testovacím prostředí budeme provozovat
pouze jeden systém, volíme jméno **Mendel**, jak můžete vidět na Obrázek 28.

![image028.png](GreyCortex%20Mendel/image028.png)

Obrázek 28 Volba jména systému, který jej dále identifikuje.

Jak můžeme
vidět na Obrázek 29, v dalším kroku si systém vyžádá
licenční email a s ním spojený licenční klíč. Licenční
klíč začíná znaky GM, kdy první znak reprezentuje jméno
společnosti, tj. GREYCORTEX a druhý poté jméno produktu, tj. Mendel.
Licenční klíč se vždy skládá ze znaků velkých písmen a
číslic. Na obrázku můžeme vidět, že byl použit licenční
email [**michal.srubar@greycortex.com](mailto:michal.srubar@greycortex.com)** a licenční klíč byl cíleně odmazán.
Ověření zadané licence poté proběhne vůči serveru
license.greycortex.com. Existuje také možnost tzv. *offline instalace* pro
případy, kdy musí proběhnout instalace v prostředí, které
je zcela izolováno od přístupu do sítě Internet. Tento typ instalace
je popsán v instalačním manuálu a zde jej nebudeme dále probírat.

![image029.png](GreyCortex%20Mendel/image029.png)

Obrázek 29 Vložení licenčního klíče a emailu.

V dalším
kroku instalátor uživateli zobrazí některé informace, které byly
uživatelem zadány a požádá uživatele o jejich kontrolu. Pokud jsou všechny
údaje správné, můžeme pomocí volby **Install Mendel** spustit samotnou
instalaci systému. Na Obrázek 30 můžeme vidět shrnutí
instalátoru v našem testovacím prostředí.

![image030.png](GreyCortex%20Mendel/image030.png)

Obrázek 30 Shrnutí informací před instalací.

V posledním
kroku nás instalátor vyzve o poslední potvrzení, že disk, který jsme v instalátoru
zvolili, může být opravdu naformátován a použit pro zápis dat systému Mendel.
Na Obrázek 31 můžeme vidět, že v našem
testovacím prostředí došlo k zápisu dat na disk označený jako **sda**.
Tímto posledním potvrzením říkáme systému, že samotná instalace může
začít. Instalátor tedy posbíral od uživatele všechny potřebné
informace a může začít s ověřením licence, zápisem dat
na disk a konfigurací systému. Během instalace dojde ke dvěma
restartům systému.

![image031.png](GreyCortex%20Mendel/image031.png)

Obrázek 31 Poslední potvrzení před zápisem dat na disk.

Jakmile bude
instalace systému Mendel úspěšně dokončena, systém na textové
konzoli zobrazí banner systému, který ukazuje základní informace o použitém
hardware, informaci o IP adrese webového rozhraní a možnost přihlášení do
webového rozhraní systému Mendel. Na Obrázek 32 můžeme vidět, že testovací
systém byl instalován v prostředí VMware. Využijeme možnost pro
přihlášení k účtu administrator pro ověření zvoleného
hesla, zadaného během instalace.

![image032.png](GreyCortex%20Mendel/image032.png)

Obrázek 32 Banner systému Mendel po úspěšné instalaci.

Po úspěšném
přihlášení je spuštěn Mendel shell, neboli ve zkratce **mshell**,
což je speciální shell systému Mendel. Mshell může být použit pro správu
systému v případě, že není dostupné webové rozhraní nebo
při prvotní instalaci. Mshell se spustí také v případě, kdy
se k systému přihlásíte s účtem administrator za použití SSH,
což si vyzkoušíme, jakmile SSH přístup v systému povolíme. Ostatní
uživatelé do mshellu přístup nemají, pokud to není explicitně
nastaveno správcem systému. Jak můžeme vidět na Obrázek 33, po přihlášení mshell hned spouští příkaz
**help**, který zobrazí nápovědu všech příkazů, kterými mshell
disponuje. Tímto je první část instalace hotová a nyní můžeme
přistoupit k druhé části, kde provedeme počáteční
nastavení systému po instalaci. Nyní tedy provedeme přihlášení do webového
rozhraní systému Mendel.

![image033.png](GreyCortex%20Mendel/image033.png)

Obrázek 33 Mendel shell je spuštěn při textovém přihlášení uživatele
do systému.

#### 3.1.4.3. Druhá část: Konfigurace ve webovém
rozhraní

Po zadání IP
adresy do webového prohlížeče vám prohlížeč pravděpodobně
zobrazí nějaké varování o tom, že se připojujete k nezabezpečenému
systému, že může dojít ke krádeži dat atd. V našem případě
totiž webový server posílá prohlížeči certifikát, který obsahuje Common
Name Mendel a očekává, že tato hodnota bude použita také pro přístup
k webovému serveru. Pokud použijeme IP adresu, pak si webový
prohlížeč nemůže ověřit, že systém, ke kterému se
připojujeme, je opravdu ten, za koho se vydává. Nyní toto riziko budeme
ignorovat a dále jej probereme v jiných sekcích. Jak můžeme
vidět na Obrázek 34, po přeskočení bezpečnostního
hlášení prohlížeče se dostaneme k přihlašovacímu formuláři
webového rozhraní systému Mendel. Pro přihlášení použijeme již
zmíněné uživatelské jméno administrator a heslo, které bylo zvoleno
během instalace.

![image034.png](GreyCortex%20Mendel/image034.png)

Obrázek 34 Připojení k webovému rozhraní systému Mendel.

Po dokončení
instalace je potřeba ještě provést šest konfiguračních
kroků, než začne systém Mendel plnohodnotně fungovat. Nejprve
musíme potvrdit licenční podmínky pro používání systému, které můžeme
vidět na Obrázek 35.

![image035.png](GreyCortex%20Mendel/image035.png)

Obrázek 35 Potvrzení licenčních podmínek systému Mendel.

V dalším kroku
nás čeká výběr jazyka. Systém Mendel je aktuálně lokalizován do
českého, anglického, polského a japonského jazyka. Seznam podporovaných
jazyků je stále rozšiřován a jsme otevřeni spolupráci
s partnery na lokalizaci do jejich rodného jazyka. Na Obrázek 36 můžeme vidět, že pro naši
instanci volíme angličtinu.

![image036.png](GreyCortex%20Mendel/image036.png)

Obrázek 36 Výběr anglického jazyka pro systém Mendel.

Ve druhém kroku
je možné do systému vložit zálohu nastavení z předešlé instalace.
Tato volba je vhodná v okamžiku, kdy například běží PoC (Proof
of Contept), po kterém se udělá záloha nastavení. Pokud se zákazník
rozhodne daný systém koupit a dojde k nové instalaci, může být toto
nastavení v tomto kroku obnoveno. Zde je důležité podotknout, že
obnova zálohy by měla proběhnout na stejnou verzi systému,
z jaké byla záloha vytvořena. Na Obrázek 37 můžeme vidět, že v naší
testovací instalaci nebudeme provádět obnovu dat ze zálohy.

![image037.png](GreyCortex%20Mendel/image037.png)

Obrázek 37 Do systému je možné vložit a obnovit nastavení ze zálohy.

Ve třetím
kroku je možné nastavit některé volby chování systému. Pro testovací
prostředí můžeme ponechat všechny volby ve výchozím nastavení,
kromě vzdáleného přístupu přes SSH. Na Obrázek 38 můžeme vidět, že povolujeme
vzdálený přístup pro podsíť 0.0.0.0/0, která reprezentuje libovolnou
zdrojovou IP adresu. Systém tedy na pozadí vytvoří taková pravidla pro
firewall, která dovolí se připojit na port 22/tcp z libovolné IP
adresy.

![image038.png](GreyCortex%20Mendel/image038.png)

Obrázek 38 Povolení vzdáleného přístupu pomocí SSH.

Systém pro
svůj správný běh a korektní zobrazování výsledků potřebuje
mít nastavený přesný čas. Nastavení času může být provedeno
manuálně nebo je možné použít NTP protokol pro synchronizaci času
s NTP servery. Na Obrázek 39 můžeme vidět, že v našem
případě využijeme veřejně dostupné NTP servery, jelikož se
v našem testovacím prostředí nenachází žádný jiný NTP server.

![image039.png](GreyCortex%20Mendel/image039.png)

Obrázek 39 Zvolení veřejných NTP serverů pro synchronizaci času.

Pátým krokem je
vytvoření a správné pojmenování podsítí, které budeme monitorovat. V našem
testovacím prostředí a v průběhu tohoto školícím materiálu
budeme používat pouze privátní rozsahy A, B a C. Tyto rozsahy jsou již obsaženy
ve výchozí instalaci systému. Na Obrázek 40 můžeme vidět, že systém
kromě těchto privátních podsítí obsahuje také některé další
rozsahy, ze kterých můžeme standardně v počítačových
sítích vidět komunikaci. Jak systém s těmito sítěmi pracuje
a proč je jejich definice velice důležitá bude dále vysvětleno v sekci
4.4.

![image040.png](GreyCortex%20Mendel/image040.png)

Obrázek 40 Nastavení podsítí, které bude systém monitorovat a uchovávat z nich data.

Tímto krokem je
konfigurace systému po instalaci kompletní a můžeme systému říct, že
chceme přejít do samotné webové aplikace systému Mendel. Jak můžeme
vidět na Obrázek 41, šestý krok je poslední před vstupem
do samotné webové aplikace systému Mendel.

![image041.png](GreyCortex%20Mendel/image041.png)

Obrázek 41 Konfigurace systému je kompletní.

Pokud jste se
dostali až k obrazovce, kterou je možné vidět na Obrázek 42, pak jste úspěšně nainstalovali
a nakonfigurovali systém Mendel pro sběr a analýzu síťového provozu.

![image042.png](GreyCortex%20Mendel/image042.png)

Obrázek 42 Webové rozhraní systému Mendel.

### 3.1.5.
První přehrání pcapu

Nyní je systém Mendel
plně funkční a můžeme tedy přejít k ověření,
že systém bude zpracovávat data, která budeme přehrávat ze systému REPLAY.
Nejprve provedeme prvotní test s použitím pcap souboru [pcaps\test-icmp-ping.pcap](http://reymond.greycortex.com/trraining.htm#_Pcap_soubory). Soubor obsahuje zhruba 3 minuty ICMP komunikace. P**řihlásíme se do
systému Mendel pomocí SSH.**

**ssh
administrator@172.29.10.102**

**Po přihlášení do systému Mendel
se dostaneme do mshellu. Tento shell obsahuje užitečný příkaz** network show**, který nám zobrazí dostupná síťová rozhraní v systému, jejich
konfiguraci a účel. Na** Obrázek 43 **můžeme vidět, že námi nainstalovaný systém Mendel má
dvě rozhraní, z nichž** ens192 **je rozhraní pro správu a má IP adresu,
ke které jsme se připojili pomocí SSH. Druhé rozhraní s názvem** ens224
**je označeno jako monitorovací rozhraní. Každý paket, který do tohoto
rozhraní přiteče, bude systémem Mendel zpracován.**

![image043.png](GreyCortex%20Mendel/image043.png)

Obrázek 43 Výstup příkazu network show v mshell.

**Nyní použijeme druhý užitečný
příkaz** ifstats**, který nám zobrazí počet příchozích dat do systému Mendel v
reálném čase. Když tento příkaz spustíme, můžeme na** Obrázek 44 **vidět, že rozhraní** ens224 **aktuálně nepřijímá žádná
data.**

![image044.png](GreyCortex%20Mendel/image044.png)

Obrázek 44 Rozhraní ens224 přijímá 0 bitů.

**Příkaz** ifstats **necháme běžet a otevřeme druhou konzoli, ve které se
přihlásíme pomocí SSH do systému REPLAY.**

**ssh
msrubar@172.29.10.103**

**Po přihlášení ověřte,
že v domovském adresáři vámi vytvořeného uživatele se nachází soubor**
[pcaps\test-icmp-ping.pcap](http://reymond.greycortex.com/trraining.htm#_Pcap_soubory) **a že má tento soubor správný kontrolní součet. Dále si zobrazte
síťová rozhraní a poznamenejte si název toho rozhraní, které nemá
nastavenou IP adresu. Na** Obrázek 45 **můžete vidět, že v našem případě se jedná o
rozhraní s názvem** ens192**. Toto rozhraní budeme používat pro
přehrávání paketů z vybraných pcap souborů.**

![image045.png](GreyCortex%20Mendel/image045.png)

Obrázek 45 Přihlášení do systému REPLAY a
ověření pcap souboru.

**Nyní máme vše připraveno
k prvnímu přehrání paketů z pcapu do systému Mendel. Samotné
přehrání provedeme pomocí programu** tcpreplay. **Pcap je dlouhý zhruba 3 minuty, proto během přehrávání
sledujte konzoli se systémem Mendel a zapnutým příkazem ifstats. Po
spuštění přehrávání dat by mělo dojít k navýšení hodnot
příchozích bitů, tj. sloupec RX bits. Samotné přehrání pcapu v systému REPLAY spustíme
následujícím příkazem.**

**sudo
tcpreplay -i ens192 test-icmp-ping.pcap**

**Pokud po spuštění přehrávání
pcapu dojde k navýšení hodnoty RX bits, znamená to, že systém
úspěšně přijímá data. Na** Obrázek 46 **můžeme vidět, že námi instalovaný systém Mendel přijímá
na monitorovacím portu ens224 data o rychlosti 1.7 K bitů za sekundu.
Tato hodnota se bude v čase měnit. Pokud vidíte ve zmíněném
sloupci nenulovou hodnotu, pak to znamená, že vaše testovací prostředí je
plně připraveno k přehrávání dalších pcapů.**

![image046.png](GreyCortex%20Mendel/image046.png)

Obrázek 46 Systém Mendel přijímá 1.7 Kb dat za
sekundu.

**Po skončení přehrávání se
můžeme ze systému REPLAY odhlásit a v systému Mendel můžeme
vypnout ifstats pomocí klávesové zkratky Ctrl+C. Dále také můžeme provést
smazání právě zachycených dat pomocí příkazu delete-all-data, který smaže všechna nasbíraná data. Jak můžeme vidět na** Obrázek 47**, systém vyzve uživatele k opsání krátkého řetězce pro
potvrzení, že chce data opravdu smazat, jelikož tento příkaz může být
velice nebezpečný. Zařaďte si jej do stejné kategorie jako je
příkaz rm -rf v unixovém
světě.**

![image047.png](GreyCortex%20Mendel/image047.png)

Obrázek 47 Smazání testovacích dat nasbíraných
systémem Mendel.

## 3.2.
TODO: VMware Workstation

Návod pro
přehrávání pcapů z hosta rovnou do guesta (Mendel) na vmware
Workstation. Replay systém je tedy ten, kde je Workstation nainstalovaný.

## 3.3.
TODO: Virtualbox

Návod pro
přehrávání pcapů z hosta rovnou do guesta (Mendel) na
Virtualbox. Replay systém je tedy ten, kde je Virtualbox nainstalovaný.
V podstatě tohle: [https://confluence.greycortex.com/pages/viewpage.action?pageId=8619317](https://confluence.greycortex.com/pages/viewpage.action?pageId=8619317)

# 4. Základní
použití systému Mendel

Testovací
prostředí máme úspěšně zprovozněno, nyní můžeme
přejít zpět k webovému rozhraní systému Mendel. Otevřeme
webový prohlížeč a přejdeme na IP adresu, kterou jsme zvolili
při instalaci nebo ji obdrželi z DHCP. V našem případě
má systém Mendel IP adresu 172.29.10.102.

## 4.1.
Filozofie webového rozhraní

Většinu
analytické činnosti budete provádět ve webovém rozhraní, které nám dovolí
přistupovat k nasbíranému síťovému provozu, dovolí nám pokládat
analytické dotazy, měnit nastavení detekčních algoritmů a mnoho
dalších operací. Celá filozofie systému je následující. Systém zpracovává a
ukládá data do své interní databáze. Webové rozhraní poté poskytuje
několik pohledů, které reprezentují různé zobrazení těchto
dat, a to vždy za nějaký vybraný časový interval. Zobrazená data na
konkrétním pohledu je možné dále detailně specifikovat volbou konkrétních
filtrů. Díky této filozofii je možné systému pokládat mnoho analytických
dotazů. Mezi příklady analytických dotazů patří:

·        
Zobraz
seznam zařízení, které komunikovaly v pondělí ve VLAN 20.

·        
Která
zařízení se pokusila komunikovat s [CnC](https://www.trendmicro.com/vinfo/us/security/definition/command-and-control-server) serverem s IP X.X.X.X od data přijetí phishingového
emailu?

·        
V pondělí
jsem přesunul správu antiviru na novou IP adresu. Snaží se nějaké
zařízení od pondělí komunikovat se starou IP adresou?

·        
Jaká
je hodnota RTT mezi konkrétními servery a jak je tedy rychlá linka mezi nimi?

·        
A
mnoho dalších.

Systém je také
schopen pomocí svých detekčních modulů hlásit velké množství
různých událostí, které vznikají na jednotlivých zařízeních nebo celé
síti. Systém také obsahuje mechanismy, pomocí kterých je možné systému
říct, které události jsou pro monitorovanou infrastrukturu relevantní a
které ne. S pomocí těchto mechanismů je systém možné vyladit pro
potřeby konkrétní infrastruktury. Za pomoci kalendáře a časových
intervalům je možné jednoduše prohledávat zaznamenaná data do minulosti,
vybrat libovolný časový interval nebo se dívat na nová data v reálném
čase.

## 4.2.
Základní prvky webového rozhraní

Na Obrázek 48 můžeme vidět typické zobrazení
po přihlášení do systému Mendel, pokud již neproběhly nějaké
ruční úpravy. Na levé straně si můžeme všimnout kalendáře,
pomocí kterého systému říkáme, jaké časové období nás zajímá. Vybírat
můžeme konkrétní dny nebo přesné časové intervaly. Kalendář
ovlivňuje všechny pohledy, na kterých je kalendář zobrazen.

![image048.png](GreyCortex%20Mendel/image048.png)

Obrázek 48 Typické zobrazení systému Mendel po přihlášení.

Dole pod kalendářem můžeme vidět
sadu filtrů a ikonek, pomocí kterých je možné blíže definovat, která data
má systém na konkrétním pohledu zobrazit. Pokud uživatel žádný filtr nevybere,
pak systému říká, aby na daném pohledu zobrazil všechna data, která pro
vybraný časový interval nasbíral. Pro konkrétní uživatelský účet je
možné nastavit, které filtry účet vidí a které ne. Uživatel si tak
může vybrat pouze ty, které používá nejčastěji, jako
například filtry pro podsítě, jména zařízení, jména
uživatelů, čísla portů atd. Tyto filtry můžete zvolit
pomocí volby atributů, které můžeme vidět na Obrázek 49. Na obrázku vidíme, že aktuální uživatel
má vybrány filtry, které mohou blíže specifikovat podsíť, jméno nebo IP
adresu zařízení, štítek zařízení, MAC adresu, službu, typ služby,
aplikaci nebo protokol. Ne všechny filtry jsou na všech pohledech aktivní.
Pokud filtr aktivní není, je zašedlý a uživatel pomocí něj nemůže
volit žádnou hodnotu.

![image049.png](GreyCortex%20Mendel/image049.png)

Obrázek 49 Vlastní filtry definujeme pomocí atributů.

V levé spodní části poté
můžeme vidět nejdůležitější tlačítko **Filter**,
pomocí kterého systému říkáme, že je náš filtr poskládán a chceme zobrazit
data. Pod tímto tlačítkem dále najdeme možnost Clear, která smaže všechny
hodnoty, které jsou aktuálně ve filtrech zadány. Pozor na to, že pokud
jednou filtr vyčistíme, pak už nemůžeme použít tlačítko
zpět (šipka doleva). Dále můžeme na Obrázek 50 vidět filtr manažér, se kterým se
blíže seznámíme v rámci jednotlivých cvičení.

![image050.png](GreyCortex%20Mendel/image050.png)

Obrázek 50 Pomocí tlačítka Filter říkáme systému, aby našel specifikovaná
data.

V podstatě celý systém je postaven na
principu pohledů, které zobrazují všechna data, pokud je pomocí
filtrů neomezíme neboli *nevyfiltrujeme*. S jednotlivými filtry
a jejich pokročilým použitím v podobě jejich skládání, ukládání
a používání na různých místech systému se blíže seznámíme v rámci
tohoto školícího materiálu.

V horní části systému můžeme
vidět jednotlivé kategorie pohledů, které systém uživateli nabízí. Na
Obrázek 51 můžeme vidět, že hned po
přihlášení nám systém ukazuje pohled nazvaný *Main*  z kategorie
*Dashboard.* Celá kategorie dashboardů obsahuje uživatelem definované
pohledy, které jsou ve výchozí instalaci nastaveny od výrobce, ale mohou být
uživatelem kompletně změněny. Zároveň si každý uživatel
může definovat své vlastní dashboardy, které mohou ukazovat přesně
to, co uživatele zajímá.

Druhá kategorie
je pojmenovaná *Network*, protože nabízí několik pohledů, které nám
poskytnou vhled do monitorované infrastruktury. Třetí kategorií je pohled
událostí, kde může uživatel najít seznam všech událostí nebo anomálií,
které systém během monitorování vaší infrastruktury zaznamenal. Různé
pohledy zobrazují různá data, z těchto pohledů můžeme
sestavit incident, který bude popisovat provozní nebo bezpečnostní
problém. Seznam těchto incidentů a práci s nimi je možné
provádět v kategorii s názvem *Incidents.* Poslední kategorií je
*Status Monitor*, což je speciální modul systému Mendel, jehož úkolem je
zajistit, aby systém pracoval bez poruchy, tj. 24 hodin denně, sedm dní
v týdnu, 365 dnů v roce. Všechny pohledy z jednotlivých
kategorií budeme probírat v následujících sekcích.

![image051.png](GreyCortex%20Mendel/image051.png)

Obrázek 51 Jednotlivé kategorie pohledů najdeme v horní části.

V pravé
horní části můžeme vidět jméno přihlášeného uživatele a
vstup do nastavení systému. Na Obrázek 52 můžeme vidět, že právě
přihlášeným uživatelem je Administrátor. Pod ikonou ozubeného kolečka
pak můžeme najít několik důležitých možností. První možností je
vstup do samotného nastavení systému, do kterého čas od času
vkročíme během následujících sekcí. Dále můžeme vidět
nastavení pro aktuálně přihlášený uživatelský účet, kde
můžeme pro daný účet změnit heslo nebo např. grafické
zobrazení systému. Dále důležitou volbou je tzv. *URL sharing,* která
nám dovolí vytvořit odkaz na pohled, který máme aktuálně
otevřený. Tento odkaz pak můžeme uložit do incidentu nebo jej poslat
kolegovi, kterému chceme ukázat, na co se právě díváme. Poslední
důležitou volbou je odkaz do uživatelské dokumentace, který může
zodpovědět mnoho otázek.

Základní prvky
webového rozhraní máme probrány, nyní se můžeme pustit do prvního pohledu
na kterém si vysvětlíme, jak systém pracuje s pakety, které dostane
na své monitorovací porty.

![image052.png](GreyCortex%20Mendel/image052.png)

Obrázek 52 Přihlášený uživatel a nastavení.

## 4.3.
Síťové toky neboli flows

Síťová
komunikace dvou zařízení mezi sebou má vždy nějaký začátek a
nějaký konec. Jedno zařízení je během komunikace klientem, který
komunikaci zahájil a druhé zařízení je serverem. Během této
komunikace jsou použity nějaké protokoly a dojde k výměně zpráv.

### 4.3.1.
Pcap – stažení textového souboru

Příkladem
takové komunikace je stažení textového souboru, které je zachyceno v souboru
[pcaps\http-get-flow.pcap](http://reymond.greycortex.com/trraining.htm#_Pcap_soubory). Soubor obsahuje komunikaci zařízení
z interní sítě s privátní IP adresou 192.168.1.11 se serverem
merlin.fit.vutbr.cz, který má veřejnou IP adresu 147.229.176.19.
Během této komunikace došlo ke stažení textového souboru s názvem **0_README.txt**. Textový soubor byl stažen
pomocí programu wget. Celý příkaz pro stažení souboru vypadal
následovně.

**wget
http://merlin.fit.vutbr.cz/mirrors/centos/7.9.2009/isos/x86_64/0_README.txt**

Pokud danou komunikaci
otevřeme v programu Wireshark, můžeme vidět, že první tři
pakety reprezentují tzv. TCP handshake mezi klientem a serverem. Operační
systém klientského zařízení vybral pro komunikaci náhodný port s
číslem 58000/tcp. Klient při dotazu na daný soubor specifikoval
protokol HTTP, proto se navázala komunikace se serverem na cílový port s
číslem 80/tcp. Port 80/tcp je výchozí port pro HTTP protokol. Navázání
tohoto spojení je zodpovědností operačních systémů daných
zařízení. Tato prvotní komunikace se na úrovni TCP protokolu označuje
jako tzv. **TCP** **handshake** a můžeme ji vidět na Obrázek 53.

![image053.png](GreyCortex%20Mendel/image053.png)

Obrázek 53 TCP handshake mezi klientem a serverem.

Po úspěšném
navázání TCP spojení přichází na řadu aplikace na klientském
zařízení, tj. použitý program wget. Program
posílá paket číslo 4, který již obsahuje aplikační vrstvu v
podobě HTTP zprávy. Obsah této zprávy můžeme vidět na Obrázek 54. Aplikační protokol HTTP je
textově čitelný protokol, jehož formát je většinou ve formě
hlavičky a těla. První HTTP zpráva obsahuje pouze hlavičku, ve
které můžeme vidět, že klient chce pomocí metody GET stáhnout objekt,
který se na serveru merlin.fit.vutbr.cz nachází na cestě mirrors/centos/7.9.2009/isos/x86_64/0_README.txt. Dále si také můžeme všimnout
atributu **User-Agent** do kterého
použitý program zapsal své jméno a verzi.

![image054.png](GreyCortex%20Mendel/image054.png)

Obrázek 54 Obsah první HTTP zprávy odeslané klientem.

Pátým paketem
vzdálený server potvrzuje klientovi, že obdržel jeho dotaz a v šestém a
osmém paketu posílá klientovi požadovaná data. Desátý paket obsahuje HTTP
zprávu, kterou můžeme vidět na Obrázek 55. Zpráva je složena ze tří
segmentů a to z paketů č. 6, 8 a 10. Server v hlavičce
odpovídá klientovi pomocí kódu **200,** čímž klientovi  sděluje, že požadovaný objekt má
na svém souborovém systému a že klient může tento soubor obdržet. Za
hlavičkou HTTP zprávy už můžeme vidět samotný obsah požadovaného
textového souboru 0_README.txt.

![image055.png](GreyCortex%20Mendel/image055.png)

Obrázek 55 V šestém paketu server posílá data
klientovi.

Paketem
číslo jedenáct klient sděluje serveru, že data úspěšně
přijal a vzdálený server tedy ví, že data nemusí posílat znovu. Dvanáctým
paketem klient říká, že po serveru již nebude požadovat žádná data a
spojení může být tedy ukončeno. V posledních dvou paketech se
zařízení pouze utvrzují v tom, že jsou si vědomi toho, že komunikace
končí a může dojít k uvolnění prostředků na obou dvou
stranách. Tento spolehlivý přenos nám zajišťuje transportní protokol
TCP.

### 4.3.2.
Jak vzniká síťový tok

Nyní přehrajeme
stejný záznam komunikace do systému Mendel a budeme zkoumat, jak s touto
komunikací systém naloží a co je schopen nám o této komunikaci říct.
Systém analyzuje jednotlivé pakety síťové komunikace a snaží se z
těchto paketů vytvářet logické síťové toky. Každý takový
tok má své zdrojové zařízení, které komunikaci zahájilo, a cílové
zařízení se kterým chtělo komunikovat. Síťový tok poté obsahuje
veškeré informace o dané komunikaci. Nejprve přeneseme soubor [pcaps\http-get-flow.pcap](http://reymond.greycortex.com/trraining.htm#_Pcap_soubory) do domovského adresáře systému REPLAY pomocí programu scp.

**scp http-get-flow.pcap [msrubar@172.29.10.103:~](mailto:msrubar@172.29.10.103:~)**

**Poté se na systém** REPLAY **přihlásíme pomocí SSH.**

**ssh**
[msrubar@172.29.10.103](mailto:msrubar@172.29.10.103)

Po
přihlášení ověříme, že se soubor přenesl správně
pomocí kontrolního součtu, který musí být
8c219c730874148ec90d7e2c8174c769.

**msrubar@replay:~$
ls -ls http-get-flow.pcap**

**4
-rw-r--r-- 1 msrubar msrubar 3823 Jul 23 11:27 http-get-flow.pcap**

**msrubar@replay:~$
md5sum http-get-flow.pcap**

**8c219c730874148ec90d7e2c8174c769  http-get-flow.pcap**

Nyní můžeme
provést přehrání pcapu do systému Mendel pomocí programu tcpreplay. Pcap musíme přehrát pod uživatelem
s uid 0, tj. uživatelem root. Rozhraní, které pro přehrání
používáme, je rozhraní s názvem ens192, které
nemá nastavenou IP adresu a je připojeno k virtuálnímu switch s názvem
HUB, který jsme vytvořili v sekci 3.1.2.

**msrubar@replay:~$ sudo tcpreplay -i ens192 http-get-flow.pcap**

**Actual: 14 packets (4148 bytes) sent in 0.085553 seconds**

**Rated: 48484.5 Bps, 0.387 Mbps, 163.64 pps**

**Statistics for network device: ens192**

**Successful
packets:        14**

**Failed
packets:            0**

**Truncated
packets:         0**

**Retried
packets (ENOBUFS): 0**

**Retried
packets (EAGAIN):  0**

Pokud
proběhne vše v pořádku, mělo by dojít k přehrání
přesně čtrnácti paketů. Nyní už se můžeme
přihlásit do systému Mendel, vybrat v kalendáři správný den a
časový interval, vyfiltrovat IP adresu klienta z dané komunikace a
nechat systém zobrazit síťové toky. Na Obrázek 56 můžeme vidět, že se nejprve
přihlásíme pomocí uživatelského jména **administrator** a zadáme heslo,
které jsme zvolili při instalaci systému Mendel v sekci 3.1.4.2. Po přihlášení se přepneme na
pohled síťových toků (Flows), který najdeme v kategorii Network.
Při přechodu na tento pohled si můžeme všimnout, že nám systém
neukazuje žádná data. Je to z toho důvodu, že síťové toky
obsahují největší detail informace o síťovém provozu. Bez dalších
parametrů by systém musel zobrazit velké množství dat, proto po nás
požaduje bližší specifikaci toho, co hledáte, pomocí filtrů.

![image056.gif](GreyCortex%20Mendel/image056.gif)

Obrázek 56 Přihlášení a zobrazení síťového
toku z přehraného provozu.

Pcap jsme
v našem testovacím prostředí přehráli 31.1.2023 v 12:42. Nejprve
pomocí kalendáře omezíme hledaný začátek intervalu na datum 31.1 od 12:00.
Poté použijeme filtr **Host,** pomocí kterého systému řekneme, že nás
zajímají pouze takové síťové toky, ve kterých byla zapojena IP adresa
192.168.1.11. To je v pcapu IP adresa klientského zařízení, které
stahovalo data. Po specifikaci všech filtrů již můžeme použít
tlačítko **Filter** pro zobrazení dat. Nyní můžeme vidět
jeden řádek, který reprezentuje síťový tok, který systém Mendel
vytvořil z paketů, které jsou zachyceny v přehraném
síťovém provozu. Vytvořený síťový tok můžeme vidět na Obrázek 57. Můžeme si všimnout, že v
hlavičce toku nám systém ukazuje směr komunikace, ve kterém je IP
adresa 192.168.1.11 zdrojem, a IP adresa 147.229.176.19 cílem. Z hlavičky
šipky komunikace je tedy hned patrné, kdo danou komunikaci zahájil.

![image057.png](GreyCortex%20Mendel/image057.png)

Obrázek 57 Síťový tok vytvořený z
přehraných paketů.

#### 4.3.2.1.1.
Aplikační
vrstva

Pod
hlavičkou můžeme nalézt jednotlivé vrstvy a informace, které u
těchto vrstev systém uchovává. Jako první se nám zobrazí aplikační
vrstva, kde můžeme vidět proběhlou HTTP transakci. Zde si
můžeme všimnout, že systém uchovává důležité informace z
hlavičky HTTP zpráv jako například který objekt klient od serveru
požaduje a jaká je odpověď serveru na tento požadavek. Dále si
můžeme všimnout, že systém obohatil danou transakci o další informace,
které nejsou součástí paketu, jako je například kontrolní součet
staženého souboru. Systém Mendel běžně obohacuje síťové toky o
další užitečné informace, které nejsou součástí paketů. S
těmito užitečnými informacemi se blíže seznámíme v rámci tohoto školícího
materiálu.

#### 4.3.2.1.2.
Transportní
vrstva

V transportní
vrstvě na Obrázek 58 můžeme vidět, že během
komunikace byl použit protokol TCP společně s dalšími informacemi,
které s tímto protokolem souvisí, jako čísla portů nebo počet
flagů, který byl přenesen. Dále si také můžeme všimnout, že byla
z této komunikace napočítána např. výkonnostní metrika [RTT](https://en.wikipedia.org/wiki/Round-trip_delay). Tato metrika nám říká, jak rychle
proběhl mezi danými zařízeními TCP handshake.  Z této informace se dá usuzovat, jak
rychlé je datové médium, které se nachází mezi danými zařízeními. V našem
případě můžeme vidět, že handshake proběhl během
8 mikro sekund. Ve vašem případě se hodnota může lišit.

![image058.png](GreyCortex%20Mendel/image058.png)

Obrázek 58 Zaznamenané informace z transportní
vrstvy.

#### 4.3.2.1.3.
Síťová
vrstva

V síťové
vrstvě, kterou vidíme na Obrázek 59, můžeme kromě IP adres nalézt
také např. Hodnoty TTL (Time To Live). Z těchto hodnot je poskládán
tzv. L3/L4 Feature Vector, který systém používá např. k heuristické
detekci operačních systémů běžících na jednotlivých
zařízeních.

![image059.png](GreyCortex%20Mendel/image059.png)

Obrázek 59 Zaznamenané informace ze síťové
vrstvy.

#### 4.3.2.1.4.
Linková
vrstva

V linkové
vrstvě na Obrázek 60 můžeme najít počet paketů,
které jednotlivé strany komunikace odeslaly, MAC adresy komunikujících
zařízení nebo také jméno rozhraní síťového adaptéru, který
přijmul pakety z dané síťové komunikace. Jméno rozhraní
může být užitečné v případě, že systém přijímá
data z více než jednoho SPAN portu.

![image060.png](GreyCortex%20Mendel/image060.png)

Obrázek 60 Zaznamenané informace z linkové vrstvy.

#### 4.3.2.1.5.
Informace
o síťovém toku

První záložka
nazvaná flow obsahuje informace o samotném síťovém toku tak, jak jej
systém Mendel poskládal z jednotlivých paketů, které obdržel na své
monitorovací rozhraní. Z informací zobrazených na Obrázek 61 můžeme vidět, že typ toku má
hodnotu **Finished**, což znamená, že
systém viděl pakety, které signalizují ukončení TCP spojení a
považuje tedy tok za dokončený. Dále si také můžeme všimnout, že nám
systém hlásí, že v tomto síťovém toku byla detekována signatura s
identifikátorem **2034581.**

![image061.png](GreyCortex%20Mendel/image061.png)

Obrázek 61 Informace o vytvořeném síťovém
toku systémem Mendel.

V
případě, že systém nalezne v síťovém toku nějaký vzor
definovaný signaturou, zaznamená událost, kterou je možné vidět na pohledu
*Events by Severity* v kategorii *Events*. Pokud na toto
zobrazení v rychlosti přejdeme, pak stejně jako na Obrázek 62 uvidíme, že systém hlásí událost se
jménem **Info: Terse Request for .txt -
Likely Hostile.** Popis generování události a práce s nimi bude blíže popsán
v kapitole 5.

![image062.png](GreyCortex%20Mendel/image062.png)

Obrázek 62 Vygenerovaná událost, popisující
zachycený vzor v síťové komunikaci.

### 4.3.3. Cvičení – Instalace
linuxového balíčku

Do systému Mendel
přehrajte soubor s názvem [pcaps\labs\package-install.pcap](http://reymond.greycortex.com/trraining.htm#_Pcap_soubory). Pcap obsahuje komunikaci linuxového systému,
na kterém proběhla instalace balíčku z oficiálního serverem
distribuce.

1.    Jaká je IP adresa klienta, který navázal
komunikaci se serverem v internetu?

2.    Jaká je MAC adresa klientského
zařízení, které navázalo komunikaci se serverem v internetu?

3.    Jaká je IP adresa cílového serveru?

4.    Na jakém cílovém portu komunikace
proběhla?

5.    Jaký zdrojový port byl použit pro stažení
balíčku?

6.    Jaký aplikační protokol byl
během komunikace použit?

7.    Jaký je název balíčku, který klient
ze serveru stáhl?

8.    Jaký je kontrolní součet MD5
staženého balíčku?

9.    Jaké je DNS jméno serveru, ze kterého byl
balíček stažen?

10.  Jaký transportní protokol byl použit pro
stažení balíčku?

11.  Jaký je L3/L4 Feature Vector spočítaný
systémem Mendel?

12.  Jaké je identifikační číslo
signatury, které byla v toku stažení balíčku detekována?

## 4.4.
Podsítě a VLANy

V dnešních TCP/IP
sítích jsou jednotlivá zařízení nejčastěji adresována IP
adresami, které spadají do rezervovaných privátních rozsahů, které jsou:

●     Private A (10.0.0.0/8),

●     Private B (172.16.0.0/12) a

●     Private C (192.168.0.0/16).

Většina
zařízení v interní síti komunikuje z jedné nebo více IP adres z výše
zmíněných rozsahů. Za použití segmentace je poté možné vytvářet
oddělené logické segmenty pro různé kategorie zařízení.
Příkladem takových segmentů mohou být:

●     192.168.100.0/24 Servery,

●     192.168.200.0/24 Uživatelé,

●     192.168.300.0/24 Veřejná WiFi
síť,

●     a tak dále.

V mnoha
infrastrukturách pak tyto rozsahy dostanou také vlastní VLAN ID. Zatímco IP
adresu daného zařízení nebo VLAN ID při komunikaci v paketech
uvidíme, jméno dané podsítě nebo VLANy nikoliv. Jména ovšem mohou jednotlivým
podsítím dodat význam a mohou být velkou pomocí analytikovi, který má
analyzovat sledovanou síť. Pojďme se podívat na to, jak s
podsítěmi a VLAN ID pracuje systém Mendel.

### 4.4.1.
Pcap – stažení textového souboru

Pro tuto sekci je
nutné mít přehrán [pcaps\http-get-flow.pcap](http://reymond.greycortex.com/trraining.htm#_Pcap_soubory) ze sekce 4.3.1. Soubor není nutné přehrávat znovu,
pokud jste to již udělali.

### 4.4.2.
Identifikace podsítí

V okamžiku, kdy
systém Mendel přijme pakety o síťové komunikaci a vytvoří z nich
síťový tok, začne z daných paketů také extrahovat další
užitečné informace. Jedna z těchto informací jsou statistiky o
komunikaci v jednotlivých podsítích. Tyto statistiky je možné najít na pohledu *Subnets*
v kategorii *Network*. Na Obrázek 63 je možné vidět celkem tři podsítě. Přehraný soubor obsahuje
celkem 10 paketů a tvoří jeden logický tok. Jak si také můžete
všimnout systém automaticky pojmenoval danou podsíť jako **Private C**.
Další podsíť má název **All internal**.
Tato podsíť reprezentuje všechny uživatelem definované sítě
dohromady. Význam této podsítě bude jasnější v průběhu
dalších sekcí.

![image063.png](GreyCortex%20Mendel/image063.png)

Obrázek 63 Pohled na statistiky jednotlivých
podsítí.

TODO:
Udělat nový screenshot, protože v sekci 3.1.3 jsme zakázali IPv6, takže už to
tam nebude.

Všechny zobrazené
sítě jsou definovány v systému ve výchozím nastavení po standardní
instalaci. Pokud například klikneme na síť 192.168.0.0/16, pak nám
systém ukáže, že aktuální jméno dané sítě je Private C a její popis je **Private class C networks.** Tyto
parametry je možné vidět na Obrázek 64 a také je můžeme změnit v
nastavení dané sítě. Přejděme tedy do nastavení dané sítě
pomocí tlačítka *Settings*.

![image064.png](GreyCortex%20Mendel/image064.png)

Obrázek 64 Informace o síti 192.168.0.0/16.

Pro síť
192.168.0.0/16 změníme následující parametry:

●     **Name:** Users,

●     **Description:** Windows
domain users.

Nyní
přejdeme zpět na pohled Subnet v kategorii Network, kde si
můžeme všimnout, že systém nyní ukazuje nové jméno dané podsítě. Jak
můžeme vidět na Obrázek 65, nové jméno je nyní možné také filtrovat
ve filtru s názvem Subnet.

![image065.png](GreyCortex%20Mendel/image065.png)

Obrázek 65 Nové jméno podsítě je nyní možné
také filtrovat.

Pokud u
podsítě Users nyní dvojklikem klikneme na počet toků, budeme
přesměrování na seznam síťových toků, které se za dané
časové období v síti Users odehrály. Zde si všimněme, že při
přesměrování došlo k automatickému vyplnění hodnoty
192.168.0.0/16 do filtru subnet. Také si můžeme všimnout, že došlo ke
přejmenování podsítě v již vytvořeném toku. Tyto dvě skutečnosti
můžeme vidět na Obrázek 66. Změna názvu podsítě je tedy
aplikována jak na nová data, tak na ta historická, která již v systému byla
uložena.

![image066.png](GreyCortex%20Mendel/image066.png)

Obrázek 66 Systém
přidal síť 192.168.0.0/16 automaticky do filtru.

### 4.4.3.
Definujte své podsítě

Směrovací
tabulky monitorované sítě mohou obsahovat desítky, stovky i tisíce podsítí
nebo VLAN. Proto je vhodné jména těchto podsítí/VLAN do systému vložit,
aby systém mohl zařazovat jednotlivá zařízení do správných podsítí. S
jednotlivými podsítěmi se poté dá pracovat jako s celky např.
při filtrování nebo vytváření detekčních pravidel. Také mnoho
interních mechanismů s těmito podsítěmi dále pracuje. Správná
definice podsítí je tedy **nezbytná** pro plnou funkčnost systému.

## 4.5.
Zařízení v síti

Pro systém Mendel
je každá jedinečná kombinace MAC adresy a IPv4/IPv6 adresy jeden tzv. *host*.
Pohled Hosts v kategorii Network nám je schopen ukázat seznam všech
komunikujících hostů v síti za vybrané časové období. Pokud se
na tento pohled podíváme, můžeme vidět, že systém rozpoznal z
přehraného pcapu [pcaps\http-get-flow.pcap](http://reymond.greycortex.com/trraining.htm#_Pcap_soubory) hosta s IP adresou 192.168.1.11 a
MAC adresou 00:0c:29:2a:8a:8a. Pokud na danou IP adresu klikneme, zobrazí
systém informace o daném hostovi, které můžeme vidět na Obrázek 67. V detailu pro daného hosta si také
můžeme všimnout časové značky, která nám říká, kdy byl daný
host na síti objeven. Tato značka reprezentuje čas, kdy systém
viděl daného hosta poprvé komunikovat. Pokud bude host na síti delší dobu
neaktivní (standardně 8 dní a více), pak jej systém zapomene.

![image067.png](GreyCortex%20Mendel/image067.png)

Obrázek 67 Detail hosta s IP adresou 192.168.1.11 na pohledu všech hostů.

## 4.6.
Porty a služby, které na nich
běží

Pokud se posuneme
v pohledech dál směrem doprava můžeme si všimnout pohledu s
názvem *Services*. V tomto zobrazení systém ukazuje služby, které na
síti komunikují opět pro vybraný časový interval a zvolené filtry.
Pokud není zvolen žádný filtr, pak systém ukazuje všechny porty a na nich
rozpoznané protokoly, které na sítí pro vybraný časový interval rozpoznal.
Pro soubor [pcaps\http-get-flow.pcap](http://reymond.greycortex.com/trraining.htm#_Pcap_soubory) můžeme na Obrázek 68 vidět, že systém rozpoznal službu
HTTP běžící na portu 80/tcp. Dále si na obrázku můžeme všimnout, že
typ služby byl rozpoznán jako **REMOTE**. Tento typ znamená, že
zařízení z monitorované sítě se připojují do externí
sítě na port č. 80/tcp a používají při této komunikaci protokol
HTTP.

![image068.png](GreyCortex%20Mendel/image068.png)

Obrázek 68 Pohled na služby, které byly na síti
rozpoznány.

### 4.6.1.
Cvičení – podsítě, hosté
a služby

Přehrajte do
systému Mendel soubor [pcaps\labs\subnets-hosts-services.pcap](http://reymond.greycortex.com/trraining.htm#_Pcap_soubory). Pcap obsahuje komunikaci zařízení
s IP adresou 10.168.0.198. Zařízení komunikovalo se dvěma
servery v internetu a jedním v privátní síti na třech rozdílných
službách.

1.    Kolik dat bylo odesláno
z podsítě 10.0.0.0/8? Využijte pohled Subnets.

2.    Kolik dat přišlo do sítě
10.0.0.0/8? Využijte pohled Subnets.

3.    Kolik hostů se z přehraného
pcapu vytvoří na pohledu Hosts?

4.    Kolik síťových toků se
vytvoří pro hosta s IP adresou 10.168.0.198?

5.    Kolik komunikujících služeb bylo
detekováno pro hosta s IP adresou 10.168.0.198 (Využijte pohled Services)?

6.    Jaký typ služby byl rozpoznán na portu
21/tcp?

7.    Jaký typ služby byl rozpoznán na portu
22/tcp?

8.    Jaký typ služby byl rozpoznán na portu
80/tcp?

## 4.7.
Kdo s kým komunikuje?

Další
užitečný pohled, který systém Mendel nabízí, se nazývá *peers*, tj.
grafické zobrazení komunikačních partnerů. Pohled může být
vhodný v případě, kdy nás zajímají závislosti mezi jednotlivými
sítěmi nebo VLANami.

### 4.7.1.
Pcap – SSH scan

Pro ukázku tohoto
pohledu využijeme soubor [pcaps\network-peers-ssh-scan.pcap](http://reymond.greycortex.com/trraining.htm#_Pcap_soubory). Pokud soubor otevřeme
v programu Wireshark a uděláme rychlou analýzu, pak zjistíme, že pcap
obsahuje komunikaci pouze na portu 22/tcp, vždy na cílovou IP adresu
172.16.13.10. Nejprve přeneseme soubor na stroj REPLAY pomocí programu scp.

**scp
network-peers-ssh-scan.pcap msrubar@172.29.10.103:~**

Soubor zachycuje
komunikaci o délce zhruba dvaceti minut. Abychom nemuseli na přehrání
pcapu čekat tak dlouho, pomůžeme si úpravou rychlosti přehrávání
pomocí parametru mbps programu tcpreplay. Přehrání pcapu by takto mělo zabrat
pouze několik sekund.

**sudo
tcpreplay -i ens192 --mbps=10 network-peers-ssh-scan.pcap**

### 4.7.2.
Zobrazení komunikačních
partnerů

Nyní můžeme
přejít do systému Mendel, nastavit časový interval na dobu
přehrání pcapu a na pohledu Peers v kategorii Network vyfiltrovat
cílovou IP adresu 172.16.13.10. Pohled komunikačních partnerů má
dvě části. V levé části můžeme vidět grafickou
reprezentaci komunikace IP:IP, tj. komunikaci jednotlivých IP adres mezi sebou.
V našem případě filtrujeme konkrétní IP adresu, a proto vidíme
komunikaci pouze s IP adresou 172.16.13.10. Na Obrázek 69 si můžeme všimnou, že pokud klikneme
na konkrétní IP adresu, zobrazí systém informace o dané IP adrese. Také si
můžeme všimnout, že pokud na IP adresu 172.16.13.10 najedeme myší, zobrazí
systém přenesená data na/z dané IP adresy. Na obrázku můžeme
vidět, že celkem 14 zařízení z internetu poslalo na naši interní
adresu celkem 32.27kB dat. Interní zařízení jim zpět odeslalo 35,82kB
dat.

![image069.gif](GreyCortex%20Mendel/image069.gif)

Obrázek 69 Zobrazení IP adresy 172.16.13.10 na pohledu komunikačních
partnerů.

Na pravé straně
můžeme vidět komunikaci s interní IP adresou z jednotlivých
autonomních systémů. Můžeme tedy vidět, že s IP adresou se
snažily komunikovat adresy ze systémů:

·        
DIGITALOCEAN-ASN,

·        
Chang
Way Technologies Co. Limited,

·        
Kanzas
LLC,

·        
China
Telecom Group a

·        
Chinanet.

Pravá strana
pohledu tedy zobrazuje komunikaci IP:ASN v případě, že
filtrujeme konkrétní IP adresu. Pokud bychom konkrétní IP adresu nefiltrovali,
pak pravá strana ukazuje komunikaci podsíť/VLAN:ASN, což můžeme
vidět na Obrázek 70, když dáme pryč IP adresu
z filtru zařízení.

![image070.gif](GreyCortex%20Mendel/image070.gif)

Obrázek 70 Pravá strana peers zobrazuje pohled
subnet/vlan:asn.

Pokud dvakrát
klikneme na spojovací čáru mezi libovolnými dvěma komunikačními
partnery, pak nás systém přesměruje na zobrazení síťových
toků mezi vybranými partnery. Na Obrázek 71 si můžeme všimnou, že
v momentě, kdy uživatel dvakrát klikl myší na spojnici mezi IP
adresami 172.16.13.10 a 193.106.191.80, byl přesměrován na pohled
síťových toků. Systém zároveň automaticky vyplnil filtr
zařízení, do kterého vložil hodnotu **193.106.191.80 & 172.16.13.10**,
kde znak **&** reprezentuje logickou spojku AND. Tímto filtrem systému
říkáme, aby filtroval pouze takové toky, které nastaly mezi zmíněnými
IP adresami.

V seznamu
síťových toků můžeme vidět, že se systém z internetu
pokusil navázat komunikaci na cílový port 22/tcp s cílovou IP adresou
172.16.13.10. Pokud tento tok otevřeme, zjistíme, že v této
komunikaci bylo přeneseno šedesát dva paketů. Zajímavou informací
mohou být data z aplikační vrstvy. V datech si můžeme všimnout,
že zdrojový systém z Ruska použil pro spojení program, který o sobě
posílá informaci, že používá knihovnu **libSSH_0.9.6.**
Pravděpodobně se tedy nejedná o klasický klientský program SSH, ale o
speciální program, který pro navázání komunikace používá zmíněnou
knihovnu. Na straně cíle se nachází SSH server implementovaný knihovnou **OpenSSH**
ve verzi 6.7p1, která pravděpodobně běží na systému [Raspbian](https://www.raspberrypi.com/software/operating-systems/).

![image071.gif](GreyCortex%20Mendel/image071.gif)

Obrázek 71 Dvojklikem přejdeme z peers na síťové toky.

### 4.7.3.
Cvičení – S kým
komunikuje mé zařízení?

Do systému Mendel
přehrajte pcap [pcaps/labs/peers-ipv4.pcap](http://reymond.greycortex.com/trraining.htm#_Pcap_soubory). Soubor obsahuje komunikace zařízení
z interní sítě s IP adresou 172.28.252.85, které komunikovalo
se servery v síti internet. Zodpovězte následující otázky pomocí
pohledu Network -> Peers:

1.    S kolika servery v internetu zařízení
z interní sítě komunikovalo?

2.    Jaký je hostname českého serveru, se
kterým zařízení komunikovalo?

3.    Jaký je hostname amerického serveru, se
kterým zařízení komunikovalo?

4.    Kolik dat [B] odeslalo zařízení
z interní sítě na server s IP adresou 147.229.176.19?

5.    Kolik dat [MB] odeslal server s IP
adresou 151.101.131 na zařízení v interní síti?

6.    Jaké je jméno podsítě, ve které se
vyskytuje server s IP adresou 147.229.176.19?

7.    Jaké je číslo ASN, ve které se
vyskytuje server s IP adresou 151.101.131.5?

## 4.8.
Analýza nad uloženými daty

Systém Mendel
uchovává veškeré informace o síťových tocích v interní databázi. Již
v sekci 4.3 jsme viděli, že tyto toky
můžeme zobrazit a filtrovat na základě dostupných filtrů
v levém menu. Systém ovšem nabízí i pokročilejší analytické dotazy,
které navíc může

uživatel
rozšiřovat nebo sám definovat nové. Tyto analytické dotazy je možné
pokládat skrze pohled *Analysis* v kategorii Network. Na tomto
pohledu je již definováno několik analytických dotazů, které jsou
k dispozici v každé instalaci. Na Obrázek 72 můžeme vidět, že jedním
z předdefinovaných analytických dotazů je dotaz s názvem *Top
HTTPS Cipher Suits*. Tento dotaz zobrazí kryptografické algoritmy, které
byly použity během TLS komunikace ze všech síťových toků za
zvolené časové období.

![image072.gif](GreyCortex%20Mendel/image072.gif)

Obrázek 72 Vybrání předdefinovaného dotazu Top HTTPS Cipher Suits v pohledu Analysis.

### 4.8.1.
Pcap – TLS spojení

Abychom si
analytický modul vyzkoušeli, podíváme se nejprve do souboru [pcaps\tls-communication.pcap](http://reymond.greycortex.com/trraining.htm#_Pcap_soubory). Soubor obsahuje komunikaci zařízení 192.168.1.2
s dvanácti webovými servery pomocí protokolu HTTP zabaleného v protokolu
TLS. Například první server, se kterým se v zachycené komunikaci
navazuje spojení, je český server s názvem [root.cz](https://www.root.cz/). Toto DNS jméno bylo během
komunikace přeloženo na IP adresu 91.213.160.188. Tento překlad není
součástí zachycené komunikace. Na Obrázek 73 můžeme vidět, že ve
čtvrtém paketu zdrojové zařízení posílá zprávu typu TLS Client Hello ve které nabízí serveru celkem 29 sad kryptografických
funkcí pomocí kterých může komunikovat.

![image073.png](GreyCortex%20Mendel/image073.png)

Obrázek 73 Klient nabízí serveru sady kryptografických algoritmů, pomocí kterých
může komunikovat.

V šestém
paketu poté můžeme vidět, že server odpovídá TLS zprávou typu Server Hello, ve které volí sadu TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384, jak můžeme vidět na Obrázek 74. Tyto parametry jsou zpracovány systémem Mendel
a uloženy k síťovým tokům, které systém z paketů
vytvoří.

![image074.png](GreyCortex%20Mendel/image074.png)

Obrázek 74 Server volí pro komunikaci sadu TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384.

### 4.8.2.
 Analýza
pomocí analytického modulu

Nyní můžeme
přehrát soubor [pcaps\tls-communication.pcap](http://reymond.greycortex.com/trraining.htm#_Pcap_soubory) pomocí systému [REPLAY](http://reymond.greycortex.com/trraining.htm#_Instalace_syst%C3%A9mu_REPLAY) do naší instance systému Mendel. Jelikož
veškerá komunikace v zachyceném souboru proběhla z interní IP
adresy 192.168.1.2, můžeme ji nejprve vyfiltrovat na pohledu síťových
toků, abychom ověřili, že systém pakety správně zpracoval.
Jak můžeme vidět na Obrázek 75, zvolíme správný časový interval a
poté filtrujeme zmíněnou IP adresu. Můžeme vidět, že systém
našel komunikaci s celkem deseti webovými servery. Pokud se
detailněji podíváme na zaznamenaná data pro komunikaci se zmíněným
serverem [root.cz](https://www.root.cz/), pak můžeme vidět, že systém pro tuto
TLS komunikaci uložil např. jméno serveru, verzi TLS protokolu nebo také [JA3](https://github.com/salesforce/ja3) hash. Z pohledu serveru poté můžeme
vidět např. informace o certifikátu, který server klientovi posílá,
nebo informaci o vybrané sadě kryptografických funkcí.

![image075.gif](GreyCortex%20Mendel/image075.gif)

Obrázek 75 Filtrování dat pro IP 192.168.1.2 na pohledu síťových toků.

Nad uloženými
daty, u jednotlivých síťových toků, je možné provádět analýzu. Přejdeme
na analytický pohled a provedeme analýzu nad použitými kryptografickými
funkcemi v datech, které jsme do systému Mendel přehráli. Jak můžeme
vidět, pro analýzu použijeme již předdefinovaný pohled s názvem Top
HTTPS Cipher Suits, do kterého navíc přidáme atribut pro cílovou IP
adresu. Přidáním tohoto atributu uvidíme, které kryptografické sady
jednotlivé webové servery zvolily pro komunikaci. Jakmile dotaz spustíme,
systém nám ukáže, že sedm webových serverů použilo při komunikaci
sadu TLS_AES_256_GCM_SHA384 a zbylé tři sadu TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384.

![image076.gif](GreyCortex%20Mendel/image076.gif)

Obrázek 76 Analýza nad použitými kryptografickými
funkcemi.

Pokud se podíváme na předdefinovaný dotaz
podrobněji, můžeme vidět, že systém hledá takové síťové
toky, ve kterých v odpovědích nalezne řetězec **TLS_**.
Z těchto toků nám zobrazí pouze dva **atributy.** Atributy
jsou samotná kryptografická sada a cílová IP adresa. Systém dále zobrazí **metriku**
počet, která udává, kolikrát byl atribut kryptografické sady pro
komunikaci s daným serverem zachycen. To vše seřazeno sestupně
podle počtu těchto komunikací od největšího po nejmenší.

Na Obrázek 77 můžeme dále vidět, že pomocí
filtrů může analytik přistupovat k velkému množství
atributů, které systém zaznamenává z L7 vrstvy aplikačních
protokolů. V tomto konkrétním případě dotaz hledá v atributu
Cipher Suite ze strany serveru. Je ovšem možné vytvořit vlastní dotazy,
které budou pracovat např. s informací o vystaviteli certifikátu
(Response Issuer dn), se jménem serveru (Reuest Server Name) a mnoho dalších.
Na tyto atributy je poté možné aplikovat operátory, které můžete znát
z SQL jazyků. Tímto způsobem můžeme definovat vlastní
dotazy a tyto dotazy ukládat, nebo sdílet s ostatními uživateli systému.

![image077.gif](GreyCortex%20Mendel/image077.gif)

Obrázek 77 Filtry dovolují analytikovi pracovat s daty z L7 vrstvy aplikačních
protokolů.

### 4.8.3.
Cvičení – Analyzujeme DNS
komunikaci

Přehrajte
síťovou komunikaci zachycenou v souboru [pcaps\labs\dns.pcap](http://reymond.greycortex.com/trraining.htm#_Pcap_soubory). Soubor obsahuje komunikaci zařízení
z interní sítě s IP adresou 172.28.252.109 s DNS serverem
s adresou 172.28.255.254. Po přehrání komunikace filtrujte
v systému Mendel IP adresu 172.28.252.109 a komunikaci analyzujte pomocí
modulu Analysis a předdefinovaných pohledů pro protokol DNS.

1.    Kolik doménových jmen se snažilo zdrojové zařízení
během komunikace přeložit (rrnames)?

2.    Jakých 5 typů DNS záznamů
zdrojové zařízení chtělo přeložit?

3.    Kolik dotazů typu DNS záznamu A
zdrojové zařízení odeslalo?

4.    Byl nějaký DNS dotaz
zodpověděn jiným návratovým kódem než 0? (Ano/Ne)

## 4.9.
Štítkuj mě aneb tagování

Doposud jsme si
ukazovali a vysvětlovali pouze základní použití systému Mendel pro analýzu
dat, které by s větším úsilím bylo možné provést i pomocí programu
Wireshark. Nyní se půjdeme podívat na pokročilejší funkcionalitu,
kterou je například tzv. štítkování nebo také *tagování*. Princip
jistě znáte z jiných systémů. Příkladem může být
emailový klient, který vám dovolí přidat štítek „Project Lazarus“ všem
emailů, které s daným projektem souvisí. Zároveň máte
většinou možnost definovat pravidla, která budou daný štítek
přiřazovat automaticky např. na základě odesílatele emailu.
Velice podobná funkcionalita je v systému Mendel s tím rozdílem, že
můžete štítkovat libovolná zařízení nebo podsítě. Zároveň je
možné psát pravidla, které toto štítkování budou provádět automaticky. Systém
obsahuje ve výchozí instalaci několik pravidel, které již štítkování
provádějí.

### 4.9.1.
Pcap – stažení souboru z SMB
serveru

Pro demonstraci štítkování
budeme používat soubor [pcaps\smb-file-download.pcap](http://reymond.greycortex.com/trraining.htm#_Pcap_soubory). V tomto souboru je zachycena
komunikace s Windows systémem, který na lokální síti publikuje sdílené
uložiště, které je dostupné skrze protokol SMB. Systém má IP adresu 172.28.0.35
a cesta k dostupnému uložišti je [\\fileshare.greycortex.com\DATA](file://fileshare.greycortex.com/DATA). Pokud daný pcap prozkoumáme pomocí programu
Wireshark, můžeme nejprve vidět vytvoření TCP spojení (TCP
Handshake), které se vytvoří z IP adresy 172.28.1.170 na cílový
server s IP adresou 172.28.0.35. Dále následuje vytvoření SMB sezení
za pomoci protokolu SMBv2. Na Obrázek 78 si můžeme všimnout, že ve třináctém
paketu proběhne autentizace pomocí NTLM s použitým uživatelským
jménem **msrubar.**

![image078.png](GreyCortex%20Mendel/image078.png)

Obrázek 78 NTLM autentizace s uživatelským jménem msrubar.

V paketu
č. 21 poté můžeme vidět pokus o připojení ke sdílenému
uložišti s názvem DATA na serveru fileshare.greycortex.com. Pokus o toto připojení můžeme
vidět na Obrázek 79.

![image079.png](GreyCortex%20Mendel/image079.png)

Obrázek 79 Pokus o připojení k sdílenému uložišti
fileshare.greycortex.com\DATA.

Dále můžeme
v paketu č. 27 sledovat, že uživatel, který se ke sdílenému úložišti
připojil, přešel do adresáře se jménem **salaries** a
z tohoto adresáře poté stáhl soubor s názvem salaries-1999-2022.zip. Jak můžeme vidět na Obrázek 80 stažení souboru bylo úspěšné.

![image080.png](GreyCortex%20Mendel/image080.png)

Obrázek 80 Stažení souboru s názvem salaries-1999-2022.zip.

Nyní můžeme soubor
přehrát do systému Mendel pomocí našeho připraveného
počítače REPLAY, který jsme připravili v sekci 3.1.3.

### 4.9.2.
Přilep mi štítek

Po úspěšném
přehrání pcapu nejprve prozkoumáme síťové toky, které
z přehráté komunikace systém Mendel vytvořil. Přihlásíme se
tedy do systému Mendel, nastavíme správný časový interval, filtrujeme
zdrojovou IP adresu klienta a přejdeme na pohled síťových toků,
což můžeme vidět na Obrázek 81.

![image081.gif](GreyCortex%20Mendel/image081.gif)

Obrázek 81 Přihlášení a vyfiltrování cílového
serveru.

Z komunikace,
která je zachycena v pcapu, systém Mendel vytvořil jeden síťový
tok. Na Obrázek 81 můžeme vidět, že v toku je
klientem zařízení s IP adresou 172.28.1.170. Spojení bylo navázáno za
pomoci transportního protokolu TCP na cílový port 445/tcp. Dále můžeme
vidět, že systém Mendel v dané komunikaci rozpoznal protokol [SMB (Server Message Block)](https://en.wikipedia.org/wiki/Server_Message_Block) a klient stáhl ze serveru 12.5 MB dat. Pokud
se dále podíváme na aplikační data, která systém k danému toku
zaznamenal, uvidíme důležité informace, které byly o daném SMB sezení
zaznamenány. Na Obrázek 82 můžeme vidět, že systém
zaznamenal jednotlivé transakce. Například v transakci s ID 7
můžeme vidět, že uživatel přistupoval ke sdílenému uložišti
s názvem DATA za použití jména serveru fileshare.greycortex.com. V transakci s ID 9 můžeme
vidět otevření adresáře salaries. V posledních
transakcích můžeme vidět samotné čtení souboru s názvem salaries-1999-2022.zip a také, že stažení souboru bylo
úspěšné.

![image082.gif](GreyCortex%20Mendel/image082.gif)

Obrázek 82 Zaznamenaná aplikační data protokolu
SMB.

Můžeme tedy
vidět, že systém správně rozpoznal všechny transakce, které na úrovni
SMB protokolu proběhly a uložil užitečné informace do
vytvořeného síťového toku. To ovšem není všechno, protože systém
v sobě obsahuje také funkcionalitu pro automatické rozpoznávání a
označení takových serverů. Pokud se blíže podíváme na samotné
zařízení reprezentující server, tj. IP adresa 172.28.0.35, pak můžeme
vidět, že má štítek SMB. Na Obrázek 83 můžeme vidět, že když na tento
štítek klikneme, systém nám řekne, že se jedná o automaticky
přiřazený štítek, který spadá do hierarchie Role/Server/File
Server/SMB. To nám říká, že dané zařízení vystupuje na síti jako SMB
file server. Štítek byl zařízení přiřazen automaticky na
základě jeho chování. Každý SMB server, který se na síti vyskytuje, tedy
automaticky dostane tento štítek. Tento štítek je zároveň možné použít ve
filtru, proto je velice jednoduché si na pohledu Hosts zobrazit všechny SMB
servery na síti.

![image083.gif](GreyCortex%20Mendel/image083.gif)

Obrázek 83 Zobrazení automaticky přiřazeného štítku SMB.

Pokud se
přepneme na pohled událostí, uvidíme, že objevení nového SMB serveru je
hlášeno událostí s názvem **Discovery: New SMB File Server**. Detektor vám
bude hlásit všechny nově objevené SMB servery v monitorované síti. Na
Obrázek 84 můžeme vidět, že v detailu
dané události nalezneme IP adresu SMB serveru. V dalších detailech nám
systém ukáže síťové toky, na základě kterých nových SMB server
odhalil.

![image084.gif](GreyCortex%20Mendel/image084.gif)

Obrázek 84 Každý nový SMB server na síti je systémem hlášen.

Tímto
způsobem je systém Mendel schopen najít a označit několik
typů serverů na síti. V sekci 5.5 se blíže podíváme na to, jak jsou
definována pravidla, která servery na síti označí a zahlásí jako událost.
Také se podíváme na to, jak psát vlastní pravidla, která najdou a označí vaše
zařízení na základě vámi definovaných požadavků.

### 4.9.3.
Cvičení – štítkujeme nové
služby

Přehrajte do
systému Mendel soubor [pcaps\labs\krb-816.pcap](http://reymond.greycortex.com/trraining.htm#_Pcap_soubory). Pcap obsahuje komunikaci dvou
zařízení v interní síti. Systém z přehrané komunikace
objeví novou službu. Detekce služby, její otagování a reportování jako událost
může trvat až 10 min.

1.    Která služba byla objevena na síti?

2.    Jaká je IP adresa zařízení, které
v komunikaci vystupuje jako klient?

3.    Jaká je IP adresa zařízení, které
v komunikaci vystupuje jako server?

4.    Jaký je název události, která detekovala
novou službu na serveru?

5.    Jaké je identifikační číslo
události, která novou službu objevila?

6.    Jaký je název štítku, který je použitý
v definici pravidla s SID -50023?

7.    Jaký je název štítku, který byl
přiřazen serveru (Přiřazení tagu může trvat až 10
minut)?

8.    V komunikaci je zachycena také IDS
signatura hlásící slabé šifrovací parametry. Jaké je identifikační
číslo této události?

## 4.10.
Shrnutí

Tímto jsme prošli
všech pět pohledů systému Mendel, které přináší [viditelnost](http://reymond.greycortex.com/trraining.htm#_Viditelnost) do infrastruktury, kterou systém
monitoruje. Naučili jsme se, že vše začíná pakety, které musí dorazit
na monitorovací porty. Z paketů systém skládá logické síťové
toky, které reprezentují síťovou komunikaci. Z paketů dále vznikají
hosté, kteří komunikují z  podsítí/VLAN. Hosté ke komunikaci
používají různé transportní a aplikační protokoly. Všechny tyto data
jsou uloženy v interní databázi, díky čemu můžeme systému
pokládat různé analytické dotazy nebo si jednoduše graficky zobrazit kdo
s kým komunikuje. To vše historicky pro libovolný časový interval
nebo pro data zpracovávaná v aktuálním čase. Nyní se můžeme
podívat na detekční mechanismy systému.

# 5. Představení detekčních
modulů

Systém Mendel
kombinuje několik detekčních mechanismů, které
v síťovém provozu hledají škodlivé vzory, anomálie a další informace,
kterou mohou být nápomocné při analyzování monitorované sítě. Výstupy
z těchto detekčních metod systém prezentuje ve formě
událostí. Na tyto události se můžeme dívat z pohledu jednotlivých
zařízení, na kterých se staly nebo z pohledu jejich závažnosti,
kterou systém označuje jako *severita***.** Seznam detekovaných
událostí můžeme najít na pohledu Events. Stejně jako i většina
ostatních pohledů v systému Mendel, i tento pohled je ovlivněn
zvoleným časovým obdobím v kalendáři a uživatelem zvolenými filtry.
Na pohledu událostí se aplikují nově tyto filtry:

·        
úroveň
zobrazení událostí a

·        
detekční
moduly.

Filtrem  úrovně
zobrazení uživatel definuje, zda chce vidět všechny události nebo pouze ty
nejrelevantnější. Pomocí filtru detekčních modulů je možné
definovat, ze kterých detekčních modulů má systém události zobrazit. Jak
můžeme vidět na Obrázek 85, ve výchozím nastavení systém zobrazuje
události ze všech detekčních modulů. Pokud najedeme myší na ikonu
jednoho z detekčních modulů, systém nám zobrazí krátký popis
vybraného modulu. Systém obsahuje následující detekční moduly:

1.    Modul pro detekci vzorů (IDS - Intrustion
Detection System).

2.    Modul pro behaviorální analýzu (NBA - Network
Behaviour Analysis).

3.    Korelační modul (Event Corelation).

4.    Modul pro zpracování logů (Log
Processing).

5.    Tagovací modul (UNTE - Universal Taging
system).

6.    Monitorovací modul (Status Monitor).

Každý
z těchto modulů je schopen vygenerovat události, které říkají
něco o samotném systému Mendel nebo o datech, která zpracovává. Jednotlivé
moduly a jejich události budou dále popsány v následujících sekcích.

![image085.gif](GreyCortex%20Mendel/image085.gif)

Obrázek 85 Ikonické filtry pro zobrazení událostí z
jednotlivých modulů.

## 5.1.
Hledáme v paketech (IDS)

Modul pro detekci
vzorů neboli *Intruction detection system* (IDS) je obecně
systém, který je schopen v síťovém provozu detekovat vzory, které
jsou popsány pravidly, které se obecně nazývají *signatury*. Systém Mendel
obsahuje známý IDS modul [surikata](https://suricata.io/). Modul pracuje s více než sedmdesáti tisíci
pravidly, které jsou každé čtyři hodiny doplňovány a
aktualizovány ze serverů společnosti GREYCORTEX. IDS Modul tedy
zachytává konkrétní vzory v síťové komunikaci. Příklad takového
pravidla je možné vidět na Obrázek 86, kde můžeme vidět, že signatura
má identifikační číslo 2034581. Identifikační číslo je
jedinečné v rámci všech signatur nebo detekčních metod v systému
Mendel. Dále můžeme vidět, že signatura spadá do *Mitre*
kategorie Information/Suspicious Communication. Kategorie je možné použít ve
filtrech nebo při posílání událostí do externích systémů (např.
SIEM systémy). U detailu signatury také můžeme vidět, kdy byla
signatura vytvořena. Nejdůležitější informace se ovšem nachází
ve vlastnostech dané signatury. V sekci vlastnosti vidíme syntaktický
zápis signatury a také co se má v síťovém provozu vlastně
hledat. Signatura hledá v URI řetězec „.txt“ při použití HTTP
metody GET. Hledá tedy stažení textového souboru. Popis jednotlivých možností,
které je možné použít při vytváření signatur, je možné najít
v oficiální [dokumentaci](https://suricata.readthedocs.io/en/suricata-6.0.5/rules/index.html).

![image086.png](GreyCortex%20Mendel/image086.png)

Obrázek 86 Příklad IDS signatury.

Vrátíme se nyní
k síťové komunikaci, která byla zachycena v pcap souboru [pcaps\wget-http-outbound-download.pcap](http://reymond.greycortex.com/trraining.htm#_Pcap_soubory). V této komunikaci došlo ke stažení
textového souboru.

Přehrajeme
tedy zmíněný pcap znovu do systému Mendel nebo se vratíme již
k uloženým datům a přejděme na pohled Events. Na Obrázek 87 můžeme vidět, že pro
zmíněnou komunikaci byla detekována událost se jménem **Info: Terse
Request for .txt - Likely Hostile**. Tato událost byla detekována IDS modulem
pomocí signatury s ID 2034581, kterou můžeme vidět na Obrázek 86. Na Obrázek 87 si dále všimněme, že systém při
kliknutí na danou signaturu, zobrazí nejenom vlastnosti dané signatury, ale
také v jakém směru komunikace probíhala a na jakém zařízení byla
signatura detekována. Můžeme tedy vidět, že se signatura detekovala
během http komunikace, kterou navázalo zařízení s IP
192.168.1.11 se serverem merlin.fit.vutbr.cz. Dále můžeme vidět, že
systém pro danou událost nabízí několik možností.

![image087.gif](GreyCortex%20Mendel/image087.gif)

Obrázek 87 Detail IDS události, která hlásí stažení
textového souboru.

Mezi tyto
možnosti patří následující volby:

1.    *To filter* – přesune vybrané parametry
z komunikační matice jako např. zdrojové a cílové zařízení
do filtru.

2.    *Ignore event* – řekne systému, aby danou událost mezi
těmito zařízeními již dále nehlásil. Tímto je možné systém ladit.
Ladění systému bude dále popsáno v sekci 5.4.

3.    *Capture* – systém začne nahrávat síťovou
komunikaci do pcap souboru.

4.    *Report an incident* – vytvoří z dané události
incident. Práce s incidenty bude dále popsána v sekci 6.4.

5.    *Show more details* – zobrazí další informace nebo kompletní
síťový tok.

Tyto možnosti máme
k dispozici pro většinu událostí, které systém reportuje. U IDS
událostí je nejzajímavější sekce, která zobrazuje část paketu, ve
které byla daná signatura detekována. Na Obrázek 88 můžeme vidět, že část
paketu najdeme v detailu události v sekci označené *packet
bytes,* kde můžeme vidět název staženého textového souboru. Tato
sekce může být obzvláště užitečná pro bezpečnostního
analytika, protože zde může nají další doplňující informace nezbytné
pro analýzu.

![image088.gif](GreyCortex%20Mendel/image088.gif)

Obrázek 88 Zobrazení detailu paketu, ve kterém
signatura našla hledaný vzor.

Na Obrázek 89 můžeme vidět, že detail
signatury obsahuje tlačítko pro zobrazení síťových toků. Tato
volba nám dohledá síťové toky, ve kterých byla signatura detekována.
Můžeme vidět, že se díváme na stejný tok, který jsme našli na pohledu
flows ze sekce 4.3. Díky tomu nemusíme jednotlivé toky
dohledávat samostatně, systém nám ukáže relevantní toky pro vybranou
signaturu. Síťové toky je možné zobrazit pro události vygenerované
většinou detekčních modulů.

![image089.gif](GreyCortex%20Mendel/image089.gif)

Obrázek 89 U většiny události je možné zobrazit
síťové toky.

### 5.1.1.
Cvičení – Komunikace do
sítě TOR

Přehrajte do
systému Mendel soubor [pcaps\labs\tor_bl.pcap](http://reymond.greycortex.com/trraining.htm#_Pcap_soubory). Pcap obsahuje komunikaci systému
z interní sítě, který komunikuje skrze síť [TOR](https://en.wikipedia.org/wiki/Tor_(network)).

1.    Jaká je IP adresa zařízení
z interní sítě, které komunikovalo do sítě TOR?

2.    Jaká je MAC adresa zdrojového
zařízení?

3.    Jaká verze TLS byla během komunikace
použita?

4.    Jaké je identifikační číslo
signatury, která komunikaci detekovala?

5.    Jaké je jméno cílové podsítě TOR
uzlu, se kterým zařízení začalo komunikovat?

6.    Na jaké cílovém portu komunikace
probíhala?

7.    Jaký ja3Hash byl rozpoznán
v síťovém toku u zdrojového zařízení?

## 5.2.
Nahráváme pakety

U každé události
je možnost začít nahrávat komunikaci do pcap souboru, která se stane
aktivní po výběru alespoň jedné z položek
z komunikační matice. Pomocí této volby je možné vytvořit
pravidlo, které nahraje konkrétní síťovou komunikaci v okamžiku, kdy
nastane od času vytvoření daného pravidla. Zde je nutno zdůraznit,
že systém Mendel si neukládá kopii síťového provozu a nahrávání dat
započne až po vytvoření pravidla pro samotné nahrávání provozu.
K již vytvořeným událostem není možné stáhnout pcap se zachycenou
síťovou komunikací.

### 5.2.1.
Zaznamenání síťového provozu

Pro demonstraci
funkcionality nahrávání provozu využijeme soubor [pcaps\wget-http-outbound-download.pcap](http://reymond.greycortex.com/trraining.htm#_Pcap_soubory). Tento pcap přehrajme pomocí tcpreplay a počkáme na vygenerování události s názvem
Info: Terse Request for .txt - Likely Hostile. Na Obrázek 90 můžeme vidět, že pokud si
zobrazíme detail dané události a klikneme na zdrojovou IP adresu, pak
můžeme použít tlačítko **Capture**. Po stisknutí tlačítka
můžeme v dialogu zvolit jméno pro záznam o nahrávání provozu. Dále si
můžeme všimnout, že systém sám před vybral, že chceme začít
nahrávat provoz ze zdrojového zařízení s IP adresou 192.168.1.11.
Zbývá nastavit limit velikost souboru do kterého se síťová komunikace
zapíše a můžeme záznam pro nahrávání provozu uložit.

![image090.gif](GreyCortex%20Mendel/image090.gif)

Obrázek 90 Vytvoření záznamu pro nahrávání
provozu do pcap souboru.

Pokaždé, když
systém od uložení tohoto záznamu příjme síťový provoz z IP
adresy 192.168.1.11, pak jej začne nahrávat. Nyní přehrajme pcap
soubor [pcaps\wget-http-outbound-download.pcap](http://reymond.greycortex.com/trraining.htm#_Pcap_soubory) znovu a počkáme na opětovné
zahlášení události se jménem *Info: Terse Request for .txt - Likely Hostile*.
Nahrané soubory se síťovou komunikací je možné stáhnout v nastavení
v sekci Detection a podsekci Data Captures. Na Obrázek 91 můžeme vidět, že očekávaná
událost byla znovu reportována, proto přejdeme do nastavení a podíváme se
na seznam pravidel pro nahrávání provozu. Na obrázku můžeme vidět, že
systém obsahuje pouze jedno, námi vytvořené pravidlo, pro nahrávání
provozu. Po zobrazení detailu tohoto pravidla můžeme vidět, že je
k dispozici ke stažení pcap soubor o celkové velikosti 4.1kB s názvem
new traffic capture.pcap.1. Pokud tento soubor stáhneme a prozkoumáme, zjistíme,
že obsahuje námi přehrátou síťovou komunikaci.

![image091.gif](GreyCortex%20Mendel/image091.gif)

Obrázek 91 Stažení nahraného síťového provozu.

## 5.3.
Hledáme v síťových
tocích (NBA)

Surikata
signatury jsou vhodné pro hledání konkrétních vzorů v síťové
komunikaci. Legitimní programy, útočník nebo malware ovšem mohou
provádět aktivity, které není možné detekovat pomocí konkrétního vzoru,
který by byl nalezen v paketech, ale je potřeba analýza na
základě vzoru chování. Jednoduchý slovní popis takového vzoru může
vypadat následovně. Pokud se jedno zařízení spojí s více než třiceti
jinými zařízeními na různých transportních portech v krátkém
definovaném intervalu, pak reportuj takové chování jako možné skenování
portů. Příklad takové NBA detekční metody můžeme vidět
na Obrázek 92. Na obrázku vidíme, že na zdrojovém
zařízení s IP adresou 172.28.252.85 byla detekována síťová
aktivita, která svým chováním odpovídá chování programu nebo uživatele, který
by se snažil zjistit otevřené porty na zařízení s IP adresou
172.28.1.170. Můžeme si také všimnout, že oproti surikata signaturám, NBA
metody neobsahují samotnou definici pravidla a není tedy možné se podívat na
přesnou definici daného pravidla. Postup detekce daného chování je
součástí know-how systému Mendel. NBA detekční metody tedy obsahují
pouze identifikátor, zařazení do kategorie, datum vytvoření, popis a
doporučení pro uživatele.

![image092.png](GreyCortex%20Mendel/image092.png)

Obrázek 92 Příklad události detekované modulem
NBA.

Tento a mnoho
dalších vzorů vyhledává v síťové komunikaci modul NBA neboli *Network
Behaviour Analysis*. Modul nezkoumá obsah jednotlivých paketů, ale
analyzuje jednotlivé toky jako celky. Díky tomu je schopen odhalit velké
množství průzkumných aktivit, změn na síti jako připojení nového
zařízení, komunikace z nedefinované VLANy, anomálie
v síťovém provozu, periodickou komunikaci a mnoho dalších.

### 5.3.1.
Pcap – nmap scan

V tomto
cvičení budeme pracovat se souborem [pcaps\nmap-scan.pcap](http://reymond.greycortex.com/trraining.htm#_Pcap_soubory). Soubor zachycuje komunikaci programu [nmap](https://nmap.org/), který
byl spuštěn s následujícím parametry pod privilegovaným uživatelem
s nejvyšším oprávněním.

sudo nmap -sV -sC
-v -n melanie.greycortex.com

Pokud
zmíněný pcap prozkoumáme, zjistíme že obsahuje komunikaci zdrojového zařízení
s IP adresou 172.28.252.85 se systémem s IP adresou 172.28.1.170. Jak
můžeme vidět na Obrázek 93, během skenování portů došlo ke
komunikaci za pomocí několika protokolů. Jak dále uvidíme, program
nmap objevil na cílovém zařízení několik otevřených portů,
k těmto portům se pokusil připojit a uložil si [bannery](https://en.wikipedia.org/wiki/Banner_grabbing), které poskytují procesy, které na daných portech
poslouchají.

![image093.png](GreyCortex%20Mendel/image093.png)

Obrázek 93 Seznam protokolů zachycených během skenování portů.

Pokud bychom
zkoumali jednotlivé konverzace na úrovni transportního protokolu TCP, zjistíme
že program nmap se pokusil připojit k celkem 2152 portům. Na Obrázek 93 můžeme vidět, že pokud cílové
porty seřadíme vzestupně, uvidíme že program nmap postupoval od portu
č. 1 nahoru. Program vybírá čísla na základě
nejpoužívanějších portů. Na obrázku také můžeme vidět, že
prvních 9 portů na cílovém systému neposlalo zpět žádnou
odpověď.

![image094.png](GreyCortex%20Mendel/image094.png)

Obrázek 94 Pokus o připojení k prvním devíti
portům na cílovém zařízení.

Nyní zmíněný
pcap přehrajeme do systému Mendel pomocí systému REPLAY popsaného
v sekci 3.1.3.

### 5.3.2.
Události hledající specifické
chování

Po přehrání
zmíněného pcapu a přihlášení se do systému nejprve ověříme,
že systém pakety správně zpracoval a vytvořil z nich síťové
toky. Na Obrázek 95 můžeme vidět, že se nejprve
přihlásíme do systému Mendel s použitím uživatelského jména
administrator. Poté v kalendáři nastavíme datum 19. srpna (den kdy
jsme pcap přehráli). Dále přejdeme na pohled Hosts, kde na grafu
pomocí pravého tlačítka myši zpřesníme časový interval. Můžeme
si všimnout, že výběr časového intervalu zároveň upraví
časový interval v kalendáři. Tímto způsobem je možné rychle
upravit časový interval kalendáře, pokud nechcete interval nastavovat
ručně v kalendáři. Dále klikneme na počet toků u
IP adresy 172.28.252.85, čímž nás systém přesměruje na pohled
síťových toků a zároveň pro nás vyplní filtr do kterého vloží IP
adresu, která nás zajímá.

V seznamu síťových toků si toky nejprve seřadíme podle
cílového portu, kde můžeme vidět několik toků, ve kterých
se program nmap snažil připojit k nízkým portům. Můžeme
ovšem vidět, že v těchto tocích byly odeslány pouze dva pakety
obsahující SYN flag, na které cílové zařízení neodeslalo žádnou
odpověď. Dále si zobrazíme pouze takové toky, ve kterých cílový
systém poslal zpět nějakou odpověď. Toho můžeme
docílit pomocí filtru **>0,** který vložíme do filtru počtu cílových
paketů. Tímto systému Mendel řekneme, aby zobrazil pouze takové toky,
ve kterých cílový systém poslal zpět jeden a více paketů.

![image095-ezgif.com-optimize.gif](GreyCortex%20Mendel/image095-ezgif.com-optimize.gif)

Obrázek 95 Kontrola toků po přehrání pcapu.

Pokud se blíže
podíváme na toky, které obsahují obousměrnou komunikaci, můžeme
usoudit, které služby na cílovém zařízení běží. Na Obrázek 96 můžeme vidět, že zařízení
odpovídá na ICMP zprávy typu Echo. Dále můžeme vidět, že na
zařízení je otevřen port č. 22/tcp na kterém běží OpenSSH
server. Pokud se podíváme do detailu toku pro port č. 22 zjistíme, že OpenSSH
server na cílovém zařízení je ve verzi 7.4. Na zařízení běží
také webový server, který odpovídá na portech č. 80/tcp a 443/tcp.
V detailu toků pro port č. 80 můžeme vidět pro každou
transakci návratový kód č. 302. Webový server se tedy snaží všechny
požadavky obsloužit skrze šifrovaný kanál na portu 443/tcp. Na cílovém systému
je dále otevřen port č. 514 a 5432, na který se program nmap pokusil
odeslat několik požadavků, aby zjistil, jaký typ služby na daném
portu naslouchá. Dále si můžeme všimnout, že se program nmap se pokusil
připojit i k portům 9010/tcp a 9011/tcp pro které ovšem cílový
systém poslal zpět pouze pakety obsahující TCP flagy ACK+RST.

![image096.png](GreyCortex%20Mendel/image096.png)

Obrázek 96 Zobrazení toků, ve kterých cílový systém odpověděl
zpět.

Systém Mendel
tedy z přehrané síťové komunikace správně poskládal
síťové toky. Nyní se půjdeme podívat na to, co v síťové
komunikaci našel. Přepneme se tedy na pohled detekovaných událostí.
V seznamu událostí můžeme vidět několik událostí, které
byly vygenerovány různými moduly systému Mendel. Zaměříme se na
událost s názvem **Scan: Internal Scan-like Behavior**. Na Obrázek 97 můžeme vidět, že tato událost
byla detekována se závažností 8 z 10, tj. velmi závažnou. Pokud si
zobrazíme detail této události, pak zjistíme, že tato událost nás informuje o
tom, že na síti byla zaznamenána aktivita, která odpovídá aktivitě
skenování portů, která mohla být vyvolána programem nebo uživatelem. V detailu
dále můžeme vidět, že nás systém informuje o tom, mezi kterými
zařízeními k této aktivitě došlo. Pokud budeme postupovat hlouběji
do detailu dané události, dostaneme se až k samostatným síťovým
tokům, které jsme již prozkoumali.

![image097-ezgif.com-optimize.gif](GreyCortex%20Mendel/image097-ezgif.com-optimize.gif)

Obrázek 97 Systém Mendel detekoval skenování portů metodou modulu NBA.

Metody modulu NBA
tedy nehledají vzory v samotných paketech, ale naopak v síťových
tocích. Toto je podstatný rozdíl mezi metodami modulu IDS a metodami modulu NBA.
Pomocí odkazu u čísla signatury můžeme přejít do nastavení dané
signatury, které se nachází v sekci Detection a podsekci NBA. Na Obrázek 98 můžeme vidět, že námi instalovaný
systém obsahuje 224 detekčních metod. Metody jsou rozděleny celkem do
šesti kategorií. Každá kategorie má svůj vlastní prefix, který můžeme
najít ve jméně dané signatury. Kategorie jsou následující:

1.    *Scan* – skenovací a průzkumné aktivity.

2.    *Discovery* – detekce změn na síti jako přidání
nového zařízení, nově komunikující služba na zařízení, nový
server v síti a další.

3.    *Flow* – anomálie v síťových tocích.

4.    *Periodic* – periodická a opakující se komunikace.

5.    *Outlier* – anomálie z pohledu přenesených dat,
komunikujících partnerů a dalších parametrů.

6.    Limit – detekce různých
parametrů na základně uživatelem definovaných limitů.

Všimněte si
také, že všechny NBA detektory mají ID se zápornou hodnotou, zatímco IDS
signatury mají identifikační čísla s kladnou hodnotou.

![image098.gif](GreyCortex%20Mendel/image098.gif)

Obrázek 98 Seznam všech NBA detektorů je možné najít v nastavení.

### 5.3.3.
Cvičení – skenování
portů

Přehrajte do
systému Mendel pcap [pcaps\labs\nba-scan.pcap](http://reymond.greycortex.com/trraining.htm#_Pcap_soubory). Soubor obsahuje síťovou komunikaci,
během které došlo ke skenování portů pomocí programu nmap.

1.    Jaký je název NBA události, která byla
v přehrané komunikaci detekována?

2.    Jaké je identifikační číslo této
NBA události?

3.    Jaká je IP adresa zařízení, které
skenování na síti provádělo?

4.    Jaké číslo portu zařízení
skenovalo?

5.    Jaká je IP adresa zařízení, které má
otevřený port pro službu RDP?

## 5.4.
Ladíme detekční metody

Uvažujme nyní
situaci, kdy máme v síti zařízení, které pravidelně provádí test
živosti jiných zařízení na síti pomocí protokolu ICMP. Tuto činnost
provádí opakovaně a několikrát během dne. V takovém
případě je detekce tohoto chování systémem zcela správná ovšem pro
monitorovanou infrastrukturu se jedná o očekáváné chování. Chtěli
bychom tedy systému říct, že pokud bude monitorovací systém provádět
tuto aktivitu, pak nechceme, aby systém Mendel tuto aktivitu dále hlásil.
Zároveň ale požadujeme, aby taková aktivita byla hlášena
v případě, že ji začne provádět jiné zařízení na
síti.

V systému Mendel
je možné definovat pravidla, která upravují chování jednotlivých
detekčních metod nebo celých detekčních modulů pro konkrétní
směry komunikace a jejich vybrané parametry. Díky těmto
pravidlům jsme schopni systému říct, že má ignorovat ping z našeho
monitorovacího zařízení, ale zároveň stále hlásit, pokud tato
aktivita nastane z jiného zařízení.

### 5.4.1.
Pcap – ICMP Scan

Možnost
ladění systému si budeme demonstrovat na síťové komunikaci zachycené
v souboru [pcaps\nmap-icmp-scan.pcap](http://reymond.greycortex.com/trraining.htm#_Pcap_soubory). V pcapu je zachycena komunikace
monitorovacího systému, který skenuje zařízení v podsíti 172.28.1.0/24.
Monitorovací systém má IP adresu 172.28.252.85. Nyní zmíněnou komunikaci
můžeme přehrát do systému Mendel. Na tuto síťovou aktivitu by
měl reagovat modul NBA, který by aktivitu měl klasifikovat jako
skenování.

### 5.4.2.
Pravidlo pro ignorování události
(false positive)

Po
přihlášení do systému Mendel můžeme rovnou přejít na pohled
událostí a pomocí grafu nastavit správný časový interval na dobu
přehrání pcap souboru. Na Obrázek 99 můžeme vidět, že zmíněná
průzkumná aktivita byla detekována NBA událostí s názvem *Scan:
PING ECHO Port Sweep,* která má ID -22020.

![image099.gif](GreyCortex%20Mendel/image099.gif)

Obrázek 99 Přihlášení a nalezení události detekující ICMP sken.

Předpokládejme
nyní, že je tato aktivita legitimní, a také očekáváná. Chceme tedy systém Mendel
upravit tak, aby tuto událost již pro náš monitorovací systém nehlásil. Na Obrázek 100 můžeme vidět, že pokud vybereme
zdrojovou IP adresu 172.28.252.85 (náš monitorovací systém), zviditelní se
tlačítko **Ignore event**. Touto volbou je možné vytvářet
zmíněná pravidla. Po stisknutí nám systém nabídne dialog pro
vytvoření pravidla, které bude budoucí chování ignorovat. Na obrázku
můžeme vidět, že systém sám předvyplnil typ události a také
zdrojové zařízení. Do popisu přidáme informaci o tom, že zdrojové
zařízení je monitorovací systém a provádí tuto aktivitu pravidelně.
Ostatní volby můžeme nechat ve výchozím nastavení a pravidlo uložíme.
Pokud bude monitorovací systém někdy v budoucnu, od okamžiku
vytvoření tohoto pravidla, znovu provádět zmíněný ICMP sken, pak
systém tuto skutečnost zaznamená, ale nebude ji ve výchozím nastavení
zobrazovat.

Situaci nyní nasimulujeme
opětovným přehráním souboru [pcaps\nmap-icmp-scan.pcap](http://reymond.greycortex.com/trraining.htm#_Pcap_soubory).

![image100.gif](GreyCortex%20Mendel/image100.gif)

Obrázek 100 Vytvoření pravidla pro ignorování
konkrétní události.

Nyní se posuneme
v čase na interval druhého přehrání pcapu a podíváme se na
seznam událostí. Na Obrázek 101 můžeme vidět, že jsme
změnili časový interval na přibližný čas přehrání
druhého pcapu. Na grafu můžeme vidět šedý sloupec, který
reprezentuje, že systém zpracoval a zaznamenal nějakou síťovou
komunikaci. Systém ovšem neukazuje žádné události. V levé části
filtru si můžeme všimnout filtru se jménem **severita**. Každá událost,
kterou systém reportuje, má svoji severitu, která může nabývat hodnot 1 až
10. Severita reprezentuje závažnost, kdy hodnota 10 představuje kritické
riziko a hodnota 1 pouze informativní. Můžeme si všimnout, že ve výchozím
nastavení má tento filtr zvolené hodnoty právě 1 až 10. Pokud se na filtr
podíváme podrobněji, pak zjistíme, že obsahuje také severitu
s hodnotou 0. Tuto severitu dostanou všechny události, na které bylo
aplikováno nějaké pravidlo. Pokud tedy ve filtru severity zaškrtneme volbu
nula, pak nám systém zobrazí událost, kterou detekoval, ale kterou jsme se
rozhodli ignorovat. V detailu události si také můžeme všimnout, že
systém zobrazuje číslo pravidla, které na danou událost bylo aplikováno.
V našem případě se jedná o pravidlo s označením FP-U1,
což je zkratka pro *uživatelský false positive s číslem 1.*

![image101.gif](GreyCortex%20Mendel/image101.gif)

Obrázek 101 Zobrazení událostí, která se systémem
ignorována.

Seznam všech
uživatelem vytvořených pravidel je možné nalézt v nastavení
v sekci Detection. Na Obrázek 102 můžeme vidět, že systém
obsahuje pouze jedno uživatelské pravidlo, které jsme právě
vytvořili. V tomto nastavení může dojít ke smazání, úpravě
nebo vytvoření nového pravidla.

![image102.gif](GreyCortex%20Mendel/image102.gif)

Obrázek 102 Seznam vytvořených pravidel (false
positives) najdeme v nastavení.

Tímto
způsobem je možné vyladit jednotlivé detekční metody všech
modulů pro monitorovanou síť, kde je systém Mendel nasazen.
Ladění systému je v podstatě denní záležitostí, jelikož každá
počítačová síť se v čase vyvíjí. Oblast bezpečnosti
a škodlivého software je také velice dynamická, každý den přináší nové
výzvy, na které se systém snaží reagovat aktualizací signatur a detekčních
pravidel.

### 5.4.3.
Cvičení – Pravidlo pro
zvýšení severity

Do systému Mendel
přehrajte soubor [pcaps\labs\malware_exe4.pcap](http://reymond.greycortex.com/trraining.htm#_Pcap_soubory). Pcap obsahuje komunikaci zařízení
z interní sítě se serverem v USA.

1.    Jaká je IP adresa zdrojového
zařízení?

2.    Jaká je MAC adresa zdrojového
zařízení?

3.    Jaký cílový port byl během komunikace
použit?

4.    Systém pro zachycenou komunikaci hlásí
událost o stažení souboru. Jaké je jméno této události?

5.    Jaké je identifikační číslo této
události?

6.    Jaké je jméno objektu (souboru), který
klient dotazoval a na kterém byla událost hlášena?

7.    Předpokládejme, že událost je hlášena
se severitou 4. Vytvořte pravidlo, které nastaví hodnotu priority na 4.
Tímto se zvýší severita pro tuto událost. Jaká je nová severita hlášené
události po druhém přehrání pcapu?

## 5.5.
UNTE (UNiversal Tagging Engine)

Další modul,
který systém Mendel obsahuje, se nazývá *UNTE* neboli *Univeral Tagging
Engine*. Pomocí tohoto modulu je možné definovat vlastní pravidla, která
jsou schopna k jednotlivým hostům nebo podsítím přiřadit
uživatelem definovaný štítek neboli *tag*. Příklad tagování jsme již
viděli v sekci 4.9.2. Pomocí tohoto modulu je možné také
definovat pravidla, která pracují s jednotlivými síťovými toky, hosty
nebo službami, které na nich běží nebo ke kterým se připojují. Představme
si např. situaci, kdybychom chtěli vyhledat a otagovat všechny DHCP
servery v monitorované síti. Pravděpodobně bychom filtrovali porty 67/udp,
68/udp nebo službu DHCP, která běží lokálně na nějakém
zařízení. Tímto způsobem bychom DHCP servery mohli najít. My ovšem
chceme, aby systém takové servery označil zcela automaticky pokaždé, když
se takový server objeví v monitorované síti.

### 5.5.1.
Analýza UNTE pravidla

Systém Mendel již
obsahuje pravidlo, které v síťové komunikaci hledá DHCP servery.
Pravidlo má ID -50009 a název **Discovery: New DHCP service**.
V nastavení systému v sekci Detection můžeme najít definici
pravidla, kterou můžeme vidět také na Obrázek 103. Každé UNTE pravidlo obsahuje
čtyři základní části, kterými jsou:

1.    jméno pravidla (rule),

2.    zdroj dat (root),

3.    predikáty (step) a

4.    akce (action).

Na obrázku
můžeme vidět, že zmíněné pravidlo má jméno DHCP server rule.
Dále můžeme vidět, že pravidlo je definováno nad seznamem obsahující
zařízení (hosts), o kterých již systém ví a má je uložená ve své interní
databázi. Na třetím řádku pravidla vidíme logický predikát, který
říká, že má systém vyhledat pouze takové hosty, kteří mají lokální
službu DHCP. To znamená zařízení, ke kterým se připojují jiná
zařízení na lokální port za pomoci protokolu DHCP. Na posledních dvou
řádcích můžeme vidět definici akcí, které se mají provést nad
zařízeními, které splňují námi definované predikáty. První akcí je
přidání tagu DHCP na vybrané zařízení a druhou ohlášení této
skutečnosti v podobě události, která bude reportována pouze
jednou pro každé zařízení, které bude v síti vystupovat jako DHCP
server. Toto pravidlo tedy každý DCHP server na síti označí a zároveň
nás o tom informuje formou události.

![image103.png](GreyCortex%20Mendel/image103.png)

Obrázek 103 Definice pravidla Discovery: New DHCP service.

### 5.5.2.
Pcap – obdržení IP adresy od DHCP
serveru

Abychom se blíže
seznámili s tím, jak pravidlo funguje, použijeme síťovou komunikaci,
která je zachycena v souboru [pcaps\dhcp.pcap](http://reymond.greycortex.com/trraining.htm#_Pcap_soubory). Soubor zachycuje zařízení
s MAC adresou 00:0b:82:01:fc:42, které se připojí do sítě a chce
obdržet IP adresu pomocí DHCP protokolu. Komunikaci můžete prozkoumat
v programu Wireshark a poté ji přehrajeme do systému Mendel. Na Obrázek 104 můžeme vidět, že systém rozpoznal
z přehraných dat dvě zařízení, které mají IP adresy
192.168.0.1 a 192.168.0.10. Pokud klikneme na toky u zařízení s IP
adresou 192.168.0.1, pak nás systém přesměruje na pohled
síťových toků s automaticky vyplněným filtrem zmíněné
IP adresy. Pokud se podíváme na detail daného toku, pak zjistíme, že systém Mendel
vytvořil ze čtyř přehraných paketů jeden logický
síťový tok. I když na začátku tohoto toku komunikovalo zařízení
se zdrojovou IP adresou 0.0.0.0 a posílalo prvotní DHCP zprávu na broadcast IP adresu
255.255.255.255, systém vytvořil logický tok, ve kterém správně
uložil zdrojovou a cílovou IP adresu. Můžeme vidět, že zdrojové
zařízení dostalo IP adresu 192.168.0.10 od DHCP serveru 192.168.0.1.
V detailu DHCP serveru si můžeme všimnout tagu DHCP. Tag byl
k serveru automaticky přiřazen pomocí zmíněného pravidla
Discovery: New DHCP service.

![image104.gif](GreyCortex%20Mendel/image104.gif)

Obrázek 104 Kontrola vytvořeného toku z DHCP provozu.

Pokud se nyní
přepneme z pohledu síťových toků na pohled událostí, pak
uvidíme samotnou UNTE událost, která nám říká, že byl na síti objeven nový
DHCP server. Na Obrázek 105 si v grafu můžeme všimnout, že
detekce nového DHCP serveru na síti proběhla o něco později, než
samotné obdržení IP adresy. UNTE detektory jsou spouštěny pouze
v určitých časových intervalech. Detekční metoda, která
hledá DHCP servery, je spouštěna každý pět minut, proto může
trvat až pět minut, než dojde k zahlášení dané události.
V samotném detailu události poté můžeme vidět, že systém hlásí,
že detekoval novou lokální službu DHCP na zařízení s IP adresou
192.168.0.1. V detailu síťových toků poté uvidíme stejný
síťový tok, který jsme mohli vidět na Obrázek 104.

![image105.gif](GreyCortex%20Mendel/image105.gif)

Obrázek 105 UNTE modul objevil nový DHCP server na síti.

Modul UNTE tedy
dovoluje definovat pravidla, ve kterých můžete využít mnoho různých
podmínek, které pracují s již uloženými informacemi o zařízeních,
službách nebo síťových tocích, které nastaly v monitorované infrastruktuře.
Na základě podmínek můžete jednotlivým zařízením nebo celým
podsítím přiřazovat tagy nebo hlásit události. Modul UNTE umí také
korelovat události z ostatních modulů a tím se stává velice
univerzálním nástrojem pro detekci vámi definovaného chování nad daty, která má
systém uloženy v databázi. Pro podrobnější informace
doporučujeme prozkoumat stránku popisující modul UNTE v uživatelské
dokumentaci kterou najdete na adrese [https://IP/data/docs/guides/unte-guide.html](https://ip/data/docs/guides/unte-guide.html). Doporučujeme si také projít další
systémová UNTE pravidla, která jsou obsažena v každé standardní instalaci
systému Mendel. Samotné definice UNTE pravidel můžete nalézt na adrese [https://IP/settings/system_unte_signatures.xhtml](https://ip/settings/system_unte_signatures.xhtml).

# 6. Analýza infikovaného zařízení

Jednotlivé
detekční moduly systému Mendel mohou poukázat na možné ukazatele
kompromitace zařízení na síti. V předchozích kapitolách jsme si
ukázali, kterými moduly systém disponuje a jaké jsou jejich schopnosti. Již
víme, že systém je schopen vyhledávat konkrétní vzory v paketech, které
jsou definovány signaturami. Také víme, že systém z jednotlivých
paketů vytváří logické síťové toky a také si zaznamenává seznam
zařízení, služeb a podsítí, které jsou v monitorované síti aktivní.
V těchto záznamech poté vyhledává behaviorální vzory, které opět
mohou sloužit jako ukazatel kompromitace. Systém nabízí několik
pohledů do detailů síťové komunikace, které mohou být použity
pro bližší zkoumání toho, co se na síti stalo nebo pro rekonstrukci
bezpečnostního incidentu. V následujících kapitolách se blíže podíváme
na to, jak nabyté znalosti využít pro vyšetření zařízení, které bylo
infikováno škodlivým programem. Dále si ukážeme, jak z těchto
indikátorů vytvořit bezpečnostní incident a jak tento incident
vyexportovat to textové podoby. Seznámíme se také s modulem pro správu
incidentů, který může být nápomocný v případě, že se
systémem pracuje více než jeden uživatel. Pro demonstraci analýzy infikovaného
zařízení použijeme záznam komunikace počítače, který byl
infikován známým trojským koněm jménem [TrickBot](https://www.malwarebytes.com/trickbot).

## 6.1.
Pcap - malware TrickBot

Pro účely
této sekce budeme analyzovat soubor [pcaps\Trickbot-infection-traffic.pcap](http://reymond.greycortex.com/trraining.htm#_Pcap_soubory), který obsahuje síťovou komunikaci
zařízení s IP adresou 10.9.25.101, které bylo infikováno malwarem TrickBot.
Záznam komunikace nezachycuje průběh infekce daného zařízení,
ale jeho síťovou aktivitu po úspěšné kompromitaci. Pokud komunikaci
prozkoumáme v programu Wireshark, zjistíme že zachycuje celkem 16731
paketů. Tuto komunikaci bychom mohli zkoumat po jednotlivých paketech, ale
rozumnější bude ji rovnou přehrát do systému Mendel. Zachycená
komunikace má celkem 72 minut. Proto můžete spustit přehrávání a
udělat si pauzu na oběd.

## 6.2.
Analýza zaznamenaných událostí

Po dokončení
přehrání pcapu se můžeme přihlásit do systému Mendel, nastavit
správný časový interval, vybrat zobrazení všech událostí a přepnout
se na pohled událostí. Na Obrázek 106 můžeme vidět, že systém hlásí několik
událostí s různou závažností v různých časových
okamžicích.

![image106.gif](GreyCortex%20Mendel/image106.gif)

Obrázek 106
Seznam detekovaných událostí zařízení infikovaného malwarem TrickBot.

Seznam událostí
si nyní seřadíme sestupně podle času výskytu konkrétní události,
abychom se mohli povívat, jak byl malware detekován v čase. Také
vypneme agregaci cílových zařízení, protože zdrojové infikované
zařízení je pouze jedno a díky tomu v čase uvidíme, které
servery byly kontaktovány jako první.

Na Obrázek 107 můžeme vidět, že po
seřazení událostí se nám na první dvě místa dostanou následující události:

1.    Info: Terse Request for .txt - Likely
Hostile (ID 2034581) a

2.    Info: Weak cipher suite used in
communication (ID 900013025).

Události byly zaznamenány
v čase 10:34 a 10:35. V detailu události můžeme vidět,
že infikované zařízení stáhlo textový soubor ze serveru [www.msftncsi.com](http://www.msftncsi.com/) a komunikovalo s dalším serverem společnosti Microsoft. V tomto
případě se jedná o správně detekované chování, které je ovšem [standardní](https://www.techrepublic.com/article/what-do-microsoft-and-ncsi-have-in-common/) pro systémy Windows. Událost tedy není spojena se
samotným malwarem, ale operačním systémem Windows, na kterém byl malware
nainstalován.

![image107.gif](GreyCortex%20Mendel/image107.gif)

Obrázek 107 Seřazení událostí podle času výskytu a vypnutí agregace
cílů.

Ve stejné
minutě došlo ke stažení souboru z Německého serveru s IP
adresou 144.91.69.195. Stažení souboru bylo zachyceno signaturou s názvem **Info:
SUSPICIOUS Dotted Quad Host MZ Response** (ID 2021076), která detekuje
přístup k serveru, během kterého byla použita IP adresa
v Host atributu protokolu HTTP. Většina uživatelů dnes pro
přístup využívá doménové jméno serveru, ke kterému se chce připojit.
Přístup přímo k IP adrese může být podezřelý. Na Obrázek 108 můžeme vidět, že pokud se
podíváme do detailu události na samotný síťový tok, můžeme si
všimnout, že v atributu Host byla použita IP 144.91.69.195 a došlo ke
stažení objektu s názvem **solar.php**. Také si můžeme všimnout
podivného řetězce v atributu User-agent, který byl malwarem
nastaven na hodnotu **pwtyyEKzNtGatwnJjmCcBLbOveCVpc**.

![image108.gif](GreyCortex%20Mendel/image108.gif)

Obrázek 108 Stažení souboru z IP adresy bez překladu DNS jména.

Další událost
s názvem **Info: EXE - Served Attached http** (ID 2014520) nás
informuje o tom, že došlo ke stažení spustitelného EXE souboru. Pokud se
podíváme do detailu události a zejména do síťových toků, pak
zjistíme, že signatura byla detekována ve stejném síťovém toku, ve kterém
došlo k detekci komunikace přímo na IP adresu. Na Obrázek 109 můžeme vidět, že pokud se opět
podíváme na síťový tok, vidíme že proces žádá php skript s názvem

solar.php, ale
server posílá zpět soubor s názvem **phn34ycjtghm.exe**.

![image109.gif](GreyCortex%20Mendel/image109.gif)

Obrázek 109 Dotaz na php skript vrací spustitelný EXE soubor.

Pokud si tento
soubor vyexportujeme z analyzovaného souboru a použijeme na něj
program file, pak zjistíme že se jedná o spustitelný
soubor pro systémy MS Windows. Na Obrázek 110 také můžeme vidět, že stažený
objekt má MD5 hash 367b6a5c0e0e8ec68ea14a085b1d32b3. Pokud hash
prověříme například na serveru [VirusTotal](https://www.virustotal.com/gui/file/415e04eb340f1b092288cbcc71295a2c95e864fc1bbfcd55d6e3f5aa67099b1a), pak zjistíme že se jedná o payload malwaru
TrickBot. Malware si tedy nejprve zjistil, na jakém zařízení se nachází a
poté stáhnul payload určený pro konkrétní operační systém a jeho
architekturu.

![image110.png](GreyCortex%20Mendel/image110.png)

Obrázek 110 Zjištění typu souboru a md5 hashe staženého objektu.

Stažení tohoto
spustitelného souboru pro systém Windows bylo detekováno také signaturou
s názvem **Policy: PE EXE or DLL Windows file download HTTP** (ID
2018959). Po stažení payloadu došlo k jeho spuštění, tj. již
spuštění samotného malwaru TrickBot.

Po spuštění
payloadu začíná malware komunikovat se svými řídícími servery (CnC).
Řídící servery infikované zařízení instruují s dalšími kroky.
Jedna z těchto komunikací byla zachycena pomocí signatury **Trojan:
Observed Trickbot Style SSL Cert (Internet Widgets Pty Ltd)** (ID 2837550).
Na Obrázek 111 můžeme vidět, že nám detail
události ukazuje, že infikované zařízení se spojilo se serverem s IP
187.58.56.26 s použitím portu 449/tcp. Tento port je opět velice
nestandardní a během komunikace byl rozpoznán protokol TLS. Pokud se
podíváme do detailu události, pak můžeme vidět, že infikované
zařízení s tímto serverem komunikovalo více než jednou. Pokud
rozklikneme detail jedné z těchto komunikací, pak můžeme
vidět, že systém uložil z aplikačních dat informace o
certifikátu a vypočetl kontrolní součty [JA3](https://cs.wikipedia.org/wiki/Otisk_JA3) pro
šifrované spojení. Zejména si všimněme pole **ja3Description**, které
jasně říká, že tato šifrovaná komunikace odpovídá nejednomu
škodlivému programu.

![image111.gif](GreyCortex%20Mendel/image111.gif)

Obrázek 111 Komunikace s řídícím serverem 187.58.56.26.

Mezi další
zaznamenané události patří signatura s názvem **Policy: Observed
Suspicious SSL Cert (External IP Lookup - ident.me)** (ID 2026743). Tato
signatura detekuje zařízení, které se snaží připojit k serveru
s DNS jménem ident[.]me. Jedná se o veřejné API, pomocí kterého je
možné zjistit aktuální veřejnou IP adresu. Malware takto zjistí
veřejnou IP adresu, ze které komunikuje a adresu předá svému
řídícímu serveru. Díky tomu je schopen řídící server i autor zjistit,
jaká je přibližná geolokace infikovaného zařízení, popř. i
společnost ve které se zařízení nachází. Na Obrázek 112 můžeme vidět, že se infikované
zařízení spojilo se zmíněným serverem za použití protokolu TLS a
detekce tedy proběhla na základě jména, které je uvedeno
v certifikátu cílového serveru. Veřejnou IP adresu, kterou server
vrátil, tedy v uloženém síťovém toku nevidíme, ani ji nejsme schopni
najít v pcap souboru.

![image112.gif](GreyCortex%20Mendel/image112.gif)

Obrázek 112 Detekce zjištění veřejné IP adresy pomocí služby ident[.]me.

V čase
10:48 poté můžeme vidět další důležitou událost, která byla
zachycena signaturou se jménem **Trojan: Trickbot Checkin Response** (ID
2032218). Signatura zachytila komunikaci infikovaného zařízení se serverem
s IP adresou 170.238.117.187 na portu 8082/tcp. Opět se jedná o
komunikaci s dalším řídícím serverem. V tomto případě
o sobě zařízení dává vědět řídícímu serveru a posílá
jméno infikovaného počítače (hostname) a další informace. Tyto data jsou
poslány formou POST dotazu v URI HTTP protokolu. V této komunikaci si
opět můžeme všimnout, že navázání spojení proběhlo přímo na
IP adresu bez překladu doménového jména a proběhlo také na ne zcela
standardní port 8082/tcp. Na Obrázek 113 můžeme vidět, že pokud se
podíváme do detailu dané události, pak v síťovém toku vidíme, že
zařízení posílá řetězec
/ono19/BACHMANN-BTO-PC_W617601.AC3B679F4A22738281E6D7B0C5946E42/90.
V tomto řetězci je **BACHMANN-BTO-PC** jméno infikovaného
zařízení. Dále také můžeme vidět použitou IP adresu a port
v atributu Host a také zvláštní řetězec **test** v atributu
User-agent. Tato komunikace je označována jako tzv. *malware checkin*
a zařízení tím dává řídícímu serveru informaci o tom, že je aktivní.
Řídící server poté převezme tuto informaci z logu webového
serveru a uloží si zařízení do seznamu aktivně infikovaných
systémů.

![image113.gif](GreyCortex%20Mendel/image113.gif)

Obrázek 113 Malware posílá tzv. checkin paket řídícímu serveru.

Jakmile malware ví, že je připojen k internetu,
může začít posílat řídícímu serveru užitečná data. Jako
první se malware pokusí získat uživatelské jméno a heslo uživatele, pod kterým
byl malware spuštěn. Malware infikoval zařízení, kde byl pouze jeden
uživatel, který byl zároveň součástí lokální skupiny Administrators.
Na Obrázek 114 vidíme, že exfiltrace těchto dat
byla detekována signaturou se jménem **Trojan: Win32/Trickbot Data
Exfiltration M2** (ID 2035356). Data odchází na stejný server, na který byl
odeslán prvotní checkin, tj. na server s IP adresou 170.238.117.187 na
port 8082/tcp. V detailu události můžeme vidět sekci packet
bytes, kde je uložen kousek paketu, ve kterém byla signatura zachycena. Pro
lepší formátování a viditelnost přepošleme data do nástroje [CyberChef](https://gchq.github.io/CyberChef/), který je integrován přímo do systému Mendel.
Ve zformátovaných datech můžeme vidět řetězec
randybachman|P@ssw0rd$. Tímto způsobem posílá malware řídícímu
serveru informaci o tom, že uživatelské jméno infikovaného zařízení je **randybachman**
a jeho heslo poté **P@ssw0rd$**. Tímto správce řídícího serveru získal
přístup k danému účtu, který může být dále použit při
dalších fázích útoku.

![image114.gif](GreyCortex%20Mendel/image114.gif)

Obrázek 114 Zjištění a exfiltrace uživatelského jména a hesla.

V dalším kroku řídící server instruuje
infikované zařízení, aby o sobě poslalo vice informací. Malware tedy
začne zjišťovat, zda je infikované zařízení připojeno do
domény, jakou má síťovou konfiguraci, jaké procesy na daném zařízení
běží atd. Pro tento účel si malware stahuje z řídícího
serveru vlastní knihovny, které tyto informace zjistí. Tímto způsobem se
dají obejít programy, které hlídají přístup uživatelů k těmto
informacím. Na Obrázek 115 můžeme vidět, že stažení tohoto
modulu bylo zaznamenáno událostí s názvem **Trojan: Trickbot Requesting
networkDll Module** (ID 2834883). Stažení proběhlo ze serveru s IP
adresou 185.98.87.185. Jak můžeme vidět v detailu síťového
toku, spojení se serverem proběhlo pomocí protokolu HTTP na cílový port
80/tcp. Malware od řídícího serveru dotazuje dva objekty se jmény **tablone.png**
a **samerton.png**. Objekty podle přípony vypadají jako obrázky, jedná
se ovšem o knihovny pro systém Windows. V transakci aplikačních dat
můžeme vidět, že server pro oba objekty vrací návratový kód 200,
který nám říká, že server objekty má na svém lokálním úložišti a může
je tedy poskytnout. Malware tedy tyto knihovny úspěšně stáhnul a
může je tedy v dalším kroku použít pro zjištění systémových
informací.

![image115.gif](GreyCortex%20Mendel/image115.gif)

Obrázek 115 Stažení dodatečných knihoven pro zjišťování síťových
informací.

Jakmile malware
zjistí potřebné systémové informace, opět je připraví k odeslání
řídícímu serveru. Tento přenos byl zachycen signaturou s názvem **Trojan:
Suspicious POST with Common Windows Process Names - Possible Process List
Exfiltration** (ID 2027117). Na Obrázek 116 můžeme vidět, že systémové
informace byly odeslány na stejný server, na který bylo odesláno také
uživatelské jméno a heslo. V detailu události můžeme opět
v sekci packet bytes vidět informace, které infikované zařízení
posílá vzdálenému serveru. Opět použijeme nástroj CyberChef pro
transformaci poslaných dat do čitelnější podoby. V poslaných
datech můžeme vidět např. seznam běžících procesů.
Tuto informaci může řídící server využít k tomu, aby
věděl, zda na zařízení neběží nějaký bezpečnostní
produkt, který by bylo potřeba obejít. V případě, že by
takový produkt detekoval, opět by si stáhnul modul, který by takový
software vyřadili z provozu. V seznamu dále můžeme
vidět informace o zařízení, tj. opět jméno počítače,
název operačního systému, jeho verzi a další. Malware také posílá
informace o síťovém nastavení jako je IP adresa, jméno domény a další.
Tyto informace může později použít při útocích na další
zařízení v síti.

![image116.gif](GreyCortex%20Mendel/image116.gif)

Obrázek 116 Exfiltrace informací o seznamu procesů, síťovém nastavení a
další.

Tímto
způsobem bychom mohli pokračovat a analyzovat také další události,
popř. jednotlivé toky. Myslím ovšem, že z popsaných událostí jste si
již udělali obrázek o postupu vyšetřování infikovaného zařízení.
V další sekci se podíváme na to, jak tyto informace zaznamenat a
vytvořit z nich zápis o bezpečnostním incidentu.

## 6.3.
Cvičení - TrickBot

Vraťme se
znovu k seznamu událostí zaznamenaných během komunikace malware
TrickBot popsané v sekci 6.1.

1.    Malware se pokusil přeložit TOR
doménu. Jaké je ID signatury, která tento překlad detekovala?

2.    Jaký je název TOR domény, který se
infikované zařízení pokusilo přeložit.

3.    Jaká je IP adresa jediného DNS serveru, se
kterým infikované zařízení komunikovalo?

4.    Infikované zařízení se pokusilo
zaútočit na doménový řadič na port 445/tcp. Jaká byla IP adresa
tohoto řadiče?

5.    Infikované zařízení komunikovalo se
třemi řídícími servery na portu 449/tcp. Jaké jsou IP adresy (3)
těchto serverů?

6.    Na pohledu analýzy zjistěte, kterému
serveru (IP) infikované zařízení poslalo nejvíce paketů.

## 6.4.
Popis bezpečnostního
incidentu

V sekci 6.2 jsme se podrobněji podívali na to,
jakým způsobem bychom vyšetřovali kompromitované zařízení.
Během této analýzy jsme odhalili mnoho skutečností, které jasně
indikují, že došlo k bezpečnostnímu incidentu. Pro tento incident
bychom si mohli sepsat jednoduchý popis z informací, které jsme doposud
zjistili. Souhrn těchto informací by mohl vypadat následovně:

1.    IP adresa infikovaného zařízení:
10.9.25.101

2.    **10:35** Stažení spustitelného EXE souboru jako solar.php
(phn34ycjtghm.exe) ze serveru 144.91.69.195 ([VirusTotal](https://www.virustotal.com/gui/file/415e04eb340f1b092288cbcc71295a2c95e864fc1bbfcd55d6e3f5aa67099b1a)).

3.    **10:46** První kontakt s CnC serverem na IP 187.58.56.26:449.

4.    **10:48** První checkin na další CnC server
170.238.117.187:8082 a poslání hostname v URI
(/ono19/BACHMANN-BTO-PC_W617601.AC3B679F4A22738281E6D7B0C5946E42/90).

5.    **10:49** Odeslání uživatelského jména a hesla na CnC
server 170.238.117.187:8082.

6.    **10:49** Malware stahuje pomocné knihovny ze serveru
185.98.87.185:80.

7.    **10:50** Malware odesílá další informace o zařízení
jako nastavení sítě, seznam procesů, systémové informace a další.

Informace bychom
chtěli k incidentu nějakým způsobem uložit. Na Obrázek 117 můžeme vidět, že systém
dovoluje vytvořit incident z pohledu, který máme právě
otevřen. Po kliknutí na volbu nahlásit incident nám systém otevře
dialogové okno pro vyplnění zprávy o incidentu. Do tohoto dialogu vyplníme
doposud zjištěné informace. Jako první zvolíme název incidentu, který
zvolíme „Zařízení infikované malwarem TrickBot“. Dále vybereme riziko,
které hodnotíme jako kritické, jelikož se jedná o aktivní infekci. Pro stav
incidentu zvolíme možnost „BEING ANALYZED“, jelikož můžeme zachycenou komunikaci
ještě dále analyzovat. Systém také nabízí možnost přidat
k incidentu předdefinované nebo uživatelem definované štítky. Pozor,
tyto štítky nemají nic společného s tagy popsanými v sekci 4.9. Jako přiřazený uživatel se
automaticky vyplnil aktuálně přihlášený uživatel. V našem
případě tedy uživatel administrator. Důležitou částí je
poté pole pro samotný popis incidentu. Pole nabízí [wysiwyg](https://cs.wikipedia.org/wiki/WYSIWYG)
editor, pomocí kterého je možné vytvořit formátovaný popis incidentu.
Jakmile je popis hotový, můžeme popis incidentu uložit. Systém nám poté
oznámí, že byl incident úspěšně uložen do správce incidentů.

![image117.gif](GreyCortex%20Mendel/image117.gif)

Obrázek 117 Uložení popisu o bezpečnostním incidentu do správy incidentů.

Systém Mendel
disponuje správcem incidentů, do kterého je možné incidenty popisovat,
sdílet s ostatními uživateli a dále s nimi pracovat. Modul pro správu
incidentů v podstatě funguje jako tiketovací systém. Každý
incident si můžete představit jako tiket, který byl někým
vytvořený, má nějaký stav, popis a může nad ním proběhnout
diskuse ve formě komentářů ostatních uživatelů. Na Obrázek 118 můžeme vidět přechod na
pohled *Incidents*. V seznamu incidentů je pouze jeden incident,
který popisuje infikované zařízení. Můžeme si všimnout, že nově
vytvořený incident dostal identifikační číslo I-1. Každý
incident má v systému jedinečné identifikační číslo. Na
obrázku můžeme také vidět možnosti přidávání komentářů
k incidentům. Jestliže tedy se systémem pracuje více uživatelů,
může nad jednotlivými incidenty probíhat diskuse.

![image118.gif](GreyCortex%20Mendel/image118.gif)

Obrázek 118 Přechod do zobrazení správy incidentů.

Důležitým
atributem každého incidentu je také datový odkaz, který uživatele přenese
na pohled, na který se díval uživatel v době, kdy byl incident
reportován. Jak můžeme vidět na Obrázek 119, pomocí tohoto odkazu se můžeme
vrátit zpět na seznam událostí, které byly zaznamenány v době
infekce zařízení. Z aktuálního pohledu je také možné vytvořit
odkaz, který můžete poslat kolegovi, kterému chceme ukázat
přesně to, na co se aktuálně díváte.

![image119.gif](GreyCortex%20Mendel/image119.gif)

Obrázek 119 Každý incident obsahuje odkaz na pohled, ze kterého byl incident
vytvořen.

Další
užitečnou možností je exportování vybraných incidentů do souboru PDF
nebo CSV. Tato volba je vhodná při reportování nebo souhrnu incidentů
za nějaké vybrané období. Export incidentu I-1 můžeme vidět na Obrázek 120. Výsledný PDF soubor obsahuje předdefinovanou
hlavičku, tabulku exportovaných incidentů, popis jednotlivých
incidentů a předdefinované záhlaví. Pokud si chceme tento incident
prohlédnout detailněji, najdete jej jako přílohu [Export_2022-08-23.pdf](http://reymond.greycortex.com/trraining.htm#_Exporty_incident%C5%AF) . Modul pro správu incidentů může využít tým analytiků,
který používá systém Mendel pro analýzu síťové komunikace a potřebuje
si o jednotlivých incidentech předávat informace a diskutovat o nich.

![image120.gif](GreyCortex%20Mendel/image120.gif)

Obrázek 120 Export vybraného incidentu do formátu
PDF.

Tímto jsme si
ukázali, jak postupovat při analýze detekovaných událostí, jak tyto
události vyšetřit a jak vyšetřená fakta uložit jako incident
přímo do systému Mendel.

# 7. Řešení cvíčení

## 4.3.3 Cvičení –
Instalace linuxového balíčku

1.    172.29.10.103

2.    00:0c:29:40:b1:c0

3.    91.189.91.38

4.    80

5.    42626

6.    HTTP

7.    htop_2.1.0-3_amd64.deb

8.    C4239BB61C0AB97DFCCF7FCF4026ABA9

9.    us.archive.ubuntu.com

10.  TCP

11.  64-64-0-0-64240-64240-60-60-1460-7-3-0-20-5-0-17302530-3

12.  2013504

## 4.6.1 Cvičení –
podsítě, hosté a služby

1.    28.22k

2.    28.59k

3.    2

4.    3

5.    3

6.    FTP

7.    SSH

8.    HTTP

## 4.7.3 Cvičení –
S kým komunikuje mé zařízení?

1.    2

2.    merlin.fit.vutbr.cz

3.    edition.cnn.com

4.    582

5.    1.21

6.    Brno University of Technology

7.    54113

## 4.8.3 Cvičení –
Analyzujeme DNS komunikaci

1.    31

2.    A, AAAA, MX, TXT, NS

3.    33

4.    Ne

## 4.9.3 Cvičení –
štítkujeme nové služby

1.    Kerberos

2.    10.1.12.2

3.    10.5.3.1

4.    Discovery: New Kerberos Server

5.    -50023

6.    _gcx_role_server_kerberos

7.    Kerberos

8.    1226001

## 5.1.1 Cvičení –
Komunikace do sítě TOR

1.    192.168.1.2

2.    30:9c:23:b7:0d:8b

3.    1.3

4.    900000004

5.    Deutsche Telekom AG

6.    9001

7.    140e0f0cad708278ade0984528fe8493

## 5.3.3 Cvičení –
skenování portů

1.    Scan: RDP Port Sweep (3389)

2.    -22010

3.    172.28.255.143

4.    3389

5.    172.28.1.116

## 5.4.3 Cvičení –
Pravidlo pro zvýšení severity

1.    172.28.252.109

2.    28:f1:0e:1e:48:28

3.    8000

4.    Policy: Executable and linking format
(ELF) file download

5.    2000418

6.    armv5l_wg

7.    8

## 6.3 Cvičení -
TrickBot

1.    2014939

2.    rvmzrf24dgmr4tce.onion

3.    10.9.25.1

4.    10.9.25.1

5.    187.58.56.26, 186.183.199.114,
200.116.199.10

6.    195.123.220.86

# Přílohy

## 7.1.
Pcap soubory

[download-vlc-merlin-http.pcap](GreyCortex%20Mendel/download-vlc-merlin-http.pcap)

[http-get-flow.pcap](GreyCortex%20Mendel/http-get-flow.pcap)

[test-icmp-ping.pcap](GreyCortex%20Mendel/test-icmp-ping.pcap)

[network-peers-ssh-scan.pcap](GreyCortex%20Mendel/network-peers-ssh-scan.pcap)

[tls-communication.pcap](GreyCortex%20Mendel/tls-communication.pcap)

[smb-file-download.pcap](GreyCortex%20Mendel/smb-file-download.pcap)

[wget-http-outbound-download.pcap](GreyCortex%20Mendel/wget-http-outbound-download.pcap)

[nmap-scan.pcap](GreyCortex%20Mendel/nmap-scan.pcap)

[nmap-icmp-scan.pcap](GreyCortex%20Mendel/nmap-icmp-scan.pcap)

[dhcp.pcap](GreyCortex%20Mendel/dhcp.pcap)

[Trickbot-infection-traffic.pcap](GreyCortex%20Mendel/Trickbot-infection-traffic.pcap)

## 7.2.
Pcap soubory
pro cvičení

[dns.pcap](GreyCortex%20Mendel/dns.pcap)

[krb-816.pcap](GreyCortex%20Mendel/krb-816.pcap)

[malware_exe4.pcap](GreyCortex%20Mendel/malware_exe4.pcap)

[nba-scan.pcap](GreyCortex%20Mendel/nba-scan.pcap)

[package-install.pcap](GreyCortex%20Mendel/package-install.pcap)

[peers-ipv4.pcap](GreyCortex%20Mendel/peers-ipv4.pcap)

[subnets-hosts-services.pcap](GreyCortex%20Mendel/subnets-hosts-services.pcap)

[tor_bl.pcap](GreyCortex%20Mendel/tor_bl.pcap)