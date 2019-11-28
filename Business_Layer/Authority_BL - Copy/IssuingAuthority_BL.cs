using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bcs.arcSpace.Data_Layer;
using bcs.arcSpace.Support_Classes;

namespace bcs.arcSpace.Business_Layer
{
    public class IssuingAuthorityReign_BL
    {


      public static bool InsertIssuingAuthorityReign(Authority objAuthority)
      {
         bool insertSuccessful = false;
         insertSuccessful = IssuingAuthorityReign_DL.InsertIssuingAuthorityReignRecord(objAuthority);
         return insertSuccessful;
      }


      public static bool UpdateIssuingAuthorityReign(Authority objAuthority)
      {
         bool updateSuccessful = false;
         updateSuccessful = IssuingAuthorityReign_DL.UpdateIssuingAuthorityReignRecord(objAuthority);
         return updateSuccessful;
      }

      public static bool DeleteIssuingAuthorityReign(Authority objAuthority)
      {
         bool deleteSuccessful = false;
         deleteSuccessful = IssuingAuthorityReign_DL.DeleteIssuingAuthorityReignRecord(objAuthority);

         return deleteSuccessful;
      }


      public static List<Authority> GetIssuingAuthorityReignList()
      {
         List<Authority> lstAuthority = (List<Authority>)null;
         lstAuthority = IssuingAuthorityReign_DL.GetIssuingAuthorityReignRecordList();
         return lstAuthority;
      }


      public static string GetIssuingAuthorityNameGivenId(List<Authority> lstAuthority, int id)
      {

         // rewrite this in the fashion of similar method in Title_BL.  mch 09.26.2018
         foreach (Authority objAuthority in lstAuthority)
         {
            if (objAuthority.Issuing_Authority_Id == id)
               return objAuthority.Issuing_Authority_Name;
         }
         return null;
      }


      public static int GetTitleIdGivenAuthorityId(List<Authority> lstAuthority, int id)
      {
         int i = -1;
         IEnumerable<Authority> qAuthority = from a in lstAuthority
                                 where a.Issuing_Authority_Id == id
                                 select a;

         foreach (Authority a in qAuthority)
         {
            i = a.Title_Id;
         }

         return i;
      }


      public static int GetStartEraIdGivenAuthorityId(List<Authority> lstAuthority, int id)
      {
         int i = -1;
         IEnumerable<Authority> qAuthority = from a in lstAuthority
                                             where a.Issuing_Authority_Id == id
                                             select a;

         foreach (Authority a in qAuthority)
         {
            i = a.Start_Era_Id;
         }

         return i;
      }


      public static int GetEndEraIdGivenAuthorityId(List<Authority> lstAuthority, int id)
      {
         int i = -1;
         IEnumerable<Authority> qAuthority = from a in lstAuthority
                                             where a.Issuing_Authority_Id == id
                                             select a;

         foreach (Authority a in qAuthority)
         {
            i = a.End_Era_Id;
         }

         return i;
      }

      public static List<Authority> GetAuthority(int authorityId)
      {
         List<Authority> lstAuthority = null;
         lstAuthority = IssuingAuthorityReign_DL.GetIssuingAuthorityReignRecord(authorityId);
         return lstAuthority;
      }

      public static List<Authority> GetAuthorityGivenPeriod(int periodId)
      {
         List<Authority> lstAuthority = null;
         lstAuthority = IssuingAuthorityReign_DL.GetIssuingAuthorityReignRecordGivenPeriodId(periodId);
         return lstAuthority;
      }









   }
}
