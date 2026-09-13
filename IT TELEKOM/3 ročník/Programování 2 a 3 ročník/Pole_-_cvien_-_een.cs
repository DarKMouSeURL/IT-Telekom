// See https://aka.ms/new-console-templ

//Měřák naměřil během minuty 60 náhodných hodnot na škále od -100 do 100.
//1) Vytvořte tedy pole hodnoty a uložte do něj 60 náhodných celých čísel. 
Random nahoda = new Random();
int[] hodnoty = new int[60]; //indexy 0..59
for (int i = 0; i < hodnoty.Length; i++)
    hodnoty[i] = nahoda.Next(-100, 101);

//2) Tato čísla vypište vedle sebe navzájem oddělená čárkou
for (int i = 0; i < hodnoty.Length; i++)
    Console.Write($"{hodnoty[i]}, ");
//nebo
foreach (int x in hodnoty)
    Console.Write($"{x}, ");

//3) Vypište první a poslední hodnotu
Console.WriteLine($"\r\n\r\nPrvní hodnota na indexu 0: {hodnoty[0]}");
Console.WriteLine($"Poslední hodnota na indexu {hodnoty.Length - 1}: {hodnoty[hodnoty.Length - 1]}");

//4) Vypište minimální a maximální hodnotu
int min = hodnoty[0]; //nastavuji na první hodnotu v poli
int max = hodnoty[0]; //nastavuji na první hodnotu v poli
for (int i = 0; i < hodnoty.Length; i++) //můžu začít cyklus i od indexu 1, když mám 0 už použitou o 2 řádky výše
{
    if (hodnoty[i] < min)
        min = hodnoty[i];
    if (hodnoty[i] > max)
        max = hodnoty[i];
}
Console.WriteLine($"\r\nNejmenší hodnota v poli: {min}");
Console.WriteLine($"Největší hodnota v poli: {max}");

//5) Vypište, kolik hodnot je kladných, kolik záporných a kolik nulových
int kladne = 0;
int zaporne = 0;
int nula = 0;

for (int i = 0; i < hodnoty.Length; i++)
{
    if (hodnoty[i] > 0)
        kladne++;
    else if (hodnoty[i] < 0)
        zaporne++;
    else
        nula++;
}
Console.WriteLine($"\r\nKladných: {kladne}, záporných: {zaporne}, nul: {nula}");

//6) Vypište průměr těchto hodnot
int suma = 0;
foreach (int x in hodnoty)
    suma += x;
double prumer = (double)suma / hodnoty.Length; //nezapomenout přetypovat na double!
prumer = Math.Round(prumer, 4); //zaokrouhlení průměru na 4 desetinná místa
Console.WriteLine("\r\nPrůměr hodnot: {0}", prumer);

//NEBO
Console.WriteLine(hodnoty.Average());

//7) Vytvořte nové pole s názvem hodnoty_abs a uložte do něj absolutní hodnoty
//   prvků původního pole hodnoty

//int[] hodnoty_abs = hodnoty; - !! POZOR, CHYBNÝ Kod, NEDOJDE KE ZKOPÍROVÁNÍ POLE, ale k vytvoření ukazatele na totéž pole
int[] hodnotyAbs = hodnoty.ToArray(); //v tomto případě DOJDE ke zkopírování pole
for (int i = 0; i < hodnotyAbs.Length; i++)
{
    if (hodnotyAbs[i] < 0)
        hodnotyAbs[i] *= -1;    //hodnoty[i]= hodnoty[i]* -1;                
}

//8) Pole hodnoty_abs vypište na consoli (prvky vedle sebe oddělené čárkou)
Console.WriteLine("\r\nAbsolutní hodnoty:");
foreach (int x in hodnotyAbs)
    Console.Write($"{x}");

//9) Vytvořte nové pole s názvem hodnoty_redukce, které bude mít přesně
//   o polovinu méně prvků než pole hodnoty. Toto pole bude obsahovat vždy
//   každý druhý prvek z původního pole hodnoty
int[] hodnotyRedukce = new int[hodnoty.Length / 2];
int j = 0;

//jedno z mnoha řešení
for (int i = 0; i < hodnoty.Length; i++)
{
    if (i % 2 == 1)
    {
        hodnotyRedukce[j] = hodnoty[i];
        j++;
    }
}

//10)Pole hodnoty_redukce vypište na consoli (prvky vedle sebe oddělené čárkou)
Console.WriteLine("\r\n\r\nRedukované pole na polovinu hodnot:");
foreach (int x in hodnotyRedukce)
    Console.Write($"{x}, ");

Console.ReadLine();


