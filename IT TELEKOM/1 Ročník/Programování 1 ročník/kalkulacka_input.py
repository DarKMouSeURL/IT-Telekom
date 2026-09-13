
"""
uzivatel zada vstupy
program zpracuje data
vysledky se zobrazi uzivately
"""

x = int(input("zadej 1. cislo: "))
y = int(input("zadej 2. cislo: "))

znamenko = input("zadej co chces delat: ")

if znamenko == "+":
    soucet = x + y
    print(f"{x}+{y}={soucet}")

if znamenko == "-":
    soucet = x - y
    print(f"{x}-{y}={soucet}")

soucet = x + y
print(f"{x} + {y} = {soucet}")

rozdil = x - y
print(f"{x} - {y} = {rozdil}")











input()
