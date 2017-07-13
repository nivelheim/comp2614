using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614FinalLibrary
{
    public class Product
    {
        private decimal extended;
        //private decimal pst;
        public int DetailId { get; set; }
        public int Quantity { get; set; }
        public String Sku { get; set; }
        public String Description { get; set; }
        public decimal Price { get; set; }
        public bool? IsTaxable { get; set; }

        public decimal Extended
        {
            get
            {
                extended = this.Quantity * this.Price;
                return extended;
            }

            set
            {
                this.extended = value;
            }
        }

        /*
        public decimal Pst
        {
            get
            {
                if (IsTaxable == true)
                {
                    this.pst = Price * (decimal)0.07;
                }

                return pst;
            }

            set
            {
                this.extended = value;
            }
        }
        */


        public Product()
        {

        }

        public Product(int id, int qty, string sku, string desc, decimal price, bool? tax)
        {
            DetailId = id;
            Quantity = qty;
            Sku = sku;
            Description = desc;
            Price = price;
            IsTaxable = tax;
        }
    }
}
