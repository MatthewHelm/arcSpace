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
    public class Reports_BL
    {
      Excel.Application app;
      Excel.Workbook wb;
      Excel.Worksheet ws;

      public Reports_BL()
      {
         //  app = new Excel.Application();
         //  wb = app.Workbooks.Open("Test.xlsx");
         Object misValue = new object();

         Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
         Excel.Workbook xlWb = xlApp.Workbooks.Add(misValue);
         Excel.Worksheet xlWs = xlWb.Worksheets[0];
         xlWs.Rows[0].Height = 100;
         xlWs.Rows[1].Height = 100;

         xlWb.SaveAs("C:\\Users\\Matth\\Documents\\test11272018.xlsx");










      }
    }
}
