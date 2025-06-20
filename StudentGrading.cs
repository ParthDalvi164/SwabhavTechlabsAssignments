using System;

namespace StudentGrading
{
    public class Student
    {
        public string name;
        public int marks;
        public char grade;

        public Student(string name)
        {
            this.name = name;
        }

        public Student(string name, int marks)
        {
            this.name = name;
            this.marks = marks;
        }

        public Student(string name, int marks, char grade)
        {
            this.name = name;
            this.marks = marks;
            this.grade = grade;
        }

        public void AssignGrade()
        {
            if (this.marks >= 90)
            {
                this.grade = 'A';
            }
            else if (this.marks > 80 && this.marks < 89)
            {
                this.grade = 'B';
            }
            else if (this.marks > 70 && this.marks < 79)
            {
                this.grade = 'C';
            }
            else
            {
                this.grade = 'D';
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Name of the student : " + this.name);
            Console.WriteLine("Marks of the student : " + this.marks);
            Console.WriteLine("Grade of the student : " + this.grade);
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            Student s1 = new Student("PD");
            Student s2 = new Student("PD", 92);
            Student s3 = new Student("PD", 81, 'B');

            s1.AssignGrade();
            s1.DisplayInfo();

            s2.AssignGrade();
            s2.DisplayInfo();

            s3.AssignGrade();
            s3.DisplayInfo();
        }
    }
}
