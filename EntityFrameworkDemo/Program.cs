
namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // GetAll();
            GetAllByCategoryId(1);

        }

        private static void GetAll()
        {
            NorthwindContext context = new NorthwindContext();
            foreach (var item in context.Products)
            {
                Console.WriteLine(item.ProductName);
            }
        }
        private static void GetAllByCategoryId(int categoryId)
        {
            NorthwindContext context = new NorthwindContext();
            var result= context.Products.Where(p=> p.CategoryId == categoryId);
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }
        }
    }
}