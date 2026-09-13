# 18. otázka VÝSTUPNÍ PERIFERIE POČÍTAČE

---

- tiskárna – připojení, dělení, výběr tiskárny
- základní princip tisku u jednotlivých druhů tiskáren
- reproduktory – typy, připojení, výběr
- monitory LCD, OLED – druhy, princip, řízení, připojení k počítači, výhody a nevýhody
- dataprojektory – druhy, princip, připojení k počítači, výhody a nevýhody

---

# tiskárna – připojení, dělení, výběr tiskárny

## dělení tiskáren

### **Impaktní** *(příklepové)*

- pracují na principu psacího stroje
- musí dojít k příklepu raznice na barvicí pásku
- typy:
    - **jehličková** – nejrozšířenější z impaktních
    - řádková
    - s kulovou hlavou
    - s typovým kolečkem

### **Neimpaktní** *(dotekové)*

- ke vzniku písma nedochází příklepem
- typy:
    - **inkoustová** *(tryskový tisk)*
    - **laserová**
    - **LED**
    - **termální** *(tepelná)*
    - **3D tiskárna**

### připojení tiskárny k počítači

- **USB** – dnes nejběžnější
- **WiFi** – bezdrátový tisk, sdílená tiskárna v síti
- **Bluetooth** – mobilní tisk
- **RJ-45 Ethernet** – síťová tiskárna (kancelář, firma)

**Historická rozhraní**

- **Centronics** *(paralelní port)* – jehličkové tiskárny
- **RS-232** *(sériový port)*

## výběr tiskárny

1. **účel použití**
    
    
    | **Použití** | **Doporučený typ** |
    | --- | --- |
    | **Kancelář, texty** | Laserová (nízké náklady/str) |
    | **Fotografie** | Inkoustová (kvalita barev) |
    | **Sklad, faktury** | Jehličková (kopírovací papír) |
    | **Pokladní páska** | Termální (tichá, rychlá) |
    | **Prototypy, modely** | 3D tiskárna |
2. **rychlost tisku** *(stránky/min nebo znaky/min)*
3. **kvalita tisku** *(DPI – Dots Per Inch)* – čím vyšší, tím detailnější
4. **barevnost** – černobílá nebo barevná (CMYK)
5. **provozní náklady** – cena za stránku (tonery, inkousty, barvicí páska)
6. **rozhraní** – USB, WiFi, Ethernet, Bluetooth
7. **duplexní tisk** – automatický oboustranný tisk
8. **Cena, výrobce**

## základní princip tisku u jednotlivých druhů tiskáren

### Jehličková tiskárna

- elektromagnetická tisková hlava s jehličkami (9 nebo 24 jehliček)
- jehličky jsou vystřelovány elektromagnety vpřed → přes barvicí pásku na papír
- výsledný obraz = matice bodů (rastr)
- **DRAFT** = rychlý tisk, viditelné body
- **NLQ** *(Near Letter Quality)* = 2 průchody, překládání → kvalitnější
- větší počet jehliček = vyšší DPI = kvalitnější tisk

#### **Výhody:**

- nízké provozní náklady
- tisk přes kopírovací papír (průklepem)
- tisk na nekonečný papír

#### **Nevýhody:**

- hlučnost
- omezená kvalita tisku
- nízká rychlost u grafiky

### Řádková tiskárna

- bez tiskací hlavy – řada kladívek (raznic) celé šířky papíru
- kladívka seřazena po 6 v **modulech** uložených do lavice
- kladívko ovládáno elektromagnetem → udeří přes barvicí pásku na papír
- lavice se kmitá vychyluje pomocí **excentru** (krokový motorek) → matice bodů
- 1 500 řádků/min, nízká hlučnost (53 dB), malá poruchovost

---

### Termální tiskárna

- pracuje s **teplo citlivými materiály**
- tepelná tisková hlava pohybující se přes šířku papíru
- **typy:**
    - s teplo citlivou **páskou** – teplo odtaví barvivo na papír
    - s teplo citlivou **fólií** – tepelný hřeben (2400 prvků) přes celou šířku
    - s teplocitlivým **papírem** – papír tmavne teplem, nejlevnější

**Výhody:** tichá, nízká spotřeba, přesný bod

**Nevýhody:** speciální papír, tepelně nestabilní výtisk, vysoké náklady

---

#### 3D tiskárna

- vyrábí fyzický plastový model z digitálního 3D modelu (CAD, 3D Studio)
- princip: model rozložen do tenkých vrstev → vrstvy se skládají v tiskárně
- materiál se **přidává** (ne odebírá jako při obrábění)
- po každé vrstvě základní deska klesne o tloušťku jedné vrstvy

**Technologie 3D tisku:**

- **FDM** *(Fused Deposition Modeling)* – nanášení roztaveného materiálu po vrstvách; dnes nejrozšířenější
- **SLS** *(Selective Laser Sintering)* – zapékání práškového materiálu laserem
- **PolyJet** – fotopolymer vytlačován z hlav a vytvrzován UV lampou; velmi jemný povrch
- **ZCORP** – prášek spojován pojivem jako inkoustová tiskárna; lze barevně

### Inkoustová tiskárna *(tryskový tisk)*

- jehlice tiskové hlavy nahrazeny **tryskami**
- neimpaktní, maticová tiskárna – hlava se nedotýká papíru
- 3 principy vypuzení inkoustu

#### **a) Tepelné působení** *(Bubble-Jet)*

- elektrický impuls zahřeje element na **~300 °C**
- inkoust se odpaří → vzduchová bublina → velký tlak → kapka vystřelena rychlostí ~100 km/h
- po odeznění impulsu bublina splaskne → podtlak nasaje nový inkoust
- hlava se mění se zásobníkem (tepelné namáhání)
- výrobci: **Canon**, **Hewlett-Packard**

#### **b) Piezoelektrická metoda** *(Ink-Jet)*

- piezoelektrická vlákna deformují stěny tryskové komůrky
- přivedením napětí → rozšíření komůrky (nasátí inkoustu)
- obrácení polarity → zúžení komůrky → kapka inkoustu vystřelena
- umožňuje přesné dávkování → lepší reprodukce barev
- výrobce: **Epson**

#### **c) Tuhé inkousty** *(Solid Ink)*

- pevný inkoust (polymer) nataven na přesně **92 °C**
- kapičky nastříkány přímo na papír *(přímý tisk)*
- nebo na přenosový buben → z bubnu na papír *(offsetový tisk)*
- výhody: okamžitá stálost, nešpiní, výborná kvalita

---

**Výhody inkoustových:** tichá, rychlá i pro grafiku, snadný barevný tisk

**Nevýhody:** vysoké náklady na zásobníky, rozpíjení na nekvalitním papíře

### Laserová tiskárna

- **stránková tiskárna** – nejprve se vytvoří celá stránka v paměti, pak se tiskne
- princip: vzájemné působení elektrických nábojů + fotocitlivý světelný válec

#### **6 kroků pracovního cyklu:**

1. **Nabití válce** záporným nábojem
2. **Osvit laserovým paprskem** → latentní obraz *(osvětlená místa se vybijí = neutrální)*
3. **Přenos toneru** – toner záporně nabit, zachytí se na neutrální osvětlená místa
4. **Přenos toneru na papír** – papír kladně nabit, odsaje toner z válce
5. **Fixace** – toner roztaven při **~180 °C** a spojen s papírem
6. **Vyčištění válce** – osvit eliminuje zbylý náboj, gumová stěrka setře toner

**Výhody:** vysoká kvalita, rychlost, nízké náklady/str

**Nevýhody:** dražší pořizovací cena, velký příkon při startu

#### LED tiskárna

- laserový paprsek nahrazen **maticí LED diod** nad světelným válcem
- pro A4 / 300 DPI potřeba **2 432 LED diod** přes celou délku válce
- diody osvětlují bod za bodem přes zaostřovací čočky
- zbytek procesu **shodný s laserovou tiskárnou**
- výhoda: méně pohyblivých částí → odolnější, konstrukčně jednodušší

#### Barevný tisk – barevné modely

**CMYK model** *(tiskárna)*

<aside>
📌

**C**yan **M**agenta **Y**ellow **K**ey (Black)

</aside>

- **subtraktivní** mísení barev
- C + M + Y dohromady = černá (teoreticky)
- K (černá) se přidává zvlášť – úspora inkoustu a kvalitnější černá

---

# reproduktory – typy, připojení, výběr

## typy reproduktorů

### **Aktivní reproduktory**

- mají **vestavěný zesilovač**
- připojí se přímo k počítači nebo TV
- jednoduchá instalace
- použití: PC sestavy, TV

### **Pasivní reproduktory**

- **bez zesilovače** – nutný externí zesilovač
- vyšší kvalita zvuku
- použití: domácí kino, hi-fi soustavy

**Soundbar**

- kompaktní liška nahrazující více reproduktorů
- určena primárně k TV
- obvykle aktivní, Bluetooth nebo HDMI ARC

### **Subwoofer**

- reproduktor pro nízké frekvence *(basy)*
- doplňuje satelitní reproduktory
- součást sestav 2.1, 5.1, 7.1

### **Surround systémy**

| Sestava | Popis |
| --- | --- |
| 2.0 | 2 satelity, bez subwooferu |
| 2.1 | 2 satelity + subwoofer |
| 5.1 | 5 satelitů + subwoofer |
| 7.1 | 7 satelitů + subwoofer |

### **Sluchátka**

- osobní výstup zvuku
- připojení: 3.5mm jack, USB, Bluetooth
- typy: over-ear, on-ear, in-ear (sluchátka do uší)

## princip funkce reproduktoru

- elektrický signál → **elektromagnet** (cívka v magnetickém poli)
- cívka se pohybuje → rozkmitá **membránu**
- vibrující membrána → **zvukové vlny** ve vzduchu
- čím vyšší signál, tím větší výchylka membrány = hlasitější zvuk

## připojení reproduktorů

### **Analogové**

- **3.5 mm jack** – nejběžnější pro PC a notebooky
- **RCA (cinch)** – AV zařízení, domácí kino
- **XLR** – profesionální audio

### **Digitální**

- **Optical TOSLINK** – bezztrátový digitální přenos
- **HDMI ARC/eARC** – zpětný zvukový kanál pro TV
- **USB** – aktivní reproduktory, napájení + zvuk
- **Bluetooth** – bezdrátové, do 10 m
- **WiFi / Chromecast / AirPlay** – multiroom audio

### výběr reproduktorů

1. **aktivní vs. pasivní** – pasivní = lepší zvuk, ale nutný zesilovač
2. **výkon [W]** – větší místnost = více wattů
3. **frekvenční rozsah [Hz]** – ideálně 20–20 000 Hz (slyšitelné pásmo)
4. **sestava** – 2.0 pro PC, 2.1/5.1/7.1 pro domácí kino
5. **připojení** – jack, Bluetooth, HDMI ARC, Optical
6. **Cena, výrobce** – Logitech, JBL, Bose, Sony

---

# monitory LCD, OLED – druhy, princip, řízení, připojení, výhody a nevýhody

## druhy – typy panelů

### LCD monitory

<aside>
📌

***L**iquid **C**rystal **D**isplay*

</aside>

- podsvícení (LED) + tekuté krystaly + barevné filtry

#### **TN** *(Twisted Nematic)*

- nejlevnější technologie
- rychlá odezva *(1–5 ms)* → gaming
- horší barvy a úzké zorné úhly

#### **IPS** *(In-Plane Switching)*

- výborné barvy a zorné úhly
- pomalejší odezva než TN
- použití: grafika, fotografové, kancelář

#### **VA** *(Vertical Alignment)*

- vysoký kontrast, hluboká černá
- kompromis mezi TN a IPS
- mírný ghosting při rychlém pohybu

### OLED monitory

<aside>
📌

***O**rganic **L**ight-**E**mitting **D**iode*

</aside>

- každý pixel **svítí samostatně** – žádné podsvícení
- dokonalá černá = pixel jednoduše zhasne

#### **AMOLED** *(Active Matrix OLED)*

- aktivní matice pro řízení pixelů
- použití v mobilních telefonech, notebookách

#### **QD-OLED** *(Quantum Dot OLED)*

- kombinace OLED + kvantové tečky
- širší barevné spektrum, vyšší jas
- nejmodernější technologie monitorů

#### výhody a nevýhody

| Technologie | Výhody | Nevýhody |
| --- | --- | --- |
| **LCD TN** | Nízká cena, rychlá odezva | Horší barvy, úzké zorné úhly |
| **LCD IPS** | Výborné barvy, široké zorné úhly | Vyšší cena, pomalejší odezva |
| **LCD VA** | Vysoký kontrast, hluboká černá | Ghosting, kompromisní barvy |
| **OLED** | Dokonalá černá, neomezený kontrast, rychlý, tenký | Burn-in, dražší, omezená životnost |

## princip fungování

### **Princip LCD:**

1. **Podsvícení** *(LED pásky za panelem)* → bílé světlo
2. **Polarizační filtr** → orientuje světelné vlny
3. **Tekuté krystaly** → natočí se dle elektrického napětí → propustí nebo zablokují světlo
4. **Barevný filtr** *(RGB)* → přidá barvu každému pixelu
5. **Výsledný pixel** na obrazovce

> Černá = tekuté krystaly zablokují světlo (ne úplně → LED svítí skrz → šedo černá)
> 

### **Princip OLED:**

1. **Organická vrstva** emituje světlo přímo při průchodu elektrického proudu
2. Každý pixel = samostatná dioda
3. Žádné podsvícení není potřeba
4. **Černá** = pixel zcela zhasnut = absolutní černá

> **Kontrast** = *světlý pixel vs. zhasnutý pixel*
> 

## parametry a řízení monitoru

| **Parametr** | **Popis** |
| --- | --- |
| **Rozlišení** | Full HD (1080p), 2K (1440p), 4K (2160p), 8K |
| **Obnovovací frekvence** | 60 Hz (standard), 144 Hz (gaming), 240 Hz (esport) |
| **Odezva** | ms – čím nižší, tím méně ghostingu (TN < IPS < VA) |
| **Kontrast** | Poměr nejsvětlejšího a nejtmavšího bodu |
| **Jas** | cd/m² (nits) – důležité pro HDR obsah |
| **Barevný gamut** | sRGB (kancelář), DCI-P3 (grafika/video), Adobe RGB |
| **HDR** | High Dynamic Range – větší rozsah jasu a kontrastu |
| **Velikost [palce]** | Úhlopříčka displeje v palcích |

### připojení monitoru k počítači

- **HDMI** – digitální obraz + zvuk; nejběžnější; verze 1.4 / 2.0 / 2.1
- **DisplayPort** – vysoký výkon, 144Hz+, pro herní monitory
- **USB-C / Thunderbolt** – moderní; napájení + data + obraz v jednom kabelu

**Historické**

- **VGA** *(D-Sub 15-pin)* – analogový, dnes zastaralý
- **DVI** – digitální/analogový, bez zvuku

---

# dataprojektory – druhy, princip, připojení k počítači, výhody a nevýhody

## druhy dataprojektorů

### **LCD projektor**

- světlo prochází třemi LCD panely *(R, G, B)*
- barvy se kombinují → obraz promítán přes čočky

### **DLP projektor**

<aside>
📌

***D**igital **L**ight **P**rocessing*

</aside>

- světlo → **DMD čip** *(pole mikroskopických zrcátek)*
- každé zrcátko se nakloní → odráží světlo do čočky *(světlé)* nebo mimo *(tmavé)*
- výhody: kompaktnější, ostřejší obraz, méně pohyblivých částí

### **LCoS projektor**

<aside>
📌

***L**iquid **C**rystal **o**n **S**ilicon*

</aside>

- kombinace LCD a DLP principů
- tekuté krystaly na křemíkovém substrátu
- vysoká kvalita obrazu, vyšší cena

### **Laserový projektor**

- světelný zdroj = laser místo lampy
- výhody: dlouhá životnost *(20 000+ hodin)*, okamžitý start, stabilní barvy
- vyšší pořizovací cena
- použití: kina, konferenční místnosti, velké instalace

### výhody a nevýhody

|  | Výhody | Nevýhody |
| --- | --- | --- |
| **Obecně** | Velký obraz (až stovky palců), přenosnost, levnější než velký TV | Závislost na osvětlení místnosti, nutnost plátna |
| **LCD projektor** | Věrné barvy, nízká cena | Těžší, horší černá |
| **DLP projektor** | Kompaktní, ostrý obraz | Rainbow effect (duhový efekt u jednočipových) |
| **Laserový** | Dlouhá životnost, okamžitý start, stabilní barvy | Vyšší cena |

## princip fungování

### **LCD projektor:**

- výkonná lampa *(nebo LED/laser)* → rozložení světla na 3 barvy *(dichroická zrcadla)* → 3 LCD panely → sloučení → čočky → promítnutí na plátno

### **DLP projektor:**

- výkonná lampa → barevné kolečko *(rotating color wheel)* → DMD čip *(pole zrcátek ~800 000 mikrozrcátek)* → naklopení zrcátek *(on/off)* → čočky → plátno

> Rychlé přepínání zrcátek vytváří iluzi šedé škály (pulzně-šířková modulace)
> 

## připojení k počítači

### **Drátové**

- **HDMI** – nejběžnější; obraz + zvuk
- **DisplayPort** – pro profesionální použití
- **USB-C / Thunderbolt** – moderní notebooky
- **VGA** – historické; analogové

### **Bezdrátové**

- **WiFi** *(Miracast, AirPlay, Chromecast)*
- **Bluetooth** – pro audio výstup
- **USB klíčenka** *(dongle)*