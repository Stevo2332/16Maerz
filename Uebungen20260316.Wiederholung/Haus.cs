using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace Uebungen20260316.Wiederholung;

public class Haus
{
    private double _qm;
    public Haus(double qm, string _farbe)
    {
        Quadratmeter = qm;
        Farbe = _farbe;

    }
    public string Farbe { get; private set; } = "weiß"; 
    public double Quadratmeter
    {
        get { return _qm; }
        set
        {
            if (value < 50)
            {
                Console.WriteLine("Quadratmeter darf nicht weniger als 50 sein.");
            }
            else
            {
                _qm = value;
            }
        }
    }
}







