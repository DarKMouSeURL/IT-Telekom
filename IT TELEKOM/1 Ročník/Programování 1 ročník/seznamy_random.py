import random
s1 = [5,4,3,2,1]
print(s1)
for i in range(5):
    print(s1[i])
s2=[]
for g in range(10):
    hod= random.randint(1,6)
    s2.append(hod)
    print(s2)
s2.append(77)
delkas2= len(s2)
print(delkas2)
for r in range(len(s2)):
    print(f"s2[{r}]={s2[r]}")
for r in range(4):
    h = int(input("Do it, podvadej: "))
    #s2.append(h)
    if h<=6:
        s2.append(h)
    else:
        print("chuju")
    print(s2)
    print(f"delka seznamu je {len(s2)}")
