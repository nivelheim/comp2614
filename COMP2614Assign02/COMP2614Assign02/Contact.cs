using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign02
{
    class Contact
    {
        //auto properties
        public String FirstName { get; set; }  
        public String LastName { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public String Province { get; set; }
        public String PostalCode { get; set; }

        public Contact()
        {
            //emtpy constructor
        }

        public Contact(String fName, String lName, String addr, String cty, String prov, String pCode)
        {
            //user defined constructor
            FirstName = fName;
            LastName = lName;
            Address = addr;
            City = cty;
            Province = prov;
            PostalCode = pCode;
        }

        public override string ToString()
        {   
            //string override
            return string.Format("{0}, {1}", this.LastName, this.FirstName); 
        }

        
    }
}
