using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using bcs.arcSpace.Support_Classes;

namespace bcs.arcSpace.Data_Layer
{
    public class CoinLabelSet_DL
    {

      public static List<CoinLabelSet> GetCoinLabelSetRecordList()
      {
         List<CoinLabelSet> lstCoinLabelSet = null;
         CoinLabelSet objCoinLabelSet = null;

         string storedProcedureString = "GetAllCoins_sp";
         SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
         SqlCommand comm = new SqlCommand(storedProcedureString, conn);
         SqlDataReader rdr;

         comm.CommandType = System.Data.CommandType.StoredProcedure;

         try
         {
            conn.Open();
            rdr = comm.ExecuteReader();

            lstCoinLabelSet = new List<CoinLabelSet>();

            while (rdr.Read())
            {
               objCoinLabelSet = new CoinLabelSet();

               objCoinLabelSet.Coin_Id = (int)rdr["coin_id"];
               objCoinLabelSet.Issuing_Authority_Name = ((string)rdr["issuing_authority_name"]).Trim();
               objCoinLabelSet.Obverse_Legend = ((string)rdr["obverse_legend"]).Trim();
               objCoinLabelSet.Reverse_Legend = ((string)rdr["reverse_legend"]).Trim();
               objCoinLabelSet.Exergue = ((string)rdr["exergue"]).Trim();

               lstCoinLabelSet.Add(objCoinLabelSet);
            }
         }
         catch (Exception ex)
         {
            lstCoinLabelSet = null;
         }
         finally
         {
            conn.Close();
            conn.Dispose();
            comm.Dispose();
         }

         return lstCoinLabelSet;
      }

    }
}
