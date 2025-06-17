// REVERSE A NUMBER
namespace Assign20June
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to be reversed : ");

            int number = Convert.ToInt32(Console.ReadLine());

            int reverseNumber = 0;

            while (number != 0) 
            {
                int rem = number % 10;
                reverseNumber = reverseNumber * 10 + rem;    
                number = number / 10;
            }

            Console.WriteLine("Reversed number is : " + reverseNumber);
        }
    }
}
