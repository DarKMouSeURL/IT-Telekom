print("5 a 6 hodina")
'''
print("proste zadej prvni cislo", end=" ")
x=int(input())
print("proste zadej druhe cislo", end=" ")
y=int(input())
#y=2027525737332443755537324343
rozdil=x-y
#print(f"x-y=rozdil")
print(f"{x} - {y} = {rozdil}")
'''

def odecist():
    x=500
    y=20
    rozdil=x-y
    print(f"{x} - {y} = {rozdil}")


def odecist1(cislo1):
    y=5
    rozdil=cislo1-y
    print(f"{cislo1} - {y} = {rozdil}")

def odecist2(cislo1,cislo2):
    r=cislo1-cislo2
    print(f"{cislo1}-{cislo2}={r}")

def odecist3(cislo1,cislo2,cislo3):
    rr=cislo1-cislo2-cislo3
    print(f"{cislo1} - {cislo2} - {cislo3} = {rr}")
#print("----------------------------------------------")

def secist():
    x=500
    y=20
    rozdil=x+y
    print(f"{x} + {y} = {rozdil}")


def secist1(cislo1):
    y=5
    rozdil=cislo1+y
    print(f"{cislo1} + {y} = {rozdil}")

def secist2(cislo1,cislo2):
    r=cislo1+cislo2
    print(f"{cislo1}+{cislo2}={r}")

def secist3(cislo1,cislo2,cislo3):
    rr=cislo1+cislo2+cislo3
    print(f"{cislo1} + {cislo2} + {cislo3} = {rr}")
#print("----------------------------------------------")
def nasobit():
    x=500
    y=20
    rozdil=x*y
    print(f"{x} * {y} = {rozdil}")


def nasobit1(cislo1):
    y=5
    rozdil=cislo1*y
    print(f"{cislo1} * {y} = {rozdil}")

def nasobit2(cislo1,cislo2):
    r=cislo1*cislo2
    print(f"{cislo1}*{cislo2}={r}")

def nasobit3(cislo1,cislo2,cislo3):
    rr=cislo1*cislo2*cislo3
    print(f"{cislo1} * {cislo2} * {cislo3} = {rr}")
#print("----------------------------------------------")
odecist()
odecist1(588884745)
print("proc")

odecist()
print("----------------------------------------------")
odecist1(45)
print("----------------------------------------------")
odecist2(888,465)
print("----------------------------------------------")
odecist3(46,84,85)
print("----------------------------------------------")
secist()
secist1(4)
secist2(8,6)
secist3(7,8,2)
print("----------------------------------------------")
nasobit()
nasobit1(2)
nasobit2(4,84)
nasobit3(4,96,24)
