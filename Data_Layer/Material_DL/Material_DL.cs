using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using bcs.arcSpace.Support_Classes;

namespace bcs.arcSpace.Data_Layer
{
    public class Material_DL
    {
      public static bool InsertMaterialRecord(Material objMaterial)
      {
         bool insertSuccessful = false;

         if (objMaterial == (Material) null)
         {
            return insertSuccessful;
         }

         string insertString = "INSERT INTO tblMaterial (material_description, material_notes) VALUES ('{0}', '{1}')";
         insertString = string.Format(insertString, objMaterial.Material_Description.Trim(), objMaterial.Material_Notes);

         insertSuccessful = DataLayer.InsertTypeRecord(insertString);

         return insertSuccessful;
      }


      public static bool UpdateMaterialRecord(Material objMaterial)
      {
         bool updateSuccessful = false;

         if (objMaterial == null)
         {
            return updateSuccessful;
         }

         string updateString = "UPDATE tblMaterial SET material_description = '{0}', material_notes = '{1}' WHERE material_id = {2}";
         updateString = string.Format(updateString, objMaterial.Material_Description.Trim(), objMaterial.Material_Notes, objMaterial.Material_Id);

         updateSuccessful = DataLayer.UpdateTypeRecord(updateString);

         return updateSuccessful;
      }


      public static bool DeleteMaterialRecord(Material objMaterial)
      {
         bool deleteSuccessful = false;

         if (objMaterial == (Material) null)
         {
            return deleteSuccessful;
         }

         string deleteStatement = string.Format("DELETE FROM tblMaterial WHERE material_id = {0}", objMaterial.Material_Id.ToString());

         deleteSuccessful = DataLayer.DeleteTypeRecord(deleteStatement);

         return deleteSuccessful;
      }


      public static List<Material> GetMaterialRecordList()
      {
         List<Material> lstMaterial = new List<Material>();
         Material objMaterial;

         string selectString = "SELECT material_id, material_description, material_notes FROM tblMaterial";

         SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
         SqlCommand comm = new SqlCommand(selectString, conn);
         SqlDataReader rdr;

         try
         {
            conn.Open();
            rdr = comm.ExecuteReader();

            while (rdr.Read())
            {
               objMaterial = new Material();
               objMaterial.Material_Id = Convert.ToInt32(rdr["material_id"]);
               objMaterial.Material_Description = Convert.ToString(rdr["material_description"]).Trim();
               objMaterial.Material_Notes = Convert.ToString(rdr["material_notes"]);

               lstMaterial.Add(objMaterial);
            }
         }
         catch
         {
            lstMaterial = null;
         }
         finally
         {
            conn.Close();
            conn.Dispose();
            comm.Dispose();
         }

         return lstMaterial;

      }

      public static Material GetMaterialObject(int materialId)
      {
         Material objMaterial = (Material) null;

         string selectString = "SELECT material_id, material_description, material_notes FROM tblMaterial where material_id = {0}";
         selectString = String.Format(selectString, materialId.ToString());

         SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
         SqlCommand comm = new SqlCommand(selectString, conn);
         SqlDataReader rdr;

         try
         {
            conn.Open();
            rdr = comm.ExecuteReader();

            while (rdr.Read())
            {
               objMaterial = new Material();
               objMaterial.Material_Id = Convert.ToInt32(rdr["material_id"]);
               objMaterial.Material_Description = Convert.ToString(rdr["material_description"]).Trim();
               objMaterial.Material_Notes = Convert.ToString(rdr["material_notes"]);
            }
         }
         catch
         {
           objMaterial = null;
         }
         finally
         {
            conn.Close();
            conn.Dispose();
            comm.Dispose();
         }
         return objMaterial;
      }


   }
}
