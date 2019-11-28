using bcs.arcSpace.Support_Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace bcs.arcSpace.Data_Layer
{
   /* START CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD START */

   public class IssuingAuthorityReign_DL
   {
      public static bool InsertIssuingAuthorityReignRecord(IssuingAuthorityReign objIssuingAuthorityReign)
      {
         bool insertSuccessful = false;

         if (objIssuingAuthorityReign == (IssuingAuthorityReign)null)
         {
            return insertSuccessful;
         }

         string insertString = "INSERT INTO tblIssuingAuthorityReign (issuing_authority_biography, period_id, reign_start_year, reign_start_era_id, reign_end_year, reign_end_era_id, issuing_authority_title_id, issuing_authority_id) VALUES ('{0}', '{1}', '{2}', {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})";
         insertString = string.Format(insertString, objIssuingAuthorityReign.Issuing_Authority_Reign_Biography, objIssuingAuthorityReign.Period_Id, objIssuingAuthorityReign.Reign_Start_Year, objIssuingAuthorityReign.Reign_Start_Era_Id, objIssuingAuthorityReign.Reign_End_Year, objIssuingAuthorityReign.Reign_End_Era_Id, objIssuingAuthorityReign.Issuing_Authority_Id);

         insertSuccessful = DataLayer.InsertTypeRecord(insertString);

         return insertSuccessful;
      }

      /*
   CREATE TABLE [dbo].[tblIssuingAuthorityReign](
	[issuing_authority_reign_id] [int] IDENTITY(1,1) NOT NULL,
	[issuing_authority_id] [int] NOT NULL,
	[issuing_authority_title_id] [int] NOT NULL,
	[period_id] [int] NOT NULL,
	[issuing_authority_reign_biography] [varchar](max) NULL,
	[reign_start_year] [int] NULL,
	[reign_start_era_id] [int] NULL,
	[reign_end_year] [int] NULL,
	[reign_end_era_id] [int] NULL,
   */

      public static bool UpdateIssuingAuthorityReignRecord(IssuingAuthorityReign objIssuingAuthorityReign)
      {
         bool updateSuccessful = false;

         if (objIssuingAuthorityReign == null)
         {
            return updateSuccessful;
         }

         string updateString = "UPDATE tblIssuingAuthorityReign set issuing_authority_id = {0}, issuing_authority_title_id = {1}, period_id = {2}, issuing_authority_reign_biography = '{3}', reign_start_year = {4}, reign_start_era_id = {5},  reign_end_year = {6}, reign_end_era_id = {7} where issuing_authority_reign_id = {8}";
         updateString = string.Format(updateString, objIssuingAuthorityReign.Issuing_Authority_Id, objIssuingAuthorityReign.Issuing_Authority_Title_Id, objIssuingAuthorityReign.Period_Id, objIssuingAuthorityReign.Issuing_Authority_Reign_Biography, objIssuingAuthorityReign.Reign_Start_Year, objIssuingAuthorityReign.Reign_Start_Era_Id, objIssuingAuthorityReign.Reign_End_Year, objIssuingAuthorityReign.Reign_End_Era_Id, objIssuingAuthorityReign.Issuing_Authority_Reign_Id);
         updateSuccessful = DataLayer.UpdateTypeRecord(updateString);

         return updateSuccessful;
      }

      /* END CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD END */

      public static bool DeleteIssuingAuthorityReignObject(IssuingAuthorityReign objIssuingAuthorityReign)
      {
         bool deleteSuccessful = false;

         if (objIssuingAuthorityReign == (IssuingAuthorityReign)null)
         {
            return deleteSuccessful;
         }

         string deleteStatement = string.Format("DELETE FROM tblIssuingAuthority WHERE issuing_authority_id = {0}", objIssuingAuthorityReign.Issuing_Authority_Reign_Id.ToString());

         deleteSuccessful = DataLayer.DeleteTypeRecord(deleteStatement);

         return deleteSuccessful;
      }

      /// <summary>
      /// Returns IssuingAuthorityReign object.
      /// </summary>
      /// <param name="issuing_authority_reign_id"></param>
      /// <returns>int issuing_authority_reign_id</returns>
      public static IssuingAuthorityReign GetIssuingAuthorityReignObject(int issuing_authority_reign_id)
      {
         IssuingAuthorityReign objIssuingAuthorityReign = new IssuingAuthorityReign();

         string selectString = "SELECT issuing_authority_reign_id, issuing_authority_title_id, issuing_authority_id, period_id, reign_start_year, reign_start_era_id, reign_end_year, reign_end_era_id, issuing_authority_reign_biography FROM tblIssuingAuthorityReign where issuing_authority_reign_id = {0}";
         selectString = string.Format(selectString, issuing_authority_reign_id.ToString());

         SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
         SqlCommand comm = new SqlCommand(selectString, conn);
         SqlDataReader rdr;

         try
         {
            conn.Open();
            rdr = comm.ExecuteReader();

            while (rdr.Read())
            {
               objIssuingAuthorityReign = new IssuingAuthorityReign();
               objIssuingAuthorityReign.Issuing_Authority_Reign_Id = Convert.ToInt32(rdr["issuing_authority_reign_id"]);
               objIssuingAuthorityReign.Issuing_Authority_Title_Id = Convert.ToInt32(rdr["issuing_authority_title_id"]);
               objIssuingAuthorityReign.Issuing_Authority_Id = Convert.ToInt32(rdr["issuing_authority_id"]);
               objIssuingAuthorityReign.Period_Id = Convert.ToInt32(rdr["period_id"]);
               objIssuingAuthorityReign.Reign_Start_Year = Convert.ToInt32(rdr["reign_start_year"]);
               objIssuingAuthorityReign.Reign_Start_Era_Id = Convert.ToInt32(rdr["reign_start_era_id"]);
               objIssuingAuthorityReign.Reign_End_Year = Convert.ToInt32(rdr["reign_end_year"]);
               objIssuingAuthorityReign.Reign_End_Era_Id = Convert.ToInt32(rdr["reign_end_era_id"]);
               objIssuingAuthorityReign.Issuing_Authority_Reign_Biography = Convert.ToString(rdr["issuing_authority_reign_biography"]);
            }
         }
         catch (Exception ex)
         {
            objIssuingAuthorityReign = null;
         }
         finally
         {
            conn.Close();
            conn.Dispose();
            comm.Dispose();
         }

         return objIssuingAuthorityReign;
      }

      /// <summary>
      /// returns all of the Issuing Authority Reign objects as a list.
      /// </summary>
      /// <returns>List<IssuingAuthorityReign></returns>
      public static List<IssuingAuthorityReign> GetIssuingAuthorityReignList()
      {
         List<IssuingAuthorityReign> lstIssuingAuthorityReign = new List<IssuingAuthorityReign>();
         IssuingAuthorityReign objIssuingAuthorityReign;

         string selectString = "SELECT issuing_authority_reign_id, issuing_authority_id, issuing_authority_title_id, period_id, issuing_authority_reign_biography, reign_start_year, reign_start_era_id,  reign_end_year, reign_end_era_id FROM tblIssuingAuthorityReign";


         SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
         SqlCommand comm = new SqlCommand(selectString, conn);
         SqlDataReader rdr;

         try
         {
            conn.Open();
            rdr = comm.ExecuteReader();

            while (rdr.Read())
            {
               objIssuingAuthorityReign = new IssuingAuthorityReign();
               objIssuingAuthorityReign.Issuing_Authority_Reign_Id = Convert.ToInt32(rdr["issuing_authority_reign_id"]);
               objIssuingAuthorityReign.Issuing_Authority_Id = Convert.ToInt32(rdr["issuing_authority_id"]);
               objIssuingAuthorityReign.Issuing_Authority_Reign_Biography = Convert.ToString(rdr["issuing_authority_reign_biography"]);
               objIssuingAuthorityReign.Period_Id = Convert.ToInt32(rdr["period_id"]);
               objIssuingAuthorityReign.Reign_Start_Year = Convert.ToInt32(rdr["reign_start_year"]);
               objIssuingAuthorityReign.Reign_Start_Era_Id = Convert.ToInt32(rdr["reign_start_era_id"]);
               objIssuingAuthorityReign.Reign_End_Year = Convert.ToInt32(rdr["reign_end_year"]);
               objIssuingAuthorityReign.Reign_End_Era_Id = Convert.ToInt32(rdr["reign_end_era_id"]);
               objIssuingAuthorityReign.Issuing_Authority_Title_Id = Convert.ToInt32(rdr["issuing_authority_title_id"]);

               lstIssuingAuthorityReign.Add(objIssuingAuthorityReign);
            }
         }
         catch(Exception e)
         {
            lstIssuingAuthorityReign = null;
         }
         finally
         {
            conn.Close();
            conn.Dispose();
            comm.Dispose();
         }

         return lstIssuingAuthorityReign;
      }

      /// <summary>
      /// Returns all of the Issuing Authority Reign objects as a list.
      /// </summary>
      /// <param name="issuing_authority_Id"></param>
      /// <returns>List<IssuingAuthorityReign></returns>
      ///
      public static List<IssuingAuthorityReign> GetIssuingAuthorityReignList(int issuing_authority_Id)
      {
         IssuingAuthorityReign objIssuingAuthorityReign;
         List<IssuingAuthorityReign> lstIssuingAuthorityReign = null;

         if (issuing_authority_Id < 1)
         {
            return lstIssuingAuthorityReign;
         }

         string storedProcedureString = "GetIssuingAuthorityReignRecords_sp";
         SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
         SqlCommand comm = new SqlCommand(storedProcedureString, conn);
         SqlDataReader rdr;
         comm.CommandType = System.Data.CommandType.StoredProcedure;
         comm.Parameters.AddWithValue("@AuthorityId", issuing_authority_Id);

         try
         {
            conn.Open();
            rdr = comm.ExecuteReader();

            lstIssuingAuthorityReign = new List<IssuingAuthorityReign>();

            while (rdr.Read())
            {
               objIssuingAuthorityReign = new IssuingAuthorityReign();

               objIssuingAuthorityReign = new IssuingAuthorityReign();
               objIssuingAuthorityReign.Issuing_Authority_Reign_Id = Convert.ToInt32(rdr["issuing_authority_reign_id"]);
               objIssuingAuthorityReign.Issuing_Authority_Title_Id = Convert.ToInt32(rdr["issuing_authority_title_id"]);
               objIssuingAuthorityReign.Issuing_Authority_Id = Convert.ToInt32(rdr["issuing_authority_id"]);
               objIssuingAuthorityReign.Period_Id = Convert.ToInt32(rdr["period_id"]);
               objIssuingAuthorityReign.Reign_Start_Year = Convert.ToInt32(rdr["reign_start_year"]);
               objIssuingAuthorityReign.Reign_Start_Era_Id = Convert.ToInt32(rdr["reign_start_era_id"]);
               objIssuingAuthorityReign.Reign_End_Year = Convert.ToInt32(rdr["reign_end_year"]);
               objIssuingAuthorityReign.Reign_End_Era_Id = Convert.ToInt32(rdr["reign_end_era_id"]);
               objIssuingAuthorityReign.Issuing_Authority_Reign_Biography = Convert.ToString(rdr["issuing_authority_reign_biography"]);

               lstIssuingAuthorityReign.Add(objIssuingAuthorityReign);
            }
         }
         catch (Exception ex)
         {
            lstIssuingAuthorityReign = null;
         }
         finally
         {
            conn.Close();
            conn.Dispose();
            comm.Dispose();
         }

         return lstIssuingAuthorityReign;
      }


      /// <summary>
      /// Returns IssuingAuthorityReign list based on given period_id.
      /// </summary>
      /// <param name="periodId"></param>
      /// <returns>List<IssuingAuthorityReign></IssuingAuthorityReign></returns>
      public static List<IssuingAuthorityReign> GetIssuingAuthorityReignListByPeriodId(int periodId)
      {
         IssuingAuthorityReign objIssuingAuthorityReign;
         List<IssuingAuthorityReign> lstIssuingAuthorityReign = null;

         if (periodId < 1)
         {
            return lstIssuingAuthorityReign;
         }

         string storedProcedureString = "GetIssuingAuthorityReignGivenPeriodId_sp";
         SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
         SqlCommand comm = new SqlCommand(storedProcedureString, conn);
         SqlDataReader rdr;
         comm.CommandType = System.Data.CommandType.StoredProcedure;
         comm.Parameters.AddWithValue("@PeriodId", periodId);

         try
         {
            conn.Open();
            rdr = comm.ExecuteReader();

            lstIssuingAuthorityReign = new List<IssuingAuthorityReign>();

            while (rdr.Read())
            {
               objIssuingAuthorityReign = new IssuingAuthorityReign();

               objIssuingAuthorityReign = new IssuingAuthorityReign();
               objIssuingAuthorityReign.Issuing_Authority_Reign_Id = Convert.ToInt32(rdr["issuing_authority_reign_id"]);
               objIssuingAuthorityReign.Issuing_Authority_Reign_Biography = Convert.ToString(rdr["issuing_authority_biography"]);
               objIssuingAuthorityReign.Period_Id = Convert.ToInt32(rdr["period_id"]);
               objIssuingAuthorityReign.Reign_Start_Year = Convert.ToInt32(rdr["reign_start_year"]);
               objIssuingAuthorityReign.Reign_Start_Era_Id = Convert.ToInt32(rdr["reign_start_era_id"]);
               objIssuingAuthorityReign.Reign_End_Year = Convert.ToInt32(rdr["reign_end_year"]);
               objIssuingAuthorityReign.Reign_End_Era_Id = Convert.ToInt32(rdr["reign_end_era_id"]);
               objIssuingAuthorityReign.Issuing_Authority_Title_Id = Convert.ToInt32(rdr["issuing_authority_title_id"]);

               lstIssuingAuthorityReign.Add(objIssuingAuthorityReign);
            }
         }
         catch (Exception ex)
         {
            lstIssuingAuthorityReign = null;
         }
         finally
         {
            conn.Close();
            conn.Dispose();
            comm.Dispose();
         }
         return lstIssuingAuthorityReign;
      }
   }
}