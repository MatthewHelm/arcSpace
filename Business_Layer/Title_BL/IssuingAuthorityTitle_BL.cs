using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bcs.arcSpace.Data_Layer;
using bcs.arcSpace.Support_Classes;

namespace bcs.arcSpace.Business_Layer
{
    public class IssuingAuthorityTitle_BL
    {

      public static bool InsertIssuingAuthorityTitle(IssuingAuthorityTitle objTitle)
      {
         bool insertSuccessful = false;
         insertSuccessful = IssuingAuthorityTitle_DL.InsertIssuingAuthorityTitleRecord(objTitle);
         return insertSuccessful;
      }


      public static bool UpdateIssuingAuthorityTitle(IssuingAuthorityTitle objTitle)
      {
         bool updateSuccessful = false;
         updateSuccessful = IssuingAuthorityTitle_DL.UpdateIssuingAuthorityTitleRecord(objTitle);
         return updateSuccessful;
      }

      public static bool DeleteIssuingAuthorityTitle(IssuingAuthorityTitle objTitle)
      {
         bool deleteSuccessful = false;
         deleteSuccessful = IssuingAuthorityTitle_DL.DeleteIssuingAuthorityTitleRecord(objTitle);
         return deleteSuccessful;
      }


      public static List<IssuingAuthorityTitle> GetIssuingAuthorityTitleList()
      {
         List<IssuingAuthorityTitle> lstTitle = (List<IssuingAuthorityTitle>)null;
         lstTitle = IssuingAuthorityTitle_DL.GetIssuingAuthorityTitleList();
         return lstTitle;
      }


      public static IssuingAuthorityTitle GetIssuingAuthorityTitleObject(int issuingAuthorityTitleId)
      {
         IssuingAuthorityTitle objIssuingAuthorityTitle = (IssuingAuthorityTitle) null;
         objIssuingAuthorityTitle = IssuingAuthorityTitle_DL.GetIssuingAuthorityTitle(issuingAuthorityTitleId);
         return objIssuingAuthorityTitle;
      }



      public static string GetIssuingAuthorityTitleGivenId(List<IssuingAuthorityTitle> lstTitle, int id)
      {
         string str = null;
         IEnumerable<IssuingAuthorityTitle> qTitle  = from t in lstTitle
         where t.Title_Id == id
         select t;

         foreach(IssuingAuthorityTitle t in qTitle)
         {
            str = t.Issuing_Authority_Title;

         }

         str = str.Trim();

         if (string.IsNullOrEmpty((str)))
         {
            return null;
         }

         return str;
      }



   }
}
