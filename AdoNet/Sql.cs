using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace AdoNet
{
    class Sql
    {
        private static string connectionString = @"Server=DESKTOP-S22NJ7J\SQLEXPRESS;Database=Cinema;Trusted_Connection=True;";
        public static void Select(string query)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlDataAdapter sda = new SqlDataAdapter(query, con))
                {
                    DataTable d = new DataTable();
                    sda.Fill(d);
                    string columnNames = "";
                    for (int i = 0; i < d.Columns.Count; i++)
                    {
                        columnNames += d.Columns[i].ColumnName + " ";
                    }
                    Console.WriteLine(columnNames);
                    foreach (DataRow dataRow in d.Rows)
                    {
                        string result = "";
                        for (int i = 0; i < d.Columns.Count; i++)
                        {
                            result += dataRow[i] + " ";
                        }
                        Console.WriteLine(result);
                    }
                }
            }
        }
        public static void Execute(string query)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand comn= new SqlCommand(query,con))
                {
                    
                    try
                    {
                        if (comn.ExecuteNonQuery()>0)
                        {

                        }
                        else
                        {
                            Console.WriteLine("Wrong");
                        }
                        
                    }
                    catch (Exception)
                    {
                        
                        Console.WriteLine("Data not found");
                        
                    }
                }
            }
        }

    }
}
