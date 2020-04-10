using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
    //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
    //The methods should take one string parameter: the respective noise property
    class Car
    {
        public Car()
        {

        }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public string MakeEngineNoise()
        {
            return EngineNoise;
        }
        public string MakeHonkNoise()
        {
            return HonkNoise;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Year: {Year}, Make: {Make}, Model: {Model}");
        }
    }
}
