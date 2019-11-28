using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bcs.arcSpace.Support_Classes;
using bcs.arcSpace.Data_Layer;


namespace bcs.arcSpace.Data_Layer
{
    public static class Mint_DL
    {

       public static bool InsertMintRecord(Mint objMint)
       {
          bool insertSuccessful = false;

          if (objMint == (Mint) null)
          {
             return insertSuccessful;
          }

          string insertString = "INSERT INTO dbo.tblMint (mint_name, description, mint_location, service_start_date, service_end_date, modern_location, mint_abbreviations) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')";

          insertString = string.Format(insertString, objMint.Mint_Name, objMint.Description, objMint.Mint_Location, objMint.Service_Start_Date, objMint.Service_End_Date, objMint.Modern_Location, objMint.Mint_Abbreviations);

          insertSuccessful = DataLayer.InsertTypeRecord(insertString);

          return insertSuccessful;
       }


       public static bool UpdateMintRecord(Mint objMint)
       {
          bool updateSuccessful = false;

          if (objMint == null)
          {
             return updateSuccessful;
          }

          if (string.IsNullOrEmpty(objMint.Mint_Name))
          {
             return updateSuccessful;
          }

         string updateString = "UPDATE tblMint SET mint_name = '{0}', description = '{1}', mint_location = '{2}', service_start_date = '{3}', service_end_date = '{4}', modern_location = '{5}', mint_abbreviations = '{6}' WHERE mint_id = {7}";
         updateString = string.Format(updateString, objMint.Mint_Name, objMint.Description, objMint.Mint_Location, objMint.Service_Start_Date, objMint.Service_End_Date, objMint.Modern_Location, objMint.Mint_Abbreviations, objMint.Mint_Id);

         updateSuccessful = DataLayer.UpdateTypeRecord(updateString);

         return updateSuccessful;
       }

       public static bool DeleteMintRecord(Mint objMint)
       {
          bool deleteSuccessful = false;

          if (objMint == (Mint) null)
          {
             return deleteSuccessful;
          }

          string deleteStatement = string.Format("DELETE FROM tblMint WHERE mint_id = {0}", objMint.Mint_Id.ToString());

          deleteSuccessful = DataLayer.DeleteTypeRecord(deleteStatement);

          return deleteSuccessful;
       }

       public static List<Mint> GetMintRecordList()
       {
          List<Mint> lstMint = (List<Mint>) null;

          string selectString = "SELECT mint_id, mint_name, description, mint_location, service_start_date, service_end_date, modern_location, mint_abbreviations FROM dbo.tblMint";
           
           Mint objMint;

           lstMint = new List<Mint>();

          SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
          SqlCommand comm = new SqlCommand(selectString, conn);
          SqlDataReader rdr;

          try
          {
             conn.Open();
             rdr = comm.ExecuteReader();

             while(rdr.Read())
             {
                objMint = new Mint();

                objMint.Mint_Id = Convert.ToInt32(rdr["mint_id"]);
                objMint.Mint_Name = Convert.ToString(rdr["mint_name"]);
                objMint.Description = Convert.ToString(rdr["description"]);
                objMint.Mint_Location = Convert.ToString(rdr["mint_location"]);
                objMint.Service_Start_Date = Convert.ToString(rdr["service_start_date"]);
                objMint.Service_End_Date = Convert.ToString(rdr["service_end_date"]);
                objMint.Modern_Location = Convert.ToString(rdr["modern_location"]);
                objMint.Mint_Abbreviations = Convert.ToString(rdr["mint_abbreviations"]);

                lstMint.Add(objMint);
             }
             
          }
          catch (Exception ex)
          {
              lstMint = (List<Mint>) null;
          }
          finally
          {
             conn.Close();
             conn.Dispose();
             comm.Dispose();
          }
          return lstMint;
       }

    }
}
