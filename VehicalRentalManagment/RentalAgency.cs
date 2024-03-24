using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicalRentalManagment
{
    public class RentalAgency
    {
        // Properties
        private List<Vehicle> Fleet { get; set; }
        public double TotalRevenue { get; private set; }

        // Constructor
        public RentalAgency()
        {
            Fleet = new List<Vehicle>();
            TotalRevenue = 0;
        }

        // Method to add vehicles to the fleet
        public void AddVehicle(Vehicle vehicle)
        {
            Fleet.Add(vehicle);
        }

        // Method to remove vehicles from the fleet
        public void RemoveVehicle(Vehicle vehicle)
        {
            Fleet.Remove(vehicle);
        }

        // Method to rent a vehicle
        public void RentVehicle(Vehicle vehicle)
        {
            Fleet.Remove(vehicle);
            TotalRevenue += vehicle.RentalPrice;
        }

        // Method to display details of vehicles in the fleet
        public void DisplayFleet()
        {
            Console.WriteLine("Vehicles in Fleet:");
            foreach (var vehicle in Fleet)
            {
                Console.WriteLine("------------------------------------");
                vehicle.DisplayDetails();
                Console.WriteLine("------------------------------------");
            }
        }
    }
}
