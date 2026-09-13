print("Funkce s navratovou hodnotou")

#test789

print("----------------------")

def deleno(citatel, jmenovatel):
    podil = citatel / jmenovatel
    #print(f"{citatel} / {jmenovatel} = {podil}")
    return podil


x = deleno(55, 7)
print(x)
print("-----")

y = deleno(100, 2)
print(f"podil je {y}")
print(f"podil je { deleno(100, 2) }")
print("-----")

#sami do promenne z...

print(f"PODIL je { deleno(333, 17) }")
print("----------------------")

def program1():
    a = 10
    b = 5
    soucet = a + b
    #print...
    return soucet


print( f"soucet je { program1() }" )
print( program1() )
print( program1() )
print("----------------------")

for e in range(3):
    print(f"opakuji 3x   {e}. pokus")
    print( program1() )
    print("---")


def program12(pocetAutobusu, autKratVice):
    pocetAut = pocetAutobusu * autKratVice
    pocetDP =pocetAutobusu + pocetAut
    return pocetDP

print(f"Na parkovisti bylo celkem {program12(4,9)} dopr. prostredku.")
print(f"Na parkovisti bylo celkem {program12(3,10)} dopr. prostredku.")

#DU  nacvicit funkce s navratovou hodnotou a slovni ulohy....
print("----------------------")

for i in range(4):
    print(f"{i}. Na parkovisti bylo celkem {program12(4,9)} dopr. prostredku.")

print("----------------------")
def program13(tresne, kratMene):
    jahody = tresne / kratMene
    ovoce = tresne + jahody
    return ovoce

print(f"Maminka koupila dohromady {program13(15, 3)} kg ovoce.")
print(f"Maminka koupila dohromady {program13(4, 5)} kg ovoce.")


print("Konec programu")

















