namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            for (var i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter a number :");
               array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("------------MAXNUMBER--------------");
            var maxNum = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] > maxNum)
                {
                    maxNum = array[i];
                }
            }
            Console.WriteLine($"MaxNum: {maxNum}");
            Console.WriteLine("--------------MINNAMBER--------------");
            var minNum = array[0];
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] < minNum)
                {
                    minNum = array[i];
                }
            }
            Console.WriteLine($"MinNum: {minNum}");
            Console.WriteLine("--------------ArithmetiPass--------------");
            var average = 0;
            for (int i = 0; i < array.Length; i++)
            {
                average = average + array[i];
            }
            average = average / array.Length;
            Console.WriteLine($"Average: {average}");
            Console.WriteLine("--------------3--------------");
            int[] Arrays = new int[5];
            for (var j = 0; j < array.Length; j++)
            {
                var result = array[j] % 3;
                if (result == 0)
                {
                    for (var i = 0; i < 5; i++)
                    {
                        Arrays[i] = array[j];
                        Console.WriteLine($"number: {Arrays[i]}");
                    }
                }
            }
            Console.WriteLine("--------------3--------------");
        }
    }
}
