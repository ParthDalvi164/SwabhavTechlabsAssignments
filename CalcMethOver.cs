using System;

namespace CalcMethOver
{
    internal class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static int Add(int[] numbers)
        {
            if (numbers == null)
            {
                Console.WriteLine("Invalid input: array is null or empty.");
                return 0;
            } 
            int sum = 0;
            for (int i = 0; i < 4; i++)
            {
                sum = sum + numbers[i];
            }
            return sum;
        }
        
        public static void Main(string[] args)
        {
            int a = 1, b = 2;
            int result = Add(a, b);
            Console.WriteLine($"Adding two integers : {a} + {b}");
            Console.WriteLine("Result : " + result);

            double a1 = 4.56, b1 = 6.789;
            double result1 = Add(a1, b1);
            Console.WriteLine($"Adding two doubles : {a1} + {b1}");
            Console.WriteLine("Result : " + result1);

            int[] array1 = { 1, 2, 4, 5 };
            int result2 = Add(array1);
            Console.WriteLine($"Adding array of integers : {array1[0]} + {array1[1]} + {array1[2]} + {array1[3]}");
            Console.WriteLine("Result : " + result2);

            int[] array = null;
            int result3 = Add(array);
            Console.WriteLine("Result : " + result3);
        }
    }
}
