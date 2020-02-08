using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TraineeApp
{
    public class DataLayer
    {
        DataSet ds = new DataSet();
        string conStr = "";
        public DataLayer()
        {
            conStr= ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString;
        }
        public DataSet SelectRec()
        {
            try
            {
                SqlConnection con = new SqlConnection(conStr);

                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "SelectRec";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);

            }
            catch (Exception ex)
            {

            }

            return ds;
       
        }
        public string InsertRow(int id,string tname,string loc,string domain,DateTime date1)
        {
            string err = "";
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@tid", id);
                    cmd.Parameters.AddWithValue("@name", tname);
                    cmd.Parameters.AddWithValue("@location", loc);
                    cmd.Parameters.AddWithValue("@techdomain", domain);
                    cmd.Parameters.AddWithValue("@startdate", date1);
                    cmd.CommandText = "InsertRecord";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    sda.Update(ds);
                   

                }
            }
            catch (Exception e) {
                err = e.Message;
                
            }
            return err;
            
           
        }
        public void update(int tid, string dom)
        {
            try
            {
                SqlConnection con = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@id", tid);
                cmd.Parameters.AddWithValue("@domain", dom);
                cmd.CommandText = "Update";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                sda.Update(ds);

                
            }catch(Exception e)
            { }
        }
    }
}