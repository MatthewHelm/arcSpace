using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using bcs.arcSpace.Support_Classes;
using bcs.arcSpace.Data_Layer;

namespace bcs.arcSpace.Business_Layer
{
    public class Coin_BL
    {

      public static byte[] ConvertImageToByteArray(System.Drawing.Image i)
      {
         byte[] img = null;

         if (i == null)
         {
            return img;
         }

         MemoryStream memStream = new MemoryStream();
         i.Save(memStream, System.Drawing.Imaging.ImageFormat.Jpeg);
         img = memStream.ToArray();
         return img;
      }

      public static bool InsertCoin(Coin objCoin)
      {
         bool insertSuccessful = false;
         insertSuccessful = Coin_DL.InsertCoinRecord(objCoin);
         return insertSuccessful;
      }

      public static List<Coin> GetCoinList()
      {
         List<Coin> lstCoin = null;
         lstCoin = Coin_DL.GetCoinRecordList();
         return lstCoin;
      }


      public static Coin GetCoin(int coinId)
      {
         Coin objCoin = Coin_DL.GetCoinRecord(coinId);
         return objCoin;
      }


      public static List<Coin> GetCoin(Coin objCoin)
      {
         List<Coin> lstCoin = null;
         lstCoin = Coin_DL.GetCoinRecord(objCoin);
         return lstCoin;
      }

      public static bool UpdateCoin(Coin objCoin)
      {
         bool updateSuccessful = false;
         updateSuccessful = Coin_DL.UpdateCoinRecord(objCoin);
         return updateSuccessful;
      }

       
    }
}
