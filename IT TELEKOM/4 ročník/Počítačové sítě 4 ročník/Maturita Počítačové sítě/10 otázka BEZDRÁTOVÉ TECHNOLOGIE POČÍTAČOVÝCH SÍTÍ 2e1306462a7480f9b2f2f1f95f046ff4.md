# 10. otázka BEZDRÁTOVÉ TECHNOLOGIE POČÍTAČOVÝCH SÍTÍ

---

- principy přenosu dat pomocí rádiových vln
- porovnání LAN a WLAN, komponenty bezdrátových sítí
- standardy WLAN, pojmy: ISM pásmo, kanály, rušení a útlum
- topologie AD-HOC, BSS, ESS, zabezpečení WEP, WPA2 a WPA3
- pojem SSID, postup připojení stanice do WLAN

---

# principy přenosu dat pomocí rádiových vln

![image.png](10%20ot%C3%A1zka%20BEZDR%C3%81TOV%C3%89%20TECHNOLOGIE%20PO%C4%8C%C3%8DTA%C4%8COV%C3%9DCH%20S%C3%8DT%C3%8D/image.png)

- 2.4GHz a 5GHz
- elektromagnetické vlny
    - světlo
- rychlost šíření 300 000 km/s

### amplituda

> jak silný je signál
> 
- jaké maximální hodnoty signál dosáhne

![image.png](10%20ot%C3%A1zka%20BEZDR%C3%81TOV%C3%89%20TECHNOLOGIE%20PO%C4%8C%C3%8DTA%C4%8COV%C3%9DCH%20S%C3%8DT%C3%8D/image%201.png)

### frekvence

> jak “rychlý” je signál
> 
- jaký má kmitočet

![image.png](10%20ot%C3%A1zka%20BEZDR%C3%81TOV%C3%89%20TECHNOLOGIE%20PO%C4%8C%C3%8DTA%C4%8COV%C3%9DCH%20S%C3%8DT%C3%8D/image%202.png)

## Amplitudová modulace (AM)

- signál se mění podle amplitudy
- udržuje si stále stejnou frekvenci
- mění se “výška” signálu

## Frekvenční modulace (FM)

- signál se mění podle frekvence
- udržuje si stále stejnou amplitudu
- mění se “rychlost” signálu

![Amfm3-en-de.gif](10%20ot%C3%A1zka%20BEZDR%C3%81TOV%C3%89%20TECHNOLOGIE%20PO%C4%8C%C3%8DTA%C4%8COV%C3%9DCH%20S%C3%8DT%C3%8D/Amfm3-en-de.gif)

# Fázová modulace

- amplituda a frekvence zůstává stále stejná
- mění se fáze viz. obrázek

![image.png](10%20ot%C3%A1zka%20BEZDR%C3%81TOV%C3%89%20TECHNOLOGIE%20PO%C4%8C%C3%8DTA%C4%8COV%C3%9DCH%20S%C3%8DT%C3%8D/image%203.png)

## Typy

### PAN (Personal Area Network)

- bluetooth
- 2-3 metry

### LAN (Wi-Fi)

- standart 802.11
- 10 - 20 metrů

### MAN (Metropolitan Area Network)

- stovky metrů

### WAN (Wide Area Network)

- GPS…

---

# porovnání LAN a WLAN, komponenty bezdrátových sítí

# LAN

- UTP kabel + RJ45
- **802.3 Ethernet**
- přenáší signál po celé trase správně
- připojení přes port SWITCH
- Bez přístupových metod
- bez kolizní

# WLAN

- bezdrátově (rádiové frekvence)
- **802.11**
- vysílání může zachytit kdokoliv v okolí
    - může být bezpečnostní riziko
- může nastat rušení rádiových frekvencí
- signál slábne se vzdáleností od vysílače
    - připojení přes AP (Access Point)
- rádiové vlny podléhají regulaci pod **ČTU** (**Č**eský **T**elekomunikační **Ú**řad)
    - platí se za licence
- přístupová metoda CSMA/CA
- snadné připojení k síti a k tomu kdekoliv v dosahu
- prodloužení drátových sítí

# komponenty bezdrátových sítí

# Stanice (STA)

- koncové zařízení s podporou pro bezdrátovou komunikaci
- PC, IoT…

# Přístupový bod (AP)

- připojuje bezdrátově hosty k sítí
- převádí z 802.11(**Wi-Fi**) na 802.3(**Ethernet**)

![image.png](10%20ot%C3%A1zka%20BEZDR%C3%81TOV%C3%89%20TECHNOLOGIE%20PO%C4%8C%C3%8DTA%C4%8COV%C3%9DCH%20S%C3%8DT%C3%8D/image%204.png)

---

# standardy WLAN, pojmy: ISM pásmo, kanály, rušení a útlum

- standard IEEE

| standart | pásmo | rychlost |
| --- | --- | --- |
| **802.11** | 2.4GHz | 2 Mb/s |
| **802.11a** | 5 GHz | 54 Mb/s |
| **802.11ac** | 5 GHz | ~7 Gb/s |
| **802.11be (Wi-Fi 7)** | 2.4/5/6 GHz | ~ 46 Gb/s |

# ISM pásmo

- bezlicenční pásmo **ISM** (unlicensed **I**ndustrial, **S**cientific and **M**edical)
- za využití pásma se neplatí

# kanály

- AP může fungovat pouze na 1 kanálu
- kanály se překrývají
- pokud 2 kanály se překrývají, dochází k rušení
- v jaké části pásma má AP pracovat jak 2.4GHz tak i 5GHz
- bezpečné uspořádání kanálů **1 6 11**

- EU má 13 kanálů

![image.png](10%20ot%C3%A1zka%20BEZDR%C3%81TOV%C3%89%20TECHNOLOGIE%20PO%C4%8C%C3%8DTA%C4%8COV%C3%9DCH%20S%C3%8DT%C3%8D/image%205.png)

- USA má 11 kanálů

![image.png](10%20ot%C3%A1zka%20BEZDR%C3%81TOV%C3%89%20TECHNOLOGIE%20PO%C4%8C%C3%8DTA%C4%8COV%C3%9DCH%20S%C3%8DT%C3%8D/image%206.png)

# rušení

- dojde když více zařízení vysílají na stejném pásmu
- stává se DoS
- rušení mohou způsobovat i spotřebiče (mikrovlnná trouby…)

# útlum

- čím zařízení je vzdálenější od AP, ztrácí se síla signálu
- překážky jako zdi… zeslabují signál

---

# topologie AD-HOC, BSS, ESS, zabezpečení WEP, WPA2 a WPA3

# AD-HOC

- zapojení bez AP
- **bluetooth, tethering**
- zařízení se spojí navzájem

![image.png](10%20ot%C3%A1zka%20BEZDR%C3%81TOV%C3%89%20TECHNOLOGIE%20PO%C4%8C%C3%8DTA%C4%8COV%C3%9DCH%20S%C3%8DT%C3%8D/image%207.png)

# BSS

<aside>
📌

- ***B**asic **S**ervice **S**et*
</aside>

- zapojení pouze s 1 AP
- většinou domácí router

![image.png](10%20ot%C3%A1zka%20BEZDR%C3%81TOV%C3%89%20TECHNOLOGIE%20PO%C4%8C%C3%8DTA%C4%8COV%C3%9DCH%20S%C3%8DT%C3%8D/image%208.png)

# ESS

<aside>
📌

- ***E**xtended **S**ervice **S**et*
</aside>

- zapojení několik AP
- společně pokrývají větší oblast

![image.png](10%20ot%C3%A1zka%20BEZDR%C3%81TOV%C3%89%20TECHNOLOGIE%20PO%C4%8C%C3%8DTA%C4%8COV%C3%9DCH%20S%C3%8DT%C3%8D/image%209.png)

# zabezpečení WEP

<aside>
📌

***W**ired **E**quivalent **P**rivacy*

</aside>

- zastaralý a dnes nepoužívaný
- první generace ochrany přístupu na Wi-Fi
- prolomená šifra RC4
- statický klíč

# WPA2

<aside>
📌

***Wi-Fi Protected Access version 2***

</aside>

- následovník WEP WPA1
- IEEE 802.11i
- šifra AES (***A**dvanced **E**ncryption **S**tandard*)
- možné použít s 802.1X (radius)
- **TKIP** (***T**emporal **K**ey **I**ntegrity **P**rotocol*)
- **AES** (***A**dvanced **E**ncryption **S**tandard*)
    - dynamické vytváření klíčů
        - za určitý čas si AP změní klíč, který používá pro komunikaci s klientem

# WPA3

<aside>
📌

***Wi-Fi Protected Access version 3***

</aside>

- nástupce WPA2 2018
- vylepšená verze
- individuální šifrování pro každé zařízení

---

# pojem SSID, postup připojení stanice do WLAN

<aside>
📌

***S**hare **S**ervise set **ID**entifier*

</aside>

- jméno Wi-Fi sítě
- vysíláno AP pro připojení
    - SSID broadcast

# postup připojení stanice do WLAN

## Beacon

- periodické oznámení o existenci sítě
- obsahuje SSID, standardy, zabezpečení
- vysílá se na L2 (rámec)

## Fáze první

- koncové zařízení odešle ***probe*** L2 rámec
- odešle SSID a podporovaný standard 802.11
- AP odpoví ***probe response***

## Fáze druhá

- koncové zařízení odešle požadavek o autentizaci
- AP odpoví typ zabezpečení a “*challenge”*
- koncové zařízení zašifruje “*challenge”* pomocí hesla na Wi-Fi
- AP zkontroluje *“challenge”* a podle výsledku umožní přístup do sítě

## Fáze třetí

- koncové zařízení odešle association request
    - obsahuje svou MAC a MAC AP (BSSID)
- AP odpoví podle *“challenge”*
    - **AID** (***Association ID***)

---

[něco navíc](10%20ot%C3%A1zka%20BEZDR%C3%81TOV%C3%89%20TECHNOLOGIE%20PO%C4%8C%C3%8DTA%C4%8COV%C3%9DCH%20S%C3%8DT%C3%8D/n%C4%9Bco%20nav%C3%ADc%20315306462a7480c6ae63c89aa8d7d545.md)