using bcs.arcSpace.Data_Layer;
using bcs.arcSpace.Support_Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace bcs.arcSpace.Business_Layer
{
   public class IssuingAuthorityName_BL
   {
      public static bool InsertIssuingAuthorityName(IssuingAuthorityName objIssuingAuthorityName)
      {
         bool insertSuccessful = false;
         insertSuccessful = IssuingAuthorityName_DL.InsertIssuingAuthorityNameRecord(objIssuingAuthorityName);
         return insertSuccessful;
      }

      public static bool UpdateIssuingAuthorityName(IssuingAuthorityName objIssuingAuthorityName)
      {
         bool updateSuccessful = false;
         updateSuccessful = IssuingAuthorityName_DL.UpdateIssuingAuthorityNameRecord(objIssuingAuthorityName);
         return updateSuccessful;
      }

      public static bool DeleteIssuingAuthorityName(IssuingAuthorityName objIssuingAuthorityName)
      {
         bool deleteSuccessful = false;
         deleteSuccessful = IssuingAuthorityName_DL.DeleteIssuingAuthorityNameRecord(objIssuingAuthorityName);
         return deleteSuccessful;
      }

        public static IssuingAuthorityName GetIssuingAuthorityNameObject(int issuingAuthorityNameId)
        {
            IssuingAuthorityName objIssuingAuthorityName = null;
            objIssuingAuthorityName = IssuingAuthorityName_DL.GetIssuingAuthorityNameObject(issuingAuthorityNameId);
            return objIssuingAuthorityName;
        }

        public static List<IssuingAuthorityName> GetIssuingAuthorityNameList()
      {
         List<IssuingAuthorityName> lstIssuingAuthorityName = null;
         lstIssuingAuthorityName = IssuingAuthorityName_DL.GetIssuingAuthorityNameList();
         return lstIssuingAuthorityName;
      }

      //public static Boolean ContainsIssuingAuthorityName(List<IssuingAuthorityName> lstIssuingAuthorityName, string userEnteredIssuingAuthorityName)
      //{
      //   int i = -1;
      //   IEnumerable<IssuingAuthorityName> qIssuingAuthorityName = from a in lstIssuingAuthorityName
      //                                                             where a.Issuing_Authority_Name.Contains(userEnteredIssuingAuthorityName)
      //                                                             select a;

      //   foreach (IssuingAuthorityName a in qIssuingAuthorityName)
      //   {
      //      i = a.Issuing_Authority_Name_Id;
      //   }

      //   if (i == -1)
      //   {
      //      return false;
      //   }
      //   else
      //   {
      //      return true;
      //   }
      //}


      public static int GetIssuingAuthorityNameIdFromListGivenName(List<IssuingAuthorityName> lstIssuingAuthorityName, string userEnteredIssuingAuthorityName)
      {
         IssuingAuthorityName objIssuingAuthorityName = new IssuingAuthorityName();

         int i = -1;
         IEnumerable<IssuingAuthorityName> qIssuingAuthorityName = from a in lstIssuingAuthorityName
                                                                   where a.Issuing_Authority_Name.Contains(userEnteredIssuingAuthorityName)
                                                                   select a;

         foreach (IssuingAuthorityName a in qIssuingAuthorityName)
         {
            i = a.Issuing_Authority_Name_Id;
         }

         return i;
      }


      public static string GetIssuingAuthorityFullNameFromGivenIssuingAuthorityNameId(List<IssuingAuthorityName> lstIssuingAuthorityName, int userEnteredIssuingAuthorityNameId)
      {
         IssuingAuthorityName objIssuingAuthorityName = new IssuingAuthorityName();

         string issuingAuthorityFullName = null;
         IEnumerable<IssuingAuthorityName> qIssuingAuthorityName = from a in lstIssuingAuthorityName
                                                                   where a.Issuing_Authority_Name_Id == userEnteredIssuingAuthorityNameId
                                                                   select a;

         foreach (IssuingAuthorityName a in qIssuingAuthorityName)
         {
            issuingAuthorityFullName = a.Issuing_Authority_Full_Name;
         }

         return issuingAuthorityFullName;
      }
   }
}