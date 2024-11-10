using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Basic Array Example
            //  2,4,6,8
            // sari, kirmizi, mavi
            // adana, ankara, istanbul
            // DegiskenTuru [] DiziAdi = new DegiskenTuru[elemanSayisi]

            //string[] colors = new string[4];

            //colors[0] = "Red";
            //colors[1] = "Yellow";
            //colors[2] = "White";
            //colors[3] = "Blue";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapesth";
            //cities[2] = "Lyon";
            //cities[3] = "Qiro";
            //cities[4] = "Uskup";

            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];

            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;

            //Console.WriteLine(numbers[5]);

            //string[] cities = { "Prag", "Rome", "Atina", "Ankara", "Bursa" };
            //Console.WriteLine(cities[2]);

            #endregion


            #region Dizideki tum elemanlari listeleme
            //string[] colors = { "Yellow", "Red", "White", "Blue", "Green", "Orange", "Pink" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 75, 124, 635, 488, 522, 7436, 2365, 1120 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i]%3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for ( int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            // dizideki en buyuk rakami bulma

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
            //int maxNumber = myArray[0];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i]>maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            #endregion

            #region Array Methods

            //string[] person = { "ali", "ahmet", "ayse", "buse", "cem", "deniz" };
            //Console.WriteLine(person.Length);

            //int[] numbers = { 47, 85, 95, 41, 25, 63, 57, 89, 86, 10 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 47, 85, 95, 41, 25, 63, 57, 89, 86, 10 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //string[] customers = { "ali", "ahmet", "ayse", "buse", "cem", "deniz" };
            //int index = Array.IndexOf(customers, "ayse");
            //Console.WriteLine(index);

            //int[] numbers = { 47, 85, 95, 41, 25, 63, 57, 89, 86, 10 };
            //Console.WriteLine("the MaxNumber in the Array: " + numbers.Max() +" "+ "and" + " " +"the MinNumber in the Array: " + numbers.Min());


            #endregion

            #region Value input by User
            //string[] cities = new string[5];
            //for (int i=0; i<cities.Length; i++)
            //{
            //    Console.Write($"Please Enter the {i + 1}. city :  ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("---------------");
            //for(int i = 0; i<cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 4, 85, 96, 75, 12, 46, 35, 48 };
            //int sum = 0;

            //for (int i=0; i<numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //int[] numbers = { 47, 85, 96, 42, 26, 63, 57, 89, 86, 10 };
            //Console.WriteLine("----------- Even Numbers -----------");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine("----------- Odd Numbers -----------");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion

            Console.Read();
        }
    }
}
