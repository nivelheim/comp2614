using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

/// <summary>
/// ---Class DataAccessObject---
/// This class is used to access to the given DB.
/// The first static method ReadOperation takes string parameter as an input.
/// This method fetches data where column 'Province' equals the input parameter. 
/// The second static method populates a List of provinces.
/// </summary>
public class DataAccessObject
{
    private static String connString = @"Server=tcp:comp2614.database.windows.net,1433;
                                        Initial Catalog=mc1720;
                                        User ID=student;
                                        Password=93nu5#S163; 
                                        Encrypt=True; 
                                        TrustServerCertificate=False; 
                                        Connection Timeout=30;";

    public DataAccessObject()
	{

	}

    public static List<Customer> ReadOperation(String province)
    {
        List<Customer> customers;

        using (SqlConnection conn = new SqlConnection(connString))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                String query = @"SELECT * FROM dbo.Customer ORDER BY CompanyName";

                if (!province.Equals("ALL"))
                {
                    query = @"SELECT * FROM dbo.Customer WHERE Province = @prov ORDER BY CompanyName";
                }

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Connection = conn;

                if (!province.Equals("ALL"))
                {
                    cmd.Parameters.AddWithValue("@prov", province);
                }
                
                conn.Open();

                customers = new List<Customer>();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    String cCode;
                    String cName;
                    String address = null;
                    String city = null;
                    String prov = null;
                    String pCode = null;
                    bool? isCreditHold = null;

                    while (reader.Read())
                    {
                        cCode = (String)reader["CustomerCode"];
                        cName = (String)reader["CompanyName"];

                        if (!reader.IsDBNull(2))
                        {
                            address = (String)reader["Address"];
                        }

                        if (!reader.IsDBNull(3))
                        {
                            city = (String)reader["City"];
                        }

                        if (!reader.IsDBNull(4))
                        {
                            prov = (String)reader["Province"];
                        }

                        if (!reader.IsDBNull(5))
                        {
                            pCode = (String)reader["PostalCode"];
                        }

                        if (!reader.IsDBNull(6))
                        {
                            isCreditHold = (bool)reader["CreditHold"];
                        }

                        customers.Add(new Customer(cCode, cName, address, city, prov, pCode, isCreditHold));

                        address = null;
                        city = null;
                        prov = null;
                        pCode = null;
                        isCreditHold = null;
                    } //end while
                } //end using reader
            }// end using command
        }//end using connection

        return customers;
    }//end method 

    public static List<String> PopulateProvinces()
    {
        List<String> provinces;

        using (SqlConnection conn = new SqlConnection(connString))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                String query = @"SELECT DISTINCT Province FROM dbo.Customer ORDER BY Province";

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Connection = conn;

                conn.Open();

                provinces = new List<String>();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    String prov = null;

                    while (reader.Read())
                    {
                        prov = (String)reader["Province"];
                        provinces.Add(prov);
                    } //end while
                } //end using reader
            }// end using command
        }//end using connection

        return provinces;
    }//end method 
}
