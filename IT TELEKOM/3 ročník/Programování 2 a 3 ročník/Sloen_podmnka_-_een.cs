Random nahoda = new Random();

int x = nahoda.Next(-200, 201);
Console.WriteLine("--------\n{0}\n--------\n", x);

Console.Write("1) Určete, zda x je větší nebo rovno -10 a zároveň liché: ");
if (x >= -10 && x % 2 != 0)
    Console.WriteLine("pravda\n");
else
    Console.WriteLine("nepravda\n");

Console.Write("2) Určete, zda x patří do intervalu < -10, 10 >: ");
if (x >= -10 && x <= 10)
    Console.WriteLine("pravda\n");
else
    Console.WriteLine("nepravda\n");

Console.Write("3) Určete, zda x patří do intervalu ( -10, 10 ): ");
if (x > -10 && x < 10)
    Console.WriteLine("pravda\n");
else
    Console.WriteLine("nepravda\n");

Console.Write("4) Vytvořte podmínku, která neguje podmínku předchozí, tedy x patří do (- nekonečno, -10> U <10, nekonečno ): ");
if (!(x > -10 && x < 10))
    Console.WriteLine("pravda\n");
else
    Console.WriteLine("nepravda\n");

Console.Write("5) Určete, zda je x sudé nebo větší než 100: ");
if (x % 2 == 0 || x > 100)
    Console.WriteLine("pravda\n");
else
    Console.WriteLine("nepravda\n");

Console.Write("6) Určete, zda je pravdou, že x není kladné číslo: ");
if (!(x > 0))
    Console.WriteLine("pravda\n");
else
    Console.WriteLine("nepravda\n");

Console.Write("7) Určete, zda x patří do intervalu ( - nekonečno, -100 > U ( 100, 1000 >: ");

if (x <= -100 || (x > 100 && x <= 1000))
    Console.WriteLine("pravda\n");
else
    Console.WriteLine("nepravda\n");

Console.ReadLine();


