s1=[15,-5,25,225,445,777,-88]
'''
a=s[0]
print("nejvetsi")
for r in range(len(s)):
    if a < s[r]:
        a=s[r]
print(a)

print("nejmensi")
b=s[0]
for r in range(len(s)):
    if b > s[r]:
        b=s[r]
print(b)

print(s1)
def fuMax(s):
    a=s[0]
    for r in range(len(s)):
        if a < s[r]:
            a=s[r]
    #print(a)
    return a
x =  fuMax(s1)
print(f"navratova hod. je {x}")
s2=[1,48,51,688,12,-565]
x = fuMax(s2)
print(f"navratova hod. je {x}")
s3=[-10,-20,-5,4]
#fuMax(s3)
print(f"navratova hod. je {fuMax(s3)}")


def fuMin(s):
    b=s[0]
    for r in range(len(s)):
        if b > s[r]:
            b=s[r]
    #print(b)
    return b
z = fuMin(s1)
print(f"navratova hod. je {z}")
z = fuMin(s2)
print(f"navratova hod. je {z}")
#fuMin(s3)
print(f"navratova hod. je {fuMin(s3)}")
'''
s=[10,20,12,3,12,77,12]
print(s)
c=12
for i in range(len(s)):
    if s[i] == c:
        print(f"cislo = {c}, s[{i}] = {s[i]}, nalezeno")
    else:
        print(f"cislo = {c}, s[{i}] = {s[i]}, NEnalezeno")
