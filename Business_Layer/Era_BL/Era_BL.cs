using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bcs.arcSpace.Support_Classes;
using bcs.arcSpace.Data_Layer;

namespace bcs.arcSpace.Business_Layer
{
    public class Era_BL
    {
      public static List<Era> GetEraList()
      {
         List<Era> lstEra = null;
         lstEra = Era_DL.GetEraRecordList();
         return lstEra;
      }


      public static string GetEraGivenId(List<Era> lstEra, int id)
      {
         string str = null;
         IEnumerable<Era> qEra = from e in lstEra
                                 where e.Era_Id == id
                                 select e;

         foreach (Era e in qEra)
         {
            str = e.Era_Name;
         }

         if (string.IsNullOrEmpty((str)))
         {
            return null;
         }

         return str;
      }


      public static Era GetEra(int eraId)
      {
         Era objEra = (Era) null;
         objEra = Era_DL.GetEraObject(eraId);
         return objEra;
      }

   }
}
