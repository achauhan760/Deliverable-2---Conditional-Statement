using System;

namespace Deliverable_2___Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Grade?");
            int grade = Convert.ToInt16(Console.ReadLine());

            if (grade >= 98 && grade <= 100)

            {
                Console.WriteLine("Your grade is an A+");
            }

            else if (grade >= 92 && grade <= 97)
            {
                Console.WriteLine("Your grade is an A");
            }

            else if (grade >= 90 && grade <= 91)
            {
                Console.WriteLine("Your grade is an A-");
            }

            else if (grade >= 88 && grade <= 89)
            {
                Console.WriteLine("Your grade is a B+");
            }

            else if (grade >= 82 && grade <= 87)
            {
                Console.WriteLine("Your grade is an B");
            }

            else if (grade >= 80 && grade <= 81)
            {
                Console.WriteLine("Your grade is a B-");
            }

            else if (grade >= 78 && grade <= 79)
            {
                Console.WriteLine("Your grade is a C+");
            }

            else if (grade >= 72 && grade <= 77)
            {
                Console.WriteLine("Your grade is a C");
            }

            else if (grade >= 70 && grade <= 71)
            {
                Console.WriteLine("Your grade is a C-");
            }

            else if (grade >= 68 && grade <= 69)
            {
                Console.WriteLine("Your grade is a D+");
            }

            else if (grade >= 62 && grade <= 67)
            {
                Console.WriteLine("Your grade is a D");
            }

            else if (grade >= 60 && grade <= 61)
            {
                Console.WriteLine("Your grade is a D-");
            }

            else if (grade < 60)
            {
                Console.WriteLine("Your Grade is a F");
            }


        }


    }
}
