# Praktické procvičení práce s OpenSSL + Apache2

## Praktické procvičení práce s OpenSSL + Apache2

Požadavky na absolvování

**Otevřené:** středa, 5. června 2024, 00.00

**Termín:** středa, 12. června 2024, 00.00

**Cílem cvičení je naučit se základní postupy a metody tvorby CA a generování a podepisování veřejných klíčů pomocí rozšířené knihovny OpenSLL.**

**Certifikační autorita (zkratka CA) je v asymetrické kryptografii subjekt, který vydává digitální certifikáty (elektronicky podepsané veřejné šifrovací klíče), čímž usnadňuje využívání PKI (Public Key Infrastructure) tak, že svojí autoritou potvrzuje pravdivost údajů, které jsou ve volně dostupném veřejném klíči uvedeny. Na základě principu přenosu důvěry tak můžeme důvěřovat údajům uvedeným v digitálním certifikátu za předpokladu, že důvěřujeme samotné certifikační autoritě.**

**OpenSSL tvoří knihovna pro šifrování a ověřování totožnosti a k ní příslušející programy. S jejím využitím se setkáte hlavně u „https“ – „HTTP over SSL“ serverů, ale používá se i v jiných situacích, kdy je potřeba při přenosu šifrovat data protokolu, který sám šifrování neimplementuje. Používá se často také pro šifrování pošty – „POP3 over SSL“, „IMAP over SSL“ a „SMTP over SSL“.**

**OpenSSL**

[**http://www.openssl.org/**](http://www.openssl.org/)

1. **Student si pomoci příkazu apt-get install openssl nainstaluje příslušnou knihovnu.**
2. **Pomocí dostupné dokumentace a pokynů cvičícího se student seznámí s nástrojem a jeho funkcemi.**
3. **Student má za úkol:**
- **Prostudovat konfigurační soubor openssl.cnf.**
- **Vytvoření CA a soukromého klíče CA.**
- **Importovat vytvořený CA certifikát kořenový (důvěryhodný) certifikát do Windows.**
- **Vytvořit klientský požadavek na podepsaný certifikát a tento požadavek podepsat jako důvěryhodná CA.**
- **-----------------------------------------------------------------------------------------------------------------------------
To generate an SSL/TLS certificate, you can use OpenSSL, a widely-used open-source toolkit for working with SSL/TLS protocols. Below are the basic steps to generate a self-signed certificate using OpenSSL:**

Jako **your_domain_or_ip**  využít IP adresu stroje (ip a) nebo localhost

sudo apt update

sudo apt install apache2

- ------------------------------

sudo ufw allow "Apache Full"

sudo a2enmod ssl

- -----------------------------

sudo systemctl restart apache2

- ----------------------------

sudo openssl req -x509 -nodes -days 365 -newkey rsa:2048 -keyout /etc/ssl/private/apache-selfsigned.key -out /etc/ssl/certs/apache-selfsigned.crt

```
Country Name (2 letter code) [XX]:US
State or Province Name (full name) []:Example
Locality Name (eg, city) [Default City]:Example
Organization Name (eg, company) [Default Company Ltd]:Example Inc
Organizational Unit Name (eg, section) []:Example Dept
Common Name (eg, your name or your server's hostname) []:your_domain_or_ip
Email Address []:webmaster@example.com
```

sudo nano /etc/apache2/sites-available/**your_domain_or_ip**.conf

```
<VirtualHost *:443>
   ServerName your_domain_or_ip
   DocumentRoot /var/www/your_domain_or_ip

   SSLEngine on
   SSLCertificateFile /etc/ssl/certs/apache-selfsigned.crt
   SSLCertificateKeyFile /etc/ssl/private/apache-selfsigned.key
</VirtualHost>
```

sudo mkdir /var/www/**your_domain_or_ip**

sudo nano /var/www/**your_domain_or_ip**/index.html

```
<h1>it worked!</h1>
```

sudo a2ensite your_domain_or_ip.conf

sudo apache2ctl configtest

```

```

Output

```
AH00558: apache2: Could not reliably determine the server's fully qualified domain name, using 127.0.1.1. Set the 'ServerName' directive globally to suppress this message
Syntax OK
```

sudo systemctl reload apache2

sudo nano /etc/apache2/sites-available/**your_domain_or_ip**.conf

```
<VirtualHost *:80>
    ServerName your_domain_or_ip
    Redirect / https://your_domain_or_ip/
</VirtualHost>
```

sudo apachectl configtest

sudo systemctl reload apache2

[Certbot](https://certbot.eff.org/)

[Návod OpenSSL + Apache2](https://www.digitalocean.com/community/tutorials/how-to-create-a-self-signed-ssl-certificate-for-apache-in-ubuntu-22-04)

![](https://app.notion.com./Lau_KB_3r_%20Praktické%20procvičení%20práce%20s%20OpenSSL%20+%20Apache2%20_%20Moodle_files/blobid0.png)

![](https://app.notion.com./Lau_KB_3r_%20Praktické%20procvičení%20práce%20s%20OpenSSL%20+%20Apache2%20_%20Moodle_files/blobid1.png)

![](https://app.notion.com./Lau_KB_3r_%20Praktické%20procvičení%20práce%20s%20OpenSSL%20+%20Apache2%20_%20Moodle_files/blobid2.png)