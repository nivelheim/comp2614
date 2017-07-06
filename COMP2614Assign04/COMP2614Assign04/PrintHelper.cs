using System;
using System.Collections.Generic;
/// <summary>
/// ---PrintHelper---
/// This class only has one static method which takes a List as a parameter
/// The method iterates through the input list and print each items in a prepared format string
/// </summary>
public class PrintHelper
{
	public PrintHelper()
	{
	}

    public static void printList(List<Customer> lst)
    {
        Console.WriteLine("{0, -37} {1, -15} {2, -4} {3, -7} {4, 5}", "CompanyName", "City", "Prov", "Postal", "Hold");
        Console.WriteLine("-----------------------------------------------------------------------------");

        foreach (Customer cust in lst)
        {
            Console.WriteLine("{0, -37} {1, -15} {2, -4} {3, -7}   {4, -5}",
                cust.CompanyName, cust.City, cust.Province, cust.PostalCode, 
                cust.IsCreditHold == true ? "Y" : "N");
        }

        Console.WriteLine("\n");
    }
}
