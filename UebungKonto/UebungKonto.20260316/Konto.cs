namespace UebungKonto._20260316
{
    public class Konto
    {
    public string Inhaber { get; set; } 
    public int Kontostand { get; set; }  

    
        public void KontostandAnzeigen()
        {
            Console.WriteLine($"Der Kontostand von {Inhaber} beträgt: {Kontostand}");
        }

        public void Einzahlen()
        {

            Kontostand = Kontostand + 100; // Hier wird der Kontostand um 100 erhöht, da die Einzahlung 100 Euro beträgt    
            Console.WriteLine("Einzahlung erfolgreich.");
            
        
        }
    }
}
