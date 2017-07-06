using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign04
{
    /// <summary>
    /// Main program that takes user input, fetch data, and print to the console.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            String buffer;              //input buffer
            String province = null;     //to store user selection as a string
            int selection;              //Parsed int from the buffer
            List<Customer> customers;   //List to store queried db
            List<String> provinces;
            int i = 0;

            //Menu layout
            Console.WriteLine("Select Province Filter:");

            //Populate all provinces from DB and display a menu based on the retrieved data
            provinces = DataAccessObject.PopulateProvinces();

            foreach (String pr in provinces)
            {
                Console.WriteLine("{0,10}: {1}", ++i, pr);
            }

            Console.WriteLine("{0,10}: {1}", ++i, "ALL");   //very last option of a menu; ALL option

            //Read from a user and parse int from the buffer
            buffer = Console.ReadLine();
            selection = Int32.Parse(buffer);

            //set province based on selection value
            if (selection == (provinces.Count + 1))
            {
                province = "ALL";
            }
            else
            {
                province = provinces[selection - 1];
            }

            //Query data based on the user input
            try
            {
                customers = DataAccessObject.ReadOperation(province);
                Console.WriteLine("Customer Listings For {0}\n\n", province);
                PrintHelper.printList(customers);
            }

            catch (SqlException ex)
            {
                Console.WriteLine($"Data Access Error\n\n{ex.Message}\n\n{ex.StackTrace}");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Processing Error\n\n{ex.Message}\n\n{ex.StackTrace}");
            }
        }   
    }
}
