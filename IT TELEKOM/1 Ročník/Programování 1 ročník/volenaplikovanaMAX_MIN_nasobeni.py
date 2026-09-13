def fuMAX(s):
    a=s[0]
    for r in range(len(s)):
        if a<s[r]:
            a=s[r]
    return a

def furovno(s1):
    b=int(input())
    for r in range(len(s1)):
        if b == s1[r]:
            print(f"cislo je v seznamu {b}")
        else:
            print("cislo neni v seznamu")

s1=[15,-5,925,225,445]
s2=[1,5,2,22,45,-8]

x = fuMAX(s1)
print(x)
z= fuMAX(s2)
print(z)
furovno(s1)

for r in range(9):
    for x in range(9):
        print(r*x, end=" ")
    print()
