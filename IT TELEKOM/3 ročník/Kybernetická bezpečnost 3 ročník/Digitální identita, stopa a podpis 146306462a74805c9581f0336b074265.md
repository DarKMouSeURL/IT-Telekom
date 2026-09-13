# Digitální identita, stopa a podpis

# Digitální identita

- odkazuje na identifikuje jednotlivce nebo v digitálním prostoru
    - uživatelské jméno
    - hesla
    - osobní informace
    - biometrie údaje
    - digitální certifikáty

## Uživatelská jména a hesla

1. **Autentizace**: používání jmen a hesel
2. **Heslo**: řetězec znaku k autentizaci
3. **Hashovaní hesel**: hash
4. **výhody hashovani**: zabraně odhaleni hesel
5. **další bezpečnostní opatřeni:** použiti soli (salt) před hashovani hesel

## biometrie

- způsob identifikace na základě biologických charakteristik (otisk prstů, rozpoznání obličeje)
- nutno šifrovat
- můžeme kombinovat s dalšími faktory autentizace
- pravidelně aktualizovat

## certifikáty

- elektronické dokumenty
    - informace o identitě a jeho veřejný klíč
- vydávány certifikační autoritou (CA)
- Veřejný klíč: součást certifikátu, sdílena s ostatními ověření digitálních podpisů

### informace

1. jméno
2. číslo certifikátu, platnost
3. digitální podpis certifikační autority
    1. pro ověření pravosti

### důležitost

1. zajištění důvěr: komunikace stran bezpečně
2. ochrana šifrování: veřejné klíče, chrání před zneužitím
3. proces vydání: autorita ověřují identitu, posiluje důvěryhodnost
4. revokace: odvolání certifikátu
5. role v kryptografii: umožní používání klíčů pro šifrování, zachování integrity a autenticity dat

2FA (Dvoufázové ověření)

- 2 různé prvky(heslo, kód z autenticatoru)
- vyšší bezpečnost
    - útočník potřebuje dvě různé přístupové údaje

# Osobní údaje

Veškeré informace vztahující se k identifikované nebo identifikovatelné fyzické osobě.

- Přímé identifikátory
    - jméno a příjmení
    - rodné číslo
    - číslo občanského průkazu
- Nepřímé identifikátory
    - věk
    - pohlaví
    - bydliště
    - fyzické či fyziologické znaky
- Zvláštní kategorie osobních údajů
    - údaje o zdravotním stavu
    - biometrické údaje
    - genetické údaje
    - údaje o náboženském vyznání

Ochrana osobních údajů je regulována zákonem a GDPR (Obecné nařízení o ochraně osobních údajů).

### digitální stopa

- cookies, osobní údaje, logy

### digitální podpis

- podobné jak digitální certifikát
- není veřejný klíč
    - plná moc