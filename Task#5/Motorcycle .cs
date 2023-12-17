using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Motorcycle:Vehicle,IStartable
    {
        public string Type {  get; set; }
        public string HasSideCar {  get; set; }
        public override void DisplayInfo()
        {
            Console.WriteLine($"From Motorcycle: Make:{Make} Mode:{Model}  Price:{Price}$ Year:{Year}" +
            $"Type:{Type} HasSideCar:{HasSideCar}");
        }
        public void Start()
        {
            Console.WriteLine("engine strart!!!");
        }
        public Motorcycle(string make, string model, int year, double price, string type, string hassidecar) : base(make, model, year, price)
        {
            Type = type;
            HasSideCar = hassidecar;
        }
    }
}
