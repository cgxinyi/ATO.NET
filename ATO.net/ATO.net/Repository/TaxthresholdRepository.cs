using ATO.net.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace ATO.net.Repository
{
    public class TaxthresholdRepository : TaxthresholdRepositoryInterface
    {
        public Boolean HasRows()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=ATO.net.Models.Model1;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");

            Boolean validRowExist = false;
            using (con)
            {
                TaxthresholdDataContext db = new TaxthresholdDataContext();
                if(db.ReadHasRow()>0)
                {
                    validRowExist = true;
                }
                 else
                {
                    validRowExist = false;
                }
            
                /* SqlCommand command = new SqlCommand("SELECT taxthresholdId FROM TaxthresholdSet;", con);
                 con.Open();

                 SqlDataReader reader = command.ExecuteReader();

                 if (reader.HasRows)
                 {
                     validRowExist = true;
                 }
                 else
                 {
                     validRowExist = false;
                 }
                 reader.Close();*/
            }
            return validRowExist;
        }

        public void InsertToDB(Taxthreshold taxthreshold)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=ATO.net.Models.Model1;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");

            try
            {
                using (con) 
                {
                    TaxthresholdDataContext db = new TaxthresholdDataContext();
                    db.AddTaxthreshold(taxthreshold);

                    /*  {
                         String query = "INSERT INTO dbo.TaxthresholdSet(taxMin, taxCent, taxLump) VALUES (@taxMin, @taxCent, @taxLump)";
                          con.Open();
                          SqlCommand cmd = new SqlCommand(query, con);
                          cmd.Parameters.AddWithValue("@taxMin", taxthreshold.taxMin);
                          cmd.Parameters.AddWithValue("@taxCent", taxthreshold.taxCent);
                          cmd.Parameters.AddWithValue("@taxLump", taxthreshold.taxLump);
                          cmd.ExecuteNonQuery();

                     con.Close();*/
                }
            }
            catch (Exception ex)
            { throw ex; }
            //finally { con.Close(); }
        }

       
        public List<Taxthreshold> ReadTaxthresholdList()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=ATO.net.Models.Model1;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            List<Taxthreshold> taxthresholds = new List<Taxthreshold>();
            try
            {
                using (con)
                {
                    TaxthresholdDataContext db = new TaxthresholdDataContext();
                    taxthresholds = db.ReadTaxthresholdTable();
                   /* SqlCommand command = new SqlCommand("SELECT * FROM dbo.Taxthreshold;", con);
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Taxthreshold taxthreshold = new Taxthreshold();
                        taxthreshold.taxMin = Double.Parse((string)reader["taxMin"].ToString());
                        taxthreshold.taxCent = Double.Parse((string)reader["taxCent"].ToString());
                        taxthreshold.taxLump = Double.Parse((string)reader["taxLump"].ToString());
                        taxthresholds.Add(taxthreshold);
                    }*/
                }
            }
            catch (Exception ex)
            { throw ex; }
            finally { con.Close(); }
            return taxthresholds;
        }

    }
}