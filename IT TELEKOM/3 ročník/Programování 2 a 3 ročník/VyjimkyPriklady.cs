// See https://aka.ms/new-console-template for more information


//Řešíme pomocí TryParse:
//Na vstupu očekáváme 1 znak.
//Tento znak ukládáme do proměnné a zobrazujeme 
//znovu s pomlčkami, tedy např. - A - 
//Pokud na vstupu nebude právě 1 znak, vypíšeme slovo "chyba"

Console.Write("Napiš jeden znak");
if (char.TryParse(Console.ReadLine(), out char znak))
    Console.WriteLine($"- {znak} -");
else
    Console.Error.WriteLine("Chyba");

//Řešíme pomocí Try-catch
//Na vstupu očekává známku 1 až 5
//Pokud na vstupu bude nevhodný formát, napíšeme slovo "chyba"
//Pokud na vstupu bude int, ale nebude to celé číslo od 1 do 5,
//potom toto rovněž řešíme výjimkou, která vypíše "není známka"


try
{
    Console.Write("Napiš známku: ");
    int znamka = int.Parse(Console.ReadLine());
    if (znak > 5 || znamka < 1)
        throw new ArgumentException("není známka");
}
catch (ArgumentException aex)
{
    Console.Error.WriteLine(aex.Message);
}
catch (FormatException fex)
{
    Console.Error.WriteLine(fex.Message);
}
catch (Exception ex)
{
    Console.Error.WriteLine("Chyba: " + ex.Message);
}


//Obě metody otestujte.


