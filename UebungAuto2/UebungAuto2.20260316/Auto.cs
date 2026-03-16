namespace UebungAuto2._20260316;

public class Auto
{
    public string Marke { get; set; }
    public string Modell { get; set; }
    public int Baujahr { get; set; }



    public void InfoAusgeben()
    {
        Console.WriteLine($"Marke: {Marke}");
        Console.WriteLine($"Modell: {Modell}");
        Console.WriteLine($"Baujahr: {Baujahr}");
    }   
}
