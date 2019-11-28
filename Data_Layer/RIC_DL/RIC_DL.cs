using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using bcs.arcSpace.Support_Classes;

namespace bcs.arcSpace.Data_Layer
{
    public class RIC_DL
    {

      #region RicVolume methods 

      public static bool InsertRicVolumeRecord(RIC objRic)
      {
         bool insertSuccessful = false;

         if (objRic == null)
         {
            return insertSuccessful;
         }

         string insertString = "Insert into tblRicVolume (ric_volume, ric_volume_description) values ('{0}', '{1}')";
         insertString = string.Format(insertString, objRic.Ric_Volume, objRic.Ric_Volume_Description);

         insertSuccessful = DataLayer.InsertTypeRecord(insertString);

         return insertSuccessful;
      }


      public static bool UpdateRicVolumeRecord(RIC objRic)
      {
         bool updateSuccessful = false;

         if (objRic == null)
         {
            return updateSuccessful;
         }

         string updateString = "Update tblRicVolume set ric_volume = '{0}', ric_volume_description = '{1}' where ric_volume_id = {2}";
         updateString = string.Format(updateString, objRic.Ric_Volume, objRic.Ric_Volume_Description, objRic.Ric_Volume_Id);

         updateSuccessful = DataLayer.UpdateTypeRecord(updateString);

         return updateSuccessful;
      }


      public static bool DeleteRicVolumeRecord(RIC objRic)
      {
         bool deleteSuccessful = false;

         if (objRic == (RIC) null)
         {
            return deleteSuccessful;
         }

         string deleteStatement = string.Format("DELETE FROM tblRicVolume WHERE ric_volume_id = {0}", objRic.Ric_Volume_Id.ToString());

         deleteSuccessful = DataLayer.DeleteTypeRecord(deleteStatement);

         return deleteSuccessful;
      }

      public static List<RIC> GetRicVolumeRecordList()
      {
         List<RIC> lstRic = new List<RIC>();

         RIC objRic = null;

         string selectString = "select ric_volume_id, ric_volume from tblRicVolume";


         SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
         SqlCommand comm = new SqlCommand(selectString, conn);
         SqlDataReader rdr;

         try
         {
            conn.Open();
            rdr = comm.ExecuteReader();

            while (rdr.Read())
            {
               objRic = new RIC();
               objRic.Ric_Volume_Id = Convert.ToInt32(rdr["ric_volume_id"]);
               objRic.Ric_Volume = Convert.ToString(rdr["ric_volume"]);

               lstRic.Add(objRic);
            }
         }
         catch
         {
            lstRic = null;
         }
         finally
         {
            conn.Close();
            conn.Dispose();
            comm.Dispose();
         }

         return lstRic;
      }

      #endregion RicVolume methods

      #region RicSection methods

      public static bool InsertRicSectionRecord(RIC objRic)
      {
         bool insertSuccessful = false;

         if (objRic == null)
         {
            return insertSuccessful;
         }

         string insertString = "Insert into tblRicSection (ric_volume_id, ric_section, ric_section_description) values ({0}, '{1}', '{2}')";
         insertString = string.Format(insertString, objRic.Ric_Volume_Id, objRic.Ric_Section, objRic.Ric_Section_Description);

         insertSuccessful = DataLayer.InsertTypeRecord(insertString);

         return insertSuccessful;
      }

      public static bool UpdateRicSectionRecord(RIC objRic)
      {
         bool updateSuccessful = false;

         if (objRic == null)
         {
            return updateSuccessful;
         }

         string updateString = "Update tblRicSection set ric_volume_id = {0}, ric_section = '{1}', ric_section_description = '{2}' where ric_section_id = {3}";
         updateString = string.Format(updateString, objRic.Ric_Volume_Id, objRic.Ric_Section, objRic.Ric_Section_Description, objRic.Ric_Section_Id);

         updateSuccessful = DataLayer.UpdateTypeRecord(updateString);

         return updateSuccessful;
      }

      public static bool DeleteRicSectionRecord(RIC objRic)
      {
         bool deleteSuccessful = false;

         if (objRic == (RIC)null)
         {
            return deleteSuccessful;
         }

         string deleteStatement = string.Format("DELETE FROM tblRicSection WHERE ric_section_id = {0}", objRic.Ric_Section_Id.ToString());

         deleteSuccessful = DataLayer.DeleteTypeRecord(deleteStatement);

         return deleteSuccessful;
      }

      public static List<RIC> GetRicSectionRecordList()
      {
         List<RIC> lstRic = new List<RIC>();

         RIC objRic = null;

         string selectString = "select ric_volume_id, ric_section_id, ric_section from tblRicSection";


         SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
         SqlCommand comm = new SqlCommand(selectString, conn);
         SqlDataReader rdr;

         try
         {
            conn.Open();
            rdr = comm.ExecuteReader();

            while (rdr.Read())
            {
               objRic = new RIC();
               objRic.Ric_Volume_Id = Convert.ToInt32(rdr["ric_volume_id"]);
               objRic.Ric_Section_Id = Convert.ToInt32(rdr["ric_section_id"]);
               objRic.Ric_Section = Convert.ToString(rdr["ric_section"]);

               lstRic.Add(objRic);
            }
         }
         catch
         {
            lstRic = null;
         }
         finally
         {
            conn.Close();
            conn.Dispose();
            comm.Dispose();
         }

         return lstRic;
      }

      public static int GetRicIndexIdByCoinId(int coinId)  // mch 09/17/2017
      {
         int ricIndexId = 0;

         if (coinId == 0)
         {
            return coinId;
         }

         string selectString = string.Format("select ric_index_id from [Ancient Roman Coins].[dbo].[tblCoins] where coin_id = {0}", coinId);

         SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
         SqlCommand comm = new SqlCommand(selectString, conn);
         SqlDataReader rdr;

         try
         {
            conn.Open();
            rdr = comm.ExecuteReader();

            rdr.Read();

            ricIndexId = Convert.ToInt32(rdr["ric_index_id"]);
         }
         catch (Exception ex)
         {
            ricIndexId = 0;
         }
         finally
         {
            conn.Close();
            conn.Dispose();
            comm.Dispose();
         }
         return ricIndexId;
      }


      public static List<RIC> GetRicSectionRecordList(Coin coin)
      {
         List<RIC> lstRic = null;
         RIC objRic;

         if (coin == null)
         {
            return lstRic;
         }

         string selectString = "select ric_section, ric_section_id from tblRicSection where ric_volume_id = {0}";
         selectString = string.Format(selectString, coin.Ric_Volume_Id);

         SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
         SqlCommand comm = new SqlCommand(selectString, conn);
         SqlDataReader rdr;

         lstRic = new List<RIC>();

         try
         {
            conn.Open();
            rdr = comm.ExecuteReader();

            while (rdr.Read())
            {
               objRic = new RIC();

               objRic.Ric_Section = Convert.ToString(rdr["ric_section"]);
               objRic.Ric_Section_Id = Convert.ToInt32(rdr["ric_section_id"]);

               lstRic.Add(objRic);

            }
         }
         catch (Exception ex)
         {
            lstRic = null;
         }
         finally
         {
            conn.Close();
            conn.Dispose();
            comm.Dispose();
         }
         return lstRic;
      }

      #endregion RicSection methods

      #region RicIndex methods

      public static bool InsertRicIndexRecord(RIC objRic)
      {
         bool insertSuccessful = false;

         if (objRic == null)
         {
            return insertSuccessful;
         }

         string insertString = "Insert into tblRicIndex (ric_volume_id, ric_section_id, ric_index, ric_index_description) values ({0}, {1}, '{2}', '{3}')";
         insertString = string.Format(insertString, objRic.Ric_Volume_Id, objRic.Ric_Section_Id, objRic.Ric_Index, objRic.Ric_Index_Description);

         insertSuccessful = DataLayer.InsertTypeRecord(insertString);

         return insertSuccessful;
      }

      public static bool UpdateRicIndexRecord(RIC objRic)
      {
         bool updateSuccessful = false;

         if (objRic == null)
         {
            return updateSuccessful;
         }

         string updateString = "Update tblRicSection set ric_volume_id = {0}, ric_section_id = {1}, ric_index = '{2}', ric_index_description = '{3}' where ric_index_id = {4}";
         updateString = string.Format(updateString, objRic.Ric_Volume_Id, objRic.Ric_Section_Id, objRic.Ric_Index, objRic.Ric_Index_Description, objRic.Ric_Index_Id);

         updateSuccessful = DataLayer.UpdateTypeRecord(updateString);

         return updateSuccessful;
      }


      public static bool DeleteRicIndexRecord(RIC objRic)
      {
         bool deleteSuccessful = false;

         if (objRic == (RIC)null)
         {
            return deleteSuccessful;
         }

         string deleteStatement = string.Format("DELETE FROM tblRicIndex WHERE ric_index_id = {0}", objRic.Ric_Index_Id.ToString());

         deleteSuccessful = DataLayer.DeleteTypeRecord(deleteStatement);

         return deleteSuccessful;
      }


      public static List<RIC> GetRicIndexRecordList()
      {
         List<RIC> lstRic = new List<RIC>();

         RIC objRic = null;

         string selectString = "select ric_volume_id, ric_section_id, ric_index_id, ric_index from tblRicIndex";


         SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
         SqlCommand comm = new SqlCommand(selectString, conn);
         SqlDataReader rdr;

         try
         {
            conn.Open();
            rdr = comm.ExecuteReader();

            while (rdr.Read())
            {
               objRic = new RIC();
               objRic.Ric_Volume_Id = Convert.ToInt32(rdr["ric_volume_id"]);
               objRic.Ric_Section_Id = Convert.ToInt32(rdr["ric_section_id"]);
               objRic.Ric_Index_Id = Convert.ToInt32(rdr["ric_index_id"]);
               objRic.Ric_Index = Convert.ToString(rdr["ric_index"]);

               lstRic.Add(objRic);
            }
         }
         catch
         {
            lstRic = null;
         }
         finally
         {
            conn.Close();
            conn.Dispose();
            comm.Dispose();
         }

         return lstRic;
      }

      #endregion RicIndex methods

      #region RIC methods

      public static RIC GetRicReferenceRecord(Coin objCoin)
      {
         string storedProcedure;
         RIC objRic = null;

         if (objCoin == null || objCoin.Ric_Index_Id == 0)
         {
            return objRic;
         }

         SqlConnection conn;
         SqlCommand comm;
         SqlDataReader rdr;

         storedProcedure = "GetRicIndexByRicIndexId_sp";

         conn = new SqlConnection(DataLayer.ConnectionString);
         comm = new SqlCommand(storedProcedure, conn);

         comm.Parameters.AddWithValue("@ricIndexId", objCoin.Ric_Index_Id);

         comm.CommandType = System.Data.CommandType.StoredProcedure;

         try
         {
            conn.Open();
            rdr = comm.ExecuteReader();

            objRic = new RIC();

            while (rdr.Read())
            {
               objRic.Ric_Volume_Id = Convert.ToInt32(rdr["ric_volume_id"]);
               objRic.Ric_Volume = Convert.ToString(rdr["ric_volume"]);
               objRic.Ric_Section_Id = Convert.ToInt32(rdr["ric_section_id"]);
               objRic.Ric_Section = Convert.ToString(rdr["ric_section"]);
               objRic.Ric_Index_Id = Convert.ToInt32(rdr["ric_index_id"]);
               objRic.Ric_Index = Convert.ToString(rdr["ric_index"]);
            }
         }
         catch (Exception ex)
         {
            objRic = null;
         }
         finally
         {
            conn.Close();
            conn.Dispose();
            comm.Dispose();
         }
         return objRic;
      }


      public static RIC GetRicReferenceRecordByRicIndexId(int ricIndexId)  // mch 09/17/2017
      {
         string storedProcedure;
         RIC objRic = null;

         if (ricIndexId == 0)
         {
            return objRic;
         }

         SqlConnection conn;
         SqlCommand comm;
         SqlDataReader rdr;

         storedProcedure = "GetRicIndexByRicIndexId_sp";

         conn = new SqlConnection(DataLayer.ConnectionString);
         comm = new SqlCommand(storedProcedure, conn);

         comm.Parameters.AddWithValue("@ricIndexId", ricIndexId);

         comm.CommandType = System.Data.CommandType.StoredProcedure;

         try
         {
            conn.Open();
            rdr = comm.ExecuteReader();

            rdr.Read();

            objRic = new RIC();

            objRic.Ric_Volume_Id = Convert.ToInt32(rdr["ric_volume_id"]);
            objRic.Ric_Volume = Convert.ToString(rdr["ric_volume"]);
            objRic.Ric_Section_Id = Convert.ToInt32(rdr["ric_section_id"]);
            objRic.Ric_Section = Convert.ToString(rdr["ric_section"]);
            objRic.Ric_Index_Id = Convert.ToInt32(rdr["ric_index_id"]);
            objRic.Ric_Index = Convert.ToString(rdr["ric_index"]);
         }
         catch (Exception ex)
         {
            objRic = null;
         }
         finally
         {
            conn.Close();
            conn.Dispose();
            comm.Dispose();
         }
         return objRic;
      }



      public static string GetRicReferenceLabel(Coin objCoin)
      {
         string ricLabel = null;

         RIC objRic = RIC_DL.GetRicReferenceRecord(objCoin);

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
