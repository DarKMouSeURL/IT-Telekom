# RIPv1 (Routing Information Protocol)

> další generace je RIPv2 (RIPng)
> 

### Historie

- 1988 - [RFC 1058](https://datatracker.ietf.org/doc/html/rfc1058)
- 1994 RIPv2 - [RFC 1723](https://datatracker.ietf.org/doc/html/rfc1723)
- 1997 RIPng IPv6- [RFC 2080](https://datatracker.ietf.org/doc/html/rfc2080)

---

- používá distance vektor
- používá HOP count jako jedinou metriku
- zapouzdřena do UDP datagramu

### Datagram RIPv1

| data link frame header | IP packet header | UDP datagram Header | RIP Message (504 bytes, 25 routes) |
| --- | --- | --- | --- |

```jsx
R2(config)#router rip
R2(config-router)#**network IP-sítě**
R2(config-router)#version 2
R2(config-router)#no auto-sumary
```

### debug

```jsx
R2(config-router)#debug rip
R2(config-router)#undebug all
```

## Defaultní cesta

- směrovač rozešle všude defaultní cesty, kde jsou potřeba

```jsx
R1(config)#ip route 0.0.0.0 0.0.0.0 next-hop-ip
```

### Propagace defaultní cesty

- RIP odešle info o defaultní cestě ve směrovacích aktualizací

**Pro propagaci pro statické cesty**

```jsx
R2(config-route)#redistribute static
```

**Pro propagaci defaultní cesty**

```jsx
R2(config-router)#default-information originate
```

**RIP RT**

```jsx
R2#show ip route
...
**Gateway id last resort is 172.30.2.2 to network 0.0.0.0**
...
**R* 0.0.0.0 [120/1] via 172.30.2.2, 00:00:16, Serial0/0/0**
```