// CURRENCY CALCULATOR
namespace Assign17June
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num_2000, num_500, num_200, num_100;

            Console.Write("Enter withdrawl amount : ");

            int amount = Convert.ToInt32(Console.ReadLine());

            if (amount > 50000)
            {
                Console.WriteLine("Amount exceeds withdrawal limit of 50000");
            }
            else
            {
                if (amount % 100 != 0)
                {
                    Console.WriteLine("Amount not in multiple of 100");
                }

                else
                {
                    if (amount >= 2000)
                    {
                        num_2000 = amount / 2000;
                        Console.WriteLine("Two thousand :" + num_2000);
                        if (amount % 2000 == 0)
                        {
                            return;
                        }
                        amount = amount % 2000;
                    }

                    if (amount >= 500)
                    {
                        num_500 = amount / 500;
                        Console.WriteLine("Five hundred :" + num_500);
                        if (amount % 500 == 0)
                        {
                            return;
                        }
                        amount = amount % 500;
                    }

                    if (amount >= 200)
                    {
                        num_200 = amount / 200;
                        Console.WriteLine("Two hundred :" + num_200);
                        if (amount % 200 == 0)
                        {
                            return;
                        }
                        amount = amount % 200;
                    }

                    if (amount >= 100)
                    {
                        num_100 = amount / 100;
                        Console.WriteLine("Hundred :" + num_100);
                        if (amount % 100 == 0)
                        {
                            return;
                        }
                        amount = amount % 100;
                    }
                }
            }
        }
    }
}
