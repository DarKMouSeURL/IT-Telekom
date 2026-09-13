x = 15.3
print(x, type(x))
pom = x*77
print(pom)

x = "1234.78"
print(x, type(x))

x = 45
print(x, type(x))

x= True
print(x, type(x))

sX = [10,20,30] #da se menit, mutable
print(sX)
print(sX, type(sX))

sX.append(111)
print(sX, type(sX))
sX[1] = 555
print(sX, type(sX))

tuple1 = (10,20,30)#nemenitelny, immutable
print(tuple1, type(tuple1))

#tuple1[1]=444
#tuple1.append(444)
#print(sX, type(sX))

a = "ABC", "111" #nemenitelny, immutable
print(a, type(a))
#a.append(444)
#s[1] = 585

tupstr = ("ACB", "HJK", "KOL")
print(tupstr, type(tupstr))
print(tupstr[:3])
print(tupstr[1:3])
for r in range(len(tupstr)):
    print(tupstr[r])

tupFloat = (1.1, 4.2, 7787.66, 11.11)
print(tupFloat, type(tupFloat))
print(tupFloat[:3])
for r in range(len(tupstr)):
    print(tupFloat[r])

tupbool = (True, False, True, False)
print(tupbool, type(tupbool))
print(tupbool[:3])
print(tupbool[::2])
for r in range(len(tupstr)):
    print(tupbool[r])
