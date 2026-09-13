def pondeli(cislo1,cislo2):
    soucet = cislo1 + cislo2
    print(f"{cislo1} - {cislo2} = {soucet}")

def utery(cislo1,cislo2,cislo3):
    y = cislo1 + cislo2 + cislo3
    return y

pondeli(4,6)
pondeli(8,1)
pondeli(6,3)

x=utery(2,4,8)
y=utery(6,3,1)
z=utery(8,3,7)

print(f"soucet je {x}")
print(f"soucet je {y}")
print(f"soucet je {z}")

print("..........................................")


def nakup(m, j, x):
    tresne= j+x
    celkem=m + j + tresne
    return celkem

print(f"maminka nakoupila {nakup(1,3,22)} kg.")
print(f"maminka nakoupila {nakup(8,5,2)} kg.")
"""
def soucetcisel(x):
    for i in range(x):
        print(i)
soucetcisel(5)
print("")
soucetcisel(9)
"""
def soucetcisel(x):
    soucet = 0
    for i in range(x+1):
        soucet = soucet + i
        print(f"Mezisoucet je {soucet}")
    print(f"soucet je {soucet}")

soucetcisel(5)
print("..............")

soucetcisel(10)

def soucetcisel2(x):
    soucet = 0
    for x in range(x+1):
        soucet = soucet +1
    return soucet


x=soucetcisel2(48)
print(f"soucet cisel je {x}")

for i in range(10):
    print(f"hlavni program i={i}")
    print(f"soucet cisel je {soucetcisel2(i)}")
    print("............")

































