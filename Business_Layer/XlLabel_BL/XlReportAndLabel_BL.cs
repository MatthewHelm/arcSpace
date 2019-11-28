using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using bcs.arcSpace.Support_Classes;
using bcs.arcSpace.Data_Layer;




namespace bcs.arcSpace.Business_Layer
{
    public class XlReportAndLabel_BL
    {

      // Replace CoinDisplaySet with XlReportAndLabel mch. 11/28/2018
      // List<XlReportAndLabel> lstXllabels
      public static Excel.Workbook GenerateLabels(List<Coin> lstCoins)
      {
         Object misValue = new object();
         Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
         Excel.Workbook xlWb = xlApp.Workbooks.Add(misValue);

         if (lstCoins == null)
         {

         }

         Excel.Worksheet xlWs = xlWb.Worksheets[0];

         for (int i = 0; i > 10; i++)
         {
            xlWs.Rows[i].Height = 120;
            xlWs.Rows[i].width = 120;
         }

         xlWb.SaveAs("C:\\Users\\Matth\\Documents\\test11272018.xlsx");

        return xlWb;
      }

      public static List<XlReportAndLabel> GetAllCoinsForReportingRecord()
      {
         List<XlReportAndLabel> lstRL = Data_Layer.XlReportAndLabel_DL.GetAllCoinsForReportingRecordList();
         return lstRL;
      }

     public static List<XlReportAndLabel> GetCoinsForReporting(int[] arrIds)
     {
        List<XlReportAndLabel> lstRL = null;
        if (arrIds == null)
        {
           return lstRL;
        }

           lstRL = Data_Layer.XlReportAndLabel_DL.GetCoinForReportingRecord(arrIds);
           return lstRL;
     }
   }
}
