print("ABC "*7)
##print(5*"A\nB\nC ")
print(5*"ABC\tDE\nF ")
#while False
#while not False:

cislo = 1
while cislo > 0:
    print(1)
    print(12)
    print(123)
    cislo=int(input("zadej cele cislo: "))

retezec = "ABCDEF"
print(retezec)
print(len(retezec))
print(retezec[-1])
print(retezec[-2])
print(retezec[-3])
print(retezec[-4])
print(retezec[-5])
print(retezec[-6])

for i in range(-1,-7,-1): #stejne jako print
    print(retezec[i])

print(retezec)
print(retezec[-1:-4:-1])
print(retezec[-1:-4])#nefunguje bo neni specifikovano opacny smer

print(retezec[-3:-7:-1])
print(retezec[-2:-5:-1])
print(retezec[::-1])
print(retezec[::-2])

seznam = [10,11,12,13]
print(seznam)
print(seznam[:3])
print(seznam[2:3])
print(seznam[::2])
print(seznam[-1:-4:-1])
print(seznam[::-1])
