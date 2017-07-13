using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614FinalLibrary
{
    public class Tax
    {
        public int TaxId { get; set; }
        //private decimal pst;
        public String TaxCode { get; set; }
        public decimal TaxRate { get; set; }

        public decimal ActualRate
        {
            get
            {
                return TaxRate / (decimal)100.0;
            }

            set
            {
                this.ActualRate = value;
            }
        }

        public Tax()
        {

        }

        public Tax(int id, String code, decimal rate)
        {
            TaxId = id;
            TaxCode = code;
            TaxRate = rate;
        }
    }
}
