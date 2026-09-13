print("------------------")
print("------------------")

def nakup( m, j, x ):
    tresni = j + x
    celkem = m + j + tresni
    return celkem

print(f"Maminka nakoupila { nakup(1, 3, 2) } kg.")
print(f"Maminka nakoupila { nakup(5, 3, 4) } kg.")

'''
def soucetCisel(x):
    for i in range(x):
        print(i)

soucetCisel(5)
print("---")
soucetCisel(3)
print("---")
soucetCisel(10)
print("---")
'''

def soucetCisel(x):
    soucet = 0
    for i in range(x+1):
        soucet = soucet + i
        print(f"Mezisoucet je {soucet}")
    print(f"Soucet je {soucet}")

soucetCisel(5)
print("---")
soucetCisel(8)
print("------")


def soucetCisel2(x):
    soucet = 0
    for i in range(x+1):
        soucet = soucet + i
    return soucet

pp = soucetCisel2(18)
print(f"Soucet cisel je {pp}")

print(f"Soucet cisel je { soucetCisel2(3) }")
print("--------------------------")

for i in range(10):
    print(f"Hlavni program i={i}")
    print(f"Soucet cisel je { soucetCisel2(i) }")
    print("--")
















