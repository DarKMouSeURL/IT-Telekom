// See https://aka.ms/new-console-template for more information

int a = 5;
int b = 1000;
int c = 15;

if (a + b > c && b + c > a && c + a > b)  // && alt+c   || alt+w
{
    Console.Write("Strany tvoří trojúhelník ");

    //obecný        if(a!=b && b!=c && c!=a) // u negace neplatí tranzitivita!!
    //rovnoramenný  if((a==b && b!=c) || (a==c && c!=b) || (c==b && a!=b)
    //rovnostraný   if(a == b && b == c) // platí tranzitivita, tzn. vyplývá, že a == c)

    if (a != b && b != c && c != a)
        Console.Write("obecný");
    else if (a == b && b == c)
        Console.Write("rovnostranný");
    else
        Console.Write("rovnoramenný");


    if (a * a + b * b == c * c || b * b + c * c == a * a || a * a + c * c == b * b)
        Console.Write(" pravoúhlý");
}
else
    Console.WriteLine("Strany NEtvoří trojúhelník");

Console.ReadLine();
