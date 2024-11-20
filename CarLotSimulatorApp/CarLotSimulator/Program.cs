using System;

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
            carOne.EngineNoise = "knocking";
            carOne.HonkNoise = "very loud";
            carOne.IsDriveable = true;
            
            carLotOne.ParkingLot.Add(carOne);
            
            //ObjectInitializer
            var carTwo = new Car()
            {
                Make = "Plymouth",
                Model = "Hemicude",
                Year = 1971,
                EngineNoise = "Bump",
                HonkNoise = "beep",
                IsDriveable = true
            };
                
                carLotOne.ParkingLot.Add(carTwo);

                var carThree = new Car()

                {
                    Make = "Chevrolet",
                    Model = "Silverado",
                    Year = 1974,
                    EngineNoise = "Bump",
                    HonkNoise = "beep",
                    IsDriveable = true
                };
            carLotOne.ParkingLot.Add(carThree);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
