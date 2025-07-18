using System;
namespace TemplatePattern
{
   

    abstract class Beverage
    {
        // Template Method: Fixed flow
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        // Abstract methods - subclass override karega
        protected abstract void Brew();
        protected abstract void AddCondiments();
    }

    // Subclass 1: Tea
    class Tea : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }
    }

    // Subclass 2: Coffee
    class Coffee : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Dripping coffee through filter");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Making Tea...");
            Beverage tea = new Tea();
            tea.PrepareRecipe();

            Console.WriteLine("\nMaking Coffee...");
            Beverage coffee = new Coffee();
            coffee.PrepareRecipe();
        }
    }
}
