using System;

namespace BookDiscountCalc
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Book b1 = new Book();
            Book b2 = new Book();

            b1.title = "Psychology of money";
            b1.author = "Morgan Housel";
            b1.price = 600;
            b1.isBestseller = true;

            b1.DisplayDetails();
            b1.CalculateDiscountedPrice();

            b2.title = "The art of war";
            b2.author = "Sun Tzu";
            b2.price = 200;
            b2.isBestseller = false;

            b2.DisplayDetails();
            b2.CalculateDiscountedPrice();
        }
    }

    public class Book
    {
        public string title, author;
        public double price;
        public bool isBestseller;

        public void CalculateDiscountedPrice()
        {
            double originalPrice = price;
            if (isBestseller)
            {
                Console.WriteLine($"The book {title} is a bestseller. Applying 10% discount!");
                price = price - (price * 0.1);
            }
            if (originalPrice > 500)
            {
                Console.WriteLine($"The book {title} is a bestseller. Applying additional 5% discount!");
                price = price - (price * 0.05);
            }
            Console.WriteLine("Final discounted price : " + price);
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Title : " + title);
            Console.WriteLine("Author : " + author);
            Console.WriteLine("Original Price : " + price);
            Console.WriteLine("Author : " + author);
        }
    }
}
