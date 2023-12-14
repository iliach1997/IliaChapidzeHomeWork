using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Motorcycle:Vehicle,IStartable
    {
        public override string Make { get; set; }
        public override string Model { get; set; }
        public override int Year { get; set; }
        public override double Price { get; set; }
        public string Type {  get; set; }
        public string HasSideCar {  get; set; }
        public override void DisplayInfo()
        {
            Console.WriteLine($"{Make}{Model}");
        }
        public void Start()
        {
            Console.WriteLine("engine strart!!!");
        }
        public Motorcycle(string make, string model, int year, double price, string type, string hassidecar)
        {
            Make = make;
            Model = model;
            Price = price;
            Year = year;
            Type = type;
            HasSideCar = hassidecar;
        }
        public Motorcycle()
        {
        }
    }
}
