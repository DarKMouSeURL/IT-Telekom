def minus():
    x=4
    y=8
    odecist=x-y
    print(f"{x} - {y} = {odecist}")
    
def plus(cislo1, cislo2):
    secist=cislo1+cislo2
    print(f"{cislo1} + {cislo2} = {secist}")
    
def krat(cislo1, cislo2, cislo3):
    nasobit=cislo1*cislo2*cislo3
    print(f"{cislo1} * {cislo2} * {cislo3} = {nasobit}")
    
def deleno(citatel, jmenovatel):
    deleni=citatel/jmenovatel
    print(f"{citatel} / {jmenovatel} = {deleni}")

"""    
def vekzuzany(jana, mladsiO):
    zuzana = jana - mladsiO
    print(f"zuzane je {zuzana} let.")
"""

def vekzuzany(j, m):
    z = j - m
    print(f"zuzane je {z} let.")

print("--------------------------------------")
minus()
minus()
plus(5,4)
plus(8,9)
krat(4,7,8)
krat(2,3,4)
deleno(8,4)
print("--------------------------------------")
vekzuzany(23, 2)
vekzuzany(30,5)
vekzuzany(17,4)
