// PALINDROME CHECK
namespace Assign20June
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to be checked as palindrome or not : ");

            int number = Convert.ToInt32(Console.ReadLine());

            int reverseNumber = 0, buffer = number;

            while (number != 0)
            {
                int rem = number % 10;
                reverseNumber = reverseNumber * 10 + rem;
                number = number / 10;
            }

            if (reverseNumber == buffer) 
            {
                Console.WriteLine($"{buffer} is a plaindrome");
            }
            else 
            {
                Console.WriteLine($"{buffer} is not a palindrome");
            }
        }
    }
}
