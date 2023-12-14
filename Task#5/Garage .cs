using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Garage:IGarage
    {
        public List<Car> cars = new List<Car>()
        {
          new Car()
          {
             Make="Lexus",
             Model="is250",
             Year=2007,
             Price=5400,
             NumberOfDoors=5,
             TrunkCapacity=400
          },
             new Car()
          {
             Make="Lexus",
             Model="F92",
             Year=2009,
             Price=7500,
             NumberOfDoors=5,
             TrunkCapacity=400
          },
             new Car()
          {
             Make="BMW",
             Model="G80",
             Year=2021,
             Price=54000,
             NumberOfDoors=5,
             TrunkCapacity=400
          },
        };
        public List<Motorcycle> motorcycles = new List<Motorcycle>()
        {
            new Motorcycle()
            {
             Make="Honda",
             Model="R1000",
             Year=2021,
             Price=24000,
             HasSideCar="???",
             Type="sport"
            }
        };
        public void Addcar(Car car)
        {
            cars.Add(car);
            Console.WriteLine("car add to garage!!!");
        }
        public void Addmotorcycle(Motorcycle motorcycle)
        {
            motorcycles.Add(motorcycle);
            Console.WriteLine("motorcycle add to garage!!!");
        }
        public void AllVehiclePrint()
        {
            var count = 0;
            foreach (var car in cars)
            {   
                count++;
                Console.WriteLine($"{count}) Mode:{car.Model} Make{car.Make} Price:{car.Price}$ Year:{car.Year}" +
                $" TrunkCapacity:{car.TrunkCapacity}L NumberOfDoors:{car.NumberOfDoors}");
            }
            foreach(var motorcycle in motorcycles)
            {
                count++;
                Console.WriteLine($"{count}) Mode:{motorcycle.Model} Make{motorcycle.Make} Price:{motorcycle.Price}$ Year:{motorcycle.Year}" +
                $"HasSideCar:{motorcycle.HasSideCar} Type:{motorcycle.Type}");
            }
        }
        public void AllPrice()
        {   double allprice = 0;
            for (int i = 0; i < cars.Count; i++)
            {
                allprice=allprice+ cars[i].Price;
            }
            for (int i = 0; i < motorcycles.Count; i++)
            {
                allprice = allprice + motorcycles[i].Price;
            }
            Console.WriteLine($"All vehicle price:{allprice}");
        }
        public Garage() { 
        
        }
    }
}
