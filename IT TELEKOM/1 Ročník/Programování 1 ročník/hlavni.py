print("start")


#if not True:
#if not False:
#if not (7 > 88):
#if False or False:
if True and True and True:
    print("sekce if....")
'''
x10=65535
xNegace = ~x10
print(xNegace)
'''

i=15
j=22
bitovySoucin= i & j
print(bitovySoucin)

i=7
j=4
bitovySoucin= i & j
print(bitovySoucin)

i=7
j=10
bitovySoucet= i | j
print(bitovySoucet)


i=5
j=10
bitovyXOR= i ^ j
print(bitovyXOR)


i=7
j=10
bitovyXOR= i ^ j
print(bitovyXOR)

print("konec")


#flag_register = 0x1234
flag_register = 0x123C
print(flag_register)

the_mask = 8

if flag_register & the_mask:
    print(" My bit is set.")
else:
    print(" My bit is reset. ")