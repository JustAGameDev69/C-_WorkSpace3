using System;
using System.Net.NetworkInformation;
using System.Security.Principal;

namespace static_method
{
    public class Student
    {
        private int number;
        private string name;
        private static string college = "BBDIT";

        public Student (int nb, string n)
        {
            number = nb;
            name = n;
        }

        public static void College_Change()
        {
            college = "PTIT";
        }

        public void Display()
        {
            Console.WriteLine(number + " " + name + " " + college);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Student.College_Change();

            Student student_1 = new Student(1, "Nguyen Hoang");
            Student student_2 = new Student(2, "Nguyen Hoang");
            Student student_3 = new Student(3, "Nguyen Hoang");

            student_1.Display();
            student_2.Display();
            student_3.Display();
        }
    }
}