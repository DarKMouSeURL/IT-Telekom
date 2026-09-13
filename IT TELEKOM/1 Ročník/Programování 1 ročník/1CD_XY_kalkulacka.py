print("XY. hodina, jednoducha kalkulacka")
print("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^")

def kalkulacka(x, y, znamenko):
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
    print(">>>konec funkce kalkulacka<<<")
    print()

kalkulacka(10, 5, "+")
kalkulacka(10, 5, "-")
kalkulacka(10, 5, "*")
kalkulacka(10, 5, "/")
print("---")
'''
cislo1=123
cislo2=100
kalkulacka(cislo1, cislo2, "/")
kalkulacka(cislo1, cislo2, "-")
kalkulacka(cislo1, cislo2, "+")
kalkulacka(cislo1, cislo2, "*")
print("------")

print("********************")
a = int(input("zadej cislo a="))
b = int(input("zadej cislo b="))
#zn = input("zadej kod operace: ")
print("********************")
kalkulacka(a, b, "+")
kalkulacka(a, b, "-")
kalkulacka(a, b, "*")
kalkulacka(a, b, "/")
print("---------")
'''
print("Konec programu")
input()
