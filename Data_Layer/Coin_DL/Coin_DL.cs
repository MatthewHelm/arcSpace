using bcs.arcSpace.Support_Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace bcs.arcSpace.Data_Layer
{
    public class Coin_DL
    {
        public static bool InsertCoinRecord(Coin objCoin)
        {
            List<SqlParameter> lstParameters;
            bool insertSuccessful = false;

            if (objCoin == null)
            {
                return insertSuccessful;
            }

            string storedProcedureString = "InsertCoin_sp";

            lstParameters = new List<SqlParameter>
            {
            new SqlParameter("@coinName", objCoin.Coin_Name),
            new SqlParameter("@coinTypeId", objCoin.Coin_Type_Id),
            new SqlParameter("@coinDescription", objCoin.Coin_Description),
     //       new SqlParameter("@issuingAuthorityId", objCoin.Issuing_Authority_Reign_Id),  mch 08122019  The issuing_authority_reign record is going to drive
            new SqlParameter("@issuingAuthorityReignId", objCoin.Issuing_Authority_Reign_Id),
            new SqlParameter("@mintId", objCoin.Mint_Id),
            new SqlParameter("@materialId", objCoin.Material_Id),
            new SqlParameter("@gradeId", objCoin.Grade_Id),
            new SqlParameter("@obverseLegend", objCoin.Obverse_Legend),
            new SqlParameter("@obverseImage", objCoin.Obverse_Image),
            new SqlParameter("@reverseLegend", objCoin.Reverse_Legend),
            new SqlParameter("@exergue", objCoin.Exergue),
            new SqlParameter("@reverseImage", objCoin.Reverse_Image),
            new SqlParameter("@weight", objCoin.Weight),
            new SqlParameter("@diameter", objCoin.Diameter),
            new SqlParameter("@dieAxis", objCoin.Die_Axis),
            new SqlParameter("@dealerId", objCoin.Dealer_Id),

            new SqlParameter("@price", objCoin.Price),
            new SqlParameter("@ricVolumeId", objCoin.Ric_Volume_Id),
            new SqlParameter("@ricSectionId", objCoin.Ric_Section_Id),
            new SqlParameter("@ricIndex", objCoin.Ric_Index),
            new SqlParameter("@startMintingYear", objCoin.Start_Minting_Year),
            new SqlParameter("@endMintingYear", objCoin.End_Minting_Year),
            new SqlParameter("@startMintingYearEra", objCoin.Start_Minting_Year_Era),
            new SqlParameter("@endMintingYearEra", objCoin.End_Minting_Year_Era)


         };

         //SqlParameter pCoinName = new SqlParameter("@coinName", objCoin.Coin_Name);
         //SqlParameter pCoinTypeId = new SqlParameter("@coinTypeId", objCoin.Coin_Type_Id);
         //SqlParameter pCoinDescription = new SqlParameter("@coinDescription", objCoin.Coin_Description);
         //SqlParameter pIssuingAuthorityId = new SqlParameter("@issuingAuthorityId", objCoin.Issuing_Authority_Reign_Id);
         //SqlParameter pMindId = new SqlParameter("@mintId", objCoin.Mint_Id);
         //SqlParameter pMaterialId = new SqlParameter("@materialId", objCoin.Material_Id);
         //SqlParameter pGradeId = new SqlParameter("@gradeId", objCoin.Grade_Id);
         //SqlParameter pObverseLegend = new SqlParameter("@obverseLegend", objCoin.Obverse_Legend);

         insertSuccessful = DataLayer.ExecuteStoredProcedure(storedProcedureString, lstParameters);
            return insertSuccessful;
        }

        public static List<Coin> GetCoinRecordList()
        {
            List<Coin> lstCoin = null;
            Coin objCoin = null;

            string storedProcedureString = "GetAllCoins_sp";
            SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
            SqlCommand comm = new SqlCommand(storedProcedureString, conn);

            SqlDataReader rdr;

            comm.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                conn.Open();
                rdr = comm.ExecuteReader();

                lstCoin = new List<Coin>();

                while (rdr.Read())
                {
                    objCoin = new Coin();

                    objCoin.Coin_Id = (int)rdr["coin_id"];
                    objCoin.Obverse_Image = (byte[])rdr["obverse_image"];
                    objCoin.Reverse_Image = (byte[])rdr["reverse_image"];
 //                   objCoin.Issuing_Authority_Name = (string)rdr["issuing_authority_name"];
                    objCoin.Obverse_Legend = (string)rdr["obverse_legend"];
                    objCoin.Reverse_Legend = (string)rdr["reverse_legend"];
                    objCoin.Exergue = (string)rdr["exergue"];

                    lstCoin.Add(objCoin);
                }
            }
            catch (Exception)
            {
                lstCoin = null;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                comm.Dispose();
            }

            return lstCoin;
        }

        public static Coin GetCoinRecord(int coinId)
        {
            Coin objCoin = null;

            if (coinId < 0)
            {
                return objCoin;
            }

            string storedProcedureString = "GetCoin_SP";
            SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
            SqlCommand comm = new SqlCommand(storedProcedureString, conn);
            SqlDataReader rdr;
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@CoinId", coinId);

            try
            {
                conn.Open();
                rdr = comm.ExecuteReader();
                objCoin = new Coin();

                while (rdr.Read())
                {
                    objCoin = new Coin();

                    objCoin.Coin_Id = Convert.ToInt32(rdr["coin_id"]);
                    objCoin.Coin_Name = Convert.ToString(rdr["coin_name"]);
                    objCoin.Coin_Type_Id = Convert.ToInt32(rdr["coin_type_id"]);
                    objCoin.Coin_Description = Convert.ToString(rdr["coin_description"]);
                    objCoin.Issuing_Authority_Reign_Id = Convert.ToInt32(rdr["issuing_authority_reign_id"]);
                    objCoin.Mint_Id = Convert.ToInt32(rdr["mint_id"]);
                    objCoin.Material_Id = Convert.ToInt32(rdr["material_id"]);
                    objCoin.Weight = Convert.ToDecimal(rdr["weight"]);
                    objCoin.Diameter = Convert.ToDecimal(rdr["diameter"]);
                    objCoin.Die_Axis = Convert.ToInt32(rdr["die_axis"]);
                    objCoin.Physical_Attributes_Id = Convert.ToInt32(rdr["physical_attributes_id"]);
                    objCoin.Obverse_Legend = Convert.ToString(rdr["obverse_legend"]);
                    objCoin.Obverse_Image = (byte[])rdr["obverse_image"];
                    objCoin.Obverse_Id = Convert.ToInt32(rdr["obverse_id"]);
                    objCoin.Reverse_Legend = Convert.ToString(rdr["reverse_legend"]);
                    objCoin.Reverse_Image = (byte[])rdr["reverse_image"];
                    objCoin.Exergue = Convert.ToString(rdr["exergue"]);
                    objCoin.Reverse_Id = Convert.ToInt32(rdr["reverse_id"]);
                    objCoin.Dealer_Id = Convert.ToInt32(rdr["dealer_id"]);
                    objCoin.Grade_Id = Convert.ToInt32(rdr["grade_id"]);
                    objCoin.Price = Convert.ToDecimal(rdr["Price"]);
                    objCoin.Ric_Volume_Id = Convert.ToInt32(rdr["ric_volume_id"]);
                    objCoin.Ric_Section_Id = Convert.ToInt32(rdr["ric_section_id"]);
                    objCoin.Ric_Index_Id = Convert.ToInt32(rdr["ric_index_id"]);
                    objCoin.Ric_Index = Convert.ToString(rdr["ric_index"]);
                }
            }
            catch (Exception)
            {
                objCoin = null;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                comm.Dispose();
            }
            return objCoin;
        }

        public static List<Coin> GetCoinRecord(Coin objCoin)
        {
            List<Coin> lstCoin = null;

            if (objCoin == null || objCoin.Coin_Id == 0)
            {
                return lstCoin;
            }

            string storedProcedureString = "GetCoin_SP";
            SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
            SqlCommand comm = new SqlCommand(storedProcedureString, conn);
            SqlDataReader rdr;
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@CoinId", objCoin.Coin_Id);

            try
            {
                conn.Open();
                rdr = comm.ExecuteReader();

                lstCoin = new List<Coin>();

                while (rdr.Read())
                {
                    objCoin = new Coin();

                    objCoin.Coin_Id = Convert.ToInt32(rdr["coin_id"]);
                    objCoin.Coin_Name = Convert.ToString(rdr["coin_name"]);
                    objCoin.Coin_Type_Id = Convert.ToInt32(rdr["coin_type_id"]);
                    objCoin.Coin_Description = Convert.ToString(rdr["coin_description"]);
                    objCoin.Issuing_Authority_Reign_Id = Convert.ToInt32(rdr["issuing_authority_reign_id"]);
                    objCoin.Mint_Id = Convert.ToInt32(rdr["mint_id"]);
                    objCoin.Material_Id = Convert.ToInt32(rdr["material_id"]);
                    objCoin.Weight = Convert.ToDecimal(rdr["weight"]);
                    objCoin.Diameter = Convert.ToDecimal(rdr["diameter"]);
                    objCoin.Die_Axis = Convert.ToInt32(rdr["die_axis"]);
                    objCoin.Physical_Attributes_Id = Convert.ToInt32(rdr["physical_attributes_id"]);
                    objCoin.Obverse_Legend = Convert.ToString(rdr["obverse_legend"]);
                    objCoin.Obverse_Image = (byte[])rdr["obverse_image"];
                    objCoin.Obverse_Id = Convert.ToInt32(rdr["obverse_id"]);
                    objCoin.Reverse_Legend = Convert.ToString(rdr["reverse_legend"]);
                    objCoin.Reverse_Image = (byte[])rdr["reverse_image"];
                    objCoin.Exergue = Convert.ToString(rdr["exergue"]);
                    objCoin.Reverse_Id = Convert.ToInt32(rdr["reverse_id"]);
                    objCoin.Dealer_Id = Convert.ToInt32(rdr["dealer_id"]);
                    objCoin.Grade_Id = Convert.ToInt32(rdr["grade_id"]);
                    objCoin.Price = Convert.ToDecimal(rdr["Price"]);
                    objCoin.Ric_Volume_Id = Convert.ToInt32(rdr["ric_volume_id"]);
                    objCoin.Ric_Section_Id = Convert.ToInt32(rdr["ric_section_id"]);
                    objCoin.Ric_Index_Id = Convert.ToInt32(rdr["ric_index_id"]);
                    objCoin.Ric_Index = Convert.ToString(rdr["ric_index"]);

                    lstCoin.Add(objCoin);
                }
            }
            catch (Exception)
            {
                lstCoin = null;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                comm.Dispose();
            }
            return lstCoin;
        }

        public static bool UpdateCoinRecord(Coin objCoin)
        {
            bool updateSuccessful = false;

            if (objCoin == null || objCoin.Coin_Id == 0)
            {
                return updateSuccessful;
            }

            string storedProcedureString = "UpdateCoin_sp";
            SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
            SqlCommand comm = new SqlCommand(storedProcedureString, conn);
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            comm.Parameters.AddWithValue("@coinId", objCoin.Coin_Id);
            comm.Parameters.AddWithValue("@coinName", objCoin.Coin_Name);
            comm.Parameters.AddWithValue("@coinTypeId", objCoin.Coin_Type_Id);
            comm.Parameters.AddWithValue("@coinDescription", objCoin.Coin_Description);
            comm.Parameters.AddWithValue("@issuingAuthorityReignId", objCoin.Issuing_Authority_Reign_Id);
            comm.Parameters.AddWithValue("@mintId", objCoin.Mint_Id);
            comm.Parameters.AddWithValue("@materialId", objCoin.Material_Id);
            comm.Parameters.AddWithValue("@obverseLegend", objCoin.Obverse_Legend);
            comm.Parameters.AddWithValue("@obverseImage", objCoin.Obverse_Image);
            comm.Parameters.AddWithValue("@obverseId", objCoin.Obverse_Id);
            comm.Parameters.AddWithValue("@reverseLegend", objCoin.Reverse_Legend);
            comm.Parameters.AddWithValue("@exergue", objCoin.Exergue);
            comm.Parameters.AddWithValue("@reverseImage", objCoin.Reverse_Image);
            comm.Parameters.AddWithValue("@reverseId", objCoin.Reverse_Id);
            comm.Parameters.AddWithValue("@gradeId", objCoin.Grade_Id);
            comm.Parameters.AddWithValue("@weight", objCoin.Weight);
            comm.Parameters.AddWithValue("@diameter", objCoin.Diameter);
            comm.Parameters.AddWithValue("@dieAxis", objCoin.Die_Axis);
            comm.Parameters.AddWithValue("@physAttribId", objCoin.Physical_Attributes_Id);
            comm.Parameters.AddWithValue("@dealerId", objCoin.Dealer_Id);
            comm.Parameters.AddWithValue("@price", objCoin.Price);
            comm.Parameters.AddWithValue("@ricIndexId", objCoin.Ric_Index_Id);
            comm.Parameters.AddWithValue("@ricVolumeId", objCoin.Ric_Volume_Id);
            comm.Parameters.AddWithValue("@ricSectionId", objCoin.Ric_Section_Id);
            comm.Parameters.AddWithValue("@ricIndex", objCoin.Ric_Index);

            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                updateSuccessful = true;
            }
            catch (Exception e)
            {
                updateSuccessful = false;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                comm.Dispose();
            }

            return updateSuccessful;
        }
    }
}