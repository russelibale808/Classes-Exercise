namespace Classes
{
    public class Program
    {

        static void Main(string[] args)
        {
            Car myFirstCar = new Car();


            myFirstCar.Name = "Nissan";
            myFirstCar.Model = "Sentra SR";
            myFirstCar.Year = "2014";

            Console.WriteLine($" My first car is a {myFirstCar.Name}." +
                              $" I got the {myFirstCar.Model} model," +
                              $" which is {myFirstCar.Year} version." );

        }
    }
}
