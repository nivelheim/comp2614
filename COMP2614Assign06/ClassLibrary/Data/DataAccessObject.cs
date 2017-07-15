using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ClassLibrary
{
    /// <summary>
    /// This is a repository class that accesses to DB and run CRUD operations
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

        public static int AddClient(Client client)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"INSERT INTO dbo.Client918606
                                 (ClientCode, CompanyName, Address1, Address2, City, Province, PostalCode, YTDSales, CreditHold, Notes)
                                 VALUES (@cCode, @cName, @addr1, @addr2, @city, @prov, @pCode, @sales, @isHold, @notes)";
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("@cCode", client.ClientCode);
                    cmd.Parameters.AddWithValue("@cName", client.CompanyName);
                    cmd.Parameters.AddWithValue("@addr1", client.Address1);
                    cmd.Parameters.AddWithValue("@prov", client.Province);
                    cmd.Parameters.AddWithValue("@sales", client.YtdSales);
                    cmd.Parameters.AddWithValue("@isHold", client.IsCreditHold);

                    if (client.Address2 != null)
                    {
                        cmd.Parameters.AddWithValue("@addr2", client.Address2);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@cName", DBNull.Value);
                    }

                    if (client.City != null)
                    {
                        cmd.Parameters.AddWithValue("@city", client.City);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@city", DBNull.Value);
                    }

                    if (client.PostalCode != null)
                    {
                        cmd.Parameters.AddWithValue("@pCode", client.PostalCode);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@pCode", DBNull.Value);
                    }

                    if (client.Notes != null)
                    {
                        cmd.Parameters.AddWithValue("@notes", client.Notes);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@notes", DBNull.Value);
                    }

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
        }

        public static int UpdateClient(Client client)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"UPDATE dbo.Client918606
                                 SET CompanyName = @cName
                                 , Address1 = @addr1
                                 , Address2 = @addr2
                                 , City = @city
                                 , Province = @prov
                                 , PostalCode = @pCode
                                 , YTDSales = @sales
                                 , CreditHold = @isHold
                                 , Notes = @notes
                                 WHERE ClientCode = @cCode";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("@cCode", client.ClientCode);
                    cmd.Parameters.AddWithValue("@cName", client.CompanyName);
                    cmd.Parameters.AddWithValue("@addr1", client.Address1);
                    cmd.Parameters.AddWithValue("@prov", client.Province);
                    cmd.Parameters.AddWithValue("@sales", client.YtdSales);
                    cmd.Parameters.AddWithValue("@isHold", client.IsCreditHold);

                    if (client.Address2 != null)
                    {
                        cmd.Parameters.AddWithValue("@addr2", client.Address2);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@addr2", DBNull.Value);
                    }

                    if (client.City != null)
                    {
                        cmd.Parameters.AddWithValue("@city", client.City);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@city", DBNull.Value);
                    }

                    if (client.PostalCode != null)
                    {
                        cmd.Parameters.AddWithValue("@pCode", client.PostalCode);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@pCode", DBNull.Value);
                    }

                    if (client.Notes != null)
                    {
                        cmd.Parameters.AddWithValue("@notes", client.Notes);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@notes", DBNull.Value);
                    }

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
        }

        public static int DeleteClient(Client client)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"DELETE dbo.Client918606
                                 WHERE ClientCode = @cCode";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@cCode", client.ClientCode);

                    conn.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
        }

        public static ClientCollection SelectAll()
        {
            ClientCollection clients;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    String query = @"SELECT * FROM dbo.Client918606 ORDER BY CompanyName";

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;
                    conn.Open();

                    clients = new ClientCollection();

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
                            bool isCreditHold;
                            String notes = null;

                            cCode = (String)reader["ClientCode"];
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

                            clients.Add(new Client(cCode, cName, address1, address2, city,
                                prov, pCode, sales, isCreditHold, notes));
                        } //end while
                    } //end using reader
                }// end using command
            }//end using connection

            return clients;
        }
    }

}