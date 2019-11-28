using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bcs.arcSpace.Support_Classes;
using bcs.arcSpace.Data_Layer;

namespace bcs.arcSpace.Data_Layer
{
    public static class Coin_Type_DL
    {

       public static bool InsertCoinTypeRecord(Coin_Type objCoinType)  
       {
          bool insertSuccessful = false;

          string strCoinType, strDescription;

          if (objCoinType == (Coin_Type) null)
          {
             return insertSuccessful;
          }

          string insertString = "INSERT INTO tblCoinType (coin_type_id, coin_type, description) VALUES (NEXT VALUE FOR seqCoinType, {0}, {1})";

          strCoinType = "'" + objCoinType.Coin_Type_Name.Trim() + "'";

          if (!string.IsNullOrEmpty(objCoinType.Coin_Type_Desc))
          {
             strDescription = "'" + objCoinType.Coin_Type_Desc.Trim() + "'";
          }
          else
          {
             strDescription = "NULL";
          }

          insertString = string.Format(insertString, strCoinType, strDescription);

          insertSuccessful = DataLayer.InsertTypeRecord(insertString);
       
          return insertSuccessful;
       }
    
       
       public static bool UpdateCoinTypeRecord(Coin_Type objCoinType)
       {
          string strDescription;

          bool updateSuccessful = false;

          if (objCoinType == (Coin_Type)null)
          {
             return updateSuccessful;
          }

          if (string.IsNullOrEmpty(objCoinType.Coin_Type_Name))
          {
             return updateSuccessful;
          }

          if (string.IsNullOrEmpty(objCoinType.Coin_Type_Desc))
          {
             strDescription = ", description = ''";
          }
          else
          {
             strDescription = string.Format(", description = '{0}'", objCoinType.Coin_Type_Desc.Trim());
          }

          string updateString = string.Format("UPDATE tblCoinType SET coin_type = '{0}'{1} WHERE coin_type_id = {2}", objCoinType.Coin_Type_Name, strDescription, objCoinType.Coin_Type_Id);
          updateSuccessful = DataLayer.UpdateTypeRecord(updateString);

         return updateSuccessful;
       }

       public static bool DeleteCoinTypeRecord(Coin_Type objCoinType) 
       {
          bool deleteSuccessful = false;

          if (objCoinType == (Coin_Type)null)
          {
             return deleteSuccessful;
          }

          string deleteStatement = string.Format("DELETE FROM tblCoinType WHERE coin_type_id = {0}", objCoinType.Coin_Type_Id.ToString());

         deleteSuccessful = DataLayer.DeleteTypeRecord(deleteStatement);

          return deleteSuccessful;
       }
              
       public static List<Coin_Type> GetCoinTypeRecordList()
       {
          Coin_Type objCoinType;
          List<Coin_Type> lstCoinType = (List<Coin_Type>)null;

          string selectStatement = "SELECT coin_type_id, coin_type, description FROM dbo.tblCoinType";

          SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
          SqlCommand comm = new SqlCommand(selectStatement, conn);
          SqlDataReader rdr;


          lstCoinType = new List<Coin_Type>();
          try
          {
             conn.Open();
             rdr = comm.ExecuteReader();

             while (rdr.Read())
             {
                objCoinType = new Coin_Type();
                objCoinType.Coin_Type_Id = Convert.ToUInt32(rdr["coin_Type_id"]);
                if (!string.IsNullOrEmpty(rdr["coin_type"].ToString()))
                {
                   objCoinType.Coin_Type_Name = Convert.ToString(rdr["coin_type"]);
                }
                else
                {
                   objCoinType.Coin_Type_Name = (string)null;
                }

                if (!string.IsNullOrEmpty(rdr["description"].ToString()))
                {
                   objCoinType.Coin_Type_Desc = Convert.ToString(rdr["description"]);
                }
                else
                {
                   objCoinType.Coin_Type_Desc = (string) null;
                }

                lstCoinType.Add(objCoinType);
             }
          }
          catch
          {
             lstCoinType = (List<Coin_Type>) null;
          }
          finally
          {
             conn.Close();
             conn.Dispose();
             comm.Dispose();
          }

          return lstCoinType;

       }
    }
}
