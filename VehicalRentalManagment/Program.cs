using System;
using VehicalRentalManagment;

class Program
{
    static void Main(string[] args)  
    {
        // Create vehicles
        Car car1 = new Car("Toyota Camry", "Toyota", 2018, 50.00, 5, "V6", "Automatic", false);
        Truck truck1 = new Truck("Ford F-150", "Ford", 2020, 80.00, 2, "Pickup", true);
        Motorcycle motorcycle1 = new Motorcycle("Honda CBR600RR", "Honda", 2021, 30.00, 600, "Gasoline", true);

        // Create rental agency
        RentalAgency rentalAgency = new RentalAgency();

        // Add vehicles to fleet
        rentalAgency.AddVehicle(car1);
        rentalAgency.AddVehicle(truck1); 
        rentalAgency.AddVehicle(motorcycle1);

        // Display fleet details

        // Rent a vehicle        rentalAgency.DisplayFleet();

        rentalAgency.RentVehicle(truck1);

        // Display updated fleet details
        Console.WriteLine("\nAfter Renting a Vehicle:");
        rentalAgency.DisplayFleet();

        // Display total revenue
        Console.WriteLine($"\nTotal Revenue: {rentalAgency.TotalRevenue:C}");


    }
}

