using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public abstract class Vehicle
    {   
      
        public  Vehicle(string make, string model, int year, double price) {
            Make = make;
            Model = model;
            Year = year;
            Price= price;
        }
        public string Make { get; set; }
        public string Model { get; set; } 
        public int Year{ get; set; }
        public double Price { get; set; }
        public abstract void DisplayInfo();
    }
}
