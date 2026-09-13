print("5. a 6. hodina, Programovani")

'''
print("zadej cele cislo x=", end="")
x = int( input() )
print("zadej cele cislo y=", end="")
y = int( input() )
rozdil = x - y
#print(f"x-y=rozdil")
print(f"{x}-{y}={rozdil}")
'''

def odecist():
    x = 500
    y = 20
    rozdil = x - y
    print(f"{x}-{y}={rozdil}")

def odecist1(cislo1):
    y = 5
    rozdil = cislo1 - y
    print(f"{cislo1}-{y}={rozdil}")

def odecist2(cislo1, cislo2):
    r = cislo1 - cislo2
    print(f"{cislo1}-{cislo2}={r}")
    print("toto je dobre")

def odecist3(a, b, c):
    r = a - b - c
    print(f"{a}-{b}-{c}={r}")

#secist()
#secist1(a)
#secist2(a, b)
#secist3(a, b, c)

#DU
#vynasobit()
#vynasobit1(a)
#vynasobit2(a, b)
#vynasobit3(a, b, c)
    
print("------------------")
odecist()
odecist()
print("------------------")
odecist1(7)
odecist1(554)
print("------------------")
odecist2(400, 33)
odecist2(-53, 0)
print("------------------")
odecist3(400, 3, 44)
print("------------------")




print("Konec programu")

input()















