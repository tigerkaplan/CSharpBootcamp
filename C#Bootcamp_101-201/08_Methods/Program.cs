using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Methods
            //()
            // Void method
            // Customer --> List, add, delete, update


            //void CustomerList()
            //{
            //    Console.WriteLine("Jane Doe");
            //    Console.WriteLine("John Doe");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();



            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();

            #endregion

            #region Void methods with String parameters

            //void WriteMethod(string CustomerName)
            //{
            //    Console.WriteLine(CustomerName);
            //}
            //WriteMethod("Jane Doe");

            // convert to customer card
            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Customer: " + name + " " + surname);
            //}

            //// Calling the method
            //CustomerCard("Jane", "Doe");
            //CustomerCard("John", "Doe");

            #endregion

            #region Void methods with Int parameters
            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(4, 5, 6);

            #endregion

            #region Return Methods

            //string CustomerName()
            //{
            //    return "Jane Doe";
            //}
            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Jane";
            //    string surname = "Doe";

            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region Return methods with String parameters

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Country: " + countryName + " - Capital: " + capital + " - Flag Color: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;

            //Console.Write("Enter the name of the country: ");
            //x = Console.ReadLine();

            //Console.Write("Enter the capital of the country: ");
            //y = Console.ReadLine();

            //Console.Write("Enter the color of the flag: ");
            //z = Console.ReadLine();

            //// Call the CountryCard method and store the result
            //Console.Write(CountryCard(x,y,z));

            //Console.Write(CountryCard("Turkiye", "Ankara", "Kirmizi-Beyaz"));

            #endregion

            #region Return methods with Int parameters
            //int Sum (int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36, 28));
            //Console.WriteLine(Sum(24, 36));
            //Console.WriteLine(Sum(14, 20));

            #endregion

            #region Sample Explanation

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + " has passed the exam. Average: " + result;
                }
                else
                {
                    return student + " hasn't passed the exam. Average: " + result;
                }
            }

            Console.WriteLine(ExamResult("Jane", 25, 41, 97));
            Console.WriteLine(ExamResult("John", 52, 14, 79));

            #endregion


            Console.Read();
        }
    }
}
