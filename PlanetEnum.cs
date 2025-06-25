using System;

namespace PlanetEnum
{
    public enum Planet { MARS, VENUS, JUPITER, SATURN, URANUS, NEPTUNE, PLUTO }
    public class Program
    {
        public float CurrentWeight { get; set; }
        public float[] ConversionFactors { get; set; } = { 0.38f, 0.90f, 2.53f, 1.07f, 0.89f, 1.14f, 0.06f }; 
        public void DisplayRelativeWeight()
        {
            for (int i = 0; i < ConversionFactors.Length; i++)
            {
                Console.WriteLine($"The weight on {(Planet)i} : {CurrentWeight * ConversionFactors[i]} kg");
            }
        }

        public void setCurrentWeight()
        {
            Console.Write("Enter the weight on earth : ");
            this.CurrentWeight = float.Parse(Console.ReadLine());
        }
        public static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.setCurrentWeight();
            p1.DisplayRelativeWeight();
        }
    }
}
