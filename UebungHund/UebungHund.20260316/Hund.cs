namespace UebungHund._20260316;

public class Hund
{
    public string Name { get; set; }
    public string Rasse { get; set; }

    public int Alter { get; set; }

    public void Bellen()
    {
        Console.WriteLine($"Der Hund {Name} bellt");
    }

    public void Info() {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Rasse: {Rasse}");
        Console.WriteLine($"Alter: {Alter}");
    
    }  



}

