using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bcs.arcSpace.Support_Classes;
using bcs.arcSpace.Data_Layer;

namespace bcs.arcSpace.Business_Layer
{
    public class Material_BL
    {

      public static bool InsertMaterial(Material objMaterial)
      {
         bool insertSuccessful = false;
         insertSuccessful = Material_DL.InsertMaterialRecord(objMaterial);
         return insertSuccessful;
      }


      public static bool UpdateMaterial(Material objMaterial)
      {
         bool updateSuccessful = false;
         updateSuccessful = Material_DL.UpdateMaterialRecord(objMaterial);
         return updateSuccessful;
      }

      public static bool DeleteMaterial(Material objMaterial)
      {
         bool deleteSuccessful = false;
         deleteSuccessful = Material_DL.DeleteMaterialRecord(objMaterial);
         return deleteSuccessful;
      }


      public static List<Material> GetMaterialList()
      {
         List<Material> lstMaterial = (List<Material>)null;
         lstMaterial = Material_DL.GetMaterialRecordList();
         return lstMaterial;
      }

      public static Material GetMaterial(int materialId)
      {
         Material objMaterial = (Material) null;
         objMaterial = Material_DL.GetMaterialObject(materialId);
         return objMaterial;
      }


      public static string GetMaterialGivenId(List<Material> lstMaterial, int id)
      {
         foreach (Material objMaterial in lstMaterial)
         {
            if (objMaterial.Material_Id == id)
               return objMaterial.Material_Description;
         }
         return null;
      }

   }
}
