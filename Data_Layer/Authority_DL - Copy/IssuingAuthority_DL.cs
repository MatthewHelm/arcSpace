using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using bcs.arcSpace.Support_Classes;

namespace bcs.arcSpace.Data_Layer
{
    public class IssuingAuthorityReign_DL
    {
      public static bool InsertIssuingAuthorityRecord(Authority objAuthority)
      {
         bool insertSuccessful = false;

         if (objAuthority == (Authority)null)
         {
            return insertSuccessful;
         }

         string insertString = "INSERT INTO tblIssuingAuthority (issuing_authority_name, issuing_authority_full_name, issuing_authority_biography, period_id, start_year, start_era_id, end_year, end_era_id, issuing_authority_title_id, issuing_authority_name_id) VALUES ('{0}', '{1}', '{2}', {3}, {4}, {5}, {6}, {7}, {8}, {9})";
         insertString = string.Format(insertString, objAuthority.Issuing_Authority_Name, objAuthority.Issuing_Authority_Full_Name, objAuthority.Issuing_Authority_Biography, objAuthority.Period_Id, objAuthority.Start_Year, objAuthority.Start_Era_Id, objAuthority.End_Year, objAuthority.End_Era_Id, objAuthority.Issuing_Authority_Name_Id, objAuthority.Issuing_Authority_Name_Id);

         insertSuccessful = DataLayer.InsertTypeRecord(insertString);

         return insertSuccessful;
      }


      public static bool UpdateIssuingAuthorityRecord(Authority objAuthority)
      {

         bool updateSuccessful = false;

         if (objAuthority == null)
         {
            return updateSuccessful;
         }

         string updateString = "UPDATE tblIssuingAuthority SET issuing_authority_name = '{0}', issuing_authority_full_name = '{1}', issuing_authority_biography = '{2}', period_id = {3}, start_year = {5}, start_era_id = {6}, end_year = {7}, end_era_id = {8}, issuing_authority_title_id = {9}, issuing_authority_name_id = {10} WHERE issuing_authority_id = {4}";
         updateString = string.Format(updateString, objAuthority.Issuing_Authority_Name, objAuthority.Issuing_Authority_Full_Name, objAuthority.Issuing_Authority_Biography, objAuthority.Period_Id, objAuthority.Issuing_Authority_Id, objAuthority.Start_Year, objAuthority.Start_Era_Id, objAuthority.End_Year, objAuthority.End_Era_Id, objAuthority.Title_Id, objAuthority.Issuing_Authority_Name_Id);


         updateSuccessful = DataLayer.UpdateTypeRecord(updateString);

         return updateSuccessful;
      }


      public static bool DeleteIssuingAuthorityRecord(Authority objAuthority)
      {
         bool deleteSuccessful = false;

         if (objAuthority == (Authority)null)
         {
            return deleteSuccessful;
         }

         string deleteStatement = string.Format("DELETE FROM tblIssuingAuthority WHERE issuing_authority_id = {0}", objAuthority.Issuing_Authority_Id.ToString());

         deleteSuccessful = DataLayer.DeleteTypeRecord(deleteStatement);

         return deleteSuccessful;
      }


      public static List<Authority> GetIssuingAuthorityRecordList()
      {
         List<Authority> lstAuthority = new List<Authority>();
         Authority objAuthority;

         string selectString = "SELECT issuing_authority_id, issuing_authority_name, issuing_authority_full_name, issuing_authority_biography, period_id, start_year, start_era_id, end_year, end_era_id, issuing_authority_title_id, issuing_authority_name_id FROM tblIssuingAuthority";

         SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
         SqlCommand comm = new SqlCommand(selectString, conn);
         SqlDataReader rdr;

         try
         {
            conn.Open();
            rdr = comm.ExecuteReader();

            while (rdr.Read())
            {
               objAuthority = new Authority();
               objAuthority.Issuing_Authority_Id = Convert.ToInt32(rdr["issuing_authority_id"]);
               objAuthority.Issuing_Authority_Name = Convert.ToString(rdr["issuing_authority_name"]);
               objAuthority.Issuing_Authority_Full_Name = Convert.ToString(rdr["issuing_authority_full_name"]);
               objAuthority.Issuing_Authority_Biography = Convert.ToString(rdr["issuing_authority_biography"]);
               objAuthority.Period_Id = Convert.ToInt32(rdr["period_id"]);
               objAuthority.Start_Year = Convert.ToInt32(rdr["start_year"]).ToString();
               objAuthority.Start_Era_Id = Convert.ToInt32(rdr["start_era_id"]);
               objAuthority.End_Year = Convert.ToInt32(rdr["end_year"]).ToString();
               objAuthority.End_Era_Id = Convert.ToInt32(rdr["end_era_id"]);
               objAuthority.Title_Id = Convert.ToInt32(rdr["issuing_authority_title_id"]);
               objAuthority.Issuing_Authority_Name_Id = Convert.ToInt32(rdr["issuing_authority_name_id"]);

               lstAuthority.Add(objAuthority);
            }
         }
         catch
         {
            lstAuthority = null;
         }
         finally
         {
            conn.Close();
            conn.Dispose();
            comm.Dispose();
         }

         return lstAuthority;
      }


      public static List<Authority> GetIssuingAuthorityRecord(int authorityId)
      {
         Authority objAuthority;
         List<Authority> lstAuthority = null;

         if (authorityId < 1)
         {
            return lstAuthority;
         }


         string storedProcedureString = "GetAuthority_SP";
         SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
         SqlCommand comm = new SqlCommand(storedProcedureString, conn);
         SqlDataReader rdr;
         comm.CommandType = System.Data.CommandType.StoredProcedure;
         comm.Parameters.AddWithValue("@AuthorityId", authorityId);

         try
         {
            conn.Open();
            rdr = comm.ExecuteReader();

            lstAuthority = new List<Authority>();

            while (rdr.Read())
            {
               objAuthority = new Authority();

               objAuthority = new Authority();
               objAuthority.Issuing_Authority_Id = Convert.ToInt32(rdr["issuing_authority_id"]);
               objAuthority.Issuing_Authority_Name = Convert.ToString(rdr["issuing_authority_name"]);
               objAuthority.Issuing_Authority_Full_Name = Convert.ToString(rdr["issuing_authority_full_name"]);
               objAuthority.Issuing_Authority_Biography = Convert.ToString(rdr["issuing_authority_biography"]);
               objAuthority.Period_Id = Convert.ToInt32(rdr["period_id"]);
               objAuthority.Start_Year = Convert.ToInt32(rdr["start_year"]).ToString();
               objAuthority.Start_Era_Id = Convert.ToInt32(rdr["start_era_id"]);
               objAuthority.End_Year = Convert.ToInt32(rdr["end_year"]).ToString();
               objAuthority.End_Era_Id = Convert.ToInt32(rdr["end_era_id"]);
               objAuthority.Title_Id = Convert.ToInt32(rdr["issuing_authority_title_id"]);
               objAuthority.Issuing_Authority_Name_Id = Convert.ToInt32(rdr["issuing_authority_name_id"]);

               lstAuthority.Add(objAuthority);
            }
         }
         catch (Exception ex)
         {
            lstAuthority = null;
         }
         finally
         {
            conn.Close();
            conn.Dispose();
            comm.Dispose();
         }

         return lstAuthority;
      }


      public static List<Authority> GetIssuingAuthorityRecordGivenPeriodId(int periodId)
      {
         Authority objAuthority;
         List<Authority> lstAuthority = null;

         if (periodId < 1)
         {
            return lstAuthority;
         }


         string storedProcedureString = "GetAuthorityGivenPeriodId_sp";
         SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
         SqlCommand comm = new SqlCommand(storedProcedureString, conn);
         SqlDataReader rdr;
         comm.CommandType = System.Data.CommandType.StoredProcedure;
         comm.Parameters.AddWithValue("@PeriodId", periodId);

         try
         {
            conn.Open();
            rdr = comm.ExecuteReader();

            lstAuthority = new List<Authority>();

            while (rdr.Read())
            {
               objAuthority = new Authority();

               objAuthority = new Authority();
               objAuthority.Issuing_Authority_Id = Convert.ToInt32(rdr["issuing_authority_id"]);
               objAuthority.Issuing_Authority_Name = Convert.ToString(rdr["issuing_authority_name"]);
               objAuthority.Issuing_Authority_Full_Name = Convert.ToString(rdr["issuing_authority_full_name"]);
               objAuthority.Issuing_Authority_Biography = Convert.ToString(rdr["issuing_authority_biography"]);
               objAuthority.Period_Id = Convert.ToInt32(rdr["period_id"]);
               objAuthority.Start_Year = Convert.ToInt32(rdr["start_year"]).ToString();
               objAuthority.Start_Era_Id = Convert.ToInt32(rdr["start_era_id"]);
               objAuthority.End_Year = Convert.ToInt32(rdr["end_year"]).ToString();
               objAuthority.End_Era_Id = Convert.ToInt32(rdr["end_era_id"]);
               objAuthority.Title_Id = Convert.ToInt32(rdr["issuing_authority_title_id"]);
               objAuthority.Issuing_Authority_Name_Id = Convert.ToInt32(rdr["issuing_authority_name_id"]);

               lstAuthority.Add(objAuthority);
            }
         }
         catch (Exception ex)
         {
            lstAuthority = null;
         }
         finally
         {
            conn.Close();
            conn.Dispose();
            comm.Dispose();
         }

         return lstAuthority;
      }



   }
}
