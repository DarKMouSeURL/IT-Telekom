# Endpoint Detection and Response (EDR)

## Endpoint Detection and Response (EDR)

Požadavky na absolvování

## **Úvod**

Endpoint Detection and Response (EDR) je kybernetická bezpečnostní technologie, která se zaměřuje na ochranu koncových zařízení (endpointů) před útoky. Endpointy jsou počítače, mobilní zařízení, serverové stanice a další zařízení, která jsou připojena k počítačové síti.

EDR umožňuje sledovat a reagovat na hrozby na koncových zařízeních v reálném čase. EDR aplikace se obvykle instalují na každé koncové zařízení v rámci organizace a umožňují sledovat a analyzovat chování endpointů. Pomocí EDR je možné detekovat potenciální hrozby, které by jinak mohly zůstat nezpozorovány, a zabránit tak škodlivému útoku.

EDR používá pokročilé technologie pro detekci hrozeb, jako jsou umělá inteligence (AI) a strojové učení (ML). Tyto technologie umožňují rozpoznat neobvyklé chování na endpointech a varovat před možnými útoky, jako jsou například phishingové útoky, ransomware nebo jiné škodlivé kódy.

EDR nejenže detekuje hrozby, ale také umožňuje organizacím reagovat na ně. Když EDR detekuje podezřelou aktivitu na endpointu, může okamžitě spustit proces reakce, jako je například izolace endpointu, odstranění škodlivého kódu nebo vytvoření bezpečnostního upozornění. Díky tomu mohou organizace rychle a účinně reagovat na hrozby a minimalizovat škody způsobené útokem.

EDR je důležitou součástí kybernetické bezpečnosti a organizace, které se snaží chránit své endpointy před útoky, by měly zvážit implementaci EDR řešení.

## **Detekční mechanismy**

Endpoint Detection and Response (EDR) provádí detekci hrozeb pomocí různých technik a metod. Základem detekce je sledování chování koncových zařízení a vyhledávání anomálií, které mohou naznačovat potenciální útok.

Níže jsou uvedeny některé způsoby, jak EDR provádí detekci:

1. Analýza souborů - EDR provádí analýzu souborů, které jsou staženy nebo spuštěny na endpointu. Pokud se soubor jeví podezřele, EDR provede hloubkovou analýzu obsahu souboru, aby zjistila, zda obsahuje škodlivý kód.
2. Sledování chování - EDR sleduje chování koncových zařízení a vyhledává anomálie, které by mohly naznačovat potenciální útok. Například pokud se na endpointu spustí neobvyklý proces, EDR může tento proces zablokovat a varovat správce.
3. Detekce sítě - EDR monitoruje síťový provoz a vyhledává anomálie v komunikaci mezi endpointy. Například pokud se endpoint snaží komunikovat s podezřelou IP adresou, EDR může blokovat tuto komunikaci a upozornit správce.
4. Heuristická analýza - EDR používá heuristickou analýzu ke zjištění podezřelých vzorců v chování endpointů. Například pokud se endpoint najednou pokusí přistupovat k velkému množství souborů nebo se snaží změnit konfiguraci systému, EDR může tuto aktivitu označit jako podezřelou a varovat správce.
5. Porovnání s databází hrozeb - EDR porovnává detekované hrozby s databází známých hrozeb a varuje správce, pokud detekuje hrozbu, která se již v minulosti projevila.

Celkově lze říci, že EDR kombinuje několik různých technik a metod pro detekci hrozeb na koncových zařízeních. Díky tomu může rychle a účinně reagovat na nové a neznámé hrozby a minimalizovat rizika spojená s kybernetickými útoky.

## **Detekce hrozeb**

Techniky detekce hrozeb používané řešeními EDR zahrnují:

- analýza signatur: signatury síťového provozu jsou kontrolovány s databází známých signatur malwaru, aby se našla shoda
- analýza chování: přijatý práh chování koncového bodu se porovnává s cílem identifikovat případy neobvyklého chování, i když jsou všechny signatury provozu platné
- analýza v sandboxu: Potenciálně škodlivé soubory jsou umístěny do bezpečného prostředí zvaného sandbox a poté spuštěny, aby bylo možné sledovat jejich chování, aniž by hrozilo poškození koncového bodu
- porovnání s whitelistem/blacklistem: aktivity koncového bodu jsou kontrolovány s předem určeným seznamem povolených a závadných IP adres, aby byl povolen nebo zakázán síťový provoz

## **Architektura EDR**

Architektura Endpoint Detection and Response (EDR) se obecně skládá z několika hlavních komponent:

1. Agent - EDR agent je malý software nainstalovaný na koncovém zařízení, který zajišťuje monitorování a detekci hrozeb. Agent běží v pozadí a sleduje aktivitu endpointu v reálném čase.
2. Konzole - Konzole je centrální řídící prvek EDR, který poskytuje správci přehled o stavu endpointů a hrozbách. Konzole umožňuje správci přijímat varování a reagovat na incidenty.
3. Databáze hrozeb - Databáze hrozeb obsahuje informace o známých hrozbách, jako jsou viry, [malware](https://moodle.teleinformatika.eu/mod/quiz/view.php?id=1809) a jiné škodlivé kódy. EDR porovnává detekované hrozby s touto databází, aby mohl rychle reagovat na známé hrozby.
4. Analýza chování - EDR provádí analýzu chování koncových zařízení a vyhledává anomálie, které mohou naznačovat potenciální hrozby. Analýza chování umožňuje EDR detekovat nové a neznámé hrozby.
5. Síťové prvky - EDR může používat síťové prvky, jako jsou firewally a IPS (Intrusion Prevention Systems), ke zvýšení bezpečnosti koncových zařízení a detekci hrozeb.

Celkově lze říci, že architektura EDR zahrnuje několik komponentů, které spolupracují na detekci a ochraně endpointů. Agent monitoruje aktivitu endpointu a posílá informace do konzole, která umožňuje správci přijímat varování a reagovat na incidenty. Analýza chování a databáze hrozeb umožňují EDR detekovat známé i neznámé hrozby. Síťové prvky, jako jsou firewally a IPS, pak mohou přispět ke zvýšení bezpečnosti koncových zařízení.

## **Komponenty EDR**

Endpoint Detection and Response (EDR) je kybernetické bezpečnostní řešení, které se zaměřuje na detekci, analýzu a prevenci hrozeb na koncových zařízeních v síti. Komponenty EDR zahrnují následující prvky:

1. Endpoint agent: Tento softwareový agent je nainstalován na koncovém zařízení, jako jsou počítače, notebooky, mobily, tablety a další. Endpoint agent se zaměřuje na sběr informací o koncovém zařízení, jako jsou operační systém, aplikace, soubory a další.
2. Senzory: Senzory jsou součástí endpoint agenta a sledují a zaznamenávají veškerou aktivitu na koncovém zařízení. To může zahrnovat informace o přístupu k souborům, instalaci aplikací, komunikaci se sítí a další.
3. Detekce a analýza: Endpoint agent a senzory umožňují detekovat a analyzovat podezřelou aktivitu na koncovém zařízení. To zahrnuje detekci virů, [malware](https://moodle.teleinformatika.eu/mod/quiz/view.php?id=1809), phishingových útoků a dalších hrozeb.
4. Reakce a prevence: Pokud se zjistí podezřelá aktivita na koncovém zařízení, endpoint agent může reagovat a přijmout opatření na prevenci šíření hrozby v síti. Například může zablokovat přístup k souborům, uzavřít komunikační kanály nebo vypnout kompromitovanou aplikaci.

Celkově jsou tyto komponenty navrženy tak, aby poskytovaly úplný obranný kruh na koncových zařízeních a chránily je před různými hrozbami a útoky.

## **Rozdíly mezi XDR a EDR**

XDR (Extended Detection and Response) a EDR (Endpoint Detection and Response) jsou oba typy kybernetických bezpečnostních řešení, avšak s několika zásadními rozdíly.

1. Rozsah: EDR se zaměřuje na koncová zařízení v síti a detekuje hrozby v této oblasti, zatímco XDR pokrývá celou síť včetně cloudu a dalších infrastruktur. To znamená, že XDR poskytuje mnohem širší a komplexnější pohled na bezpečnost celé sítě.
2. Data a analýza: EDR se zaměřuje na analýzu dat, která jsou sbírána na koncových zařízeních, zatímco XDR zahrnuje sběr a analýzu dat z mnoha zdrojů, včetně koncových zařízení, sítě, cloudových služeb a dalších. To umožňuje detekovat a řešit hrozby, které by mohly být přehlédnuty, kdyby byla použita pouze EDR.
3. Integrace: XDR je navržen tak, aby integroval a analyzoval data z mnoha různých zdrojů a poskytoval komplexní pohled na bezpečnost celé sítě. To zahrnuje integraci s dalšími bezpečnostními řešeními, jako jsou SIEM, IAM, CASB a další. EDR je zaměřeno především na detekci a reakci na hrozby na koncových zařízeních a může být integrováno s dalšími bezpečnostními nástroji.

Celkově lze říci, že XDR je komplexnější a širší řešení pro kybernetickou bezpečnost celé sítě, zatímco EDR je zaměřeno na koncová zařízení a nabízí hloubkový pohled na bezpečnost na této úrovni.