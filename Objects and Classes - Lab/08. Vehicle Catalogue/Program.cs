using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            CatalogVehicle catalog = new CatalogVehicle();

            while (input != "end")
            {
                string[] tokens = input.Split("/");

                catalog.AddNewVehicle(tokens);
                input = Console.ReadLine();
            }

            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");

                foreach (Car car in catalog.Cars.OrderBy(c => c.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");

                foreach (Truck truck in catalog.Trucks.OrderBy(t => t.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }

    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }

        public Truck(string[] tokens)
        {
            this.Brand = tokens[1];
            this.Model = tokens[2];
            this.Weight = int.Parse(tokens[3]);
        }
    }

    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }

        public Car(string[] tokens)
        {
            this.Brand = tokens[1];
            this.Model = tokens[2];
            this.HorsePower = int.Parse(tokens[3]);
        }
    }

    class CatalogVehicle
    {
        public List<Car> Cars { get; set; } = new List<Car>();
        public List<Truck> Trucks { get; set; } = new List<Truck>();

        public void AddNewVehicle(string[] tokens)
        {
            string type = tokens[0];

            if (type == "Car")
            {
                this.Cars.Add(new Car(tokens));
            }
            else
            {
                this.Trucks.Add(new Truck(tokens));
            }
        }
    }
}
