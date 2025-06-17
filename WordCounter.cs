// WORD COUNT
namespace Assign17June
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the sentence to be checked : ");

            string sentence = Console.ReadLine();

            int count = 0;

            foreach (char character in sentence)
            {
                if (character == ' ')
                {
                    count++;
                }
            }

            Console.WriteLine("The number of words is : " + (count + 1));
        }
    }
}
