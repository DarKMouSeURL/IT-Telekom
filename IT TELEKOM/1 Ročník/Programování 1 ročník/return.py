def program1():
    x=4
    y=6
    r=x+y
  #  print(f"{x} + {y} = {r}")
    return r


def program2(cislo1, cislo2):
    vynasobeni=cislo1+cislo2
   # print(f"{cislo1} * {cislo2} = {vynasobeni}")
    return vynasobeni
print("////////////////////////////////////////////////////////////////////////////////////////")
print(program1())
print(program2(4.,8))
    
print("////////////////////////////////////////////////////////////////////////////////////////")

def deleno(citatel, jmenovatel):
    podil = citatel / jmenovatel
    #print(f"{citatel} / {jmenovatel} = {podil}")
    return podil


x = deleno(4, 5)
print(x)
print("////////////////////////////////////////////////////////////////////////////////////////")
y = deleno (100, 2)
print(f"podil je {y}")
print(f"podil je {y}")

z = deleno(5, 7)
print(z)
print("////////////////////////////////////////////////////////////////////////////////////////")

for e in range (7):
    print(f"opakuj 7x {e}")
    print(program1())

def program12(cislo1, cislo2):
    r=cislo1*cislo2
    s=r+cislo2
    return s

print(program12(9, 4))

for i in range(8):
    print(f"{i}program12(9, i)")
    
def program13(cislo1,cislo2):
    r=cislo1/cislo2
    s=r+cislo1
    return s

print(program13(15,3))

    
