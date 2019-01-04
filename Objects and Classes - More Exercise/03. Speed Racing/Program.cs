using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < carsCount; i++)
            {
                string[] data = Console.ReadLine().Split();
                cars.Add(new Car(data));
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] tokens = input.Split();
                string carModel = tokens[1];
                int amountOfKm = int.Parse(tokens[2]);

                cars.Find(x => x.Model == carModel).Drive(amountOfKm);

                input = Console.ReadLine();
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TraveledDistance}");
            }
        }
    }

    class Car
    {
        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionFor1Km { get; set; }

        public double TraveledDistance { get; set; }

        public Car(string[] carInfo)
        {
            this.Model = carInfo[0];
            this.FuelAmount = double.Parse(carInfo[1]);
            this.FuelConsumptionFor1Km = double.Parse(carInfo[2]);
        }

        public void Drive(double amountOfKm)
        {
            double fuelNeeded = amountOfKm * this.FuelConsumptionFor1Km;

            if (this.FuelAmount >= fuelNeeded)
            {
                this.FuelAmount -= fuelNeeded;
                this.TraveledDistance += amountOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
