using bcs.arcSpace.Support_Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace bcs.arcSpace.Data_Layer
{
    public class IssuingAuthorityName_DL
    {

/* START CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD START */

      public static bool InsertIssuingAuthorityNameRecord(IssuingAuthorityName objIssuingAuthorityName)
        {
            bool insertSuccessful = false;

            if (objIssuingAuthorityName == (IssuingAuthorityName)null)
            {
                return insertSuccessful;
            }

            string insertString = "INSERT INTO tblIssuingAuthorityName (issuing_authority_name, issuing_authority_full_name) VALUES ('{0}', '{1}')";
            insertString = string.Format(insertString, objIssuingAuthorityName.Issuing_Authority_Name, objIssuingAuthorityName.Issuing_Authority_Full_Name);

            insertSuccessful = DataLayer.InsertTypeRecord(insertString);

            return insertSuccessful;
        }

        public static bool UpdateIssuingAuthorityNameRecord(IssuingAuthorityName objIssuingAuthorityName)
        {
            bool updateSuccessful = false;

            if (objIssuingAuthorityName == null)
            {
                return updateSuccessful;
            }

            string updateString = "UPDATE tblIssuingAuthorityName SET issuing_authority_name = '{0}', issuing_authority_full_name = '{1}' WHERE issuing_authority_id = {2}";
            updateString = string.Format(updateString, objIssuingAuthorityName.Issuing_Authority_Name, objIssuingAuthorityName.Issuing_Authority_Full_Name, objIssuingAuthorityName.Issuing_Authority_Name_Id);

            updateSuccessful = DataLayer.UpdateTypeRecord(updateString);

            return updateSuccessful;
        }

        public static bool DeleteIssuingAuthorityNameRecord(IssuingAuthorityName objIssuingAuthorityName)
        {
            bool deleteSuccessful = false;

            if (objIssuingAuthorityName == (IssuingAuthorityName)null)
            {
                return deleteSuccessful;
            }

            string deleteStatement = string.Format("DELETE FROM tblIssuingAuthorityName WHERE issuing_authority_name_id = {0}", objIssuingAuthorityName.Issuing_Authority_Name_Id.ToString());

            deleteSuccessful = DataLayer.DeleteTypeRecord(deleteStatement);

            return deleteSuccessful;
        }

/* STOP CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD STOP */



      public static IssuingAuthorityName GetIssuingAuthorityNameObject(int issuingAuthorityName)
        {
            IssuingAuthorityName objIssuingAuthorityName = (IssuingAuthorityName) null;

            string selectString = "SELECT issuing_authority_name_id, issuing_authority_name, issuing_authority_full_name, issuing_authority_alternate_name FROM tblIssuingAuthorityName where issuing_authority_name_id = {0}";
            selectString = string.Format(selectString, issuingAuthorityName.ToString());

            SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
            SqlCommand comm = new SqlCommand(selectString, conn);
            SqlDataReader rdr;

            try
            {
                conn.Open();
                rdr = comm.ExecuteReader();

                while (rdr.Read())
                {
                    objIssuingAuthorityName = new IssuingAuthorityName();
                    objIssuingAuthorityName.Issuing_Authority_Name_Id = Convert.ToInt32(rdr["issuing_authority_name_id"]);
                    objIssuingAuthorityName.Issuing_Authority_Name = Convert.ToString(rdr["issuing_authority_name"]);
                    objIssuingAuthorityName.Issuing_Authority_Full_Name = Convert.ToString(rdr["issuing_authority_full_name"]);
                    objIssuingAuthorityName.Issuing_Authority_Alternate_Name = Convert.ToString(rdr["issuing_authority_alternate_name"]);
                }
            }
            catch (Exception e)
            {
                objIssuingAuthorityName = null;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                comm.Dispose();
            }

            return objIssuingAuthorityName;
        }

        public static List<IssuingAuthorityName> GetIssuingAuthorityNameList()
        {
            List<IssuingAuthorityName> lstIssuingAuthorityName = new List<IssuingAuthorityName>();
            IssuingAuthorityName objIssuingAuthorityName;

            string selectString = "SELECT issuing_authority_name_id, issuing_authority_name, issuing_authority_full_name, issuing_authority_alternate_name FROM tblIssuingAuthorityName";

            SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
            SqlCommand comm = new SqlCommand(selectString, conn);
            SqlDataReader rdr;

            try
            {
                conn.Open();
                rdr = comm.ExecuteReader();

                while (rdr.Read())
                {
                    objIssuingAuthorityName = new IssuingAuthorityName();
                    objIssuingAuthorityName.Issuing_Authority_Name_Id = Convert.ToInt32(rdr["issuing_authority_name_id"]);
                    objIssuingAuthorityName.Issuing_Authority_Name = Convert.ToString(rdr["issuing_authority_name"]);
                    objIssuingAuthorityName.Issuing_Authority_Full_Name = Convert.ToString(rdr["issuing_authority_full_name"]);
                    objIssuingAuthorityName.Issuing_Authority_Alternate_Name = Convert.ToString(rdr["issuing_authority_alternate_name"]);

                    lstIssuingAuthorityName.Add(objIssuingAuthorityName);
                }
            }
            catch (Exception e)
            {
                lstIssuingAuthorityName = null;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                comm.Dispose();
            }

            return lstIssuingAuthorityName;
        }
    }
}