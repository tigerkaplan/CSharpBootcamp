using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If else

            // 1 Condition

            //Console.Write("Please, enter the your password: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Correct Password");
            //}
            //else
            //{
            //    Console.WriteLine("Password not successful");
            //}

            // More than 1 condition

            //string capital, country;
            //Console.Write("Enter the capital city: ");
            //capital = Console.ReadLine();

            //Console.Write("Enter the country: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "turkiye")
            //{
            //    Console.Write("Correct Information");
            //}
            //else
            //{
            //    Console.Write("Incorrect Information");
            //}

            // Arithmetic Operations

            //int number;
            //Console.Write("Please, enter the number: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Correct number");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong Number");
            //} 

            //Average

            //int exam1, exam2, exam3, average;
            //string result = "";

            //// Input exams
            //Console.Write("Exam1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Exam2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Exam3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //// Calculate average
            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Average of the exams: " + average);

            //// Determine the result based on the average
            //if (average > 0 && average <= 50)
            //{
            //    result = "a need for improvement"; // Fixed assignment operator
            //}
            //else if (average > 50 && average <= 70)
            //{
            //    result = "below average"; // Fixed assignment operator
            //}
            //else if (average > 70 && average <= 84)
            //{
            //    result = "good"; // Fixed assignment operator
            //}
            //else if (average > 84)
            //{
            //    result = "successful"; // Fixed assignment operator
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Pleae, enter a city name: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city== "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("City in the list");
            //} 
            //else
            //{
            //    Console.WriteLine("City not in the list");
            //}


            //Console.Write("Please, enter a username: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.Write(" this username is invalid");
            //}
            //else
            //{
            //    Console.Write("Welcome !");
            //}



            //Console.Read();

            #endregion

            #region Mod
            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Please, enter the first number: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Please, enter the second number: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.WriteLine("The remainder of the division of the 1st number by the 2nd number: " + result);

            // Even or Odd
            //Console.Write("Please, enter the number: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Even Number");
            //}
            //else
            //{
            //    Console.WriteLine("Odd Number");
            //}
            #endregion

            #region Decision structures with char variables
            ////Char
            //char team;
            //Console.Write("Please, enter the team symbol: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' || team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //else if (team == 'f' || team == 'F')
            //{
            //    Console.Write("Fenerbahce");
            //}
            //else if (team == 'b' || team == 'B')
            //{
            //    Console.Write("Besiktas");
            //}
            //else
            //{
            //    Console.Write("Unknown team symbol.");
            //}

            #endregion

            #region Example

            //Console.WriteLine("******  C# Bootcamp Cafe Menu  ******");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------------------");
            //Console.WriteLine("1-Main Course");
            //Console.WriteLine("2-Soup");
            //Console.WriteLine("3-Pizza");
            //Console.WriteLine("4-Drinks");
            //Console.WriteLine("5-Desserts");
            //Console.WriteLine("--------------------------------------------------");
            //Console.WriteLine();
            //string MenuItem;
            //Console.WriteLine("Please, choose the your preffered Menu: ");
            //MenuItem = Console.ReadLine();

            //if (MenuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------------  Main Course  -------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Curry Chicken");
            //    Console.WriteLine("2- Fries");
            //    Console.WriteLine("3- Rice");
            //    Console.WriteLine("4- Somon");
            //    Console.WriteLine("5- Mousaqqa");
            //    Console.WriteLine();
            //    Console.WriteLine("-------------------  Main Course  -------------------");
            //    Console.WriteLine();
            //}
            //if (MenuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------------  Soup  -------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Lentil Soup");
            //    Console.WriteLine("2- Onion Soup");
            //    Console.WriteLine();
            //    Console.WriteLine("-------------------  Soup  -------------------");
            //    Console.WriteLine();
            //}
            //if (MenuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------------  Pizza  -------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Margarita");
            //    Console.WriteLine("2- 4 Cheese Pizza");
            //    Console.WriteLine();
            //    Console.WriteLine("-------------------  Pizza  -------------------");
            //    Console.WriteLine();
            //}
            //if (MenuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------------  Drinks  -------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Ayran");
            //    Console.WriteLine("2- Lemonade");
            //    Console.WriteLine("3- Water");
            //    Console.WriteLine();
            //    Console.WriteLine("-------------------  Drinks  -------------------");
            //    Console.WriteLine();
            //}
            //if (MenuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------------  Desserts  -------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Baklava");
            //    Console.WriteLine("2- Kazandibi");
            //    Console.WriteLine();
            //    Console.WriteLine("-------------------  Desserts  -------------------");
            //    Console.WriteLine();
            //}

            #endregion

            #region Switch Case
            //Console.WriteLine("Please, enter the month number");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("January"); break;
            //    case 2: Console.WriteLine("February"); break;
            //    case 3: Console.WriteLine("March"); break;
            //    case 4: Console.WriteLine("April"); break;
            //    case 5: Console.WriteLine("May"); break;
            //    case 6: Console.WriteLine("June"); break;
            //    case 7: Console.WriteLine("July"); break;
            //    case 8: Console.WriteLine("August"); break;
            //    case 9: Console.WriteLine("September"); break;
            //    case 10: Console.WriteLine("October"); break;
            //    case 11: Console.WriteLine("November"); break;
            //    case 12: Console.WriteLine("December"); break;
            //    default: Console.WriteLine("Incorrect Data Input"); break;
            //}

            #endregion

            #region Swith Case Calculator
            //int number1, number2, result;
            //char symbol;

            //Console.Write("Input the 1st number: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("Input the 2nd number: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Please, input the operator: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Total: " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Difference: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Dividence: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Times: " + result);
            //        break;
            //    default:
            //        Console.WriteLine("Please enter correct operator");
            //        break;
            //}

            #endregion


            Console.Read();
        }
    }
}