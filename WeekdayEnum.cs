using System;

namespace WeekdayEnum
{
    public enum WeekDay { MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY }
  
    public class Program
    {
        public WeekDay ts { get; set; }

        public void CheckWeekDay()
        {
            Console.Write("Enter a number (1-7) : ");
            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    this.ts = WeekDay.MONDAY;
                    Console.WriteLine($"the day of the week is : {this.ts}");
                    break;

                case 2:
                    this.ts = WeekDay.TUESDAY;
                    Console.WriteLine($"the day of the week is : {this.ts}");
                    break;

                case 3:
                    this.ts = WeekDay.WEDNESDAY;
                    Console.WriteLine($"the day of the week is : {this.ts}");
                    break;

                case 4:
                    this.ts = WeekDay.THURSDAY;
                    Console.WriteLine($"the day of the week is : {this.ts}");
                    break;
                
                case 5:
                    this.ts = WeekDay.FRIDAY;
                    Console.WriteLine($"the day of the week is : {this.ts}");
                    break;
                
                case 6:
                    this.ts = WeekDay.SATURDAY;
                    Console.WriteLine($"the day of the week is : {this.ts}");
                    break;

                case 7:
                    this.ts = WeekDay.SUNDAY;
                    Console.WriteLine($"the day of the week is : {this.ts}");
                    break;

                default:
                    Console.WriteLine($"Invalid Number!!!");
                    break;
            }
        }
        public static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.CheckWeekDay();
        }
    }
}
