namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] MyArray = new int[5];
            for (var i = 0; i < MyArray.Length; i++)
            {
                Console.WriteLine("Enter a number :");
                MyArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("------------MAXNUMBER--------------");
            var MaxNum = 0;
            for (var i = 0; i < MyArray.Length; i++)
            {
                if (MyArray[i] > MaxNum)
                {
                    MaxNum = MyArray[i];
                }
            }
            Console.WriteLine($"MaxNum: {MaxNum}");
            Console.WriteLine("--------------MINNAMBER--------------");
            var MinNum = MyArray[0];
            for (var i = 0; i < MyArray.Length; i++)
            {
                if (MyArray[i] < MinNum)
                {
                    MinNum = MyArray[i];
                }
            }
            Console.WriteLine($"MinNum: {MinNum}");
            Console.WriteLine("--------------ArithmetiPass--------------");
            var average = 0;
            for (int i = 0; i < MyArray.Length; i++)
            {
                average = average + MyArray[i];
            }
            average = average / MyArray.Length;
            Console.WriteLine($"Average: {average}");
            Console.WriteLine("--------------3--------------");
            int[] Arrays = new int[5];
            for (var j = 0; j < MyArray.Length; j++)
            {
                var result = MyArray[j] % 3;
                if (result == 0)
                {
                    for (var i = 0; i < 5; i++)
                    {
                        Arrays[i] = MyArray[j];
                        Console.WriteLine($"number: {Arrays[i]}");
                    }
                }
            }
            Console.WriteLine("--------------3--------------");
        }
    }
}
