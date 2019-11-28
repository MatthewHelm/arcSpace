using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bcs.arcSpace.Support_Classes;
using bcs.arcSpace.Data_Layer;

namespace bcs.arcSpace.Business_Layer
{
    public class StateProvince_BL
    {
      /// <summary>
      /// 
      /// </summary>
      /// <param name="objStateProvince"></param>
      /// <returns></returns>
      public static Boolean InsertStateProvince(StateProvince objStateProvince)
      {
         bool insertSuccessful = false;
         insertSuccessful = Data_Layer.StateProvince_DL.InsertStateProvinceRecord(objStateProvince);
         return insertSuccessful;
      }


      /// <summary>
      /// 
      /// </summary>
      /// <param name="objStateProvince"></param>
      /// <returns></returns>
      public static bool UpdateStateProvince(StateProvince objStateProvince)
      {
         bool updateSuccessful = false;
         updateSuccessful = Data_Layer.StateProvince_DL.UpdateStateProvinceRecord(objStateProvince);
         return updateSuccessful;
      }

      
      /// <summary>
      /// 
      /// </summary>
      /// <param name="objStateProvince"></param>
      /// <returns></returns>
      public static bool DeleteStateProvince(StateProvince objStateProvince)
      {
         bool deleteSuccessful = false;
         deleteSuccessful = Data_Layer.StateProvince_DL.DeleteStateProvinceRecord(objStateProvince);
         return deleteSuccessful;
      }


      /// <summary>
      /// 
      /// </summary>
      /// <returns></returns>
      public static List<StateProvince> GetStateProvinceList()
      {
         List<StateProvince> lstStateProvince = null;
         lstStateProvince = Data_Layer.StateProvince_DL.GetStateProvinceRecordList();
         return lstStateProvince;
      }

   }
}
