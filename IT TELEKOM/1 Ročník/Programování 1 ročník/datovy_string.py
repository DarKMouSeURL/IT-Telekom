s1 = [10,21,32]
print(s1)
print("ahoj")
#      0123
print("ahoj"[0])
print("ahoj"[1])
print("ahoj"[2])
print("ahoj"[3])
print(" ")
print(f"delka je {len('ahoj')}")
for r in range(4):
    print("ahoj"[r])
print(" ")
slovo = "teleinfo"
for t in range (len(slovo)):
    print(f"[slovo][{t}] = {slovo[t]}")
print(" ")
veta = "moje nove kolo"
print(len(veta))
for r in range(len(veta)):
        print(f"[veta][{r}] = {veta[r]}")
# slicing, vyseknuti casti znakoveho retezce
print(veta [4:11])
print(veta [6:13:2])
print(veta [::2])

veta2=str(input("tvoje veta: "))
print(veta2 [::2])
for s in range(len(veta2)):
    print(veta2[s])
