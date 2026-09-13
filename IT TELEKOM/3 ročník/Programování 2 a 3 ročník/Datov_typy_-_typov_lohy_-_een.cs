// See https://aka.ms/new-console-template for more information

//1. Vytvořte pravdivostí proměnnou s názvem alfa a uložte do ní hodnotu nepravda 
bool alfa = false;

//2. Vytvořte celočíselnou proměnnou s názvem cislo a uložte do ní hodnotu -9 miliard
long cislo = -9000000000;

//3. Vytvořte textovou proměnnou s názvem x a uložte do ní obsah proměnné cislo 
string x = cislo.ToString();

//4. Vytvořte textovou proměnnou s názvem hodnota a napište do ní hodnotu 2,15 
string hodnota = "2,15";

//5. Vytvořte proměnnou pro uložení desetinného čísla s názvem y a uložte do ní  
//   hodnotu z proměnné hodnota 
double y = double.Parse(hodnota);
float yy = float.Parse(hodnota);

//6. Vytvořte proměnnou s názvem z a uložte do ní znak i 
char z = 'i';

//7. Vytvořte proměnnou s názvem zz a uložte do ní číselnou hodnotu, která odpovídá
//   unicode hodnotě znaku uloženého v proměnné z 
int zz = z;
int zzz = (int)z;

//8. Vytvořte celočíselnou proměnnou vek a použijte pro ni co nejvýhodnější a 
//   nejsprávnější datový typ pro ukládání věku 
byte vek;

//9. Vytvořte nejméně přesnou proměnnou pro uložení desetinného čísla s názvem 
//   vzorek a uložte do ní hodnotu 2,22 
float vzorek = 2.22f;

//10.Vytvořte celočíselnou proměnnou s názvem zkraceny_vzorek a uložte do ní 
//   desetinné číslo z proměnné vzorek. DOJDE K ODSTRANĚNÍ ČÁSTI ČÍSLA ZA DES. ČÁRKOU! 
int zkraceny_vzorek = (int)vzorek;

//11.Vytvořte proměnnou pro uložení znaku s názvem click a uložte do ní znak,  
//   který odpovídá unicode hodnotě 64 
char click = (char)64;

//12.Předpokládejme proměnnou char znamka = '5'; 
//   Uložte hodnotu proměnné známka do celočíselné proměnné znamka_int 
//   Pozor, ať neuložíte číslo odpovídající pozici znaku 5 v Unicode tabulce! (53) 
char znamka = '5';
int znamka_int = znamka - 48; // 53 - 48 = 5
int znamka_int2 = int.Parse(znamka.ToString());
