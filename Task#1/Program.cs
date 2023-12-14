namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Enter your Name:");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter your LastName:");
            var lastName = Console.ReadLine();
            Console.WriteLine("Enter your Gmail:");
            var userGmail = Console.ReadLine();
            var fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);
            Console.WriteLine(userGmail);
            var a = 5;
            var b = a;
            var c = b;
            var d = 5.4;
            var f = (float)d;
        }
    }
}
