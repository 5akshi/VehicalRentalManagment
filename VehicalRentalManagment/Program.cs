using System;
using VehicalRentalManagment;

class Program
{
    static void Main(string[] args)
    {
        // Test the implementation
        Vehicle car = new Car("Civic", "Honda", 2020, 50.00m, 5, "Gas", "Automatic", false);
        Truck truck = new Truck("F-150", "Ford", 2018, 80.00m, 4, "Pickup", true);
        Motorcycle motorcycle = new Motorcycle("Ninja", "Kawasaki", 2019, 40.00m, 1000, "Gas", true);

        RentalAgency rental = new RentalAgency(10);

        rental.AddVehicle(car);


        car.DisplayDetails();
        Console.WriteLine();

        truck.DisplayDetails();
        Console.WriteLine();

        motorcycle.DisplayDetails();
        Console.WriteLine();
    }
}

