print("yolooooooo")

#funkce bez parametru
def secist():
    soucet = 50+4
    print("50+4" + " = " + str (soucet))
    print(f"50+4 = {soucet}")

def odecist():
    x = 123
    y = 3
    rozdil = x-y
    print(str (x) + "-" + str (y) + " = " + str (rozdil))
    print(f"{x} - {y} = {rozdil}")

def nasobit():
    a = 15
    b= 4
    soucin = a*b
    print(str (a) + "*" + str (b) +" = " +  str (soucin))
    print(f"{a} * {b} = {soucin}")

def secist(cislo1):
    soucet = cislo1 + 12
    print(f"{cislo1} + {12} = {soucet}")

def odecist(cislo1):
    odecet = cislo1 - 100
    print(f"{cislo1} - {100} = {odecet}")

def vynasobit(cislo1):
    soucin  = cislo1 * 4
    print(f"{cislo1} * {4} = {soucin}")


#secist()    #volani, hej ousko!!!!!!!!!!!!!!!!!!!!!!!!!
#odecist()
nasobit()
secist(-7)
odecist(1000)
vynasobit(4)

input()
print("konec hlavniho programu")
print("jsem uplne ztraceny")