using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign02
{
    class Program
    {
        static void Main(string[] args)
        {
            String firstName;   //user input firstname
            String lastName;    //user input lastname
            String address;     //user input address
            String city;        //user input city
            String province;    //user input province
            String postalCode;  //user input postal code

            Contact[] array = new Contact[3];     //an array to save three contacts

            Console.WriteLine("Contact Information");
            Console.WriteLine("-----------------------------");

            //receives user input--------------------
            Console.Write("{0, -15}", "Firstname:");
            firstName = Console.ReadLine();

            Console.Write("{0, -15}", "Lastname:");
            lastName = Console.ReadLine();

            Console.Write("{0, -15}", "Address:");
            address = Console.ReadLine();

            Console.Write("{0, -15}", "City:");
            city = Console.ReadLine();

            Console.Write("{0, -15}", "Province:");
            province = Console.ReadLine();

            Console.Write("{0, -15}", "Postalcode:");
            postalCode = Console.ReadLine();

            Console.WriteLine("\nContacts");
            Console.WriteLine("-----------------------------");
            //end receiving user input--------------------

            //create a Contact obj and assign manually using property
            Contact temp1 = new Contact();
            temp1.FirstName = firstName;
            temp1.LastName = lastName;
            temp1.Address = address;
            temp1.City = city;
            temp1.Province = province;
            temp1.PostalCode = postalCode;
            array[0] = temp1; //assign this obj to array pos 0

            //create a Contact obj using constructor
            Contact temp2 = new Contact (firstName, lastName, address, city, province, postalCode);
            array[1] = temp2; //assign this obj to array pos 1

            //create a Contact obj using initializer syntax
            Contact temp3 = new Contact
            {
                FirstName = firstName,
                LastName = lastName,
                Address = address,
                City = city,
                Province = province,
                PostalCode = postalCode
            };
            array[2] = temp3; //assign this obj to array pos 2

            //print each object in the array
            foreach (Contact c in array)
            {
                Console.WriteLine("{0} {1}\n{2}\n{3} {4}  {5}\n\n", c.FirstName, c.LastName, c.Address, c.City, c.Province, c.PostalCode);
            }
            


        }
    }
}
