using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 10 Stars Vertically
            //for (int i = 1; i <= 10;  i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region 10 Stars Horizantally
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}
            #endregion

            #region 10 Stars Horizantally & Vertically
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}
            #endregion

            #region Right Triangle
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Opposıte Way Right Triangle

            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Right and Opposite Right Triangle

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int k = 4; k >= 1; k--)
            //{
            //    for (int m = 1; m <= k; m++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Baklava Slice

            // baklava diliminin yari yuksekligi (half-height of the baklava slice)
            //int n = 5;

            //// Top half (including the middle line)
            //for (int i = 1; i <= n; i++)
            //{
            //    // Print spaces
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    // Print stars
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    // Move to the next line
            //    Console.WriteLine();
            //}

            //// Bottom half
            //for (int i = n - 1; i >= 1; i--)
            //{
            //    // Print spaces
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    // Print stars
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    // Move to the next line
            //    Console.WriteLine();
            //}

            #endregion

            #region Pyramid

            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //    // i kucuk esit n olana kadar i 1 1 artsin 
            //{
            //    // space  
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    // stars
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Opposite way Pyramid
            //int n = 5;
            //for (int i = n; i >= 1; i--)
            //{
            //    //spaces
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write("0");
            //    }
            //    // stars
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    //spaces
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write("0");
            //    }
            //        Console.WriteLine();
            //}
            #endregion


            Console.Read();

        }
    }
}