using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bcs.arcSpace.Support_Classes;

namespace bcs.arcSpace.Data_Layer
{
    public class StateProvince_DL
    {
      /// <summary>
      /// 
      /// </summary>
      /// <param name="objStateProvince"></param>
      /// <returns></returns>
      public static bool InsertStateProvinceRecord(StateProvince objStateProvince)
      {
         bool insertSuccessful = false;

         if (objStateProvince == null)
         {
            return insertSuccessful;
         }

         string insertString = "insert into tblStateProvince (country_id, state_province) values ({0}, '{1}');";
         string.Format(insertString, objStateProvince.State_Province_Id);

         return insertSuccessful;
      }


      /// <summary>
      /// 
      /// </summary>
      /// <param name="objStateProvince"></param>
      /// <returns></returns>
      public static bool UpdateStateProvinceRecord(StateProvince objStateProvince)
      {

         bool updateSuccessful = false;

         if (objStateProvince == null)
         {
            return updateSuccessful;
         }

         string updateString = "UPDATE tblStateProvince SET country_id = '{0}', state_province = '{1}' from tblStateProvince where state_province_id = {2}";

         updateString = string.Format(updateString, objStateProvince.Country_Id, objStateProvince.State_Province, objStateProvince.State_Province_Id);

         updateSuccessful = DataLayer.UpdateTypeRecord(updateString);

         return updateSuccessful;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="objStateProvince"></param>
      /// <returns></returns>
      public static bool DeleteStateProvinceRecord(StateProvince objStateProvince)
      {
         bool deleteSuccessful = false;

         if (objStateProvince == null)
         {
            return deleteSuccessful;
         }

         string deleteStatement = string.Format("DELETE FROM tblStateProvince WHERE state_province_id = {0}", objStateProvince.State_Province_Id.ToString());

         deleteSuccessful = DataLayer.DeleteTypeRecord(deleteStatement);

         return deleteSuccessful;
      }



      /// <summary>
      /// 
      /// </summary>
      /// <returns></returns>
      public static List<StateProvince> GetStateProvinceRecordList()
      {
         List<StateProvince> lstStateProvince = null;
         StateProvince objStateProvince;

         string selectString = "SELECT state_province_id, countr_id, state_prvoince FROM tblStateProvince";

         SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
         SqlCommand comm = new SqlCommand(selectString, conn);
         SqlDataReader rdr;

         try
         {
            conn.Open();
            rdr = comm.ExecuteReader();

            while (rdr.Read())
            {
               objStateProvince = new StateProvince();
               objStateProvince.State_Province_Id = Convert.ToInt32(rdr["state_province_id"]);
               objStateProvince.Country_Id= Convert.ToInt32(rdr["countr_id"]);
               objStateProvince.State_Province = Convert.ToString(rdr["state_province"]);

               lstStateProvince.Add(objStateProvince);
            }
         }
         catch
         {
            lstStateProvince = null;
         }
         finally
         {
            conn.Close();
            conn.Dispose();
            comm.Dispose();
         }

         return lstStateProvince;
      }
    }
}
