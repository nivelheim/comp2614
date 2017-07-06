using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Midterm
{
    /// <summary>
    /// Main program that create/print the items
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //List to contain items
            GroceryItemCollection list = new GroceryItemCollection();

            //Items created using explicit constructor
            list.Add(new GroceryItem("4L Milk", 3.87, new DateTime(2017, 5, 28)));
            list.Add(new GroceryItem("500g Cottage Cheese", 4.28, new DateTime(2017, 7, 15)));
            list.Add(new GroceryItem("1 Tin Mushroom Soup", 0.99, DateTime.MaxValue));
            list.Add(new GroceryItem("15kg Dog Food", 29.99, new DateTime(2019, 9, 23)));

            GroceryItem item = new GroceryItem("Test", 29.99, new DateTime(2019, 9, 23));
            Console.WriteLine(item.Description);

            //Natural order
            Console.WriteLine("Natural Order:");
            OutputHelper.PrintList(list);

            //Line feeds between two different display methods
            Console.WriteLine("\n\n\n");
            
            //Sorted order
            list.Sort();
            Console.WriteLine("Sorted Order: [Price Descending]");
            OutputHelper.PrintList(list);
        }
    }
}
