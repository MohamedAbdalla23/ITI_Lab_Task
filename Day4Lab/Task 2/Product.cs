
namespace Day4Lab.Task_2
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Category Category { get; set; }
        public double Price { get; set; }
        public Size ProductSize { get; set; }

        public Product(int id, string name, Category category, double price, Size size)
        {
            Id = id;
            Name = name;
            Category = category;
            Price = price;
            ProductSize = size;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Product: {Name}\nCategory: {Category}\nPrice: {Price}\nSize: {ProductSize.Width}x{ProductSize.Height}x{ProductSize.Depth} cm\n\n");
        }

        public static double GetTotalPrice(Product[] products)
        {
            double total = 0;
            foreach (var product in products)
            {
                total += product.Price;
            }
            return total;

        }
    }
}
