using System;

namespace TrafficEnum
{
    public enum TrafficSignal { RED, YELLOW, GREEN }
    public class Program
    {
        public TrafficSignal ts { get; set; }

        public void AcceptSignal()
        {
            Console.WriteLine("Enter the signal : \n1. RED \n2. YELLOW \n3. GREEN");
            Console.Write("Enter signal : ");
            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    this.ts = TrafficSignal.RED;
                    Console.WriteLine($"the signal is {this.ts} and hence 'STOP'");
                    break;

                case 2:
                    this.ts = TrafficSignal.YELLOW;
                    Console.WriteLine($"the signal is {this.ts} and hence 'GET READY'");
                    break;

                case 3:
                    this.ts = TrafficSignal.GREEN;
                    Console.WriteLine($"the signal is {this.ts} and hence 'GO'");
                    break;

                default:
                    Console.WriteLine($"Invalid Signal!!!");
                    break;
            }
        }

        public static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.AcceptSignal();
        }
    }
}
