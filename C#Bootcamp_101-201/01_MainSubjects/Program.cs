using System;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)

        #region PrintingCommands
        {
            //Console.WriteLine("Hello World!");
            // purple color cupe shows that it is method
            //Console.WriteLine("Hi !");

            //Console.WriteLine("***** Main Categories *****");
            //Console.WriteLine();
            //Console.WriteLine("1- Soups");
            //Console.WriteLine("2- Main Course");
            //Console.WriteLine("3- Cold Starters");
            //Console.WriteLine("4- Salads");
            //Console.WriteLine("5- Desserts");
            //Console.WriteLine("6- Drinks");
            //Console.WriteLine();
            //Console.WriteLine("***** Main Categories *****");

            #endregion

            #region String Variables

            // string
            // Variable_type variable_name

            //   string name;
            //   name = "Jane";
            //   Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Jane";
            //customerSurname = "Doe";
            //customerPhone = "+90 123 456 78 90";
            //customerEmail = "jane.doe@gmail.com";
            //district = "Kadikoy";
            //city = "Istanbul";

            //Console.WriteLine("**** Reservation Card ****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------------------------------");
            //Console.WriteLine("Customer: " + customerName + " " + customerSurname);
            //Console.WriteLine("Contact: " + customerPhone);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("Address : " + district + "/" + city);
            //Console.WriteLine("-----------------------------------------------------------------");

            //Console.WriteLine();

            //customerName = "John";
            //customerSurname = "Doe";
            //customerPhone = "+90 123 45 67";
            //customerEmail = "hhon.doe@gmail.com";
            //district = "Uskudar";
            //city = "Istanbul";

            //Console.WriteLine("-----------------------------------------------------------------");
            //Console.WriteLine("Customer: " + customerName + " " + customerSurname);
            //Console.WriteLine("Contact: " + customerPhone);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("Address : " + district + "/" + city);
            //Console.WriteLine("-----------------------------------------------------------------");

            #endregion

            #region Int Variables
            //int   tamsayi turunde degiskenler

            int number = 24;
            Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonatePrice = 30;

            Console.WriteLine("**** Restourant Price List ****"); 
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("----- Hamburger : " + hamburgerPrice + " " + "TL");
            Console.WriteLine("----- Coke : " + cokePrice + " " + "TL");
            Console.WriteLine("----- Water : " + waterPrice + " " + "TL");
            Console.WriteLine("----- Fries : " + friesPrice + " " + "TL");
            Console.WriteLine("----- Pizza : " + pizzaPrice + " " + "TL");
            Console.WriteLine("----- Lemonate : " + lemonatePrice + " " + "TL");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("**** Restourant Price List ****");


            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;


            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonatePrice;

            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Total Hamburger :" + " " + totalHamburgerPrice + " " + "TL");      
            Console.WriteLine("Total Coke :" + " " + totalCokePrice + " " + "TL");
            Console.WriteLine("Total Water :" + " " + totalWaterPrice + " " + "TL");
            Console.WriteLine("Total Fries :" + " " + totalFriesPrice + " " + "TL");
            Console.WriteLine("Total Pizza :" + " " + totalPizzaPrice + " " + "TL");
            Console.WriteLine("Total Lemonade :" + " " + totalLemonadePrice + " " + "TL");


            Console.WriteLine();

            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice;

            Console.WriteLine(" Bill : " + totalPrice );


            #endregion


            Console.Read();
        }

    }
}
