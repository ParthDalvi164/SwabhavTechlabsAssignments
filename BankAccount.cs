using System;

namespace BankGameApp
{
    public class BankAccount
    {
        public string AccountHolder;
        public double Balance;

        public BankAccount(string AccountHolder, double Balance)
        {
            this.AccountHolder = AccountHolder;
            this.Balance = Balance;
        }

        public void WithDraw(double amount)
        {
            this.Balance = this.Balance - amount;
        }

        public void Deposit(double amount)
        {
            this.Balance = this.Balance + amount;
        }

        public void TakeTurn()
        {
            Console.Write($"{this.AccountHolder} Withdraw or Deposit (w/d) : ");
            string userResp = Console.ReadLine();
            if (userResp == "w")
            {
                Console.Write($"Amount to withdraw : ");
                double withdrawAmount = double.Parse(Console.ReadLine());
                if (withdrawAmount > this.Balance)
                {
                    Console.WriteLine($"Insufficient balance, try again !!!");
                    TakeTurn();
                }
                WithDraw(withdrawAmount);
            }
            else
            {
                if (userResp == "d")
                {
                    Console.Write($"Amount to deposit : ");
                    double depositAmount = double.Parse(Console.ReadLine());
                    Deposit(depositAmount);
                }
                else
                {
                    Console.WriteLine("Invalid Character entered!");
                    TakeTurn();
                }
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            int roundNumber = 1;

            Random random = new Random();
            double randNumber1 = random.Next(100, 500);
            double randNumber2 = random.Next(100, 500);

            BankAccount ba1 = new BankAccount("Account 1", randNumber1);
            BankAccount ba2 = new BankAccount("Account 2", randNumber2);

            while (roundNumber <= 3)
            {
                Console.WriteLine($"Round {roundNumber} : ");
                ba1.TakeTurn();
                ba2.TakeTurn();
                roundNumber++;
            }

            if (ba1.Balance > ba2.Balance)
            {
                Console.WriteLine($"{ba1.AccountHolder} Won!!!");
            }
            else
            {
                if (ba1.Balance < ba2.Balance)
                {
                    Console.WriteLine($"{ba2.AccountHolder} Won!!!");
                }
                else
                {
                    Console.WriteLine($"there was a tie!!!");
                }
            }
        }
    }
}
