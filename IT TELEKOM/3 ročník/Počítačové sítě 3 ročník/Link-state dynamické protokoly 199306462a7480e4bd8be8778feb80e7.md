# Link-state dynamické protokoly

<aside>
☝

[Distance vektor - směr a velikost, Distance-Vector Dynamic protocols (něco jiného než link-state)](RIPv1%20(Routing%20Information%20Protocol)%20181306462a7480b18bbaf268720c6a1c.md)

</aside>

- lze si představit link-state jako kompletní mapu cest (road map)
- tuto mapu používá každý směrovač k určení nejkratší cesty do sítě
- směrovací posílají aktualizace → info o jejich cestách
    - info o přímo připojených sítích
    - typ sítě
    - sousední směrovače
    - důvod k názvu link-state (stav linky)
- každý směrovač mají údaje o všech směrovačích v doméně
- každý směrovač si vypočítá vlastní mapu topologie, nezávisle na ostatních

## Zástupci

1. OSPF (Open Shortest Path First)
2. IS-IS (Intermediate System-to-Intermediate System)

## Proces

1. směrovač **se učí** o vlastních linkách v přímo připojené síti
2. směrovač je zodpovědný na **navázání spojení** se sousedními přímo připojenými směrovači
    1. používá každých 15 sekund HELLO packetu, k navázaní spojení se sousedem (adjacency) a kontroly spojení se sousedem (keep alive)
    2. když je soused nedosažitelná, sousedství se rozpadne
3. **vytváří LSP** (Link-State Packet) obsahující stav každé přímo připojené linky
    1. **obsahuje**: ID souseda, typ linky a bandwidth
    2. zaplaví se na všechny oblasti (flooding)
4. **posílá** (flood) všem sousedům (a ti sousedi dalším sousedům), ukládají do databáze
5. používají SPF algoritmus 
    1. **divergence** - doba kdy všechny směrovače se naučí celou síť
6. používá data z databáze a **vytváří vlastní mapu** topologie (z LSP) a **výpočet nejkratší cesty** do každé sítě, zapsáno do IP-RT
    1. databáze bude stejná na každém směrovači
    2. podle databáze se bude počítat nejlepší cesta

## Výhody link state protokolů

- vytváří mapu topologie
- rychlejší konvergence
- odesílají aktualizace pouze při změně v topologii
- hierarchický desing