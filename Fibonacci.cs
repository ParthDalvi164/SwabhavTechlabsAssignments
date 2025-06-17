// FIBONACCI SERIES TILL NTH FIBONACCI
namespace Assign20June
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of fibonacci series : ");

            int number = Convert.ToInt32(Console.ReadLine());

            int num1 = 1, num2 = 1;

            if (number == 1) 
            {
                Console.WriteLine($"Fibonacci series till 1st element : {num1}");
                return;
            }

            if (number == 2)
            {
                Console.WriteLine($"Fibonacci series till 2nd element : {num1} {num2}");
                return;
            }

            Console.Write($"Fibonacci Series till {number}th element : ");

            Console.Write(num1 + " ");
            Console.Write(num2 + " ");

            for (int i = 2; i < number; i++)
            {
                int temp = num1 + num2;
                num1 = num2;
                num2 = temp;
                Console.Write(temp + " ");
            }
        }
    }
}
