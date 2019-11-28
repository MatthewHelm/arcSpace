using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bcs.arcSpace.Support_Classes;
using bcs.arcSpace.Data_Layer;
using bcs.arcSpace.Business_Layer;

namespace bcs.arcSpace.Business_Layer
{
    public class Mint_BL
    {
      
      public static bool InsertMint(Mint objMint)
      {
         bool insertSuccessful = false;
         insertSuccessful = Mint_DL.InsertMintRecord(objMint);
         return insertSuccessful;
      }


      public static bool UpdateMint(Mint objMint)
      {
         bool updateSuccessful  = false;
         updateSuccessful = Mint_DL.UpdateMintRecord(objMint);
         return updateSuccessful;
      }

      public static bool DeleteMint(Mint objMint)
      {
         bool deleteSuccessful = false;
         deleteSuccessful = Mint_DL.DeleteMintRecord(objMint);
         return deleteSuccessful;
      }

       public static List<Mint> GetMintList()
       {
          List<Mint> lstMint = (List<Mint>) null;
          lstMint = Mint_DL.GetMintRecordList();
          return lstMint;   
       }

      public static string GetMintGivenId(List<Mint> lstMint, int id)
      {
         foreach (Mint objMint in lstMint)
         {
            if (objMint.Mint_Id == id)
               return objMint.Mint_Name;
         }
         return null;
      }




   }
}
