using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bcs.arcSpace.Support_Classes;
using bcs.arcSpace.Data_Layer;

namespace bcs.arcSpace.Business_Layer
{
    public static class ArcNode_BL
    {
      public static List<ArcNode> GetArcNodeObjectsForTreeView()
      {
         List<ArcNode> lstArcNode = null;
         lstArcNode = ArcNode_DL.GetAllCoinRecordsForTreeView();
         return lstArcNode;
      }


      public static List<ArcNode> GetArcNodeObjectsForTreeView(int period_id)
      {
         List<ArcNode> lstArcNode = null;
         lstArcNode = ArcNode_DL.GetCoinRecordsForTreeViewByPeriodId(period_id);
         return lstArcNode;
      }

   }
}
