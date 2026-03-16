namespace UebungLampe._20260316;

public class Lampe
{
public string Farbe { get; set; } = string.Empty;   
    //Ein bool ist dafür zuständig, ob die Lampe an oder aus ist. Bool benutz True oder False , um den Zustand zu beschreiben. 
    public bool IstEingeschaltet { get; set; }

    // Hier wird zum Beispiel der Bool genutzt um zu sehen ob die Lampe an oder aus ist. Je nachdem wird eine Nachricht ausgegeben.
    public void Einschalten()
    {
        IstEingeschaltet = true;
    }

    public void Ausschalten()
    {
        IstEingeschaltet = false;
    }
    // Hier wird zum Beispiel der Bool genutzt um zu sehen ob die Lampe an oder aus ist. Je nachdem wird eine Nachricht ausgegeben.

    public void StatusAnzeigen()
    {
        if (IstEingeschaltet)
        {
            Console.WriteLine($"Die {Farbe} Lampe ist eingeschaltet.");
        }
        else
        {
            Console.WriteLine($"Die {Farbe} Lampe ist ausgeschaltet.");
        }
    }


}
