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
      private List<Car> cars = new List<Car>();
      private List<Motorcycle> motorcycles = new List<Motorcycle>();
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
        public void PrintVehicles()
        {
            var count = 0;
            foreach (var car in cars)
            {   
                count++;
                Console.WriteLine($"{count}) Make:{car.Make} Mode:{car.Model} Price:{car.Price}$ Year:{car.Year}" +
                $" TrunkCapacity:{car.TrunkCapacity}L NumberOfDoors:{car.NumberOfDoors}");
            }
            foreach(var motorcycle in motorcycles)
            {
                count++;
                Console.WriteLine($"{count}) Make{motorcycle.Make} Mode:{motorcycle.Model}  Price:{motorcycle.Price}$ Year:{motorcycle.Year}" +
                $"HasSideCar:{motorcycle.HasSideCar} Type:{motorcycle.Type}");
            }
        }
        public void CountTotalPrice()
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
    }
}
