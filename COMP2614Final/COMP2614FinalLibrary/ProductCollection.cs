using System;
using System.ComponentModel;
using System.Linq;
using COMP2614FinalLibrary;

namespace COMP2614FinalLibrary
{
    public class ProductCollection : BindingList<Product>
    {
        public decimal Subtotal => this.Sum(x => x.Extended);
        //public decimal CalcPst => this.Sum(x => x.Pst);

        public decimal CalcGst
        {
            get 
            {
                return Subtotal * (decimal)0.05;
            }

            set
            {
                this.CalcGst = value;
            }
        }

        public decimal CalcPst
        {
            get
            {
                decimal temp = 0;
                foreach (Product p in this)
                {
                    if (p.IsTaxable == true)
                    {
                        temp += p.Extended * (decimal)0.07;
                    }
                }
                return temp;
            }

            set
            {
                this.CalcGst = value;
            }
        }

        public decimal Grandtotal
        {
            get
            {
                return Subtotal + CalcGst + CalcPst;
            }

            set
            {
                this.Grandtotal = value;
            }
        }

    }
}
