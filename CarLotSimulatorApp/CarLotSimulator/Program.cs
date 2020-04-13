using System;

namespace CarLotSimulator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            CarLot cars = new CarLot();
            Car firstCar = new Car();
            Car secondCar = new Car();
            Car thirdCar = new Car();

            firstCar.Year = 2019;
            firstCar.Make = "Kia";
            firstCar.Model = "Forte";
            firstCar.EngineNoise = "Quiet";
            firstCar.HonkNoise = "Loud";
            firstCar.IsDriveable = true;
            cars.carList.Add(firstCar);
            
            secondCar.Year = 2014;
            secondCar.Make = "Ford";
            secondCar.Model = "Explorer";
            secondCar.EngineNoise = "Quiet";
            secondCar.HonkNoise = "Very Loud";
            secondCar.IsDriveable = true;
            cars.carList.Add(secondCar);

            thirdCar.Year = 1966;
            thirdCar.Make = "Ford";
            thirdCar.Model = "Galaxie 500";
            thirdCar.EngineNoise = "Loud";
            thirdCar.HonkNoise = "Low";
            thirdCar.IsDriveable = true;
            cars.carList.Add(thirdCar);

            firstCar.MakeEngineNoise();
            firstCar.MakeHonkNoise();
            
            secondCar.MakeEngineNoise();
            secondCar.MakeHonkNoise();

            thirdCar.MakeEngineNoise();
            thirdCar.MakeHonkNoise();

            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            foreach (var car in cars.carList)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
               


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//


        }
    }
}
