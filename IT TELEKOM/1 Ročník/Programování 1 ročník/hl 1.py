"""
def donula(cislo):
    return cislo + donula(cislo-1)

print(donula(9))
"""
def donula(cislo):
    if cislo != 0:
        return cislo + donula(cislo-1)
    else:
        return 0

soucet=donula(9)
print(soucet)