namespace _2C_KonverzeMeziDatovymiTypy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //**************Převody se stringem*********************

            //Parsování - převod ze stringu na cokoli
            string hodnota1 = "50";
            int hodnota1Int = int.Parse(hodnota1);
            double hodnota1D = double.Parse(hodnota1);

            //Cokoli na string je .ToString();
            double x = 55.75;
            int xx = 5;
            char xxx = '@';
            string y = x.ToString();   
            string yy = y.ToString();
            string yyy = xxx.ToString();

            
            //************Ostatní převody datových typů mimo string******************

            //Konverze z desetinného čísla na celé číslo
            float z = 8.9f;
            int zInt = Convert.ToInt32(z); //konverze - dochází k zaokrouhlení = 9
            Console.WriteLine(zInt);
            int zInt2 = (int)z;       //přetypování - dochází k odseknutí desetinných míst = 8
            Console.WriteLine(zInt2);

            //Z celého čísla udělat desetinné není problém, vybyreme si konverzci nebo přetypování
            int alfa = 101;
            double alfaD = Convert.ToDouble(alfa);
            double alfaD2 = (double)alfa;
            Console.WriteLine(alfaD);
            Console.WriteLine(alfaD2);

            char znak = '@';
            int znakInt = znak; //číslo, které odpovídá znaku v unicode table, netřeba konverze
            Console.WriteLine(znakInt);

            int ddddd = 70;
            char fffff = (char)ddddd; //přetypování čísla na znak
            Console.WriteLine(fffff);

            string veta = "Dneska je hezky";
            char pismeno = veta[3]; //vytáhnutí znaku z pole znaků (stringu)
            Console.WriteLine(pismeno);

            //PROBLÉMOVÝ ÚKOL
            char k = '9';
            int kk = (int)k; //do kk se uloží 54, odpovídající znaku '6'
            int kkk = (int)k - 48; //legitimní způsob, jak se díky pohybu  v
                                   //unicode table dostat k číslu 6




            Console.ReadLine();
        }
    }
}