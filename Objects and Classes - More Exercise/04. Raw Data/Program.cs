using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < carsCount; i++)
            {
                string[] carInfo = Console.ReadLine().Split();

                cars.Add(new Car(carInfo));
            }

            string type = Console.ReadLine();

            if (type == "fragile")
            {
                foreach (var car in cars.Where(c => c.CarsCargo.Type == "fragile" && c.CarsCargo.Weight < 1000))
                {
                    Console.WriteLine(car.Model);
                }
            }
            else if (type == "flamable")
            {
                foreach (var car in cars.Where(c => c.CarsCargo.Type == "flamable" && c.CarsEngine.Power > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }

    class Engine
    {
        public int Speed { get; set; }

        public int Power { get; set; }

        public Engine(int speed, int power)
        {
            this.Speed = speed;
            this.Power = power;
        }
    }

    class Cargo
    {
        public int Weight { get; set; }

        public string Type { get; set; }

        public Cargo(int weight, string type)
        {
            this.Weight = weight;
            this.Type = type;
        }
    }

    class Car
    {
        public string Model { get; set; }

        public Engine CarsEngine { get; set; }

        public Cargo CarsCargo { get; set; }

        public Car(string[] carInfo)
        {
            this.Model = carInfo[0];
            this.CarsEngine = new Engine(int.Parse(carInfo[1]), int.Parse(carInfo[2]));
            this.CarsCargo = new Cargo(int.Parse(carInfo[3]), carInfo[4]);
        }
    }
}
