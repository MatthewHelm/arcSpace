using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using bcs.arcSpace.Support_Classes;

namespace bcs.arcSpace.Data_Layer
{
    public class Grade_DL
    {

      public static bool InsertGradeRecord(Grade objGrade)
      {
         bool insertSuccessful = false;

         if (objGrade == (Grade) null)
         {
            return insertSuccessful;
         }

         string insertString = "INSERT INTO tblGrade (grade_code, description) VALUES ('{0}', '{1}')";
         insertString = string.Format(insertString, objGrade.Grade_Code, objGrade.Description);

         insertSuccessful = DataLayer.InsertTypeRecord(insertString);

         return insertSuccessful;
      }


      public static bool UpdateGradeRecord(Grade objGrade)
      {

         bool updateSuccessful = false;

         if (objGrade == null)
         {
            return updateSuccessful;
         }

         string updateString = "UPDATE tblGrade SET grade_code = '{0}', description = '{1}' WHERE grade_id = {2}";
         updateString = string.Format(updateString, objGrade.Grade_Code, objGrade.Description, objGrade.Grade_Id);


         updateSuccessful = DataLayer.UpdateTypeRecord(updateString);

         return updateSuccessful;
      }


      public static bool DeleteGradeRecord(Grade objGrade)
      {
         bool deleteSuccessful = false;

         if (objGrade == (Grade) null)
         {
            return deleteSuccessful;
         }

         string deleteStatement = string.Format("DELETE FROM tblGrade WHERE grade_id = {0}", objGrade.Grade_Id.ToString());

         deleteSuccessful = DataLayer.DeleteTypeRecord(deleteStatement);

         return deleteSuccessful;
      }


      public static List<Grade> GetGradeRecordList()
      {
         List<Grade> lstGrade = new List<Grade>();
         Grade objGrade;

         string selectString = "SELECT grade_id, grade_code, description FROM tblGrade";

         SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
         SqlCommand comm = new SqlCommand(selectString, conn);
         SqlDataReader rdr;

         try
         {
            conn.Open();
            rdr = comm.ExecuteReader();

            while (rdr.Read())
            {
               objGrade = new Grade();
               objGrade.Grade_Id = Convert.ToInt32(rdr["grade_id"]);
               objGrade.Grade_Code = Convert.ToString(rdr["grade_code"]);
               objGrade.Description = Convert.ToString(rdr["description"]);

               lstGrade.Add(objGrade);
            }
         }
         catch
         {
            lstGrade = null;
         }
         finally
         {
            conn.Close();
            conn.Dispose();
            comm.Dispose();
         }

         return lstGrade;

      }
   }
}
