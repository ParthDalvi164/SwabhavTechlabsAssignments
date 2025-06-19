namespace RandomNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string userResp = "yes";
            Console.WriteLine("Random number generator game");
            
            
            while (userResp != "no")
            {
                Random random = new Random();
                int randNumber = random.Next(1, 101);
                Console.WriteLine("Random number generated : " + randNumber);
                RandomNumberGenerator(randNumber, count, out userResp);
            }
        }



        public static void RandomNumberGenerator(int randNumber, int count, out string userResp)
        {
            userResp = "";
            Console.Write("Guess a number : ");
            int userGuess = Convert.ToInt32(Console.ReadLine());
            count++;

            if (userGuess == randNumber)
            {
                Console.WriteLine($"You won in {count} attempts");
                Console.Write("Do you want ro play the game again?");
                userResp = Console.ReadLine();
                return;
            }
            Console.WriteLine("You guessed it wrong");
            if(count >= 5)
            {
                userResp = "no";
                return;
            }
            RandomNumberGenerator(randNumber, count, out userResp);
        }
    }
}
