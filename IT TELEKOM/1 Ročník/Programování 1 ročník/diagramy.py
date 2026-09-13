x=input()
while x<10: 
    #testovani: True pro licha cisla 
    if x%2==1:   #zbytek po celociselnem deleni 2 je jedna 
        print(f"Prikaz1, if True:, x={x} je LICHE cislo") 
    else: 
        print(f"Prikaz2, if False:, x={x} je SUDE cislo")    
    x+=1 

for x in range(1,10): 
    #testovani: True pro suda cisla 
    if x%2==0:   #zbytek po celociselnem deleni 2 je nula 
        print(f"Prikaz1, if True:, x={x} je SUDE cislo") 
    else: 
        print(f"Prikaz2, if False:, x={x} je LICHE cislo")   