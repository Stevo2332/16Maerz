namespace UebungTemperatur._20260316;

public class Temperatur
{
    public double GradCelsius { get; set; }

    public void Anzeigen()
    {
        Console.WriteLine($"Die Temperatur beträgt {GradCelsius} °C");

    }
    public void Erhoehen()
    {
        GradCelsius += 1;
        Console.WriteLine("Temperatur erhöht");
    
    }
    
    public void Senken()
    {
        GradCelsius -= 1;
        Console.WriteLine("Temperatur gesenkt");
    }

}
