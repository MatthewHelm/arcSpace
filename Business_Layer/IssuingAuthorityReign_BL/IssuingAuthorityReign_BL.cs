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


      public static bool InsertIssuingAuthorityReign(IssuingAuthorityReign objIssuingAuthorityReign)
      {
         bool insertSuccessful = false;
         insertSuccessful = IssuingAuthorityReign_DL.InsertIssuingAuthorityReignRecord(objIssuingAuthorityReign);
         return insertSuccessful;
      }


      public static bool UpdateIssuingAuthorityReign(IssuingAuthorityReign objIssuingAuthorityReign)
      {
         bool updateSuccessful = false;
         updateSuccessful = IssuingAuthorityReign_DL.UpdateIssuingAuthorityReignRecord(objIssuingAuthorityReign);
         return updateSuccessful;
      }

      public static bool DeleteIssuingAuthorityReign(IssuingAuthorityReign objIssuingAuthorityReign)
      {
         bool deleteSuccessful = false;
         deleteSuccessful = IssuingAuthorityReign_DL.DeleteIssuingAuthorityReignObject(objIssuingAuthorityReign);

         return deleteSuccessful;
      }


      public static List<IssuingAuthorityReign> GetIssuingAuthorityReignList()
      {
         List<IssuingAuthorityReign> lstIssuingAuthorityReign = (List<IssuingAuthorityReign>)null;
         lstIssuingAuthorityReign = IssuingAuthorityReign_DL.GetIssuingAuthorityReignList();
         return lstIssuingAuthorityReign;
      }

      public static IssuingAuthorityReign GetIssuingAuthorityReign(int issuing_authority_reign_id)
        {
            IssuingAuthorityReign objIssuingAuthorityReign = (IssuingAuthorityReign)null;
            objIssuingAuthorityReign = IssuingAuthorityReign_DL.GetIssuingAuthorityReignObject(issuing_authority_reign_id);
            return objIssuingAuthorityReign;
        }

      public static int GetIssuingAuthorityTitleIdByIssuingAuthorityReignId(List<IssuingAuthorityReign> lstIssuingAuthorityReign, int id)
      {
         int i = -1;
         IEnumerable<IssuingAuthorityReign> qIssuingAuthorityReign = from a in lstIssuingAuthorityReign
                                 where a.Issuing_Authority_Reign_Id == id
                                 select a;

         foreach (IssuingAuthorityReign a in qIssuingAuthorityReign)
         {
            i = a.Issuing_Authority_Title_Id;
         }
         return i;
      }


      public static int GetReignStartEraIdGivenIssuingAuthorityReignId(List<IssuingAuthorityReign> lstIssuingAuthorityReign, int id)
      {
         int i = -1;
         IEnumerable<IssuingAuthorityReign> qIssuingAuthorityReign = from a in lstIssuingAuthorityReign
                                             where a.Issuing_Authority_Reign_Id == id
                                             select a;

         foreach (IssuingAuthorityReign a in qIssuingAuthorityReign)
         {
            i = a.Reign_Start_Era_Id;
         }
         return i;
      }


      public static int GetReignEndEraIdGivenIssuingAuthorityReignId(List<IssuingAuthorityReign> lstAuthority, int id)
      {
         int i = -1;
         IEnumerable<IssuingAuthorityReign> qIssuingAuthorityReign = from a in lstAuthority
                                             where a.Issuing_Authority_Reign_Id == id
                                             select a;

         foreach (IssuingAuthorityReign a in qIssuingAuthorityReign)
         {
            i = a.Reign_End_Era_Id;
         }
         return i;
      }

      public static List<IssuingAuthorityReign> GetIssuingAuthorityReignEntries(int issuing_authority_id)
      {
         List<IssuingAuthorityReign> lstAuthority = null;
         lstAuthority = IssuingAuthorityReign_DL.GetIssuingAuthorityReignList(issuing_authority_id);
         return lstAuthority;
      }

      public static List<IssuingAuthorityReign> GetAuthorityGivenPeriod(int periodId)
      {
         List<IssuingAuthorityReign> lstAuthority = null;
         lstAuthority = IssuingAuthorityReign_DL.GetIssuingAuthorityReignListByPeriodId(periodId);
         return lstAuthority;
      }
   }
}
