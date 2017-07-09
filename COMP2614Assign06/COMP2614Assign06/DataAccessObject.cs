using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

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

    public static List<Customer> SelectAll()
    {
        List<Customer> customers;

        using (SqlConnection conn = new SqlConnection(connString))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                String query = @"SELECT * FROM dbo.Customer ORDER BY CompanyName";

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Connection = conn;
                conn.Open();

                customers = new List<Customer>();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        String cCode;
                        String cName;
                        String address1;
                        String address2 = null;
                        String city = null;
                        String prov;
                        String pCode = null;
                        decimal sales;
                        bool? isCreditHold;
                        String notes = null;

                        cCode = (String)reader["CustomerCode"];
                        cName = (String)reader["CompanyName"];
                        address1 = (String)reader["Address1"];
                        prov = (String)reader["Province"];
                        sales = (decimal)reader["YTDSales"];
                        isCreditHold = (bool)reader["CreditHold"];

                        if (!reader.IsDBNull(3))
                        {
                            address2 = (String)reader["Address2"];
                        }

                        if (!reader.IsDBNull(4))
                        {
                            city = (String)reader["City"];
                        }

                        if (!reader.IsDBNull(6))
                        {
                            pCode = (String)reader["PostalCode"];
                        }

                        if (!reader.IsDBNull(9))
                        {
                            notes = (String)reader["Notes"];
                        }

                        customers.Add(new Customer(cCode, cName, address1, address2, city, 
                            prov, pCode, sales, isCreditHold, notes));
                    } //end while
                } //end using reader
            }// end using command
        }//end using connection

        return customers;
    }
}
