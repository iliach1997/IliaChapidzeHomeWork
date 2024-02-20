namespace Task_61
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
            var honor = new Product("honor90", 10, 3, 2, ProductCategory.Electronics);
            Console.WriteLine(honor.GetProductInfo()); 
            Console.WriteLine(honor.CalculateDiscountedPrice());
            var apple = new DiscountedProduct("15pro max", 5999, 3, 2, ProductCategory.Electronics);
            Console.WriteLine(apple.GetProductInfo());
            Console.WriteLine(apple.CalculateDiscountedPrice());
                var inventory = new Inventory();
                inventory.add(apple);
                inventory.add(honor);
            Console.WriteLine("***********");
                var product = inventory.GetById(0);
                Console.WriteLine(product.Name);
                Console.ReadKey();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
