namespace UebungFernseher._20260316;

public class Fernseher
{
    public string Marke { get; set; }
    public int Kanal { get; set; }
    public bool IstAn { get; set; }

    public void Markenzeichen()
    {
        Console.WriteLine($"Die Marke des Fernsehers ist: {Marke}");
    }

    public void Einschalten()
    {
        IstAn = true;
        Console.WriteLine("Der Fernseher ist eingeschaltet.");
    }

    public void Ausschalten()
    {
        IstAn = false;
        Console.WriteLine("Der Fernseher ist ausgeschaltet.");
    }

    public void KanalAnzeigen()
    {
        Console.WriteLine($"Aktueller Kanal: {Kanal}");
    }
}
