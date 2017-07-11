using System;
/// <summary>
/// ---Class Customer---
/// Item class to save all the prroperties of each rows from DB
/// </summary>
public class Client
{
    public String ClientCode { get; set; }
    public String CompanyName { get; set; }
    public String Address1 { get; set; }
    public String Address2 { get; set; }
    public String City { get; set; }
    public String Province { get; set; }
    public String PostalCode { get; set; }
    public decimal YtdSales { get; set; }
    public bool IsCreditHold { get; set; }
    public String Notes { get; set; }

	public Client(String cCode, String cName, String add1, String add2, String cty, 
        String prov, String pCode, decimal sale, bool cred, String note)
	{
        ClientCode = cCode;
        CompanyName = cName;
        Address1 = add1;
        Address2 = add2;
        City = cty;
        Province = prov;
        PostalCode = pCode;
        YtdSales = sale;
        IsCreditHold = cred;
        Notes = note;
	}
}
