"""
print("zadej pocet opakovani: ", end="")
pocet = int( input())


for x in range (pocet):
    print(x)
    print("hehehhe")
    print("grrrrrr")
    print("////////////////////////////////////////////////////////////")
"""

def opakovat():
    print("start funkce opakovat")
    for x in range(3):
        print(f"{x} prvni radek...")
        print(f"{x}...posledni radek")
    print("gonec funkce opakovat")

opakovat()
opakovat()

def pozdravit ():
    for s in range(5):
        print("ahoj")

pozdravit()

def pozdravit2(pozdrav):
    for f in range(3):
        print(pozdrav)

pozdravit2("bud zdrav")



