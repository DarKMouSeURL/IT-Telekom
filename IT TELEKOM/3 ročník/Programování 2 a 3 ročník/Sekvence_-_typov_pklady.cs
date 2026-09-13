// See https://aka.ms/new-console-template for more information

//PŘ1: předpokládejme rovnici y = 5x + 3;
//na vstupu zadá uživatel hodnotu x
//vypište y

Console.WriteLine("Program pro řešení rovnice y=5x+3");
Console.WriteLine("*********************************");
//vstup(y)
Console.Write("x: ");
double x = double.Parse(Console.ReadLine());
//algoritmus
double y = 5 * x + 3;
//výstup
Console.WriteLine("y = "+y);
Console.ReadLine();

//PŘ2: PROHOZENÍ 2 HODNOT MEZI SEBOU
int a = 5;
int b = 10;
Console.WriteLine($"a: {a}, b:{b}");    //$ alt+ů    {} alt+bn
int pom = a;
      a = b;
      b = pom;
Console.WriteLine($"a: {a}, b:{b}");


