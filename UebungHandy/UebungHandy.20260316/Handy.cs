namespace UebungHandy._20260316;

public class Handy
{
public string Marke { get; set; }   
public string Modell { get; set; }  

public string AkkuProzent { get; set; } 



    public void Anzeigen()
    {
        Console.WriteLine($"Marke: {Marke}");
        Console.WriteLine($"Modell: {Modell}");
        Console.WriteLine($"Akku: {AkkuProzent}%");
    }   

    public void Aufladen()
    {
        AkkuProzent = "100";
        Console.WriteLine("Handy aufgeladen!");
    }

}
