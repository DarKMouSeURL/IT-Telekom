'''
1.
x=10/0 #Exception has occurred: ZeroDivisionError division by zero
print(x)
///
2.
s=[10,18,444,54554,5]#IndexError:list index out of range
#print(s[48])
s[45]=300 #IndexError: list assignment index out of range
///
3.
f=open("neni.txt")#FileNotFoundError: [Errno 2] No such file or directory: 'neni.txt'
///
4.
cislo=int("abc")#ValueError: invalid literal for int() with base 10: 'abc'
///
5.
print(neni)#NameError: name 'neni' is not defined
'''
#///
'''
a=40
b=0
try:
    #ne/vykona nebezpecny kod
    podil=a//b
    print(podil)
except ZeroDivisionError as e:
    print(e)
except:
    print("nastala chyba obecna")

try:
    s=[1,2,3]
    print(s[9])
except IndexError as e:
    print(e)
'''
#///
'''
try:
    f=open("neni.txt")
except FileNotFoundError as e:
    print(e)
finally:
    #nepovinna sekce na zaver, provede vzdy
    pass
'''
#///
'''
try:
    cislo=int("abc")
except NameError as e:
    print(e)
except ValueError as e:
    print(e)
'''
#///

try:
    print(neni)
except NameError as e:
    print(e)