namespace Task_2
{
    internal class Program
    {
        static void Print()
        {


            Console.WriteLine("Enter option:");
            Console.WriteLine("\t+: Add");
            Console.WriteLine("\t-: Subtract");
            Console.WriteLine("\t*: Multiply");
            Console.WriteLine("\t/: Divide");
        }
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            double result = 0;
            Console.WriteLine("____________________");
            Console.WriteLine("Calculkator Program");
            Console.WriteLine("____________________");
            Console.WriteLine("Enter number 1");





            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            num2 = Convert.ToDouble(Console.ReadLine());
            Print();
            string option = Console.ReadLine();
            if (option == "+")
            {
                result = num1 + num2;
                Console.WriteLine($"Your result {result}");
            }
            else if (option == "-")
            {
                result = num1 - num2;
                Console.WriteLine($"Your result {result}");
            }
            else if (option == "*")
            {
                result = num1 * num2;
                Console.WriteLine($"Your result {result}");
            }
            else if (option == "/")
            {
                result = num1 / num2;
                Console.WriteLine($"Your result {result}");
            }
            else
            {
                Console.WriteLine("Error your cherecter not machted!!!");
            }

            Console.WriteLine("---------------------------------");
            Console.WriteLine("calculator from switch");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Enter number 1");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            num2 = Convert.ToDouble(Console.ReadLine());
            Print();

            switch (Console.ReadLine())
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"Your result {result}");
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"Your result {result}");
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"Your result {result}");
                    break;
                case "/":
                    result = num1 / num2;
                    Console.WriteLine($"Your result {result}");
                    break;
            }
            Console.ReadKey();
        }
    }
}
