using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bcs.arcSpace.Support_Classes;
using bcs.arcSpace.Data_Layer;

namespace bcs.arcSpace.Business_Layer
{
    public class CoinDisplaySet_BL
    {
      public static List<CoinDisplaySet> GetCoinDisplaySetList()
      {
         List<CoinDisplaySet> lstCoinDisplaySet = null;
         lstCoinDisplaySet = CoinDisplaySet_DL.GetCoinDisplaySetRecordList();
         return lstCoinDisplaySet;
      }


    }
}
