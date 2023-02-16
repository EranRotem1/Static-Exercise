using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public class CarLot
    {
        public static int NumberOfCars;

    }

    public class Car
    {
        public int numberOfWheels = 4;
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public Car(string make, string model, int year) 
        {
            Make = make;
            Model = model;
            Year = year;
            CarLot.NumberOfCars++;
        }
    }
}
