using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bcs.arcSpace.Data_Layer;
using bcs.arcSpace.Support_Classes;

namespace bcs.arcSpace.Business_Layer
{
    public class Grade_BL
    {

      public static bool InsertGrade(Grade objGrade)
      {
         bool insertSuccessful = false;
         insertSuccessful = Grade_DL.InsertGradeRecord(objGrade);
         return insertSuccessful;
      }


      public static bool UpdateGrade(Grade objGrade)
      {
         bool updateSuccessful = false;
         updateSuccessful = Grade_DL.UpdateGradeRecord(objGrade);
         return updateSuccessful;
      }

      public static bool DeleteGrade(Grade objGrade)
      {
         bool deleteSuccessful = false;
         deleteSuccessful = Grade_DL.DeleteGradeRecord(objGrade);
         return deleteSuccessful;
      }


      public static List<Grade> GetGradeList()
      {
         List<Grade> lstGrade = (List<Grade>)null;
         lstGrade = Grade_DL.GetGradeRecordList();
         return lstGrade;
      }

      public static string GetGradeGivenId(List<Grade> lstGrade, int id)
      {
         foreach (Grade objGrade in lstGrade)
         {
            if (objGrade.Grade_Id == id)
               return objGrade.Grade_Code;
         }
         return null;
      }


   }
}
