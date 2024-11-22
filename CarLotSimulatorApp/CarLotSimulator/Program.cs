﻿using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLotOne = new CarLot();
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            
            //DotNotation
            var carOne = new Car();
            carOne.Make = "Chevrolet";
            carOne.Model = "Chevelle";
            carOne.Year = 1970;
            carOne.IsDriveable = true;
            
            carOne.MakeEngineNoise("Vroom");
            carOne.MakeHonkNoise("Honk");
            
            carLotOne.ParkingLot.Add(carOne);
            
            //ObjectInitializer
            var carTwo = new Car()
            {
                Make = "Plymouth",
                Model = "Hemicuda",
                Year = 1971,
                IsDriveable = true
            };
            
            carTwo.MakeEngineNoise("Vroomity");
            carTwo.MakeHonkNoise("Honkity");
            
                carLotOne.ParkingLot.Add(carTwo);

                var carThree = new Car("Chevrolet", "silverado", 1974, true);

                carThree.MakeEngineNoise("Vroomity yikes");
                carThree.MakeHonkNoise("Honkity oops");
                
            carLotOne.ParkingLot.Add(carThree);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine($"Number of cars created: {CarLot._numberOfCars}");
        }
    }
}
