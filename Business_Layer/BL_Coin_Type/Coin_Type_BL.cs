﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bcs.arcSpace.Support_Classes;
using bcs.arcSpace.Data_Layer;

namespace bcs.arcSpace.Business_Layer
{
    public static class Coin_Type_BL
    { 
       
       /// <summary>
       /// 
       /// </summary>
       /// <param name="coinType"></param>
       /// <param name="coinTypeDescription"></param>
       /// <returns></returns>
       private static Coin_Type CreateCoinTypeObject(uint coinTypeId, string coinType, string coinTypeDescription)
       {
          Coin_Type objCoinType = (Coin_Type)null;

          if (string.IsNullOrEmpty(coinType) || string.IsNullOrEmpty(coinTypeDescription))
          {
             return objCoinType;
          }

          objCoinType = new Coin_Type();

          objCoinType.Coin_Type_Id = coinTypeId;
          objCoinType.Coin_Type_Name = coinType;
          objCoinType.Coin_Type_Desc = coinTypeDescription;

          return objCoinType;
       }

       public static bool InsertCoinType(Coin_Type objCoinType)
       {
          bool insertSuccessful = false;
          insertSuccessful = Coin_Type_DL.InsertCoinTypeRecord(objCoinType);  
          return insertSuccessful;
       }

       public static bool UpdateCoinType(Coin_Type objCoinType) 
       {
          bool updateSuccessful = false;

          updateSuccessful = Coin_Type_DL.UpdateCoinTypeRecord(objCoinType);

          return updateSuccessful;
       }

       public static bool DeleteCoinType(Coin_Type objCoinType)
       {
          bool deleteSuccessful = false;
          deleteSuccessful = Coin_Type_DL.DeleteCoinTypeRecord(objCoinType);
          return deleteSuccessful;
       }
    
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
       public static List<Coin_Type> GetCoinTypeList()
       {
          List<Coin_Type> lstCoinType = Data_Layer.Coin_Type_DL.GetCoinTypeRecordList();
          return lstCoinType;
       }

      public static string GetCoinTypeGivenId(List<Coin_Type> lstCoinType, int id)
      {
         foreach (Coin_Type objCoinType in lstCoinType)
         {
            if (objCoinType.Coin_Type_Id == id)
               return objCoinType.Coin_Type_Name;
         }
         return null;
      }


    }
}
