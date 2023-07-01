namespace Classes
{
    public class Program
    {
         static void Main(string[] args)
         {
            Car myCar = new Car();
            myCar.Make = "Chevrolet";
            myCar.Model = "Tahoe";
            myCar.Year = 2018;

            Console.WriteLine($"My new car is a {myCar.Year} {myCar.Make} {myCar.Model}");
         }
    }
}
