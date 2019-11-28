using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using bcs.arcSpace.Support_Classes;

namespace bcs.arcSpace.Data_Layer
{
    public class CoinDisplaySet_DL
    {
      public static List<CoinDisplaySet> GetCoinDisplaySetRecordList()
      {
         List<CoinDisplaySet> lstCoinDisplaySet = null;
         CoinDisplaySet objCoinDisplaySet = null;

         string storedProcedureString = "GetAllCoins_sp";
         SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
         SqlCommand comm = new SqlCommand(storedProcedureString, conn);
         SqlDataReader rdr;

         comm.CommandType = System.Data.CommandType.StoredProcedure;

         //Coin objCoin;
         //string ricLabel = null;

         try
         {
            conn.Open();
            rdr = comm.ExecuteReader();

            lstCoinDisplaySet = new List<CoinDisplaySet>();

            while (rdr.Read())
            {
               objCoinDisplaySet = new CoinDisplaySet();

               objCoinDisplaySet.Coin_Id = (int)rdr["coin_id"];
               objCoinDisplaySet.Obverse_Image = (byte[])rdr["obverse_image"];
               objCoinDisplaySet.Reverse_Image = (byte[])rdr["reverse_image"];
               objCoinDisplaySet.Issuing_Authority_Name = ((string)rdr["issuing_authority_name"]).Trim();
               objCoinDisplaySet.Obverse_Legend = ((string)rdr["obverse_legend"]).Trim();
               objCoinDisplaySet.Reverse_Legend = ((string)rdr["reverse_legend"]).Trim();
               objCoinDisplaySet.Exergue = ((string)rdr["exergue"]).Trim();

               //objCoin = new Coin();
               //objCoin.Coin_Id = objCoinDisplaySet.Coin_Id;
               //ricLabel = RIC_DL.GetRicReferenceLabel(objCoin);

               //objCoinDisplaySet.Ric_Label = ricLabel;

               lstCoinDisplaySet.Add(objCoinDisplaySet);
            }
         }
         catch (Exception ex)
         {
            lstCoinDisplaySet = null;
         }
         finally
         {
            conn.Close();
            conn.Dispose();
            comm.Dispose();
         }

         return lstCoinDisplaySet;
      }


      // mch 02/20/2019  
      public static List<CoinDisplaySet> GetCoinDisplaySetRecordListByIssuingAuthorityIdAndName(int issuingAuthorityId, string issuingAuthorityName)
      {
         List<CoinDisplaySet> lstCoinDisplaySet = null;
         CoinDisplaySet objCoinDisplaySet = null;

         string storedProcedureString = "GetAllCoins_sp";
         SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
         SqlCommand comm = new SqlCommand(storedProcedureString, conn);



         comm.CommandType = System.Data.CommandType.StoredProcedure;

         SqlDataReader rdr;
         comm.CommandType = System.Data.CommandType.StoredProcedure;
    //     comm.Parameters.AddWithValue("@CoinId", coinId);




         //Coin objCoin;
         //string ricLabel = null;

         try
         {
            conn.Open();
            rdr = comm.ExecuteReader();

            lstCoinDisplaySet = new List<CoinDisplaySet>();

            while (rdr.Read())
            {
               objCoinDisplaySet = new CoinDisplaySet();

               objCoinDisplaySet.Coin_Id = (int) rdr["coin_id"];
               objCoinDisplaySet.Obverse_Image = (byte[]) rdr["obverse_image"];
               objCoinDisplaySet.Reverse_Image = (byte[]) rdr["reverse_image"];
               objCoinDisplaySet.Issuing_Authority_Name = ((string) rdr["issuing_authority_name"]).Trim();
               objCoinDisplaySet.Obverse_Legend = ((string) rdr["obverse_legend"]).Trim();
               objCoinDisplaySet.Reverse_Legend = ((string) rdr["reverse_legend"]).Trim();
               objCoinDisplaySet.Exergue = ((string) rdr["exergue"]).Trim();

               //objCoin = new Coin();
               //objCoin.Coin_Id = objCoinDisplaySet.Coin_Id;
               //ricLabel = RIC_DL.GetRicReferenceLabel(objCoin);

               //objCoinDisplaySet.Ric_Label = ricLabel;

               lstCoinDisplaySet.Add(objCoinDisplaySet);
            }
         }
         catch (Exception ex)
         {
            lstCoinDisplaySet = null;
         }
         finally
         {
            conn.Close();
            conn.Dispose();
            comm.Dispose();
         }

         return lstCoinDisplaySet;
      }




      public static List<CoinDisplaySet> GetCoinDisplaySetRecordList(List<Coin> lstCoins)
      {
         List<CoinDisplaySet> lstCoinDisplaySet = null;
         CoinDisplaySet objCoinDisplaySet = null;

         if (lstCoins == null)
         {
            return lstCoinDisplaySet;
         }

         string coinIdList = null;  // mch. Take coin_ids in lstCoins and put in comma delimited list 11/28/2018



         string storedProcedureString = "GetAllCoins_sp";
         SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
         SqlCommand comm = new SqlCommand(storedProcedureString, conn);
         SqlDataReader rdr;

         comm.CommandType = System.Data.CommandType.StoredProcedure;


         try
         {
            conn.Open();
            rdr = comm.ExecuteReader();

            lstCoinDisplaySet = new List<CoinDisplaySet>();

            while (rdr.Read())
            {
               objCoinDisplaySet = new CoinDisplaySet();

               objCoinDisplaySet.Coin_Id = (int)rdr["coin_id"];
               objCoinDisplaySet.Obverse_Image = (byte[])rdr["obverse_image"];
               objCoinDisplaySet.Reverse_Image = (byte[])rdr["reverse_image"];
               objCoinDisplaySet.Issuing_Authority_Name = ((string)rdr["issuing_authority_name"]).Trim();
               objCoinDisplaySet.Obverse_Legend = ((string)rdr["obverse_legend"]).Trim();
               objCoinDisplaySet.Reverse_Legend = ((string)rdr["reverse_legend"]).Trim();
               objCoinDisplaySet.Exergue = ((string)rdr["exergue"]).Trim();

               //objCoin = new Coin();
               //objCoin.Coin_Id = objCoinDisplaySet.Coin_Id;
               //ricLabel = RIC_DL.GetRicReferenceLabel(objCoin);

               //objCoinDisplaySet.Ric_Label = ricLabel;

               lstCoinDisplaySet.Add(objCoinDisplaySet);
            }
         }
         catch (Exception ex)
         {
            lstCoinDisplaySet = null;
         }
         finally
         {
            conn.Close();
            conn.Dispose();
            comm.Dispose();
         }

         return lstCoinDisplaySet;
      }





















   }
}
