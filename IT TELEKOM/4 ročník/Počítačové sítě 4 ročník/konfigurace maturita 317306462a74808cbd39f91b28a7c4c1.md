# konfigurace maturita

# DHCP

```jsx
R1(config)#ip dhcp excluded-address 3.0.0.1
R1(config)#ip dhcp pool DHCP
R1(dhcp-config)#network 3.0.0.0 255.0.0.0
R1(dhcp-config)#default-router 3.0.0.1
R1(dhcp-config)#dns-seever 8.8.8.8
```

```jsx
R1#show ip dhcp binding
IP address       Client-ID/              Lease expiration        Type
                 Hardware address
3.0.0.2          0001.4256.D43B           --                     Automatic
```

![image.png](konfigurace%20maturita/image.png)

# SSH

```jsx
R1(config)#ip domain-name example.com
R1(config)#username admin password cisco.123
R1(config)#crypto key generate rsa
The name for the keys will be: R1.example.com
Choose the size of the key modulus in the range of 360 to 4096 for your
  General Purpose Keys. Choosing a key modulus greater than 512 may take
  a few minutes.

How many bits in the modulus [512]:**2048**
% Generating 2048 bit RSA keys, keys will be non-exportable...[OK]
R1(config)#line vty 0 4
R1(config-line)#login local
R1(config-line)#transport input ssh
R1(config-line)#exit
R1(config)#enable secret heslo
R1(config)#line con 0
R1(config-line)#password heslo
R1(config-line)#login
```

```jsx
C:\>ssh admin@3.0.0.1
```