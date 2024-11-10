using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CRUD - Create - Read - Update - Delete

            // Displays the Food Order Management Panel to the user
            Console.WriteLine("********** Food Order Management Panel **********");
            Console.WriteLine();


            Console.WriteLine("---------------------------------------------");

            #region Adding Category
            //// Prompts the user to enter a category name
            //Console.Write("The category name you want to add: ");
            //string categoryName = Console.ReadLine(); // Stores the user's input as `categoryName`

            //// Creates a SqlConnection object to connect to the database
            //SqlConnection connection = new SqlConnection("Data Source=TIGERKAPLAN\\SQLEXPRESS;
            //Initial Catalog=C#BootcampDB;
            //Integrated Security=True");

            //connection.Open(); // Opens the connection to the database

            //// Creates a SqlCommand object to insert the category name into the `TblCategory` table
            //SqlCommand command = new SqlCommand("INSERT INTO TblCategory (CategoryName) VALUES (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName); // Adds the user input (`categoryName`) to the SQL command as a parameter

            //command.ExecuteNonQuery(); // Executes the command, adding the new category to the table
            //connection.Close(); // Closes the database connection

            //Console.Write("Category added successfully!"); // Displays a success message to the user
            #endregion

            #region Adding Product
            //// Variable declarations for storing product details
            //string productName;
            //decimal productPrice;
            //// bool productStatus; // Optional variable, if product status is not intended to change, we can set it directly

            //// Prompt the user to enter the product name
            //Console.Write("Product name: ");
            //productName = Console.ReadLine(); // Reads the product name from user input

            //// Prompt the user to enter the product price
            //Console.Write("Product Price: ");
            //productPrice = decimal.Parse(Console.ReadLine()); // Converts the input to decimal type and stores it in productPrice

            //// Establish a SQL connection to the database
            //SqlConnection connection = new SqlConnection("Data Source=TIGERKAPLAN\\SQLEXPRESS;
            //Initial Catalog=C#BootcampDB;
            //Integrated Security=True");
            //connection.Open(); // Opens the database connection

            //// Prepare a SQL command to insert product details into TblProduct
            //SqlCommand command = new SqlCommand("INSERT INTO TblProduct (ProductName, ProductPrice, ProductStatus) VALUES (@productName, @productPrice, @productStatus)", connection);

            //// Add the product details as parameters to prevent SQL injection
            //command.Parameters.AddWithValue("@productName", productName); 
                  // Sets the ProductName parameter
            //command.Parameters.AddWithValue("@productPrice", productPrice); 
                  // Sets the ProductPrice parameter
            //command.Parameters.AddWithValue("@productStatus", true); 
                  // Sets ProductStatus to true (or active)

            //// Execute the command, adding the product to TblProduct
            //command.ExecuteNonQuery();
            //connection.Close(); // Closes the database connection

            //// Display a confirmation message to the user
            //Console.Write("Product added successfully!");

            #endregion

            #region Listing Product
            //SqlConnection connection = new SqlConnection("Data Source = TIGERKAPLAN\\SQLEXPRESS; initial Catalog = C#BootcampDB; integrated Security = true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable datatable = new DataTable();
            //adapter.Fill(datatable);

            //foreach (DataRow row in datatable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}



            //connection.Close();

            #endregion

            #region Deleting Product
            //Console.Write("Delete Product Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source = TIGERKAPLAN\\SQLEXPRESS;
            //initial Catalog = C#BootcampDB;
            //integrated Security = true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId = @productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();
            //Console.Write("Product deleted successfully!");
            #endregion

            #region Update Product
            //Console.Write("Update Product Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Update Product Name: ");
            //string productName = Console.ReadLine();

            //Console.Write("Update Product Price: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection(
            //"Data Source = TIGERKAPLAN\\SQLEXPRESS;
            //initial Catalog = C#BootcampDB;
            //integrated Security = true");
           
            //connection.Open();
            
            
            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName = @productName,
            //ProductPrice = @ProductPrice
            //where ProductId = @productId", connection);
            
            
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Product updated successfully!");
            #endregion

            Console.Read(); // Keeps the console open until the user presses a key

        }
    }
}

