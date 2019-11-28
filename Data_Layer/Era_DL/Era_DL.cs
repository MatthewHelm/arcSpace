using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using bcs.arcSpace.Support_Classes;

namespace bcs.arcSpace.Data_Layer
{
    public class Era_DL
    {
      public static bool InsertEraRecord(Era objEra)
      {
         bool insertSuccessful = false;

         if (objEra == (Era) null)
         {
            return insertSuccessful;
         }

         string insertString = "INSERT INTO tblEra (era_name, era_description) VALUES ('{0}', '{1}')";
         insertString = string.Format(insertString, objEra.Era_Name, objEra.Era_Description);

         insertSuccessful = DataLayer.InsertTypeRecord(insertString);

         return insertSuccessful;
      }


      public static bool UpdateEraRecord(Era objEra)
      {
         bool updateSuccessful = false;

         if (objEra == null)
         {
            return updateSuccessful;
         }

         string updateString = "UPDATE tblEra SET era_name = '{0}', era_description = '{1}' WHERE era_id = {2}";
         updateString = string.Format(updateString, objEra.Era_Name, objEra.Era_Description, objEra.Era_Id);

         updateSuccessful = DataLayer.UpdateTypeRecord(updateString);

         return updateSuccessful;
      }

      public static bool DeleteEraRecord(Era objEra)
      {
         bool deleteSuccessful = false;

         if (objEra == (Era)null)
         {
            return deleteSuccessful;
         }

         string deleteStatement = string.Format("DELETE FROM tblEra WHERE era_id = {0}", objEra.Era_Id.ToString());

         deleteSuccessful = DataLayer.DeleteTypeRecord(deleteStatement);

         return deleteSuccessful;
      }



      public static List<Era> GetEraRecordList()
      {
         List<Era> lstEra = new List<Era>();
         Era objEra;

         string selectString = "SELECT era_id, era_name, era_description FROM tblEra";

         SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
         SqlCommand comm = new SqlCommand(selectString, conn);
         SqlDataReader rdr;

         try
         {
            conn.Open();
            rdr = comm.ExecuteReader();

            while (rdr.Read())
            {
               objEra = new Era();
               objEra.Era_Id = Convert.ToInt32(rdr["era_id"]);
               objEra.Era_Name = Convert.ToString(rdr["era_name"]);
               objEra.Era_Description = Convert.ToString(rdr["Era_description"]);

               lstEra.Add(objEra);
            }
         }
         catch
         {
            lstEra = null;
         }
         finally
         {
            conn.Close();
            conn.Dispose();
            comm.Dispose();
         }
         return lstEra;
      }

      public static Era GetEraObject(int eraId)
      {
         Era objEra = (Era) null;

         if (!(eraId > 0))
         {
            return objEra;
         }

         string selectString = "SELECT era_id, era_name, era_description FROM tblEra where era_id = " + eraId.ToString();

         SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
         SqlCommand comm = new SqlCommand(selectString, conn);
         SqlDataReader rdr;

         try
         {
            conn.Open();
            rdr = comm.ExecuteReader();

            while (rdr.Read())
            {
               objEra = new Era();
               objEra.Era_Id = Convert.ToInt32(rdr["era_id"]);
               objEra.Era_Name = Convert.ToString(rdr["era_name"]);
               objEra.Era_Description = Convert.ToString(rdr["Era_description"]);
            }
         }
         catch
         {
            objEra = null;
         }
         finally
         {
            conn.Close();
            conn.Dispose();
            comm.Dispose();
         }
         return objEra;
      }


   }
}
