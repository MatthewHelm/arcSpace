using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using bcs.arcSpace.Support_Classes;

namespace bcs.arcSpace.Data_Layer
{
    public class IssuingAuthorityTitle_DL
    {
      public static bool InsertIssuingAuthorityTitleRecord(IssuingAuthorityTitle objIssuingAuthorityTitle)
      {
         bool insertSuccessful = false;

         if (objIssuingAuthorityTitle == (IssuingAuthorityTitle) null)
         {
            return insertSuccessful;
         }

         string insertString = "INSERT INTO tblIssuingAuthorityTitle (issuing_authority_title, description) VALUES ('{0}', '{1}')";
         insertString = string.Format(insertString, objIssuingAuthorityTitle.Issuing_Authority_Title, objIssuingAuthorityTitle.Description);

         insertSuccessful = DataLayer.InsertTypeRecord(insertString);

         return insertSuccessful;
      }


      public static bool UpdateIssuingAuthorityTitleRecord(IssuingAuthorityTitle objIssuingAuthorityTitle)
      {

         bool updateSuccessful = false;

         if (objIssuingAuthorityTitle == null)
         {
            return updateSuccessful;
         }

         string updateString = "UPDATE tblIssuingAuthorityTitle SET issuing_authority_title = '{0}', description = '{1}' WHERE issuing_authority_title_id = {2}";
         updateString = string.Format(updateString, objIssuingAuthorityTitle.Issuing_Authority_Title, objIssuingAuthorityTitle.Description, objIssuingAuthorityTitle.Title_Id);


         updateSuccessful = DataLayer.UpdateTypeRecord(updateString);

         return updateSuccessful;
      }



      public static bool DeleteIssuingAuthorityTitleRecord(IssuingAuthorityTitle objIssuingAuthorityTitle)
      {
         bool deleteSuccessful = false;

         if (objIssuingAuthorityTitle == (IssuingAuthorityTitle) null)
         {
            return deleteSuccessful;
         }

         string deleteStatement = string.Format("DELETE FROM tblIssuingAuthorityTitle WHERE issuing_authority_title_id = {0}", objIssuingAuthorityTitle.Title_Id.ToString());

         deleteSuccessful = DataLayer.DeleteTypeRecord(deleteStatement);

         return deleteSuccessful;
      }



      public static IssuingAuthorityTitle GetIssuingAuthorityTitle(int issuingAuthorityTitleId)
      {
         IssuingAuthorityTitle objIssuingAuthorityTitle = (IssuingAuthorityTitle) null;

         if (!(issuingAuthorityTitleId > 0))
         {
            return objIssuingAuthorityTitle;
         }

         string selectString = "select issuing_authority_title_id, issuing_authority_title, description from tblIssuingAuthorityTitle where issuing_authority_title_id = {0}";
         selectString = string.Format(selectString, issuingAuthorityTitleId.ToString());

         SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
         SqlCommand comm = new SqlCommand(selectString, conn);
         SqlDataReader rdr;

         try
         {
            conn.Open();
            rdr = comm.ExecuteReader();

            while (rdr.Read())
            {
               objIssuingAuthorityTitle = new IssuingAuthorityTitle();
               objIssuingAuthorityTitle.Title_Id = Convert.ToInt32(rdr["issuing_authority_title_id"]);
               objIssuingAuthorityTitle.Issuing_Authority_Title = Convert.ToString(rdr["issuing_authority_title"]);
               objIssuingAuthorityTitle.Description = Convert.ToString(rdr["description"]);
            }
         }
         catch
         {
            objIssuingAuthorityTitle = null;
         }
         finally
         {
            conn.Close();
            conn.Dispose();
            comm.Dispose();
         }

         return objIssuingAuthorityTitle;

      }

      public static List<IssuingAuthorityTitle> GetIssuingAuthorityTitleList()
      {
         List<IssuingAuthorityTitle> lstIssuingAuthorityTitle = new List<IssuingAuthorityTitle>();
         IssuingAuthorityTitle objIssuingAuthorityTitle;

         string selectString = "SELECT issuing_authority_title_id, issuing_authority_title, description FROM tblIssuingAuthorityTitle";

         SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
         SqlCommand comm = new SqlCommand(selectString, conn);
         SqlDataReader rdr;

         try
         {
            conn.Open();
            rdr = comm.ExecuteReader();

            while (rdr.Read())
            {
               objIssuingAuthorityTitle = new IssuingAuthorityTitle();
               objIssuingAuthorityTitle.Title_Id = Convert.ToInt32(rdr["issuing_authority_title_id"]);
               objIssuingAuthorityTitle.Issuing_Authority_Title = Convert.ToString(rdr["issuing_authority_title"]);
               objIssuingAuthorityTitle.Description = Convert.ToString(rdr["description"]);

               lstIssuingAuthorityTitle.Add(objIssuingAuthorityTitle);
            }
         }
         catch
         {
            lstIssuingAuthorityTitle = null;
         }
         finally
         {
            conn.Close();
            conn.Dispose();
            comm.Dispose();
         }
         
         return lstIssuingAuthorityTitle;
      }





   }
}
