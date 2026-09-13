print("zacatek")
a=int(input())
b=int(input())
c=int(input())

if a>b:
    pom=a
    a=b
    b=pom

if b>c:
    pom=b
    b=c
    c=pom

print(c)
print("konec")

print("zacatek")
a=int(input())
b=int(input())
c=int(input())
maxx=a

if b>maxx:
    maxx=b

if c>maxx:
    maxx=c

print(maxx)
print("konec")

print("zacatek")
a=int(input())
b=int(input())
c=int(input())

if a>b:
    if a>c:
        if b>c:
            print(c, b, a)
        else:
            print(b, c, a)
    else:
        print(b, a, c)
else:
    if b>c:
        if a>c:
            print(c,a,b)
        else:
            print(a,c,b)
    else:
        print(a,b,c)

print("konec")