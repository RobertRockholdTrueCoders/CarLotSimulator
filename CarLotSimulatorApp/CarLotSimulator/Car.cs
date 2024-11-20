using System;
using System.Xml.Schema;
using Microsoft.VisualBasic;

namespace CarLotSimulator;

public class Car
{
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise { get; set; }
    public bool IsDriveable { get; set; }

    public void MakeEngineNoise(string engineNoise)
    {
        Console.WriteLine($"The {Year} {Make} {Model} is making a weird {engineNoise}.");
    }

    public void MakeHonkNoise(string honkNoise)
    {
        Console.WriteLine($"The {Year} {Make} {Model} is making a weird {honkNoise}.");
    }
    public Car(string make, string model, )
}