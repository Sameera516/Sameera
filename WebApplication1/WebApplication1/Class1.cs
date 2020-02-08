using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public class Class1
    {
        string str = "";
        public Class1()
        {
            str = ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString;
        }
        public DataSet GetAllRecords()
        {
            DataSet ds = new DataSet();
            string sqlquery = "select * from Student1";
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    SqlCommand cmd = new SqlCommand(sqlquery, con);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return ds;
        }
        public DataSet InsertRecord()
        {
            DataSet dd = new DataSet();
            string sqlquery = "insert into Student1 values(5,'alex','javascript','11/2/2020')";
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    SqlCommand cmd = new SqlCommand(sqlquery, con);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(dd);
                }
            }
            catch (Exception ex)
            {

            }
            return dd;
        }
        public DataSet GetaStudent(int id)
        {
            DataSet d = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@sid", id);
                    cmd.CommandText = "PrGetaStudent";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(d);
                    ada.Update(d);
                }
            }
            catch(Exception e) {
                Console.WriteLine(e);
            }
            return d;
        }
        public DataSet Insertrow(int id,string name,string course,string date)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@sid", id);
                    cmd.Parameters.AddWithValue("@sname",name);
                    cmd.Parameters.AddWithValue("@Course", course);
                    cmd.Parameters.AddWithValue("@StartDate", date);
                    cmd.CommandText = "InsertRows";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    sda.Update(ds);
                }
            }
            catch(Exception e) {
                Console.WriteLine(e);
            }
            return ds;
        }
    }
}