namespace ProductApp
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public float Discount { get; set; }
        public float DiscountedPrice { get; set; }

        public Product() 
        {
            Console.Write("Enter the product ID : ");
            this.Id = int.Parse(Console.ReadLine());

            Console.Write("Enter the product name : ");
            this.Name = Console.ReadLine();

            Console.Write("Enter the product price : ");
            this.Price = float.Parse(Console.ReadLine());

            Console.Write("Enter the product discount percentage : ");
            this.Discount = float.Parse(Console.ReadLine());

            this.DiscountedPrice = CostAfterDiscount();
        }

        public float CostAfterDiscount()
        {
            return this.Price - (this.Price * (this.Discount / 100));
        }

        public void DisplayProduct()
        {
            Console.WriteLine($"Product ID : {this.Id}");
            Console.WriteLine($"Product name : {this.Name}");
            Console.WriteLine($"Product price : {this.Price}");
            Console.WriteLine($"Product discount percentage : {this.Discount}");
            Console.WriteLine($"Price after discount : {this.DiscountedPrice}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.DisplayProduct();

            Product p2 = new Product();
            p2.DisplayProduct();
        }
    }
}
