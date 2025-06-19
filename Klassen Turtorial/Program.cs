



using System;

class Person
{
    // Attribute(Variablen)+ Eigenschaften
    public string Name { get; set; }
    public int Alter { get; set; }
    public string Vorname { get; set; }
    public string Adresse { get; set; }

    // Methode
    public void SagHallo()
    {
        Console.WriteLine($"Hallo, ich heiße {Vorname} {Name} und bin {Alter} Jahre alt.");
    }

    // Methode
    public string GetAdresse()
    {
        return Adresse;
    }
}

