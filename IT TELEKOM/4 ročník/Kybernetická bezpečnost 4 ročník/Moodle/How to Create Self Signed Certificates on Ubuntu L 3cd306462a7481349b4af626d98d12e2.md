# How to Create Self Signed Certificates on Ubuntu Linux

## How to Create Self Signed Certificates on Ubuntu Linux

Požadavky na absolvování

**Otevřené:** středa, 5. června 2024, 00.00

**Termín:** středa, 12. června 2024, 00.00

Cílem cvičení je naučit se základní postupy a metody tvorby CA a generování a podepisování veřejných klíčů pomocí rozšířené knihovny OpenSLL.

Certifikační autorita (zkratka CA) je v asymetrické kryptografii subjekt, který vydává digitální certifikáty (elektronicky podepsané veřejné šifrovací klíče), čímž usnadňuje využívání PKI (Public Key Infrastructure) tak, že svojí autoritou potvrzuje pravdivost údajů, které jsou ve volně dostupném veřejném klíči uvedeny. Na základě principu přenosu důvěry tak můžeme důvěřovat údajům uvedeným v digitálním certifikátu za předpokladu, že důvěřujeme samotné certifikační autoritě.

OpenSSL tvoří knihovna pro šifrování a ověřování totožnosti a k ní příslušející programy. S jejím využitím se setkáte hlavně u „https“ – „HTTP over SSL“ serverů, ale používá se i v jiných situacích, kdy je potřeba při přenosu šifrovat data protokolu, který sám šifrování neimplementuje. Používá se často také pro šifrování pošty – „POP3 over SSL“, „IMAP over SSL“ a „SMTP over SSL“.

### **The OpenSSL**

The OpenSSL toolkit is required to generate an SSL/TLS certificate on Ubuntu. This tool is usually installed on Ubuntu Linux by default. If not, run the commands below to install it on Ubuntu.

[http://www.openssl.org/](http://www.openssl.org/)

```
sudo apt update
sudo apt install openssl
```

```
To create a new Self-Signed SSL Certificate, use the openssl req command. Below is the command to generate an SSL/TLS certificate for the example.com domain.
```

```
openssl req -newkey rsa:4096 -x509 -sha256 -days 365 -nodes -out example.crt -keyout example.key
```

The command details are as follows:

- **newkey rsa:2048** – creates a new certificate request and 2048 bit RSA key.
- **x509** – creates a X.509 certificate.
- **sha256** – use 265-bit SHA (Secure Hash Algorithm) to create the certificate
- **days 365** – the number of days to certify the certificate for. Typically a year or more
- **nodes** – creates a key without a passphrase.
- **out example.crt** – specifies the filename to write the newly created certificate to
- **keyout example.key** – specifies the filename to write the private key to.

Once you press ENTER, the command will generate a private key and prompt you with questions to generate the certificate.

```
Generating a RSA private key
...................................++++
............................++++
writing new private key to 'example.key'
-----
```

```
You’ll provide these answers similar to the ones below. Replace details with your own that represent the certificate you’re generating.
```

```
Country Name (2 letter code) [AU]:US
State or Province Name (full name) [Some-State]:New York
Locality Name (eg, city) []:New York
Organization Name (eg, company) [Internet Widgits Pty Ltd]:EXAMPLE, Inc.
Organizational Unit Name (eg, section) []:Publishing
Common Name (e.g. server FQDN or YOUR name) []:example.com
Email Address []:admin@example.com
```

After that, two files (**example.crt** and **example.key**) will be created in the directory you ran the command. Use these files in your Nginx or Apache setup to enable HTTPS connections.

That should do it.

1. **Student si pomoci příkazu apt-get install openssl nainstaluje příslušnou knihovnu.**
2. **Pomocí dostupné dokumentace a pokynů cvičícího se student seznámí s nástrojem a jeho funkcemi.**
3. **Student má za úkol:**
- **Prostudovat konfigurační soubor openssl.cnf.**
- **Vytvoření CA a soukromého klíče CA.**
- **Importovat vytvořený CA certifikát kořenový (důvěryhodný) certifikát do Windows.**