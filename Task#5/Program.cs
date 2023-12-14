namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car=new Car("lexsus","is250",2007,5009,5,430);
            var motorcycle = new Motorcycle("honda", "cbr300", 2007, 2999.99, "sport", "???");
            car.DisplayInfo();
            car.Start();
            var garage = new Garage();
            garage.Addcar(car);
            garage.Addmotorcycle(motorcycle);
            garage.AllVehiclePrint();
            garage.AllPrice();
        }
    }
}
