using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using bcs.arcSpace.Data_Layer;
using bcs.arcSpace.Support_Classes;

namespace bcs.arcSpace.Data_Layer
{
    public static class ArcNode_DL
    {
      public static List<ArcNode> GetAllCoinRecordsForTreeView()
      {
         List<ArcNode> lstArcNode = null;
         ArcNode objArcNode = null;
          
         string storedProcedureString = "GetAllCoinsForTreeView_sp";
         SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
         SqlCommand comm = new SqlCommand(storedProcedureString, conn);
         SqlDataReader rdr;
         comm.CommandType = System.Data.CommandType.StoredProcedure;

         try
         {
            conn.Open();
            rdr = comm.ExecuteReader();

            lstArcNode = new List<ArcNode>();

            while (rdr.Read())
            {
               objArcNode = new ArcNode();

               objArcNode.Coin_Id = Convert.ToInt32(rdr["coin_id"]);

               objArcNode.Coin_Description = Convert.ToString(rdr["coin_description"]);

               objArcNode.Coin_Type_Id = Convert.ToInt32(rdr["coin_type_id"]);
               objArcNode.Coin_Type = Convert.ToString(rdr["coin_type"]);

               objArcNode.Issuing_Authority_Reign_Id = Convert.ToInt32(rdr["issuing_authority_reign_id"]);
               objArcNode.Issuing_Authority_Name = Convert.ToString(rdr["issuing_authority_name"]);

               objArcNode.Issuing_Authority_Title_Id = Convert.ToInt32(rdr["issuing_authority_title_id"]);
               objArcNode.Issuing_Authority_Title = Convert.ToString(rdr["issuing_authority_title"]);

               objArcNode.Period_Id = Convert.ToInt32(rdr["period_id"]);
               objArcNode.Period_Name = Convert.ToString(rdr["period_name"]);

               objArcNode.Start_Year = Convert.ToInt32(rdr["start_year"]);

               objArcNode.End_Year = Convert.ToInt32(rdr["end_year"]);

               objArcNode.Formatted_Reign = Convert.ToString(rdr["formatted_reign"]);

               objArcNode.Mint_Id = Convert.ToInt32(rdr["mint_id"]);
               objArcNode.Mint_Name = Convert.ToString(rdr["mint_name"]);

               objArcNode.Physical_Attributes_id = Convert.ToInt32(rdr["physical_attributes_id"]);
               objArcNode.Weight = Convert.ToDecimal(rdr["weight"]);
               objArcNode.Diameter = Convert.ToDecimal(rdr["diameter"]);
               objArcNode.Die_Axis= Convert.ToInt32(rdr["die_axis"]);

               objArcNode.Grade_Id = Convert.ToInt32(rdr["grade_id"]);
               objArcNode.Grade_Code = Convert.ToString(rdr["grade_code"]);

               objArcNode.Obverse_Id = Convert.ToInt32(rdr["obverse_id"]);
               objArcNode.Obverse_Legend = Convert.ToString(rdr["obverse_legend"]);
               objArcNode.Obverse_Image = (byte[]) rdr["obverse_image"];

               objArcNode.Reverse_Id = Convert.ToInt32(rdr["reverse_id"]);
               objArcNode.Reverse_Legend = Convert.ToString(rdr["reverse_legend"]);
               objArcNode.Exergue = Convert.ToString(rdr["exergue"]);
               objArcNode.Reverse_Image = (byte[]) rdr["reverse_image"];
               objArcNode.Formatted_Ric_Index = Convert.ToString(rdr["formatted_ric_index"]);

               lstArcNode.Add(objArcNode);
            }
         }
         catch (Exception ex)
         {
            lstArcNode = null;
         }
         finally
         {
            conn.Close();
            conn.Dispose();
            comm.Dispose();
         }
         return lstArcNode;
      }

      public static List<ArcNode> GetCoinRecordsForTreeViewByPeriodId(int period_id)
      {
         List<ArcNode> lstArcNode = null;
         ArcNode objArcNode = null;

         string storedProcedureString = "GetCoinsForTreeViewByPeriodId_sp";
         SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
         SqlCommand comm = new SqlCommand(storedProcedureString, conn);
         SqlDataReader rdr;
         comm.CommandType = System.Data.CommandType.StoredProcedure;
         comm.Parameters.AddWithValue("@PeriodId", period_id);

         try
         {
            conn.Open();
            rdr = comm.ExecuteReader();

            lstArcNode = new List<ArcNode>();

            while (rdr.Read())
            {
               objArcNode = new ArcNode();

               objArcNode.Coin_Id = Convert.ToInt32(rdr["coin_id"]);

               objArcNode.Coin_Description = Convert.ToString(rdr["coin_description"]);

               objArcNode.Coin_Type_Id = Convert.ToInt32(rdr["coin_type_id"]);
               objArcNode.Coin_Type = Convert.ToString(rdr["coin_type"]);

               objArcNode.Issuing_Authority_Reign_Id = Convert.ToInt32(rdr["issuing_authority_reign_id"]);
               objArcNode.Issuing_Authority_Name = Convert.ToString(rdr["issuing_authority_name"]);

               objArcNode.Issuing_Authority_Title_Id = Convert.ToInt32(rdr["issuing_authority_title_id"]);
               objArcNode.Issuing_Authority_Title = Convert.ToString(rdr["issuing_authority_title"]);

               objArcNode.Period_Id = Convert.ToInt32(rdr["period_id"]);
               objArcNode.Period_Name = Convert.ToString(rdr["period_name"]);

               objArcNode.Start_Year = Convert.ToInt32(rdr["reign_start_year"]);

               objArcNode.End_Year = Convert.ToInt32(rdr["reign_end_year"]);

               objArcNode.Formatted_Reign = Convert.ToString(rdr["formatted_reign"]);

               objArcNode.Mint_Id = Convert.ToInt32(rdr["mint_id"]);
               objArcNode.Mint_Name = Convert.ToString(rdr["mint_name"]);

               objArcNode.Physical_Attributes_id = Convert.ToInt32(rdr["physical_attributes_id"]);
               objArcNode.Weight = Convert.ToDecimal(rdr["weight"]);
               objArcNode.Diameter = Convert.ToDecimal(rdr["diameter"]);
               objArcNode.Die_Axis = Convert.ToInt32(rdr["die_axis"]);

               objArcNode.Grade_Id = Convert.ToInt32(rdr["grade_id"]);
               objArcNode.Grade_Code = Convert.ToString(rdr["grade_code"]);

               objArcNode.Obverse_Id = Convert.ToInt32(rdr["obverse_id"]);
               objArcNode.Obverse_Legend = Convert.ToString(rdr["obverse_legend"]);
               objArcNode.Obverse_Image = (byte[]) rdr["obverse_image"];

               objArcNode.Reverse_Id = Convert.ToInt32(rdr["reverse_id"]);
               objArcNode.Reverse_Legend = Convert.ToString(rdr["reverse_legend"]);
               objArcNode.Exergue = Convert.ToString(rdr["exergue"]);
               objArcNode.Reverse_Image = (byte[]) rdr["reverse_image"];
               objArcNode.Formatted_Ric_Index = Convert.ToString(rdr["formatted_ric_index"]);

               lstArcNode.Add(objArcNode);
            }
         }
         catch (Exception ex)
         {
            lstArcNode = null;
         }
         finally
         {
            conn.Close();
            conn.Dispose();
            comm.Dispose();
         }

         return lstArcNode;
      }

   }
}
