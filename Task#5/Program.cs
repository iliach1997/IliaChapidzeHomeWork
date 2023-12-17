namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car=new Car("lexus","is250",2007,5400,5,400);
            var car1 = new Car("BMW", "G80", 2020, 74500, 5, 400);
            var motorcycle = new Motorcycle("honda", "cbr300", 2007, 2999, "sport", "???");
            car.DisplayInfo();
            car.Start();
            motorcycle.DisplayInfo();
            motorcycle.Start();
            var garage = new Garage();
            garage.Addcar(car);
            garage.Addcar(car1);
            garage.Addmotorcycle(motorcycle);
            garage.PrintVehicles();
            garage.CountTotalPrice();
            Console.ReadKey();
        }
    }
}
