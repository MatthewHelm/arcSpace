using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using bcs.arcSpace.Global_Layer;
using bcs.arcSpace.Support_Classes;
using bcs.arcSpace.Business_Layer;



namespace bcs.arcSpace.Application_Layer
{
    public static class LabelBuilder
    {
        public static bool CreateLabels(List<XlReportAndLabel> lstRL)
        {
            bool SuccessfullyCreatedLabels = false;

            if (lstRL == null)
            {
                return SuccessfullyCreatedLabels;
            }

            Object misValue = new object();
            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlApp.StandardFont = "Arial Narrow";
            xlApp.StandardFontSize = 6;

            Excel.Workbook xlWb = xlApp.Workbooks.Add(Type.Missing);

            Excel._Worksheet xlWs = xlWb.ActiveSheet;

            xlWs.Cells.RowHeight = 288;                    
            xlWs.Cells.ColumnWidth = 24;

            xlWs.Cells.Borders.LineStyle = Excel.XlLineStyle.xlDouble;
            xlWs.Cells.Borders.Weight = Excel.XlBorderWeight.xlThin;

            xlWs.Cells.FormatConditions.AddIconSetCondition();
            xlWs.Cells.Style.horizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            xlWs.Cells.Style.verticalAlignment = Excel.XlVAlign.xlVAlignTop;

            xlWs.PageSetup.TopMargin = 0.07;
            xlWs.PageSetup.BottomMargin = 0.07;
            xlWs.PageSetup.LeftMargin = 0.07;
            xlWs.PageSetup.RightMargin = 0.07;

         StringBuilder sb = null;  
            int labelCnt = lstRL.Count;

            int j = 1;
            int k = 0;
            int lineCnt = 0;
            for (int i = 0; i < labelCnt; i++)
            {
                sb = new StringBuilder();
                if (String.IsNullOrEmpty(lstRL[i].Issuing_Authority_Title))
                {
                    sb.AppendLine(((string)lstRL[i].Issuing_Authority_Name).Trim() + Environment.NewLine);
                    lineCnt++;
                }
                else
                {
                    sb.Append(((string)lstRL[i].Issuing_Authority_Name).Trim());
                    sb.AppendLine(" as " + ((string) lstRL[i].Issuing_Authority_Title).Trim());
                    lineCnt++;
                }

                if (!String.IsNullOrEmpty(lstRL[i].Reign_Begin_Year))
                {
                    sb.AppendLine(lstRL[i].Reign_Begin_Year + " - " + lstRL[i].Reign_End_Year);
                    lineCnt++;
                }

                if (!String.IsNullOrEmpty(lstRL[i].Coin_Type))
                {
                    sb.AppendLine(lstRL[i].Coin_Type);
                    lineCnt++;
                }

                sb.AppendLine("Mint: " + ((string) lstRL[i].Mint_Name).Trim());
                lineCnt++;

                if (!string.IsNullOrEmpty(lstRL[i].Start_Minting_Year))
                {
                    sb.AppendLine("Years Minted: " + ((string)lstRL[i].Start_Minting_Year).Trim() + " - " + ((string)lstRL[i].End_Minting_Year).Trim());
                    lineCnt++;
                }

                sb.AppendLine("Obverse Legend:");

                sb.AppendLine(((string) lstRL[i].Obverse_Legend).Trim());
                sb.AppendLine("Reverse Legend:");
                sb.AppendLine(((string)lstRL[i].Reverse_Legend).Trim());
                sb.AppendLine("Exergue: " + ((string)lstRL[i].Exergue).Trim());
                sb.AppendLine("Coin Description:  ");
                sb.AppendLine(((string) lstRL[i].Coin_Description));
                lineCnt = lineCnt + 4;

                if (k < 3)
                {
                    k++;
                }
                else
                {
                    k = 1;
                    j++;
                }

                for (int q = 0; q < Global_Layer.Globals.LineCountInLabel - lineCnt; q++)
                {
                    sb.AppendLine("");
                }

                sb.AppendLine("brandywine creek software");
                xlWs.Cells[j, k] = sb.ToString();
                lineCnt = 0;
            }

            xlWb.SaveAs("C:\\Users\\Matth\\Documents\\test122320183.xlsx");

            xlWb.Close(0);
            xlApp.Quit();

            SuccessfullyCreatedLabels = true;
 
            return SuccessfullyCreatedLabels;
        }

    }
}
