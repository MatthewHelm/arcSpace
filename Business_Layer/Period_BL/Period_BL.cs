using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bcs.arcSpace.Support_Classes;
using bcs.arcSpace.Data_Layer;

namespace bcs.arcSpace.Business_Layer
{
    public class Period_BL
    {
      public static bool InsertPeriod(Period objPeriod)
      {
         bool insertSuccessful = false;
         insertSuccessful = Period_DL.InsertPeriodRecord(objPeriod);
         return insertSuccessful;
      }

      public static bool UpdatePeriod(Period objPeriod)
      {
         bool updateSuccessful = false;
         updateSuccessful = Period_DL.UpdatePeriodRecord(objPeriod);
         return updateSuccessful;
      }

      public static bool DeletePeriod(Period objPeriod)
      {
         bool deleteSuccessful = false;
         deleteSuccessful = Period_DL.DeletePeriodRecord(objPeriod);
         return deleteSuccessful;
      }

      public static List<Period> GetPeriodList()
      {
         List<Period> lstPeriod = (List<Period>)null;
         lstPeriod = Period_DL.GetPeriodRecordList();
         return lstPeriod;
      }

      public static string GetPeriodGivenId(List<Period> lstPeriod, int id)
      {
         // rewrite this in the fashion of similar method in Title_BL.  mch 09.26.2018
         foreach (Period objPeriod in lstPeriod)
         {
            if (objPeriod.Period_Id == id)
               return objPeriod.Period_Name;
         }
         return null;
      }

      public static List<Period> GetPeriodsHavingCoins()
      {
         List<Period> lstPeriod = null;
         lstPeriod = Period_DL.GetPeriodListHavingCoins();
         return lstPeriod;
      }


   }
}
