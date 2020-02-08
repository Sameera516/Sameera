using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;


namespace TraineeApp
{
    public class Trainee
    {
        public int Tid
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public string Location
        {
            get; set;
        }
        public string TechDomain
        {
            get; set;
        }
        public DateTime StartDate
        {
            get; set;
        }
        string constr = "";
        public Trainee()
        {
            constr = ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString;
        }
        public DataSet InsertRecord(int td, string tname, string loc, string domain, DateTime sdate)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@tid", td);
                    cmd.Parameters.AddWithValue("@name", tname);
                    cmd.Parameters.AddWithValue("@location", loc);
                    cmd.Parameters.AddWithValue("@techdomain", domain);
                    cmd.Parameters.AddWithValue("@startdate", sdate);
                }

            }
            catch (Exception e) { }
            return ds;

        }
    }
}