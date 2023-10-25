namespace ToetsVragen;
class Adres
{
    public string Stad { get; set; }
}

struct Persoon
{
    public string Naam { get; set; }
    public Adres Adres { get; set; }
}

public class MainKlasse
{
    public static void Main(string[] args)
    {
        Persoon p1 = new Persoon { Naam = "Alice", Adres = new Adres { Stad = "Delft" } };
        Persoon p2 = p1;
        p1.Adres = null;
        System.Console.WriteLine(p2.Adres.Stad);
    }
}