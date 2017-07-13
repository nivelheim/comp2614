using System;
using System.Collections.Generic;

public class ClientValidation
{
    private static List<String> errors;

	public ClientValidation()
	{
        errors = new List<String>();
	}

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

    public static ClientCollection GetClients() => DataAccessObject.SelectAll();
    public static int DeleteClient(Client client) => DataAccessObject.DeleteProduct(client);
    //{
    //    return ProductRepository.DeleteProduct(product);
    //}

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

    private static bool validate(Client client)
    {
        bool success = true;
        errors.Clear();

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

        if (client.YtdSales < 0)
        {
            errors.Add("YTD Sales cannot be negative");
            success = false;
        }

        return success;
    }
}
