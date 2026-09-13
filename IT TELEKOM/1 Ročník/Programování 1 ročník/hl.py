#algoritmus pro zamenu promenych, soubor nejakynazevsouboru.drawio
a= "jedna"
b= "posledni"

pomocna=a
a=b
b=pomocna
#a,b=b,a

print(f"a={a}, b={b}")

c=10
d=11
if c>d:
    print(f"P1 za ifem je true...")
else:
    print(f"P1 za ifem je false...")


if c>d:
    print(f"P1 za ifem je true...")

x=0
while x<10:
    print(f"telo cyklu while, x={x}")
    x=x+1

s=[10,20,30]
for i in range(3):
    print(s[i])