# Instalace Nessus® Essentials

**Připojení pomocí SSH na linux server**

**`ssh student@10.60.63.X`Stažení instalačního balíčku nástroje Nessus**

curl --request GET \  `-`-url '[https://www.tenable.com/downloads/api/v2/pages/nessus/files/Nessus-10.11.1-ubuntu1604_amd64.deb](https://www.tenable.com/downloads/api/v2/pages/nessus/files/Nessus-10.11.1-ubuntu1604_amd64.deb)' \
  --output 'Nessus-10.11.1-ubuntu1604_amd64.deb''

**Instalace nátroje Nessus**

sudo dpkg --install Nessus-10.11.1-debian10_amd64.deb

**Spuštění služby**

`sudo systemctl start nessusd`

**Přes web [Tenable Nessus Essentials Vulnerability Scanner | Tenable®](https://www.tenable.com/products/nessus/nessus-essentials) provést registraci. Na e-mail přijde aktivační kód**

**Otevřít webovou stránku [https://10.60.63.X:8834](https://10.60.63.x:8834/) a kliknout na Continue**

**Smazání uživatele:** /opt/nessus/sbin/nessuscli lsuser  ([https://docs.tenable.com/nessus/command-line-reference/Content/ListUsers.htm](https://docs.tenable.com/nessus/command-line-reference/Content/ListUsers.htm))

**Vybereme Nessus Essential**

Naposledy změněno: pondělí, 19. ledna 2026, 14.25