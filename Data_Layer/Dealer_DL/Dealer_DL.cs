using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bcs.arcSpace.Support_Classes;

namespace bcs.arcSpace.Data_Layer
{
    public static class Dealer_DL
   { 
     /// <summary>
     /// 
     /// </summary>
     /// <param name="objDealer"></param>
     /// <returns></returns>

     public static Boolean InsertDealerRecord(Dealer objDealer)
      {
         bool insertSuccessful = false;

         if (objDealer == null)
         {
            return insertSuccessful;
         }

         string insertString = "INSERT INTO tblDealer (first_name, last_name, business_name, street_address1, street_address2, city, state_province_id, postal_code, country_id, phone_number, email_address, web_site, notes) VALUES ('{0}', '{1}', '{2}', ";
         insertString = insertString + "'{3}', '{4}', '{5}', '{6}', '{7}', '{8}', {9}, '{10}', '{11}', '{12}', '{13}')";
         insertString = string.Format(insertString, objDealer.First_Name, objDealer.Last_Name, objDealer.Address1, objDealer.Address2, objDealer.City, objDealer.State_Province_Id, objDealer.Postal_Code, objDealer.Country_Id, objDealer.Phone_Number, objDealer.Email_Address, objDealer.Web_Site, objDealer.Notes);

         insertSuccessful = DataLayer.InsertTypeRecord(insertString);

         return insertSuccessful;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="objDealer"></param>
      /// <returns></returns>

      public static bool UpdateDealerRecord(Dealer objDealer)
      {

         bool updateSuccessful = false;

         if (objDealer == null)
         {
            return updateSuccessful;
         }

         string updateString = "UPDATE tblDealer SET first_name = '{0}', last_name = '{1}', business_name = '{2}', street_address1 = '{3}', street_address2 = '{4}', ";
         updateString = updateString + "city = '{5}', state_province_id = {6}, postal_code = '{7}', country_id = {8}, phone_number = '{9}', email_address = '{10}', web_site = '{11}', notes = '{12}'";
         updateString = updateString + "WHERE dealer_id = {13}";

         updateString = string.Format(updateString, objDealer.First_Name, objDealer.Last_Name, objDealer.Business_Name, objDealer.Address1, objDealer.Address2, objDealer.City, objDealer.State_Province_Id, objDealer.Postal_Code, objDealer.Country_Id, objDealer.Phone_Number, objDealer.Email_Address, objDealer.Web_Site, objDealer.Notes);


         updateSuccessful = DataLayer.UpdateTypeRecord(updateString);

         return updateSuccessful;
      }


      /// <summary>
      /// 
      /// </summary>
      /// <param name="objDealer"></param>
      /// <returns></returns>
      public static bool DeleteDealerRecord(Dealer objDealer)
      {
         bool deleteSuccessful = false;

         if (objDealer == null)
         {
            return deleteSuccessful;
         }

         string deleteStatement = string.Format("DELETE FROM tblDealer WHERE dealer_id = {0}", objDealer.Dealer_Id.ToString());

         deleteSuccessful = DataLayer.DeleteTypeRecord(deleteStatement);

         return deleteSuccessful;
      }


      public static List<Dealer> GetDealerRecordList()
      {
         List<Dealer> lstDealer = new List<Dealer>();
         Dealer objDealer;

         string selectString = "SELECT dealer_id, first_name, last_name, business_name, street_address1, street_address2, city, state_province_id, postal_code, country_id, phone_number, email_address, web_site, notes FROM tblDealer";

         SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
         SqlCommand comm = new SqlCommand(selectString, conn);
         SqlDataReader rdr;

         try
         {
            conn.Open();
            rdr = comm.ExecuteReader();

            while (rdr.Read())
            {
               objDealer = new Dealer();
               objDealer.Dealer_Id = Convert.ToInt32(rdr["dealer_id"]);
               objDealer.First_Name = Convert.ToString(rdr["first_name"]);
               objDealer.Last_Name = Convert.ToString(rdr["Last_name"]);
               objDealer.Business_Name = Convert.ToString(rdr["business_name"]);
               objDealer.Address1 = Convert.ToString(rdr["street_address1"]);
               objDealer.Address2 = Convert.ToString(rdr["street_address2"]);
               objDealer.City = Convert.ToString(rdr["city"]);
               objDealer.State_Province_Id = Convert.ToInt32(rdr["state_province_id"]);
               objDealer.Postal_Code = Convert.ToString(rdr["postal_code"]);
               objDealer.Country_Id = Convert.ToInt32(rdr["country_id"]);
               objDealer.Phone_Number = Convert.ToString(rdr["phone_number"]);
               objDealer.Email_Address = Convert.ToString(rdr["email_address"]);
               objDealer.Web_Site = Convert.ToString(rdr["web_site"]);
               objDealer.Notes = Convert.ToString(rdr["notes"]);

               lstDealer.Add(objDealer);
            }
         }
         catch
         {
            lstDealer = null;
         }
         finally
         {
            conn.Close();
            conn.Dispose();
            comm.Dispose();
         }

         return lstDealer;

      }

   }
}
