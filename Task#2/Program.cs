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
            Console.WriteLine("____________________");
            Console.WriteLine("Calculkator Program");
            Console.WriteLine("____________________");
            Console.WriteLine("Enter number 1");
            var firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            var secondNumber = Convert.ToDouble(Console.ReadLine());
            Print();
            var option = Console.ReadLine();
            if(firstNumber==0||secondNumber==0)
            {
                Console.WriteLine("ShemoiyvaneT nulisgan gansxvavebuli ricxvi:");
            }
            else
            {
             if (option == "+")
            {
               var result = firstNumber + secondNumber;
                Console.WriteLine($"Your result {result}");
            }
            else if (option == "-")
            {
               var result = firstNumber - secondNumber;
                Console.WriteLine($"Your result {result}");
            }
            else if (option == "*")
            {
               var result = firstNumber * secondNumber;
                Console.WriteLine($"Your result {result}");
            }
            else if (option == "/")
            {
              var  result = firstNumber / secondNumber;
                Console.WriteLine($"Your result {result}");
            }
            else
            {
                Console.WriteLine("Error your cherecter not machted!!!");
            }}
            Console.WriteLine("---------------------------------");
            Console.WriteLine("calculator from switch");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Enter number 1");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            Print();
            switch (Console.ReadLine())
            {
                case "+":
                   var result = firstNumber + secondNumber;
                    Console.WriteLine($"Your result {result}");
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    Console.WriteLine($"Your result {result}");
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    Console.WriteLine($"Your result {result}");
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    Console.WriteLine($"Your result {result}");
                    break;
            }
            Console.ReadKey();
        }
    }
}
