using System;

/// <summary>
/// Class to store values for Item object
/// </summary>
public class Item
{
    public int Quantity { get; set; }
    public String Sku { get; set; }
    public String Description { get; set; }
    public double Price { get; set; }
    public Boolean Taxable { get; set; }

    /// <summary>
    /// Default Constructor for Item class
    /// </summary>
	public Item()
	{
        //default constructor
	}
}
