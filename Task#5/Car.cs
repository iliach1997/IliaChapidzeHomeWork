using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Car:Vehicle,IStartable
    {   
        public int NumberOfDoors {  get; set; }
        public int TrunkCapacity {  get; set; }
        public override void DisplayInfo()
        {
            Console.WriteLine($"From Car: Make:{Make} Mode:{Model}  Price:{Price}$ Year:{Year}" +
            $" TrunkCapacity:{TrunkCapacity}L NumberOfDoors:{NumberOfDoors}");
        }
        public void Start()
        {
            Console.WriteLine("engine strart!!!");
        }
        public Car( string make, string model, int year, double price, int numberofdoors, int trunkcapacity) : base(make, model, year, price)
        {
            NumberOfDoors = numberofdoors; 
            TrunkCapacity = trunkcapacity;
        } 
    }
}
