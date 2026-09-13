"""
for x in range(4):
    a = int(input("zadej: "))
    if a < 0:
        a=999
    b = int(input("zadej: "))
    v = a + b
    print(v)
"""
for x in range(9,30, 3):
    print(x, end="")
print()    
s2 = ["ahojda", "tvoja matka", "heheha"]
print(s2[2])
s2[1]="Dobrou rano"
print(s2)
for i in range(3):
    print(s2[i])
s2.append("amigos")
print(s2)
s2.append("BBC")
print(s2)

s3=[]
print(s3)
s3.append(10)
print(s3)
s3.append(30)
print(s3)
import random
x=random.randint(0,9)
print(x)
for r in range(201):
    x=random.randint(0,9)
    s3.append(x)
    print(s3)
input("stiskni enter")
