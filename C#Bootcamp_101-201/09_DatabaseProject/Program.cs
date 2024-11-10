using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.Net   ---- Framework 

            Console.WriteLine(" ********** C# Product-Category Information System ********** ");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine(" -------------------------------------------------------- ");
            Console.WriteLine(" 1- Categories");
            Console.WriteLine(" 2- Products");
            Console.WriteLine(" 3- Orders");
            Console.WriteLine(" 4- Exit");
            Console.Write(" Please enter the table No you want to see: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine(" -------------------------------------------------------- ");




            SqlConnection connection = new SqlConnection("Data Source = TIGERKAPLAN\\SQLEXPRESS; initial Catalog = C#BootcampDB; integrated Security = true");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }

            // Class
            // Object
            // Properity 


            Console.Read();
        }
    }
}

