using bcs.arcSpace.Support_Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace bcs.arcSpace.Data_Layer
{
    public class XlReportAndLabel_DL
    {
        public static List<XlReportAndLabel> GetAllCoinsForReportingRecordList()
        {
            XlReportAndLabel objRL = null;
            List<XlReportAndLabel> lstRL = null;

            string storedProcedureString = "GetAllCoinsForReporting_sp";
            SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
            SqlCommand comm = new SqlCommand(storedProcedureString, conn);
            SqlDataReader rdr;

            comm.CommandType = System.Data.CommandType.StoredProcedure;


            /*

      private int _rep_label_id;
      private int _coin_id;  // coin_id int
      private string _issuing_authority_name;   // issuing_authority_name varchar(128)
      private string _issuing_authority_title;  // issuing_authority_title varchar(64)
      private string _coin_type;                // coin_type varchar(64),startMintingYear varchar(8)
      private string _start_minting_year;       // startMintingYear varchar(8)
      private string _end_minting_year;         // endMintingYear varchar(8)
      private string _mint_name;                // mint_name varchar(64)
      private string _material_description;     // material_description varchar(64)
      private string _diameter;
      private string _weight;
      private string _die_axis;
      private string _obverse_legend;
      private string _obverse_description;
      private string _reverse_legend;
      private string _exergue;
      private string _reverse_description;
      private string _ric_index;
      private string _usd_price;
      private string _period;
      private string _reign_begin_year; 
      private string _reign_end_year;
      private string _grade;
      private string _coin_description;


            */


            try
            {
                conn.Open();
                rdr = comm.ExecuteReader();

                lstRL = new List<XlReportAndLabel>();

                while (rdr.Read())
                {
                    objRL = new XlReportAndLabel();

                    objRL.Coin_Id = (int)rdr["coin_id"];
                    objRL.Coin_Description = (string)rdr["coin_description"];
                    objRL.Issuing_Authority_Name = (string)rdr["issuing_authority_name"];
                    objRL.Issuing_Authority_Title = (string)rdr["issuing_authority_title"];
                    objRL.Coin_Type = (string)rdr["coin_type"];
                    objRL.Start_Minting_Year = (string)rdr["startMintingYear"];  //  minting of coin

                    objRL.End_Minting_Year = (string)rdr["endMintingYear"];  // minting of coin
                    objRL.Mint_Name = (string)rdr["mint_name"];
                    objRL.Material_Description = (string)rdr["material_description"];
                    objRL.Diameter = (string)rdr["diameter"];
                    objRL.Weight = (string)rdr["weight"];
                    objRL.Die_Axis = (string)rdr["dieAxis"];
                    objRL.Obverse_Legend = (string)rdr["obverse_legend"];
                    objRL.Obverse_Description = (string)rdr["obverse_description"];
                    objRL.Reverse_Legend = (string)rdr["reverse_legend"];
                    objRL.Exergue = (string)rdr["exergue"];
                    objRL.Reverse_Description = (string)rdr["reverse_description"];
                    objRL.Ric_Index = (string)rdr["RicIndex"];
                    objRL.Usd_Price = (string)rdr["usdPrice"];
                    objRL.Period = (string)rdr["period_name"];
                    objRL.Reign_Begin_Year = (string)rdr["AuthorityStartYear"];  // authority's reign
                    objRL.Reign_End_Year = (string)rdr["AuthorityEndYear"];      // authority's reign

                    lstRL.Add(objRL);
                }
            }
            catch (Exception)
            {
                lstRL = null;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                comm.Dispose();
            }

            return lstRL;
        }

        public static List<XlReportAndLabel> GetCoinForReportingRecord(int[] arrIds)
        {
            XlReportAndLabel objRL = null;
            List<XlReportAndLabel> lstRL = null;

            if (arrIds == null)
            {
                return lstRL;
            }

            /*

                SqlCommand cmd = new SqlCommand("dbo.DoSomethingWithEmployees", conn);
    cmd.CommandType = CommandType.StoredProcedure;
    SqlParameter tvparam = cmd.Parameters.AddWithValue("@List", tvp);
    // these next lines are important to map the C# DataTable object to the correct SQL User Defined Type
    tvparam.SqlDbType = SqlDbType.Structured;
    tvparam.TypeName = "dbo.IDList";

            */
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("ID", typeof(int)));
            foreach (var id in arrIds)
                dt.Rows.Add(id);
            string storedProcedureString = "GetCoinsForReportingByCoinId_sp";
            SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
            SqlCommand comm = new SqlCommand(storedProcedureString, conn);
            SqlDataReader rdr;
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter pArrIds = comm.Parameters.AddWithValue("@coinIds", dt);
            pArrIds.SqlDbType = System.Data.SqlDbType.Structured;
            pArrIds.TypeName = "dbo.idList";

            try
            {
                conn.Open();
                rdr = comm.ExecuteReader();
                lstRL = new List<XlReportAndLabel>();

                while (rdr.Read())
                {
                    objRL = new XlReportAndLabel();

                    objRL.Coin_Id = (int)rdr["coin_id"];
                    objRL.Coin_Description = (string) rdr["coin_description"];
                    objRL.Issuing_Authority_Name = (string)rdr["issuing_authority_name"];
                    objRL.Issuing_Authority_Title = (string)rdr["issuing_authority_title"];
                    objRL.Coin_Type = (string)rdr["coin_type"];
                    objRL.Start_Minting_Year = (string)rdr["startMintingYear"];  //  minting of coin
                    objRL.End_Minting_Year = (string)rdr["endMintingYear"];  // minting of coin
                    objRL.Mint_Name = (string)rdr["mint_name"];
                    objRL.Material_Description = (string)rdr["material_description"];
                    objRL.Diameter = (string)rdr["diameter"];
                    objRL.Weight = (string)rdr["weight"];
                    objRL.Die_Axis = (string)rdr["dieAxis"];
                    objRL.Obverse_Legend = (string)rdr["obverse_legend"];
           //         objRL.Obverse_Description = (string)rdr["obverse_description"];
                    objRL.Reverse_Legend = (string)rdr["reverse_legend"];
                    objRL.Exergue = (string)rdr["exergue"];
          //          objRL.Reverse_Description = (string)rdr["reverse_description"];
                    objRL.Ric_Index = (string)rdr["RicIndex"];
                    objRL.Usd_Price = (string)rdr["usdPrice"];
                    objRL.Period = (string)rdr["period_name"];
                    objRL.Reign_Begin_Year = (string)rdr["AuthorityStartYear"];  // authority's reign
                    objRL.Reign_End_Year = (string)rdr["AuthorityEndYear"];      // authority's reign

                    lstRL.Add(objRL);
                }
            }
            catch(Exception ex)
            {
                lstRL = null;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                comm.Dispose();
            }

            return lstRL;
        }
    }
}