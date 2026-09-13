import random

"""
s1=[]
for r in range(6):
    x=random.randint(0,554564654564)
    print(x)
    s1.append(x)
    
print("//////")
print(s1)

for r in range(6):
    print(s1[r])
    
s2=[]
#deep copy
for i in range(len(s1)):
    s2.append(s1[i])
    
print(s2)

for i in range(len(s2)):
    s2[i]=-123
print(s2)
"""
"""
sd=["pondelok", "utorok", "stredok", "ctvrtok", "paitok", "sobot", "nedelok"]


for r in range(10):
    index=random.randint(0,6)
    print(sd[index])

sm=["leden", "unor", "brezen", "duben"]
print("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^")
for r in range(10):
    print(sm[random.randint(0,3)])
for i in range(10):
    d=random.randint(0,30)
    m=random.randint(0,12)
    r=random.randint(2000,2023)
    dvt=random.randint(0,6)
    print(f"{d}.{sm[m]} {r}, {sd[dvt]}")
"""
"""
acka="AAAAAAssssdddfff"
print(acka[:6])

acka="Axxxxu"
print(acka[:1])
print(acka[0])

acka="jjkklkjjjAAAAA"
print(acka[9:])

acka="uiiiooooooA"
print(acka[10])

acka="rrreeddAAAAAAAuuuuii"
print(acka[7:14])

acka="aaaaaaaaaAuuuuu"
print(acka[9])

acka="AfAfAfAfAfAfA"
print(acka[::2])

acka="AuuAuuAuuAuuAu"
print(acka[::3])

acka="AxxxAuuuAfffAuuuAx"
print(acka[::4])

acka="rrrtAaaaxAiiiiAqqqqAr"
print(acka[4::5])

acka="adffAasAfeAeeArrttt"
print(acka[4:14:3])
"""
s=[
"AAAAAAssssdddfff",
"Axxxxu",
"jjkklkjjjAAAAA",
"uiiiooooooA",
"rrreeddAAAAAAAuuuuii",
"aaaaaaaaaAuuuuu",
"AfAfAfAfAfAfA",
"AuuAuuAuuAuuAu",
"AxxxAuuuAfffAuuuAx",
"rrrtAaaaxAiiiiAqqqqAr",
"adffAasAfeAeeArrttt",
    ]
print(s)
for r in range(len(s)):
    print(s[r])
