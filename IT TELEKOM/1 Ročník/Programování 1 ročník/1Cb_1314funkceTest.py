

def minus():
    r = 4-2
    print(f"4-2={r}")

def plus(a, b):
    p = a + b
    print(f"{a} + {b} = {p}")

def krat(a, b, c):
    k = a * b * c
    print(f"{a} * {b} * {c} = {k}")

def deleno(citatel, jmenovatel):
    d = citatel / jmenovatel
    print(f"{citatel} / {jmenovatel} = {d}")

'''
def vekZuzany(jana, mladsiO):
    zuzana = jana - mladsiO
    print(f"Zuzane je {zuzana} let.")
'''

def vekZuzany(j, m):
    z = j - m
    print(f"Zuzane je {z} let.")

print("---------------")
minus()
minus()
plus(12, 9)
plus(6, 6)
krat(1, 2, 3)
krat(10, -2, 9)
print("---------------")
deleno(5, 2)
vekZuzany(23, 2)
vekZuzany(30, 5)
vekZuzany(17, 4)








