// FACTORIAL OF A NUMBER
namespace Assign17June
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number whose factorial is to be calculated : ");

            int number = Convert.ToInt32(Console.ReadLine());

            int prod = 1;

            for (int i = 1; i <= number; i++)
            {
                prod = prod * i;
            }

            Console.WriteLine($"Factorial of {number} is : " + prod);
        }
    }
}
