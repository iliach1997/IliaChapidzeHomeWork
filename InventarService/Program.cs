namespace InventarService
{
    public class Program
    {
        static void Main(string[] args)
        {

            var categoryRepository = new CategoryRepository();
            var categoryService = new CategoryService(categoryRepository);
            var productRepository=new ProductRrepository();
            var productService = new ProductService(productRepository);

            var categoryPhone= categoryService.GetByID(1);
            var categoryLaptop=categoryService.GetByID(2);

            
            var ct = new Category()
            {
                Id = 1,
                Name = "Phone",
            };
            var honor = new Product()
            {
                Id = 1,
                Name = "Honor",
                Description = "90",
                Category = categoryPhone,
            };
            var Samsung = new Product()
            {
                Id = 1,
                Name = "sumsung",
                Description = "a72",
                Category = categoryPhone,
                Quantity = 123,
            };
            var php = new Product()
            {
                Id = 1,
                Name = "php",
                Description = "x9023",
                Category = categoryLaptop,
                Quantity = 9,
            };
            productService.Add(honor);
            productService.Add(php);
            productService.getByCategoryName("Leptop");
            productService.getByCategoryName("Phone");
            productService.GetAll();
        }
    }
}
