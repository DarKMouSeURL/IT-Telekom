citatel = 14
jmenivatel = 3

podilc = citatel//jmenivatel
print(f"{citatel}//{jmenivatel}={podilc}")
podilR = citatel/jmenivatel
print(f"{citatel}/{jmenivatel}={podilR}")
zbytek = citatel % jmenivatel
print(f"{citatel}%{jmenivatel}={zbytek}")

jm=4
for cit in range(11):
    print(f"{cit}//{jm}={cit//jm}")
    print(f"{cit}%{jm}={cit%jm}")

#algoritmus ciferneho souctu
#532 =>10
#532%10=2
#532 // 10 = 53
#53%10=3
#53//10=5

cislo = 532
cifernysoucet = 0
cislopom = cislo
while cislopom >0:
    cifra = cislopom %10
    cifernysoucet = cifernysoucet+cifra
    cislopom = cislopom //10
print(f"ciferny soucet cisla {cislo} je {cifernysoucet}")