using System;

namespace StringManip
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string : ");
            string userResp = Console.ReadLine();

            string[] subsections = userResp.Split(",");

            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Developer Name : " + subsections[i]);
                }
                if (i == 1)
                {
                    Console.WriteLine("Company Name : " + subsections[i]);
                }
                if (i == 2)
                {
                    Console.WriteLine("Location : " + subsections[i]);
                }
            }

        }
    }
}
