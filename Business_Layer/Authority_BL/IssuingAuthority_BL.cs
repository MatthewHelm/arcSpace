using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bcs.arcSpace.Data_Layer;
using bcs.arcSpace.Support_Classes;

namespace bcs.arcSpace.Business_Layer
{
    public class IssuingAuthority_BL
    {
      public static bool InsertIssuingAuthority(IssuingAuthority objAuthority)
      {
         bool insertSuccessful = false;
         insertSuccessful =  IssuingAuthority_DL.InsertIssuingAuthorityRecord(objAuthority);
         return insertSuccessful;
      }


      public static bool UpdateIssuingAuthority(IssuingAuthority objAuthority)
      {
         bool updateSuccessful = false;
         updateSuccessful = IssuingAuthority_DL.UpdateIssuingAuthorityRecord(objAuthority);
         return updateSuccessful;
      }

      public static bool DeleteIssuingAuthority(IssuingAuthority objAuthority)
      {
         bool deleteSuccessful = false;
  //       deleteSuccessful = IssuingAuthority_DL.DeleteIssuingAuthorityReignRecord(objAuthority);

         return deleteSuccessful;
      }


      public static List<IssuingAuthority> GetIssuingAuthorityList()
      {
         List<IssuingAuthority> lstAuthority = (List<IssuingAuthority>)null;
   //      lstAuthority = IssuingAuthority_DL.GetIssuingAuthorityRecordList();
         return lstAuthority;
      }


      public static IssuingAuthority GetIssuingAuthorityObject(int authorityId)
      {
         IssuingAuthority objIssuingAuthority = null;
         objIssuingAuthority = IssuingAuthority_DL.GetIssuingAuthorityRecord(authorityId); // object being assigned was lstAuthority
         return objIssuingAuthority;
      }

   }
}
