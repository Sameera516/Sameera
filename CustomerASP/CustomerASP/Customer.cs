using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace CustomerASP
{
    public class Customer
    {
        string constr = "";
        public Customer()
        {
            constr = ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString;
        }
        public DataSet Insertrow(int Cid, string Cname, string Pname, int Price)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@Cid", Cid);
                    cmd.Parameters.AddWithValue("@Cname", Cname);
                    cmd.Parameters.AddWithValue("@Pname", Pname);
                    cmd.Parameters.AddWithValue("@Price", Price);
                    cmd.CommandText = "InsertRows";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    sda.Update(ds);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return ds;
        }

    }
}