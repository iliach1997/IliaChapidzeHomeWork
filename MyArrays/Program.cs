// See https://aka.ms/new-console-template for more information
namespace IliaChapidzeHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] MyArray = new int[5];
            for (int i = 0; i < MyArray.Length; i++)
            {
         
                Console.WriteLine("Enter a number :");
                MyArray[i] = Convert.ToInt32(Console.ReadLine());

             
               
            }
            Console.WriteLine("------------MAXNUMBER--------------");
            var MaxNum = 0;
            for (int j = 0;j < MyArray.Length; j++)
            {
             
                if (MyArray[j] > MaxNum)
                { 
                    MaxNum = MyArray[j]; 
                  
                }
           
            }  
            Console.WriteLine($"MaxNum: {MaxNum}");
            Console.WriteLine("--------------MINNAMBER--------------");
             var MinNum = MyArray[0];
            for (int g = 0; g < MyArray.Length; g++)
            {   
                
                if (MyArray[g] < MinNum)
                {
                    MinNum = MyArray[g];

                }
      
            }
            Console.WriteLine($"MinNum: {MinNum}"); 
            Console.WriteLine("--------------ArithmetiPass--------------");
            var ArithmetiPass = 0;
            for(int g = 0;g < MyArray.Length; g++)
            {
                ArithmetiPass =ArithmetiPass+MyArray[g];
               
 
                
            } 
            ArithmetiPass =ArithmetiPass / MyArray.Length;

            Console.WriteLine($"ArithmetiPass: {ArithmetiPass}");


            Console.WriteLine("--------------3--------------");
            int[] Arrays = new int[5];
           
            for (int g = 0; g < MyArray.Length; g++)
            {
                var result = MyArray[g] % 3;
                if (result==0)
                {
                  for (int i = 0; i < 5; i++)
                    {
                        Arrays[i] = MyArray[g];
                        Console.WriteLine($"number: {Arrays[i]}");
                    }
                }
              
            }
            
            Console.WriteLine("--------------3--------------");















        }
    }
}