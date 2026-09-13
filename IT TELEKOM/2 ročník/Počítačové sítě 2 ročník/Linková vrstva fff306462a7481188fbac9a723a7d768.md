# Linková vrstva

# čísla portů

- [TCP](TCP%20fff306462a7481aab137dca903873521.md), [UDP](UDP%20fff306462a7481198b42ecb8420236c0.md) protokol

![Untitled](Linkov%C3%A1%20vrstva%20fff3-d768/Untitled.png)

# Socket

- 192.168.1.5**:1099**, 192.168.1.7:**80**
- zdrojový          cílový

![Untitled](Linkov%C3%A1%20vrstva%20fff3-d768/Untitled%201.png)

# skupiny portů

## Well-known ports

- porty od 0 do 1023
- pro často používání aplikace
- serverové rozhraní

## Registred ports

- porty od 1023 do 49151
- uděleno od IANA

## privátní a dynamické porty

- porty od 49 151  do 65 535

### čísla well-known portů

| **Port Number** | **Protocol** | **Application** |
| --- | --- | --- |
| **20** | TCP | **File Transfer Protocol (FTP) - Data** |
| **21** | TCP | **File Transfer Protocol (FTP) - Control** |
| **22** | TCP | Secure Shell (SSH) |
| **23** | TCP | **Telnet** |
| **25** | TCP | Simple Mail Transfer Protocol (SMTP) |
| **53** | UDP, TCP | **Domain Name System (DNS)** |
| **67** | UDP | Dynamic Host Configuration Protocol (DHCP) - Server |
| **68** | UDP | Dynamic Host Configuration Protocol - Client |
| **69** | UDP | Trivial File Transfer Protocol (TFTP) |
| **80** | TCP | **Hypertext Transfer Protocol (HTTP)** |
| **110** | TCP | Post Office Protocol version 3 (POP3) |
| **143** | TCP | Internet Message Access Protocol (IMAP) |
| **161** | UDP | Simple Network Management Protocol (SNMP) |
| **443** | TCP | **Hypertext Transfer Protocol Secure (HTTPS)** |

## NETSAT příkaz

- vypíše otevřené porty

![Untitled](Linkov%C3%A1%20vrstva%20fff3-d768/Untitled%202.png)