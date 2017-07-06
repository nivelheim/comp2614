using System;
using System.Collections.Generic;

/// <summary>
/// Class Invoice to store:
/// InvoiceDate, InvoiceNumber, Terms, and List of items the invoice contains.
/// </summary>
public class Invoice
{
    public List<Item> ItemList {get; set;}      //List of items
    public DateTime InvoiceDate {get; set;}
    public int TermDigit {get; set;} 
    public int InvoiceNumber {get; set;}

    /// <summary>
    /// Default constructor for the class Invoice
    /// </summary>
	public Invoice()
	{
        //default constuctor
	}
}
