# Sekce_ Služby _ Operační systémy

- DNS (Domain Name System) pracuje s pojmem **DNS zóna**, což je logická část doménového jmenného prostoru, za kterou je zodpovědný konkrétní DNS server. Správná konfigurace zóny je klíčová pro funkčnost celé domény.1. Co je DNS zónaDNS zóna je soubor DNS záznamů, které popisují určitou část doménové hierarchie. Každá zóna má alespoň jeden **autoritatívní DNS server**.Zóna nezačíná ani nekončí automaticky – její rozsah je určen **delegací**.**Příklad:**`example.com
├── www.example.com
├── mail.example.com
└── shop.example.com`2. Typy DNS zónForward zóna se používá nejčastěji a obsahuje záznamy typu A, AAAA, CNAME, MX atd.3. SOA záznam (Start of Authority)Každá DNS zóna **musí obsahovat právě jeden SOA záznam**. SOA určuje základní parametry zóny a synchronizaci mezi DNS servery.`example.com. IN SOA ns1.example.com. admin.example.com. ( 2025010101 ; Serial 3600 ; Refresh 900 ; Retry 1209600 ; Expire 86400 ) ; Minimum TTL`4. NS záznam (Name Server)NS záznam určuje, které DNS servery jsou autoritativní pro danou zónu.`example.com. IN NS ns1.example.com.
example.com. IN NS ns2.example.com.`Každý NS server musí mít odpovídající **A nebo AAAA záznam** (tzv. *glue record*).5. A záznam (IPv4)A záznam mapuje doménové jméno na IPv4 adresu.`www.example.com. IN A 192.0.2.10`6. AAAA záznam (IPv6)AAAA záznam je IPv6 ekvivalent A záznamu.`www.example.com. IN AAAA 2001:db8::10`Moderní služby by měly mít A i AAAA záznam.7. CNAME záznamCNAME vytváří alias na jiné doménové jméno.`shop.example.com. IN CNAME www.example.com.`**Pravidla CNAME:**8. TTL (Time To Live)TTL určuje, jak dlouho si DNS resolver pamatuje záznam v cache.`www 3600 IN A 192.0.2.10`Forward a Reverse DNS zóny – konfigurace a souvislostiDNS pracuje se zónami, které určují, jakým způsobem se provádí překlad mezi doménovými jmény a IP adresami. Základními typy jsou **forward zóna** a **reverse zóna**.1. Forward DNS zóna**Forward zóna** slouží k překladu:`doménové jméno → IP adresa`Jedná se o nejčastěji používaný typ DNS zóny. Forward zóna obsahuje záznamy jako:**Příklad forward zóny:**`example.com
├── www.example.com → 192.0.2.10
├── mail.example.com → 192.0.2.20
└── shop.example.com → www.example.com`2. Obsah forward zónyKaždá forward zóna MUSÍ obsahovat minimálně:Typická struktura forward zóny:`$TTL 3600
@ IN SOA ns1.example.com. admin.example.com. ( 2025010101 3600 900 1209600 86400 )
@ IN NS ns1.example.com.
@ IN NS ns2.example.com.
ns1 IN A 192.0.2.1
ns2 IN A 192.0.2.2
www IN A 192.0.2.10
mail IN A 192.0.2.20`4. Reverse DNS zóna**Reverse zóna** slouží k opačnému překladu:`IP adresa → doménové jméno`Používá se zejména:5. Reverse zóna – IPv4IPv4 reverse DNS používá doménu **in-addr.arpa**.IP adresa `192.0.2.10` se zapisuje obráceně:`10.2.0.192.in-addr.arpa`**Příklad reverse zóny:**`$TTL 3600
@ IN SOA ns1.example.com. admin.example.com. ( 2025010101 3600 900 1209600 86400 )
@ IN NS ns1.example.com.
10 IN PTR www.example.com.
20 IN PTR mail.example.com.`6. PTR záznamPTR záznam mapuje IP adresu na doménové jméno.`10 IN PTR www.example.com.`Každá veřejná IP adresa by měla mít PTR záznam.PTR záznam musí ukazovat na jméno, které má odpovídající A/AAAA záznam (*forward ↔︎ reverse konzistence*).7. Reverse zóna – IPv6IPv6 reverse DNS používá doménu **ip6.arpa**.Adresa se zapisuje:IPv6 reverse zóny jsou výrazně složitější a často se delegují po /64.8. Vazba mezi forward a reverse zónouSprávná konfigurace DNS vyžaduje:**Příklad správné vazby:**`www.example.com. IN A 192.0.2.10
10.2.0.192.in-addr.arpa. 10 IN PTR www.example.com.`Co je *Active Directory Domain Services* (AD DS)?**AD DS** je služba od Microsoftu, která funguje jako **centrální databáze** všech důležitých informací o uživatelích, počítačích a dalších věcech v síti. Představ si to jako **adresář/telefonní seznam pro celou počítačovou síť** – ale mnohem chytřejší.🧠 Co AD DS dělá?✅ 1. **Ukládá informace o uživatelích a počítačích**Do AD DS se ukládají:✅ 2. **Autentizuje a autorizuje – kontroluje přihlášení**Když se **student nebo zaměstnanec přihlásí do počítače**, AD DS ověří jeho jméno a heslo a rozhodne, **co může dělat** (např. spouštět programy, přistupovat k souborům nebo tiskárnám).✅ 3. **Centrální správa pravidel – Group Policy**Správci si pomocí AD DS mohou nastavit pravidla, která se automaticky uplatní na všechny počítače:✅ 4. **Všechno je organizované do stromů a domén**Síť může mít:🖥️ Co je *Domain Controller* (DC)?**Domain Controller** je server (počítač), který **hostuje AD DS**.
Tenhle server **ověřuje všechny přihlášení a spravuje databázi AD DS**. Pokud jeden DC selže, ostatní můžou převzít jeho práci, protože si navzájem **kopírují data (replicace)**.🌍 Příklad, jak to funguje (analogicky)Představ si **školní seznam žáků**:
    - DNS zóny a základní DNS záznamy
        
        DNS (Domain Name System) pracuje s pojmem **DNS zóna**, což je logická část doménového jmenného prostoru, za kterou je zodpovědný konkrétní DNS server. Správná konfigurace zóny je klíčová pro funkčnost celé domény.
        
        ---
        
        ### 1. Co je DNS zóna
        
        DNS zóna je soubor DNS záznamů, které popisují určitou část doménové hierarchie. Každá zóna má alespoň jeden **autoritatívní DNS server**.
        
        Zóna nezačíná ani nekončí automaticky – její rozsah je určen **delegací**.
        
        **Příklad:**
        
        ```
        example.com
        ├── www.example.com
        ├── mail.example.com
        └── shop.example.com
        ```
        
        ---
        
        ### 2. Typy DNS zón
        
        - **Forward zóna** – převod jména na IP adresu
        - **Reverse zóna** – převod IP adresy na jméno
        
        Forward zóna se používá nejčastěji a obsahuje záznamy typu A, AAAA, CNAME, MX atd.
        
        ---
        
        ### 3. SOA záznam (Start of Authority)
        
        Každá DNS zóna **musí obsahovat právě jeden SOA záznam**. SOA určuje základní parametry zóny a synchronizaci mezi DNS servery.
        
        ```
        example.com. IN SOA ns1.example.com. admin.example.com. (
            2025010101 ; Serial
            3600       ; Refresh
            900        ; Retry
            1209600    ; Expire
            86400 )    ; Minimum TTL
        ```
        
        - **Serial** – verze zóny (musí se zvýšit při změně)
        - **Refresh** – jak často se slave ptá mastera
        - **Retry** – opakování při chybě
        - **Expire** – platnost zóny
        - **Minimum TTL** – cache negativních odpovědí
        
        ---
        
        ### 4. NS záznam (Name Server)
        
        NS záznam určuje, které DNS servery jsou autoritativní pro danou zónu.
        
        ```
        example.com. IN NS ns1.example.com.
        example.com. IN NS ns2.example.com.
        ```
        
        Každý NS server musí mít odpovídající **A nebo AAAA záznam** (tzv. *glue record*).
        
        ---
        
        ### 5. A záznam (IPv4)
        
        A záznam mapuje doménové jméno na IPv4 adresu.
        
        ```
        www.example.com. IN A 192.0.2.10
        ```
        
        - **www** – název hosta
        - **A** – typ záznamu
        - **192.0.2.10** – IPv4 adresa
        
        ---
        
        ### 6. AAAA záznam (IPv6)
        
        AAAA záznam je IPv6 ekvivalent A záznamu.
        
        ```
        www.example.com. IN AAAA 2001:db8::10
        ```
        
        Moderní služby by měly mít A i AAAA záznam.
        
        ---
        
        ### 7. CNAME záznam
        
        CNAME vytváří alias na jiné doménové jméno.
        
        ```
        shop.example.com. IN CNAME www.example.com.
        ```
        
        **Pravidla CNAME:**
        
        - nesmí existovat spolu s jinými záznamy
        - neukazuje na IP adresu
        - nelze použít na kořen zóny
        
        ---
        
        ### 8. TTL (Time To Live)
        
        TTL určuje, jak dlouho si DNS resolver pamatuje záznam v cache.
        
        ```
        www 3600 IN A 192.0.2.10
        ```
        
        - nízké TTL – rychlé změny
        - vysoké TTL – menší zátěž DNS
        
        ## Forward a Reverse DNS zóny – konfigurace a souvislosti
        
        DNS pracuje se zónami, které určují, jakým způsobem se provádí překlad mezi doménovými jmény a IP adresami. Základními typy jsou **forward zóna** a **reverse zóna**.
        
        ---
        
        ### 1. Forward DNS zóna
        
        **Forward zóna** slouží k překladu:
        
        ```
        doménové jméno → IP adresa
        ```
        
        Jedná se o nejčastěji používaný typ DNS zóny. Forward zóna obsahuje záznamy jako:
        
        - A
        - AAAA
        - CNAME
        - MX
        - TXT
        - SRV
        
        **Příklad forward zóny:**
        
        ```
        example.com
        ├── www.example.com     → 192.0.2.10
        ├── mail.example.com    → 192.0.2.20
        └── shop.example.com    → www.example.com
        ```
        
        ---
        
        ### 2. Obsah forward zóny
        
        Každá forward zóna MUSÍ obsahovat minimálně:
        
        - SOA záznam
        - NS záznamy
        
        Typická struktura forward zóny:
        
        ```
        $TTL 3600
        @   IN SOA ns1.example.com. admin.example.com. (
                2025010101
                3600
                900
                1209600
                86400 )
        
        @   IN NS ns1.example.com.
        @   IN NS ns2.example.com.
        
        ns1 IN A 192.0.2.1
        ns2 IN A 192.0.2.2
        
        www  IN A 192.0.2.10
        mail IN A 192.0.2.20
        ```
        
        ---
        
        ### 4. Reverse DNS zóna
        
        **Reverse zóna** slouží k opačnému překladu:
        
        ```
        IP adresa → doménové jméno
        ```
        
        Používá se zejména:
        
        - u mail serverů
        - pro logování
        - pro bezpečnostní kontroly
        
        ---
        
        ### 5. Reverse zóna – IPv4
        
        IPv4 reverse DNS používá doménu **in-addr.arpa**.
        
        IP adresa `192.0.2.10` se zapisuje obráceně:
        
        ```
        10.2.0.192.in-addr.arpa
        ```
        
        **Příklad reverse zóny:**
        
        ```
        $TTL 3600
        @   IN SOA ns1.example.com. admin.example.com. (
                2025010101
                3600
                900
                1209600
                86400 )
        
        @   IN NS ns1.example.com.
        
        10  IN PTR www.example.com.
        20  IN PTR mail.example.com.
        ```
        
        ---
        
        ### 6. PTR záznam
        
        PTR záznam mapuje IP adresu na doménové jméno.
        
        ```
        10 IN PTR www.example.com.
        ```
        
        Každá veřejná IP adresa by měla mít PTR záznam.
        
        PTR záznam musí ukazovat na jméno, které má odpovídající A/AAAA záznam (*forward ↔︎ reverse konzistence*).
        
        ---
        
        ### 7. Reverse zóna – IPv6
        
        IPv6 reverse DNS používá doménu **ip6.arpa**.
        
        Adresa se zapisuje:
        
        - po hexadecimálních znacích
        - v opačném pořadí
        
        IPv6 reverse zóny jsou výrazně složitější a často se delegují po /64.
        
        ---
        
        ### 8. Vazba mezi forward a reverse zónou
        
        Správná konfigurace DNS vyžaduje:
        
        - A/AAAA záznam ve forward zóně
        - PTR záznam v reverse zóně
        
        **Příklad správné vazby:**
        
        ```
        www.example.com. IN A 192.0.2.10
        10.2.0.192.in-addr.arpa. 10 IN PTR www.example.com.
        
        ```
        
    
    Vybrat aktivitu Co je Active Directory Domain Services (AD DS)? AD...
    
    ## Co je *Active Directory Domain Services* (AD DS)?
    
    **AD DS** je služba od Microsoftu, která funguje jako **centrální databáze** všech důležitých informací o uživatelích, počítačích a dalších věcech v síti. Představ si to jako **adresář/telefonní seznam pro celou počítačovou síť** – ale mnohem chytřejší.
    
    ## 🧠 Co AD DS dělá?
    
    ### ✅ 1. **Ukládá informace o uživatelích a počítačích**
    
    Do AD DS se ukládají:
    
    - uživatelská jména a hesla,
    - počítače,
    - skupiny uživatelů,
    - tiskárny a další síťové zdroje.
        
        Díky tomu může síť vědět, kdo je kdo a co smí dělat.
        
    
    ---
    
    ### ✅ 2. **Autentizuje a autorizuje – kontroluje přihlášení**
    
    Když se **student nebo zaměstnanec přihlásí do počítače**, AD DS ověří jeho jméno a heslo a rozhodne, **co může dělat** (např. spouštět programy, přistupovat k souborům nebo tiskárnám).
    
    ---
    
    ### ✅ 3. **Centrální správa pravidel – Group Policy**
    
    Správci si pomocí AD DS mohou nastavit pravidla, která se automaticky uplatní na všechny počítače:
    
    - jaké aplikace se mají nainstalovat,
    - jak se musí měnit hesla,
    - co je povoleno nebo zakázáno.
        
        To se provádí pomocí **Group Policy (GPO)**.
        
    
    ---
    
    ### ✅ 4. **Všechno je organizované do stromů a domén**
    
    Síť může mít:
    
    - **Domény** – skupiny uživatelů a počítačů,
    - **Organizační jednotky (OU)** – logické části jako “učitelé” nebo “studenti”,
    - **Lesy a stromy** – větší hierarchie více domén.
        
        To pomáhá velkým organizacím se v tom neztratit.
        
    
    ---
    
    ## 🖥️ Co je *Domain Controller* (DC)?
    
    **Domain Controller** je server (počítač), který **hostuje AD DS**.
    
    Tenhle server **ověřuje všechny přihlášení a spravuje databázi AD DS**. Pokud jeden DC selže, ostatní můžou převzít jeho práci, protože si navzájem **kopírují data (replicace)**.
    
    ---
    
    ## 🌍 Příklad, jak to funguje (analogicky)
    
    Představ si **školní seznam žáků**:
    
    - **Jména, třídy, učitele** jsou jako objekty v AD DS,
    - když se chce žák dostat do učebny, ukáže svůj studentský průkaz – AD DS „ověří“, kdo je, a rozhodne, kam může jít,
    - učitelé mohou nastavit pravidla, co studenti smí dělat (například co mohou otevřít za učební pomůcky).
    - Díky tomu může síť vědět, kdo je kdo a co smí dělat.
    - To se provádí pomocí **Group Policy (GPO)**.
    - To pomáhá velkým organizacím se v tom neztratit.