srcname = input("Enter file name: ")
try:
    if srcname.endswith(".txt"):
        src = open(srcname, 'rt')
    else:
        src = open(srcname + ".txt", 'rt')
except BaseException as e:
    print("Bad file name!", e)
    exit()

ll=[]
for r in src.readlines():
    for ch in r:
        ll.append(ch)

for j in range(26):
    print(f"{chr(97+j)}->{ll.count(chr(97+j))}", end= " ")

print()

for j in range(26):
    print(f"{chr(65 + j)}->{ll.count(chr(65 + j))}", end=" ")

