using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ClassLibrary
{
    /// <summary>
    /// Class ClientValidation 
    /// This class is a filter layer between MainForm and the DataAccessObject
    /// This filter layer validates input from forms before any database query executes
    /// </summary>
    public class ClientValidation
    {
        private static List<String> errors;         //static list that keeps error strings from validate()

        static ClientValidation()
        {
            errors = new List<String>();
        }

        //This method adds newline charcter between each error strings 
        public static string ErrorMessage   
        {
            get
            {
                string message = "";

                foreach (string line in errors)
                {
                    message += line + "\r\n";
                }

                return message;
            }
        }

        //Select all db
        public static ClientCollection GetClients() => DataAccessObject.SelectAll();

        //Delete a record
        public static int DeleteClient(Client client) => DataAccessObject.DeleteClient(client);

        //Add a record
        public static int AddClient(Client client)
        {
            if (validate(client))
            {
                return DataAccessObject.AddClient(client);
            }
            else
            {
                return -1;
            }
        }

        //Update a record
        public static int UpdateClient(Client client)
        {
            if (validate(client))
            {
                return DataAccessObject.UpdateClient(client);
            }
            else
            {
                return -1;
            }
        }

        //Test method for getting clients
        public static int GetClients(Client client)
        {
            if (validate(client))
            {
                return DataAccessObject.UpdateClient(client);
            }
            else
            {
                return -1;
            }
        }


        //Validation method that compares input with regex strings
        //If error occurs, add the message to the static string list
        private static bool validate(Client client)
        {
            bool validationResult = true;
            errors.Clear();

            String regexClientCode = @"[A-Z][A-Z][A-Z][A-Z][A-Z]";
            String regexProvince = @"[A-Z][A-Z]";
            String regexPostalCode = @"[A-Z]\d[A-Z] \d[A-Z]\d";

            if (!Regex.IsMatch(client.ClientCode, regexClientCode))
            {
                errors.Add("Client Code must be in AAAAA format");
                validationResult = false;
            }

            if (!Regex.IsMatch(client.Province, regexProvince))
            {
                errors.Add("Provincial must be in AA format");
                validationResult = false;
            }

            if (!Regex.IsMatch(client.PostalCode, regexPostalCode))
            {
                errors.Add("Postal Code must be in A9A 9A9 format");
                validationResult = false;
            }

            if (client.CompanyName == "" || client.CompanyName == null)
            {
                errors.Add("Company Name cannot be empty");
                validationResult = false;
            }

            if (client.Address1 == "" || client.Address1 == null)
            {
                errors.Add("Address 1 cannot be empty");
                validationResult = false;
            }

            if (client.YtdSales < 0)
            {
                errors.Add("YTD Sales cannot be negative");
                validationResult = false;
            }

            return validationResult;
        }

        /*
        private static bool validate(Client client)
        {
            bool success = true;
            errors.Clear();

            if (client.ClientCode == "")
            {
                errors.Add("Client Code cannot be empty");
                success = false;
            }

            if (client.CompanyName == "")
            {
                errors.Add("Company Name cannot be empty");
                success = false;
            }

            if (client.Address1 == "")
            {
                errors.Add("Address 1 cannot be empty");
                success = false;
            }

            if (client.Province == "")
            {
                errors.Add("Province cannot be empty");
                success = false;
            }

            if (client.PostalCode == "")
            {
                errors.Add("Postal Code cannot be empty");
                success = false;
            }

            if (client.YtdSales < 0)
            {
                errors.Add("YTD Sales cannot be negative");
                success = false;
            }

            return success;
        }
        */
    }
}
