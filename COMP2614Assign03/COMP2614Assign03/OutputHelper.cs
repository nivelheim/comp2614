using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Globalization;

/// <summary>
/// This class helps user to print the contents of Invoice object to the console
/// by using static method included.
/// </summary>
public class OutputHelper
{
    /// <summary>
    /// Default constructor
    /// </summary>
	public OutputHelper()
	{
        //def constructor
	}

    /// <summary>
    /// Static method for the class OutputHelper
    /// Takes an Invoice object as a parameter to print to the console.
    /// </summary>
    public static void printInvoice(Invoice inv)
    {
        char taxable;               //used for representation at line  53
        double subTotal = 0.0;      //Quantity * Price
        double pstTotal = 0.0;      //Total PST amount 
        double final = 0.0;         //subTotal + pstTotal + GST at line 68


        //First layout
        Console.WriteLine("{0, -17} {1}", "Invoice Number:", inv.InvoiceNumber);
        Console.WriteLine("{0, -17} {1}", "Invoice Date:", String.Format("{0:MMM d, yyyy}", inv.InvoiceDate));
        Console.WriteLine("{0, -17} {1}", "Discount Date:", String.Format("{0:MMM d, yyyy}", inv.InvoiceDate.AddDays(inv.TermDigit % 100)));
        Console.WriteLine("{0, -17} {1:n2}% {2} days ADI", "Terms:", inv.TermDigit / 100, inv.TermDigit % 100);
        Console.WriteLine("-----------------------------------------------------------------------");
        Console.WriteLine("{0, -3} {1, -13} {2, -23} {3, 6} {4, -3} {5, 10}", "Qty", "SKU", "Description", "Price", "PST", "Ext");
        Console.WriteLine("-----------------------------------------------------------------------");

        //Loop for items
        foreach (Item i in inv.ItemList)
        {
            double itemPst = 0.0;
            if (i.Taxable == true)
            {
                itemPst = (i.Price * i.Quantity) * (0.07);
            }

            Console.WriteLine("{0, 3} {1, -13} {2, -23} {3, 6:n} {4, 2} {5, 10:n}", i.Quantity, i.Sku, i.Description, i.Price,
                taxable = i.Taxable == true ? 'Y' : 'N', (i.Quantity * i.Price));

            subTotal += i.Price * i.Quantity;
            pstTotal += itemPst;

        }

        //Subtotal, GST, PST, Total
        Console.WriteLine("-----------------------------------------------------------------------");
        Console.WriteLine("{0, 17} {1} {2, 34:n}", "", "Subtotal:", subTotal);
        Console.WriteLine("{0, 17} {1} {2, 39:n}", "", "GST:", subTotal * 0.05);

        //Only print if PST applicable item exists
        if (pstTotal > 0)
        {
            Console.WriteLine("{0, 17} {1} {2, 39:n}", "", "PST:", pstTotal);
        }

        Console.WriteLine("-----------------------------------------------------------------------");
        final = subTotal + (subTotal * 0.05) + pstTotal;    //Calculates Total by adding subTotal + GST + PST
        Console.WriteLine("{0, 17} {1} {2, 37:n}\n", "", "Total:", final);
        Console.WriteLine("{0, 17} {1} {2, 34:n}\n\n\n", "", "Discount:", final * ((inv.TermDigit / 100)/100.00));
    }
}
