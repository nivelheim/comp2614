using System;
using System.Collections.Generic;
/// <summary>
/// List inheritance of GroceryItem type
/// Adds TotalPrice calculation propety method to the list function
/// </summary>
public class GroceryItemCollection : List<GroceryItem>
{
    public double totalPrice;       //Sum of itmes price in the list

	public GroceryItemCollection()
	{
        //Default Constructor
    }

    //Propety method to return sum of item prices when accessed
    public double TotalPrice
    {
        get
        {
            totalPrice = 0;     //must reset; otherwise the sum adds up for every propety call
            foreach (GroceryItem item in this)
            {
                totalPrice += item.Price;       
            }

            return totalPrice;
        }

        set
        {
            totalPrice = value;
        }
    }
}
