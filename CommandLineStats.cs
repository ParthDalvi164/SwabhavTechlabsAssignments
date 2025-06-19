using System;

namespace CommandLineStats
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number of elements to be processed : ");
            int count = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[count];
            int average, sum = 0;
            for (int i = 0; i < count; i++)
            {
                Console.Write($"Enter number {i + 1} : ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(array);

            foreach (int num in array) {
                sum = sum + num;
            }

            average = sum / count;

            Console.WriteLine("Total number of elements : " + count);
            Console.WriteLine("Maximum of all the elements : " + array[count - 1]);
            Console.WriteLine("Minimum of all the elements : " + array[0]);
            Console.WriteLine("Average of all the elements : " + average);
        }
    }
}
