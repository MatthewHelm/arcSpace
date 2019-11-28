using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bcs.arcSpace.Support_Classes;
using bcs.arcSpace.Data_Layer;

namespace bcs.arcSpace.Data_Layer
{
   public class Country_DL
    {
      static private string ConnectionString = "Data Source=BCSWS7;Initial Catalog=\"Ancient Roman Coins\";Integrated Security=True";

      public static List<Country> GetCountryRecordList()
      {
         List<Country> lstCountry = new List<Country>();
         Country objCountry;

         string selectString = "SELECT country_id, country_name from tblCountry";

         SqlConnection conn = new SqlConnection(ConnectionString);
         SqlCommand comm = new SqlCommand(selectString, conn);
         SqlDataReader rdr;

         try
         {
            conn.Open();
            rdr = comm.ExecuteReader();

            while (rdr.Read())
            {
               objCountry = new Country();
               objCountry.Country_Id = Convert.ToInt32(rdr["country_id"]);
               objCountry.Country_Name = Convert.ToString(rdr["country_name"]);

               lstCountry.Add(objCountry);
            }
         }
         catch
         {
            lstCountry = null;
         }
         finally
         {
            conn.Close();
            conn.Dispose();
            comm.Dispose();
         }

         return lstCountry;
      }
   }
}
