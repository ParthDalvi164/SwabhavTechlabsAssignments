using System;

namespace PigDice
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int total = 0, turnCount = 0;
            Console.WriteLine("PIG DICE GAME");
            Console.WriteLine("-------------");

            while (total < 20)
            {
                Console.WriteLine("-------------");
                Console.WriteLine($"TURN {turnCount + 1} : ");
                Console.WriteLine("-------------");
                turnCount++;
                TakeTurn(ref total);
            }

            Console.WriteLine($"You finished in {turnCount} turns!");
        }

        public static void TakeTurn(ref int total)
        {
            int currentTotal = 0;
            Console.Write("Roll or Hold? (r/h) -> ");
            string userResp = Console.ReadLine();

            if (userResp == "r")
            {
                Random random = new Random();
                int randNumber = random.Next(1, 7);

                Console.WriteLine("Die : " + randNumber);

                if (randNumber == 1)
                {
                    Console.WriteLine("Turn over. No Score!!!");
                    currentTotal = 0;
                    return;
                }
                currentTotal = currentTotal + randNumber;
                TakeTurn(ref total);
            }

            total = total + currentTotal;
            return;
        }
    }
}
