using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CarLotSimulator;

public class CarLot
{
    public CarLot()
    {
    }

    public static int _numberOfCars = 1;
    public List<Car> ParkingLot { get; set; } = new List<Car>();

    public void CheckCars()
    {
        foreach (var vehicle in ParkingLot)
        {
            Console.WriteLine($"This vehicle is a {vehicle.Year} {vehicle.Make} {vehicle.Model}");
            vehicle.MakeEngineNoise(vehicle.EngineNoise);
            vehicle.MakeHonkNoise(vehicle.HonkNoise);
            Console.WriteLine("------------------");
        }
    }
}