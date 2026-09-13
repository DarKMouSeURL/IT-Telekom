// See https://aka.ms/new-console-template for more information

List<Osoba> zaznamy = new List<Osoba> ();
zaznamy.Add(new Osoba("Michael", 17));
zaznamy.Add(new Zamestnanec("Martin", 18,200000));

foreach (Osoba o in zaznamy)
    Console.WriteLine(o);

//****************** class Osoba *****************************
class Osoba
{
     protected string jmeno;
     protected int vek;

    public Osoba(string jmeno, int vek)
    {
        this.jmeno = jmeno;
        this.vek = vek;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name} [jmeno: {jmeno}, vek: {vek}]";
    }
}

//******************** class Zamestnanec ************************
class Zamestnanec : Osoba
{
    double plat;

    public Zamestnanec(string jmeno, int vek, double plat):base(jmeno, vek)
    {     
        this.plat = plat;
    }

    public override string ToString()
    {
        return base.ToString()+$"[plat: {plat}]";
    }
}
