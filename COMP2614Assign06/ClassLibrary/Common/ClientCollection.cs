using System;
using System.ComponentModel;
using System.Linq;

namespace ClassLibrary
{
    /// <summary>
    /// Class ClientCollection that extends BindingList
    /// Also includes Total Sales Calculation and Total Credit Hold Count Calculation
    /// </summary>
    public class ClientCollection : BindingList<Client>
    {

        public ClientCollection()
        {

        }

        public decimal TotalYTDSales => this.Sum(x => x.YtdSales);

        public int CreditHoldCount => this.Count(x => x.IsCreditHold == true);

    }
}
