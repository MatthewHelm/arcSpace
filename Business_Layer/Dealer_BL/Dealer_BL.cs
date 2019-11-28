using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bcs.arcSpace.Support_Classes;
using bcs.arcSpace.Data_Layer;

namespace bcs.arcSpace.Business_Layer
{
    public class Dealer_BL
    {
      /// <summary>
      /// 
      /// </summary>
      /// <param name="objDealer"></param>
      /// <returns></returns>
      public static Boolean InsertDealer(Dealer objDealer)
      {
         bool insertSuccessful = false;
         insertSuccessful = Data_Layer.Dealer_DL.InsertDealerRecord(objDealer);
         return insertSuccessful;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="objDealer"></param>
      /// <returns></returns>
      public static bool UpdateDealer(Dealer objDealer)
      {
         bool updateSuccessful = false;
         updateSuccessful = Data_Layer.Dealer_DL.UpdateDealerRecord(objDealer);
         return updateSuccessful;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="objDealer"></param>
      /// <returns></returns>
      public static bool DeleteDealer(Dealer objDealer)
      {
         bool deleteSuccessful = false;
         deleteSuccessful = Data_Layer.Dealer_DL.DeleteDealerRecord(objDealer);
         return deleteSuccessful;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <returns></returns>
      public static List<Dealer> GetDealerList()
      {
         List<Dealer> lstDealers = null;
         lstDealers = Data_Layer.Dealer_DL.GetDealerRecordList();
         return lstDealers;
      }

    }
}
