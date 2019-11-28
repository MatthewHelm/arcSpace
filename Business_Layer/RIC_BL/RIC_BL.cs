using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bcs.arcSpace.Support_Classes;
using bcs.arcSpace.Data_Layer;

namespace bcs.arcSpace.Business_Layer
{
    public class RIC_BL
    {
      #region RicVolume methods

      public static bool InsertRicVolume(RIC objRic)
      {
         bool insertSuccessful = false;
         insertSuccessful = RIC_DL.InsertRicVolumeRecord(objRic);
         return insertSuccessful;
      }

      public static bool UpdateRicVolume(RIC objRic)
      {
         bool updateSuccessful = false;
         updateSuccessful = RIC_DL.UpdateRicVolumeRecord(objRic);
         return updateSuccessful;
      }

      public static bool DeleteRicVolume(RIC objRic)
      {
         bool deleteSuccessful = false;
         deleteSuccessful = RIC_DL.DeleteRicVolumeRecord(objRic);
         return deleteSuccessful;
      }

      public static List<RIC> GetRicVolumeList()
      {
         List<RIC> lstRic = (List<RIC>) null;
         lstRic = RIC_DL.GetRicVolumeRecordList();
         return lstRic;
      }

      public static string GetRicVolumeGivenId(List<RIC> lstRic, int id)
      {
         foreach (RIC objRic in lstRic)
         {
            if (objRic.Ric_Volume_Id == id)
               return objRic.Ric_Volume;
         }
         return null;
      }

      #endregion RicVolume methods



      #region RicSection methods

      public static bool InsertRicSection(RIC objRic)
      {
         bool insertSuccessful = false;
         insertSuccessful = RIC_DL.InsertRicSectionRecord(objRic);
         return insertSuccessful;
      }

      public static bool UpdateRicSection(RIC objRic)
      {
         bool updateSuccessful = false;
         updateSuccessful = RIC_DL.UpdateRicSectionRecord(objRic);
         return updateSuccessful;
      }

      public static bool DeleteRicSection(RIC objRic)
      {
         bool deleteSuccessful = false;
         deleteSuccessful = RIC_DL.DeleteRicSectionRecord(objRic);
         return deleteSuccessful;
      }

      public static List<RIC> GetRicSectionList()
      {
         List<RIC> lstRic = (List<RIC>) null;
         lstRic = RIC_DL.GetRicSectionRecordList();
         return lstRic;
      }

      public static List<RIC> GetRicSectionList(Coin coin)
      {
         List<RIC> lstRIc = null;
         lstRIc = RIC_DL.GetRicSectionRecordList(coin);
         return lstRIc;
      }

      public static string GetRicSectionGivenId(List<RIC> lstRic, int id)
      {
         foreach (RIC objRic in lstRic)
         {
            if (objRic.Ric_Section_Id == id)
               return objRic.Ric_Section;
         }
         return null;
      }

      #endregion RicSection methods



      #region RicIndex methods

      public static bool InsertRicIndex(RIC objRic)
      {
         bool insertSuccessful = false;
         insertSuccessful = RIC_DL.InsertRicIndexRecord(objRic);
         return insertSuccessful;
      }

      public static bool UpdateRicIndex(RIC objRic)
      {
         bool updateSuccessful = false;
         updateSuccessful = RIC_DL.UpdateRicIndexRecord(objRic);
         return updateSuccessful;
      }

      public static bool DeleteRicIndex(RIC objRic)
      {
         bool deleteSuccessful = false;
         deleteSuccessful = RIC_DL.DeleteRicIndexRecord(objRic);
         return deleteSuccessful;
      }

      public static List<RIC> GetRicIndexList()
      {
         List<RIC> lstRic = (List<RIC>)null;
         lstRic = RIC_DL.GetRicIndexRecordList();
         return lstRic;
      }

      public static string GetRicIndexGivenId(List<RIC> lstRic, int id)
      {
         foreach (RIC objRic in lstRic)
         {
            if (objRic.Ric_Index_Id == id)
               return objRic.Ric_Index;
         }
         return null;
      }

      #endregion RicIndex methods



      #region RIC methods

      public static RIC GetRicReference(Coin objCoin)
      {
         RIC objRic = RIC_DL.GetRicReferenceRecord(objCoin);
         return objRic;
      }


      public static int GetRicIndexByCoinId(int coinId)  // mch 09/17/2017
      {
         int ricIndexId = 0; 
         ricIndexId = RIC_DL.GetRicIndexIdByCoinId(coinId);
         return ricIndexId;
      }

      public static RIC GetRicReferenceByRicIndexId(int ricIndexId)  // mch 09/17/2017
      {
         RIC objRic = null;
         objRic = RIC_DL.GetRicReferenceRecordByRicIndexId(ricIndexId);
         return objRic;
      }

      public static string GetRicReferenceLabel(RIC objRic)  // mch 09/17/2017
      {
         string ricLabel = null;

         if (objRic == null)
         {
            return ricLabel;
         }
         ricLabel = "RIC " + objRic.Ric_Volume + " " + objRic.Ric_Section + " " + objRic.Ric_Index;
         return ricLabel;
      }

      #endregion RIC methods


   }
}
