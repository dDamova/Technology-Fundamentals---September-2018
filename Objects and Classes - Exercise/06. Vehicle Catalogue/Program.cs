using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _6._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            int carsCount = 0;
            int trucksCount = 0;

            int carsTotalHorsePower = 0;
            int trucksTotalHorsePower = 0;

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] tokens = input.Split();

                Vehicle currentVehicle = new Vehicle(tokens);

                if (currentVehicle.Type.ToLower() == "car")
                {
                    currentVehicle.Type = "Car";

                    carsCount++;
                    carsTotalHorsePower += currentVehicle.HorsePower;
                }
                else if (currentVehicle.Type.ToLower() == "truck")
                {
                    currentVehicle.Type = "Truck";

                    trucksCount++;
                    trucksTotalHorsePower += currentVehicle.HorsePower;
                }

                vehicles.Add(currentVehicle);

                input = Console.ReadLine();
            }
            string modelToPrint = Console.ReadLine();

            while (modelToPrint != "Close the Catalogue")
            {
                foreach (var vehicle in vehicles.Where(v => v.Model == modelToPrint))
                {
                    Console.WriteLine($"Type: {vehicle.Type}");
                    Console.WriteLine($"Model: {vehicle.Model}");
                    Console.WriteLine($"Color: {vehicle.Color}");
                    Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
                }

                modelToPrint = Console.ReadLine();
            }

            double carsAverage = carsTotalHorsePower / (double)carsCount;
            double trucksAverage = trucksTotalHorsePower / (double)trucksCount;

            if (carsCount > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {carsAverage:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }
            if (trucksCount > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {trucksAverage:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
        }
    }

    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

        public Vehicle(string[] vehicleInfo)
        {
            this.Type = vehicleInfo[0];
            this.Model = vehicleInfo[1];
            this.Color = vehicleInfo[2];
            this.HorsePower = int.Parse(vehicleInfo[3]);
        }
    }
}
