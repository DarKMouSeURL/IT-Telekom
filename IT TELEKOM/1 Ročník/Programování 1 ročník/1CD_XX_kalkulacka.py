print("13. hodina, jednoducha kalkulacka")

'''
-uzivatel zada vstupy z klavesnice
-program zpracuje data...
-vysledky zpracovani se zobrazi uzivateli
'''

x = int(input("zadej cislo x="))
y = int(input("zadej cislo y="))
znamenko = input("zadej kod operace: ")

if znamenko == "+":
    soucet = x + y
    print(f"{x} + {y} = {soucet}")

if znamenko == "-":
    rozdil = x - y
    print(f"{x} - {y} = {rozdil}")

if znamenko == "*":
    soucin = x * y
    print(f"{x} * {y} = {soucin}")

if znamenko == "/":
    soucin = x / y
    print(f"{x} / {y} = {soucin}   promenna y nesmi byt nula")

print("Konec programu")
input()





