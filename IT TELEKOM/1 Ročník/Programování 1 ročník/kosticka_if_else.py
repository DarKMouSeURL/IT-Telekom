import random

hod = random.randint(1,6)
def zobrazit(hod):
    if hod == 6:
        print("XXXXXXXXX")
        print("X       x")
        print("X o   o x")
        print("X       x")
        print("X o   o x")
        print("X       x")
        print("X o   o x")
        print("X       x")
        print("XXXXXXXXX")

    if hod == 5:
        print("XXXXXXXXX")
        print("X       x")
        print("X o   o x")
        print("X       x")
        print("X   o   x")
        print("X       x")
        print("X o   o x")
        print("X       x")
        print("XXXXXXXXX")

    if hod == 4:
        print("XXXXXXXXX")
        print("X       x")
        print("X o   o x")
        print("X       x")
        print("X       x")
        print("X       x")
        print("X o   o x")
        print("X       x")
        print("XXXXXXXXX")

    if hod == 3:
        print("XXXXXXXXX")
        print("X       x")
        print("X o     x")
        print("X       x")
        print("X   o   x")
        print("X       x")
        print("X     o x")
        print("X       x")
        print("XXXXXXXXX")

    if hod == 2:
        print("XXXXXXXXX")
        print("X       x")
        print("X o     x")
        print("X       x")
        print("X       x")
        print("X       x")
        print("X     o x")
        print("X       x")
        print("XXXXXXXXX")

    if hod == 1:
        print("XXXXXXXXX")
        print("X       x")
        print("X       x")
        print("X       x")
        print("X   o   x")
        print("X       x")
        print("X       x")
        print("X       x")
        print("XXXXXXXXX")
for i in range(88):
    hod = random.randint(1,6)
    print(hod)
    zobrazit(hod)
