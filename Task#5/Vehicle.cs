using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public abstract class Vehicle
    {
        public abstract string Make { get; set; }
        public abstract string Model { get; set; }
        public abstract int Year{ get; set; }
        public abstract double Price { get; set; }

        public abstract void DisplayInfo();
    }
}
