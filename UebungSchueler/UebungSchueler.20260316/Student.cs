namespace UebungSchueler._20260316;

public class Student
{
public string FirstName { get; set; }

public string LastName { get; set; }    

public string Mainclass { get; set; }

    public void SayHello()
    {
        Console.WriteLine($"Hallo ich bin {FirstName} {LastName} und bin Schueler der {Mainclass} ");
    }

}
