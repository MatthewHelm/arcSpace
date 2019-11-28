using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bcs.arcSpace.Support_Classes;

namespace bcs.arcSpace.Data_Layer
{
    public class Period_DL
    {

      public static Boolean InsertPeriodRecord(Period objPeriod)
      {
         bool insertSuccessful = false;

         if (objPeriod == (Period) null)
         {
            return insertSuccessful;
         }

         string insertString = "INSERT INTO dbo.tblPeriod (period_name, period_description, start_year, start_era_id, end_year, end_era_id, seq_no) VALUES ('{0}', '{1}', {2}, {3}, {4}, {5}, {6})";

         insertString = string.Format(insertString, objPeriod.Period_Name, objPeriod.Period_Description, objPeriod.Start_Year, objPeriod.Start_Era_Id, objPeriod.End_Year, objPeriod.End_Era_Id, objPeriod.Seq_No);

         insertSuccessful = DataLayer.InsertTypeRecord(insertString);

         return insertSuccessful;
      }



      public static bool UpdatePeriodRecord(Period objPeriod)
      {
         bool updateSuccessful = false;

         if (objPeriod == null)
         {
            return updateSuccessful;
         }

         if (string.IsNullOrEmpty(objPeriod.Period_Name))
         {
            return updateSuccessful;
         }
         // "INSERT INTO dbo.tblPeriod (period_name, period_description, start_year, start_era_id, end_year, end_era_id, seq_no) VALUES ('{0}', '{1}', {2}, {3}, {4}, {5}, {6})";
         string updateString = "UPDATE tblPeriod SET period_name = '{0}', period_description = '{1}', start_year = {2}, start_era_id = {3}, end_year = {4}, end_era_id = {5}, seq_no = {6} WHERE period_id = {7}";
         updateString = string.Format(updateString, objPeriod.Period_Name, objPeriod.Period_Description, objPeriod.Start_Year, objPeriod.Start_Era_Id, objPeriod.End_Year, objPeriod.End_Era_Id, objPeriod.Seq_No, objPeriod.Period_Id);

         updateSuccessful = DataLayer.UpdateTypeRecord(updateString);

         return updateSuccessful;
      }

      public static bool DeletePeriodRecord(Period objPeriod)
      {
         bool deleteSuccessful = false;

         if (objPeriod == (Period)null)
         {
            return deleteSuccessful;
         }

         string deleteStatement = string.Format("DELETE FROM tblPeriod WHERE period_id = {0}", objPeriod.Period_Id.ToString());

         deleteSuccessful = DataLayer.DeleteTypeRecord(deleteStatement);

         return deleteSuccessful;
      }



      public static List<Period> GetPeriodRecordList()
      {
         List<Period> lstPeriod = (List<Period>)null;

         string selectString = "SELECT period_id, period_name, period_description, start_year, start_era_id, end_year, end_era_id, seq_no FROM dbo.tblPeriod";

         Period objPeriod;

         lstPeriod = new List<Period>();

         SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
         SqlCommand comm = new SqlCommand(selectString, conn);
         SqlDataReader rdr;

         try
         {
            conn.Open();
            rdr = comm.ExecuteReader();

            while (rdr.Read())
            {
               objPeriod = new Period();

               objPeriod.Period_Id = Convert.ToInt32(rdr["period_id"]);
               objPeriod.Period_Name = Convert.ToString(rdr["period_name"]);
               objPeriod.Period_Description = Convert.ToString(rdr["period_description"]);
               objPeriod.Start_Year = Convert.ToInt32(rdr["start_year"]);
               objPeriod.Start_Era_Id = Convert.ToInt32(rdr["start_era_id"]);
               objPeriod.End_Year = Convert.ToInt32(rdr["end_year"]);
               objPeriod.End_Era_Id = Convert.ToInt32(rdr["End_era_id"]);
               objPeriod.Seq_No = Convert.ToInt32(rdr["seq_no"]);

               lstPeriod.Add(objPeriod);
            }
         }
         catch (Exception ex)
         {
            lstPeriod = (List<Period>)null;
         }
         finally
         {
            conn.Close();
            conn.Dispose();
            comm.Dispose();
         }
         return lstPeriod;
      }


      public static List<Period> GetPeriodListHavingCoins()
      {
         Period objPeriod = (Period) null;
         List<Period> lstPeriod = (List<Period>) null;

         SqlConnection conn;
         SqlCommand comm;
         SqlDataReader rdr;


         string storedProcedureString = "GetPeriodsHavingCoins_sp";
         conn = new SqlConnection(DataLayer.ConnectionString);
         comm = new SqlCommand(storedProcedureString, conn);

         comm.CommandType = System.Data.CommandType.StoredProcedure;

         lstPeriod = new List<Period>();

         try
         {
            conn.Open();
            rdr = comm.ExecuteReader();
            while (rdr.Read())  // should only return single instance
            {
               objPeriod = new Period();

               objPeriod.Period_Id = Convert.ToInt32(rdr["period_id"]);
               objPeriod.Period_Name = Convert.ToString(rdr["period_name"]);
               objPeriod.Period_Description = Convert.ToString(rdr["period_description"]);
               objPeriod.Start_Year = Convert.ToInt32(rdr["start_year"]);
               objPeriod.Start_Era_Id = Convert.ToInt32(rdr["start_era_id"]);
               objPeriod.End_Year = Convert.ToInt32(rdr["end_year"]);  
               objPeriod.End_Era_Id = Convert.ToInt32(rdr["End_era_id"]);

               lstPeriod.Add(objPeriod);
            }


         }
         catch
         {
            lstPeriod = (List<Period>) null;
         }
         finally
         {
            conn.Close();
            conn.Dispose();
            comm.Dispose();
         }

         return lstPeriod;
      }



   }
}
