using System;

namespace PigDiceCalesthenics
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Game game = new Game();
            game.Start();
        }
    }

    class Game
    {
        private TotalScore totalScore;
        private TurnCounter turnCounter;

        public Game()
        {
            totalScore = new TotalScore();
            turnCounter = new TurnCounter();
        }

        public void Start()
        {
            Console.WriteLine("PIG DICE GAME");
            Console.WriteLine("-------------");

            while (!totalScore.HasReachedTarget())
            {
                DisplayTurnHeader();
                Turn turn = new Turn();
                turn.Play(totalScore);
                turnCounter.Increment();
            }

            Console.WriteLine($"You finished in {turnCounter.GetCount()} turns!");
        }

        private void DisplayTurnHeader()
        {
            Console.WriteLine("-------------");
            Console.WriteLine($"TURN {turnCounter.NextTurnNumber()} : ");
            Console.WriteLine("-------------");
        }
    }

    class TotalScore
    {
        private int value = 0;
        private const int Target = 20;

        public void Add(int amount)
        {
            value += amount;
        }

        public bool HasReachedTarget()
        {
            return value >= Target;
        }
    }

    class TurnCounter
    {
        private int count = 0;

        public void Increment()
        {
            count++;
        }

        public int GetCount()
        {
            return count;
        }

        public int NextTurnNumber()
        {
            return count + 1;
        }
    }

    class Turn
    {
        private int currentTurnScore = 0;
        private Dice dice;
        private UserInput userInput;

        public Turn()
        {
            dice = new Dice();
            userInput = new UserInput();
        }

        public void Play(TotalScore totalScore)
        {
            string choice = userInput.GetChoice();

            if (choice == "r")
            {
                int dieValue = dice.Roll();

                Console.WriteLine("Die : " + dieValue);

                if (dieValue == 1)
                {
                    Console.WriteLine("Turn over. No Score!!!");
                    return;
                }

                currentTurnScore += dieValue;
                Play(totalScore); 
            }

            totalScore.Add(currentTurnScore);
        }
    }

    class Dice
    {
        private readonly Random random;

        public Dice()
        {
            random = new Random();
        }

        public int Roll()
        {
            return random.Next(1, 7);
        }
    }

    class UserInput
    {
        public string GetChoice()
        {
            Console.Write("Roll or Hold? (r/h) -> ");
            return Console.ReadLine();
        }
    }
}
