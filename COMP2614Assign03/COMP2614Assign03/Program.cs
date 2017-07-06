using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace COMP2614Assign03
{
    /// <summary>
    /// Main program to read from data, put data into classes and print to the console
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Creates an array of lines read from a text file
            var lines = File.ReadLines("invoicedata.txt");

            //Split each line, itemize, and contain them in a list of items
            foreach (var line in lines)
            {

                String[] temp = line.Split('|');            //splits the line into a header and items
                String[] headerArray = temp[0].Split(':');  //splits the header into header properties

                List<Item> ItemList = new List<Item>();     
                Invoice tempInvoice = new Invoice();        //Temporary object to add in the list 

                //Itemize the items in the temp array
                for (int i = 1; i < temp.Length; i++)
                {
                    Item tempItem = extractItemFromString(temp[i]);
                    ItemList.Add(tempItem);
                }

                //Set header properties of temporary object with the data extracted in headerArray
                tempInvoice.InvoiceNumber = Int32.Parse(headerArray[0]);
                tempInvoice.InvoiceDate = DateTime.Parse(headerArray[1]);
                tempInvoice.TermDigit = Int32.Parse(headerArray[2]);
                tempInvoice.ItemList = ItemList;

                //print the tempInvoice in a format designed in OutputHelper class
                OutputHelper.printInvoice(tempInvoice);
            }
        }

        /// <summary>
        /// Takes a string that contains item properties, then return it in an Item object
        /// </summary>
        /// <param name="str"></param>
        /// <returns>Item</returns>
        public static Item extractItemFromString(String str)
        {
            String[] itemProperties = str.Split(':');
            Item tempItem = new Item();

            tempItem.Quantity = Int32.Parse(itemProperties[0]);
            tempItem.Sku = itemProperties[1];
            tempItem.Description = itemProperties[2];
            tempItem.Price = Double.Parse(itemProperties[3]);

            if (itemProperties[4].Equals("Y"))
            {
                tempItem.Taxable = true;
            }
            else
            {
                tempItem.Taxable = false;
            }

            return tempItem;
        }

        
    }
}
