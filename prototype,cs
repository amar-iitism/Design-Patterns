public interface IPrototype<T>
{
    T Clone();
}

public class Car : IPrototype<Car>
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    // Constructor
    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    // Clone method implementation
    public Car Clone()
    {
        return (Car)MemberwiseClone(); // Shallow copy
    }

    public override string ToString()
    {
        return $"{Year} {Make} {Model}";
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Create a new Car object (the prototype)
        Car originalCar = new Car("Toyota", "Camry", 2020);

        // Clone the original car to create a new instance
        Car clonedCar = originalCar.Clone();

        // Modify the cloned car
        clonedCar.Year = 2021;

        // Display both cars
        Console.WriteLine("Original Car: " + originalCar);
        Console.WriteLine("Cloned Car: " + clonedCar);
    }
}



