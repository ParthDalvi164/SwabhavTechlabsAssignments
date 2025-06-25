using System;

namespace PersonApp
{
    public enum EvaluationResult { UNDERWEIGHT, NORMAL, OVERWEIGHT, OBESE }
  
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public double BMI { get; set; }
        public EvaluationResult Evaluation { get; set; }

        public Person(int id, string name, int age, double height, double weight)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Height = height;
            this.Weight = weight;
        }

        public Person(int id, string name, int age) : this(id, name, age, 5, 50) { }

        public void CalculateBMI()
        {
            this.BMI = this.Weight / (this.Height * this.Height);
        }

        public void EvaluateBMI()
        {
            if (this.BMI < 18.5)
            {
                this.Evaluation = EvaluationResult.UNDERWEIGHT;
            }
            else if (this.BMI < 25)
            {
                this.Evaluation = EvaluationResult.NORMAL;
            }
            else if (this.BMI < 30)
            {
                this.Evaluation = EvaluationResult.OVERWEIGHT;
            }
            else
            {
                this.Evaluation = EvaluationResult.OBESE;
            }
        }

        public void Display()
        {
            Console.WriteLine($"For the candidate with ID : {this.Id}, Name : {this.Name}, Age : {this.Age}, Height : {this.Height}, Weight : {this.Weight}");
            Console.WriteLine($"The BMI score is : {this.BMI} & the evaluation is : {this.Evaluation}");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Person p1 = new Person(12, "Parth", 21, 1.76, 53);
            p1.CalculateBMI();
            p1.EvaluateBMI();
            p1.Display();
        }
    }
}
