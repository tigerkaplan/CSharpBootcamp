using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ForEach Loop

            // Foreach (1, 2, 3, 4)
            // 1. variable type."
            // 2. variable name
            // 3. in
            // 4. list  / Collection / Array


            //  Works with the same logic as the for loop
            //  Works more effectively compared to for
            //  Everything that is done with for can be done with foreach, and everything done with foreach can be done with for

            //string[] cities = { "Milano", "Roma", "Budapesth", "Ankara", "Istanbul", "Varsaw" };

            //// Display all the elements of the array on the screen

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            // in Arithmetic
            //int[] numbers = { 47, 85, 98, 41, 25, 63, 58, 89, 86, 10, 265, 6546, 98456 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            // Aritmetic Operations
            //int[] numbers = { 47, 85, 98, 41, 25, 63, 58, 89, 86, 10, 265, 6546, 98456 };
            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}

            //Console.WriteLine(total);

            //List
            //  using with database
            // a member of collections
            // looks like array - it is asking that item type of list

            // List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            // foreach (int number in numbers)
            // {
            //      Console.WriteLine(number);
            // }

            //string word = "hello";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}



            #endregion

            #region Sample exam system application
            Console.WriteLine("---------- C# Bootcamp Exam Application ----------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // Getting the number of students in the class
            Console.WriteLine("------------------------------");
            Console.Write("How many students do you have in your class?: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            // Arrays to store student names and grade averages
            string[] studentNames = new string[studentCount];
            double[] studentExamAverage = new double[studentCount];

            // Gathering exam scores for each student
            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"Enter the name of student {i + 1}: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                // 3 exam scores for each student
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Please enter exam score {j + 1} for {studentNames[i]}: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;
                }

                studentExamAverage[i] = totalExamResult / 3;
                Console.WriteLine();
            }

            // Calculate students' average score and determine pass/fail status
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine($"Average of {studentNames[i]}: {studentExamAverage[i]}");

                // Determine pass/fail status
                if (studentExamAverage[i] >= 50)
                {
                    Console.WriteLine($"Student {studentNames[i]} has passed the lesson.");
                }
                else
                {
                    Console.WriteLine($"Student {studentNames[i]} has not passed the lesson.");
                }
                Console.WriteLine("------------------------------");
            }


            #endregion


            Console.Read();
        }
    }
}
