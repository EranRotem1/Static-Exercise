namespace StaticExercise
{
    public static class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(TempConverter.FahrenheitToCelcius(32));
            Console.WriteLine(TempConverter.CelciusToFahrenheit(0));
            
            Console.WriteLine();
            
            Car car1 = new Car("Honda", "Civic", 2008);
            Console.WriteLine(CarLot.NumberOfCars);
            Car car2 = new Car("Toyota", "Prius", 2014);
            Console.WriteLine(CarLot.NumberOfCars);
            Car car3 = new Car("Ford", "Runner", 2018);
            Console.WriteLine(CarLot.NumberOfCars);
        }
    }
}
