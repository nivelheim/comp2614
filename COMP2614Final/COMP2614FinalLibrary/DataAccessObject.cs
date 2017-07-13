using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace COMP2614FinalLibrary
{
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

        public static ProductCollection SelectAll()
        {
            ProductCollection products;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    String query = @"SELECT * FROM dbo.InvoiceDetail ORDER BY DetailId";

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;
                    conn.Open();

                    products = new ProductCollection();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int pid;
                            int qty;
                            String sku;
                            String desc = null;
                            decimal price;
                            bool? isTaxable = null;

                            pid = (int)reader["DetailId"];
                            qty = (int)reader["Quantity"];
                            sku = (String)reader["Sku"];
                            price = (decimal)reader["Price"];     

                            if (!reader.IsDBNull(3))
                            {
                                desc = (String)reader["Description"];
                            }

                            if (!reader.IsDBNull(5))
                            {
                                isTaxable = (bool?)reader["Taxable"];
                            }

                            products.Add(new Product(pid, qty, sku, desc, price, isTaxable));
                        } //end while
                    } //end using reader
                }// end using command
            }//end using connection

            return products;
        }

        public static List<Tax> SelectAllTaxes()
        {
            List<Tax> taxes;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    String query = @"SELECT * FROM dbo.InvoiceDetail ORDER BY DetailId";

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;
                    conn.Open();

                    taxes = new List<Tax>();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int tid;
                            String code;
                            decimal rate;

                            tid = (int)reader["TaxId"];
                            code = (String)reader["TaxCode"];
                            rate = (decimal)reader["TaxRate"];

                            taxes.Add(new Tax(tid, code, rate));
                        } //end while
                    } //end using reader
                }// end using command
            }//end using connection

            return taxes;
        }
    }

}
