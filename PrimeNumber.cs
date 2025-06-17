// PRIME NUMBER CHECK
namespace Assign17June
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to be checked as prime or not : ");

            int number = Convert.ToInt32(Console.ReadLine());

            bool isPrime = true;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"{number} is a prime number");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number");
            }
        }
    }
}
