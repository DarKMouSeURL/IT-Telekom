# konfigurace pravidel na Fortinetu

# 2. nastavit vlastní hostname na fortinetu

> **System** → **Settings**
> 

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image.png)

<aside>
⚠️

nezapomenout uložit (Apply)

</aside>

# 3. změna konfiguračního portu (např. 20443)

> **System** → **Settings**
> 

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%201.png)

<aside>
⚠️

nezapomenout uložit (Apply)

</aside>

# 4. nastavení požadavků hesla u admina např.

- min. 17 znaků celkově
- min. 3 malé písmena
- min. 1 velké písmeno
- min. 2 číslice
- min. 1 special znak

> **System** → **Settings**
> 

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%202.png)

<aside>
⚠️

nezapomenout uložit (Apply)

</aside>

# 5. doba nečinnosti po které bude uživatel odhlášen (např. 10 min)

> **System** → **Settings**
> 

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%203.png)

<aside>
⚠️

nezapomenout uložit (Apply)

</aside>

# 6. tvorba nového admin účtu s jménem VPNadmin

## a. admin bude pouze moct spravovat VPN a zobrazit pravidla na FW

> **System → Administrators**
> 

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%204.png)

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%205.png)

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%206.png)

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%207.png)

# 7. linka WAN bude brát adresu z DHCP

> **Network → Interfaces**
> 

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%208.png)

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%209.png)

# 8. linka LAN1 a LAN3 bude mít adresu podle topologie a první použitelnou

<aside>
📌

nutné rozdělení LAN1 a LAN3 od lan (hardware switch), tak aby LAN1 a LAN3 byly samostatné rozhraní

</aside>

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2010.png)

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2011.png)

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2012.png)

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2013.png)

<aside>
📌

nástavní statické IP adresy podle plánu 

</aside>

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2014.png)

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2015.png)

# 9. vytvoření pravidel na FW

## a. každé pondělí od 12:00 do 13:00 LAN1 nebude mít přístup na webový server

> **Policy & Objects → Firewall Policy**
> 

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2016.png)

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2017.png)

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2018.png)

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2019.png)

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2020.png)

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2021.png)

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2022.png)

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2023.png)

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2024.png)

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2025.png)

## b. LAN1 a LAN3 nebudou moct používat nezabezpečené e-mail protokoly (SMTP, POP3, IMAP)

> **Policy & Objects → Firewall Policy**
> 

<aside>
📌

nutné pro každou LAN vytvořit nové pravidlo

</aside>

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2026.png)

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2027.png)

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2028.png)

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2029.png)

## c. z LAN1 na Web server bude moct použít pouze HTTP, HTTPS

<aside>
📌

nutné nastavit 2 pravidla

</aside>

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2030.png)

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2031.png)

<aside>
⚠️

1. pravidlo musí být pod prvním pravidlem
</aside>

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2032.png)

# 10. konfigurace VPN

## a. základní konfigurace VPN

> **VPN → SSL-VPN Setting**
> 

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2033.png)

<aside>
⚠️

nejdříve je nutné **vytvořit účty** “ucitel” a “student” úkol **b**. a **c.**

</aside>

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2034.png)

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2035.png)

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2036.png)

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2037.png)

## b. vytvoření uživatele student, přístup přes web portál, kde má jednu záložku na SSH pro připojení 172.16.0.**20**

> **User & Authentication → User Definition**
> 

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2038.png)

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2039.png)

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2040.png)

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2041.png)

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2042.png)

> **VPN → SSL-VPN Portals**
> 

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2043.png)

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2044.png)

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2045.png)

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2046.png)

> **VPN → SSL-VPN Settings**
> 

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2047.png)

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2048.png)

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2049.png)

## c. vytvoření uživatele učitel, přístup přes tunelovací režim, přístup vždy a všude

> **User & Authentication → User Definition**
> 

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2050.png)

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2051.png)

> **VPN → SSL-VPN Portals**
> 

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2052.png)

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2053.png)

> **VPN → SSL-VPN Settings**
> 

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2054.png)

## d. vypnout split tunneling pro VPN

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2055.png)

![image.png](dou%C4%8Dov%C3%A1n%C3%AD%20fortinet/image%2056.png)

---

# logování provozu

> **Log & Report → Log Settings**
> 

![image.png](konfigurace%20pravidel%20na%20Fortinetu/image.png)

> **Policy & Objects → Firewall Policy**
> 

![image (1).png](konfigurace%20pravidel%20na%20Fortinetu/image_(1).png)

> **Log & Report → Forward Traffic**
> 

![image (2).png](konfigurace%20pravidel%20na%20Fortinetu/image_(2).png)

# Omezení pásmo pro vybrané aplikace a weby

> **Policy & Object → Trafic Shaping**
> 

![image (3).png](konfigurace%20pravidel%20na%20Fortinetu/image_(3).png)

![image (4).png](konfigurace%20pravidel%20na%20Fortinetu/image_(4).png)

![image (5).png](konfigurace%20pravidel%20na%20Fortinetu/image_(5).png)

![image (6).png](konfigurace%20pravidel%20na%20Fortinetu/image_(6).png)

---

# IPS na FW

> **Security Profiles → Intrusion Prevention**
> 

![image (7).png](konfigurace%20pravidel%20na%20Fortinetu/image_(7).png)

![image (8).png](konfigurace%20pravidel%20na%20Fortinetu/image_(8).png)

![image (9).png](konfigurace%20pravidel%20na%20Fortinetu/image_(9).png)

![image (10).png](konfigurace%20pravidel%20na%20Fortinetu/image_(10).png)

> **Policy & Objects → Firewall Policy**
> 

![image (11).png](konfigurace%20pravidel%20na%20Fortinetu/image_(11).png)

---

# VPN pomocí IPSec-Wizard

🙏

---

# filtrace aplikací/protokolů

> **Security Profiles → Application Control**
> 

![image (12).png](konfigurace%20pravidel%20na%20Fortinetu/image_(12).png)

![image (13).png](konfigurace%20pravidel%20na%20Fortinetu/image_(13).png)

![image (14).png](konfigurace%20pravidel%20na%20Fortinetu/image_(14).png)

![image (15).png](konfigurace%20pravidel%20na%20Fortinetu/image_(15).png)

> **Policy & Objects → Firewall Policy**
> 

![image (16).png](konfigurace%20pravidel%20na%20Fortinetu/image_(16).png)

---

# Web-filtering

> **Security Profiles → Web Filter**
> 

![image.png](konfigurace%20pravidel%20na%20Fortinetu/image%201.png)

![image.png](konfigurace%20pravidel%20na%20Fortinetu/image%202.png)

> **Policy & Objects → Firewall Policy**
> 

![image.png](konfigurace%20pravidel%20na%20Fortinetu/image%203.png)

[Tilted_Towers_7-0_0523_202603230408.conf](konfigurace%20pravidel%20na%20Fortinetu/Tilted_Towers_7-0_0523_202603230408.conf)