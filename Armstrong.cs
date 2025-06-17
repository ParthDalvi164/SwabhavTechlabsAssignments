// ARMSTRONG NUMBER
namespace Assign20June
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to be checked as armstrong or not : ");

            int number = Convert.ToInt32(Console.ReadLine());

            int buffer = number, digit = 0, expoSum = 0;

            while (buffer != 0)
            {
                buffer = buffer / 10;
                digit++;
            }

            buffer = number;

            while(buffer != 0)
            {
                int rem = buffer % 10;
                expoSum = expoSum + Convert.ToInt32(Math.Pow(rem, digit));
                buffer = buffer / 10;
            }

            if (number == expoSum)
            {
                Console.WriteLine($"{number} is an armstrong number");
            }
            else 
            {
                Console.WriteLine($"{number} is not an armstrong number");
            }
        }
    }
}
