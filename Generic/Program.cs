namespace ToetsVragen;
public class SorteerbareLijstTaken<T> where T : IComparable<T>
{
    private List<T> taken = new List<T>();

    public void VoegToe(T taak)
    {
        taken.Add(taak);
    }

    // ... andere functies om de elementen in de lijst
    // aan te passen, te verplaatsen, etc. 

    public T Eerste()
    {
        if (taken.Count == 0)
            throw new InvalidOperationException("De lijst is leeg!");

        T max = taken[0];
        foreach (T taak in taken)
            if (taak.CompareTo(max) > 0)
                max = taak;

        return max;
    }
}
class Programmas
{
    static void Hoofd()
    {
        SorteerbareLijstTaken<int> lijst = new SorteerbareLijstTaken<int>();
        lijst.VoegToe(1);
        lijst.VoegToe(2);
        lijst.VoegToe(3);
        Console.WriteLine(lijst.Eerste());
    }
}