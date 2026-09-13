# 12. otázka KYBERNETICKÉ ÚTOKY

---

- definice malware, typy malware a jejich popis
- obecné členění kybernetických útoků
- popis základních typů útoků
- specifické formy kybernetických útoků (útoky na sociálních sítích, cyberwar...)
- ochrana a prevence před kybernetickými útoky

---

# definice malware, typy malware a jejich popis

**není jedna stanovená definice**

> “Malware je škodlivý software navržený tak, aby narušil, poškodil nebo získal neoprávněný přístup k počítačovým systémům.”
> 

# typy malware a jejich popis

## Viry

- škodlivý software, který se duplikuje a šíří
- vkládá se do softwaru, skrytý před uživatelem a antivirem

Poskládán ze 2 částí

1. vyhledávací rutina
2. Kopírovací rutina
- sektorové viry, bootovací viry, makroviry, multiplatformní viry

## Červy

- neparazitický
- červ se dokáže šířit sám, není závislý na hostitelském souboru
- multivektorové šíření (šíření více způsoby)
    - e-mail, IM a IRC…

## Trojské koně

- software vydávající se za legitimní program
- uživatel většinou dobrovolně stahuje
- pirátské programy, stahování programů z neověřených zdrojů
- použití checksum pro zkontrolování integrity programu z oficiálního webu

## Adware

- reklamní malware
- vyskakovací reklamy
- zpomaluje zařízení
- často přichází jako trojský kůň

## SpyWare

- tajně krade data od uživatele
- může ukrást přihlašovací údaje nebo finanční údaje

## Ransomware

- šifrování disku a všech dat na něm
- požaduje výkupné pro odšifrování souborů
- např. WannaCry

## Rootkity

- souhrn programů pro narušení systému
- hluboko v systému
- v jádře systému (kernel)
- skrytý a trvalý přístup k systému

## Exploity

> využití zranitelnosti v systému
> 
- distribuční mechanismus pro malware
- využití zranitelnosti v systému nebo programu

---

# obecné členění kybernetických útoků

## Útok na důvěrnost

- soc. inženýrství
- Malware

## Útoky na integritu

- SQL injection
- Man-in-the-middle

## Útok na dostupnost

- DOS / DDOS

# popis základních typů útoků

### Sociální inženýrství

- “hackování” lidí
- typ útoku, kdy jsou cíle lidi
- snaha získat osobní údaje (hesla, bankovní informace…)
- *phishing, Vishing, Smishing…*
    - **phishing** - vylákání z oběti osobní údaje (hesla…), vydávání se za velké společnosti, textové zprávy
    - **Vishing** - vylákání z oběti osobní údaje pomocí telefoního hovoru
    - **Smishing** - pomocí SMS zpráv

### Malware

- kód pro napadení systému
- získání přístupu nebo narušení chodu systému

### SQL injection

- napadení SQL databáze
- snaha získat data které uživatel nemá normálně přístup
- nesprávné ověření vstupu od uživatele

### Man-in-the-middle

- typ útoku, kdy útočník odposlouchává komunikaci
- útočník je mezi cílem a hostitelem
- může odposlouchávat nebo měnit komunikaci
- nejčastěji v otevřených wi-fi sítích

### DOS / DDOS

<aside>
📌

***D**enial **O**f **S**ervice*

</aside>

- znemožnění přístupu k systému
- narušení CIA-Availability

<aside>
📌

***D**istributed **D**enial **O**f **S**ervice*

</aside>

- zahlcení hostitele
- DDOS - používá více zařízení (botnet)

---

# specifické formy kybernetických útoků (útoky na sociálních sítích, cyberwar...)

## útoky na sociálních sítích

- sociální inženýrství
- phishing
    - vylákání z oběti osobní údaje (hesla…), vydávání se za velké společnosti, e-mail
- krádež totožnosti na sociální síti
    - kdy se útočník zmocní účtu
    - může rozšiřovat svoji působnost, napsání kontaktům na soc.
    - třeba propagace scam služby na ukradeném účtě

## Cyberwar

- odehrává se pouze přes internet (kyberprostor)
- odehrává se mezi státy
- většinou se zaměřují na infrastrukturu
    - dopravu, militární důležité prostředky
- Tallinnský manuál
    - mezinárodní právo vojenským operacím v kyberprostoru

*kyberprostor* = 5. válečná zóna

## Botnet

- infikované zařízení v botnetu
- na dálku řízené útočníkem
- bez povšimnutí uživatele
- ne vždy nelegální činnost
    - distribuovaný výpočet (dobrovolnické zapojení do dobrovolného projektu)

### složení

1. botmaster
2. command-and-control infrastruktura
3. boti

## Kyber terorismus

- kybernetické útoky, které se snaží o vyvolání strachu populace
- cíl může být
    - energetický průmysl, přepravní nebo státní instituce
- politický nebo náboženský motiv
- DDOS, krádež identity vysoce postaveného člena na soc. sítích, změna obsahu web stránek (defacement)

---

# ochrana a prevence před kybernetickými útoky

## aktualizace SW

- Pravidelné aktualizování SW/OS
- Bezpečnostní záplaty

## Obezřetnost a znalost o soc. inženýrství

- neklikat na podezřelé odkazy
- nestahovat podezřelé soubory
- odhalení phishingu…
- školení zaměstnanců o hrozbách

## antivirus

- na koncovém zařízení
- chrání před škodlivým softwarem
- není 100%
- nutný pokud pracujeme s podezřelými soubory
- zpomalení PC

## politiky (2FA)

- nastavení osobních politik
- 2 fázové ověření
- silná hesla
- nepoužívat pouze 1 heslo na více služeb/stránek…

## Zálohování

- prevence vůči ztrátě dat
- zejména proti ransomwaru

## šifrování disku / dat

- užitečné při fyzické ukradení zařízení