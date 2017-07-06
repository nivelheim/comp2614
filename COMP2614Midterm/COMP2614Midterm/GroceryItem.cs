using System;

/// <summary>
/// GroceryItem class that contains properties of each grocery item
/// </summary>
public class GroceryItem : IComparable<GroceryItem>
{
    public String Description { get; private set; }
    public double Price { get; set; }
    public DateTime ExpirationDate { get; private set; }

    public GroceryItem()
    {
        //default constructor
    }

    //Explicit Constructor
    public GroceryItem(String dsc, double pr, DateTime exp)
    {
        Description = dsc;
        Price = pr;
        ExpirationDate = exp;
    }

    //Compare for descending sort
    public int CompareTo(GroceryItem item)
    {
        if (item == null)
        {
            return 1;
        }

        //Compare item with this object
        return item.Price.CompareTo(this.Price);
    }

}

