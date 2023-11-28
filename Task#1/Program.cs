namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Enter your Name:");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter your LastName:");
            string LastName = Console.ReadLine();
            Console.WriteLine("Enter your Gmail:");
            string UserGmail = Console.ReadLine();
            string FullName = Name + " " + LastName;

            Console.WriteLine(FullName);
            Console.WriteLine(UserGmail);

            //Implicit 
            int a = 5;
            float b = a;
            double c = b;
            //Explicit
            double d = 5.4;
            float f = (float)d;
        }
    }
}
