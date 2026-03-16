

namespace UebungAuto._20260316;

public class Auto1
{
   
    public string Marke { get; set; } = string.Empty;     
    public string Modell { get; set; } = string.Empty;  
    public int Baujahr { get; set; }

    public void InfoAusgeben()
    {
        Console.WriteLine($"Marke: {Marke}");
        Console.WriteLine($"Modell: {Modell}");
        Console.WriteLine($"Baujahr: {Baujahr}");
    }

}

