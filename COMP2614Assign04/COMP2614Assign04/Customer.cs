using System;
/// <summary>
/// ---Class Customer---
/// Item class to save all the prroperties of each rows from DB
/// </summary>
public class Customer
{
    public String CustomerCode { get; set; }
    public String CompanyName { get; set; }
    public String Address { get; set; }
    public String City { get; set; }
    public String Province { get; set; }
    public String PostalCode { get; set; }
    public bool? IsCreditHold { get; set; }

	public Customer(String cCode, String cName, String add, String cty, String prov, String pCode, bool? cred)
	{
        CustomerCode = cCode;
        CompanyName = cName;
        Address = add;
        City = cty;
        Province = prov;
        PostalCode = pCode;
        IsCreditHold = cred;
	}
}
