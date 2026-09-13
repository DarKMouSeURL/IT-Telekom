// See https://aka.ms/new-console-template for more information

Console.WriteLine("Program na dělení 2 čísel");
Console.WriteLine("-------------------------");

//VSTUPY
Console.Write("Dělenec: ");
int delenec = int.Parse(Console.ReadLine());
Console.Write("Dělitel: ");
int delitel = int.Parse(Console.ReadLine());

//ALGORITMUS
if (delitel != 0) //!= nerovná se
{
    int celocisPodil = delenec / delitel; //celočíselný podíl, při ukládání do double bude výsledek stejný
    int zbytek = delenec % delitel; //zbytek po celočíselném dělení
    double podil = (double)delenec / (double)delitel; //podíl s desetinným výsledkem

    //VÝSTUPY
    Console.WriteLine($"celočíselný podíl: {celocisPodil}, zbytek {zbytek}");
    Console.WriteLine($"podíl: {podil}");
}

Console.ReadLine();


