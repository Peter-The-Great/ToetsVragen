class A
{
    public virtual void functie() { Console.WriteLine("A"); }
}

class B : A
{
    public override void functie() { Console.WriteLine("B"); }
}
class Klasse
{
    public int Waarde { get; set; }
    public static Klasse operator +(Klasse a, Klasse b)
    {
        return new Klasse { Waarde = a.Waarde + b.Waarde };
    }
}
public class Program
{
    public static void Main()
    {
        var een = new Klasse() { Waarde = 1 };
        var twee = new Klasse() { Waarde = 1 };
        Console.WriteLine((een + twee).Waarde * 2);
        A a = new B();
        a.functie();
    }
}