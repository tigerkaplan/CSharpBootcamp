using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Variables
            //double number;

            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Price List *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Apple Unit Price:" + " " + applePrice + " " + "TL");
            //Console.WriteLine("---- Orange Unit Price:" + " " + orangePrice + " " + "TL");
            //Console.WriteLine("---- Strawberry Unit Price:" + " " + strawberryPrice + " " + "TL");
            //Console.WriteLine("---- Potato Unit Price:" + " " + potatoPrice + " " + "TL");
            //Console.WriteLine("---- Tomato Unit Price:" + " " + tomatoPrice + " " + "TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------------");
            //Console.WriteLine("Item: Apple      - " + "Unit Price:" + " " + applePrice + " - Gr:" + " " + appleGram + " - TotalPrice:" + " " + appleTotalPrice);
            //Console.WriteLine("Item: Orange     - " + "Unit Price:" + " " + orangePrice + " - Gr:" + " " + orangeGram + " - TotalPrice:" + " " + orangeTotalPrice);
            //Console.WriteLine("Item: Strawberry - " + "Unit Price:" + " " + strawberryPrice + " - Gr:" + " " + strawberryGram + " - TotalPrice:" + " " + strawberryTotalPrice);
            //Console.WriteLine("Item: Potato     - " + "Unit Price:" + " " + potatoPrice + " - Gr:" + " " + potatoGram + " - TotalPrice:" + " " + potatoTotalPrice);
            //Console.WriteLine("Item: Tomato     - " + "Unit Price:" + " " + tomatoPrice + " - Gr:" + " " + tomatoGram + " - TotalPrice:" + " " + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Total Shopping:" + " " + shoppingTotalPrice + " "+ "TL");
            #endregion

            #region Char Variables
            //Caesar Cipher
            // no turkish charachter 
            // " string 'char 

            //char symbol;
            //symbol = 'A';

            //Console.WriteLine(symbol);
            //Console.Read();
            #endregion

            #region Data inputs from the keyboard and string variables
            //Console.WriteLine("**** C# Airline Passenger Information ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdendityNumber;

            //Console.Write("Passenger Name: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Passenger Surname: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Passenger District:");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Passenger City: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Passenger Age: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Passenger ID: ");
            //passengerIdendityNumber = Console.ReadLine();

            //Console.WriteLine("----------------------------------");
            //Console.WriteLine( "Passenger ID:" + passengerIdendityNumber + " " + "- Passenger Name Surname:" + passengerName + " "+ passengerSurname + " " + passengerDistrict + " / " + passengerCity + " " + passengerAge );

            #endregion

            #region Integer inputs and conversions from the keyboard

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoeCount, computerCount, chairCount, tvCount;

            //Console.Write("Please enter the number of pairs you purchased:");
            //shoeCount = int.Parse(Console.ReadLine());

            //Console.Write("Please enter the number of computers you purchased:");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Please enter the number of chair you purchased:");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Please enter the number of tv you purchased:");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoeCount * shoePrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Total amount you need to pay:" + totalPrice + "TL");

            #endregion

            #region Decimal number operations from the keyboard

            //double exam1, exam2, exam3, result;

            //Console.Write("Please enter the score for the 1st exam:");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Please enter the score for the 2nd exam:");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Please enter the score for the 3rd exam:");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine(" Average of the result: " + result);

            #endregion

            #region Character inputs from the keyboard
            //char gender;
            //Console.Write("Please choose a gender: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine ("Gender:" +  gender);

            #endregion
            Console.Read();
        }

    }
}
