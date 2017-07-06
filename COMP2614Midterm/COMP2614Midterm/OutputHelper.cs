using System;
using System.Collections.Generic;

/// <summary>
/// Helps printing the result to the console in an organized form 
/// </summary>
public class OutputHelper
{
	public OutputHelper()
	{
        //Default Constructor
	}

    public static void PrintList(GroceryItemCollection list)
    {
        Console.WriteLine("{0,-25} {1, 10}    {2, -20}", "Grocery Item", "Price", "Expires");
        Console.WriteLine("------------------------------------------------------");
        
        foreach (GroceryItem item in list)
        {
            Console.WriteLine("{0,-25} {1, 10}    {2, -20}", item.Description, item.Price,
                item.ExpirationDate == DateTime.MaxValue ? "<Never>" : String.Format("{0:ddd MMM d, yyyy}", item.ExpirationDate));
        }

        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("{0} {1,29:n}", "Total:", list.TotalPrice);
    }
}
