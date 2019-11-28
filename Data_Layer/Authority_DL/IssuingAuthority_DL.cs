using bcs.arcSpace.Support_Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace bcs.arcSpace.Data_Layer
{
    public class IssuingAuthority_DL
    {
        /* START CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD START */

        public static bool InsertIssuingAuthorityRecord(IssuingAuthority objAuthority)
        {
            bool insertSuccessful = false;

            if (objAuthority == (IssuingAuthority)null)
            {
                return insertSuccessful;
            }

            string insertString = "INSERT INTO tblIssuingAuthority (issuing_authority_name_id, issuing_authority_biography, issuing_authority_birth_year, issuing_authority_birth_era_id, issuing_authority_death_year, issuing_authority_death_era_id, sequence_id) VALUES ({0}, '{1}', {2}, {3}, {4}, {5}, {6})";
            insertString = string.Format(insertString, objAuthority.Issuing_Authority_Name_Id, objAuthority.Issuing_Authority_Biography, objAuthority.Issuing_Authority_Birth_Year, objAuthority.Issuing_Authority_Birth_Era_Id, objAuthority.Issuing_Authority_Death_Year, objAuthority.Issuing_Authority_Death_Era_Id, objAuthority.Sequence_Id);

            insertSuccessful = DataLayer.InsertTypeRecord(insertString);

            return insertSuccessful;
        }

        public static bool UpdateIssuingAuthorityRecord(IssuingAuthority objAuthority)
        {
            bool updateSuccessful = false;

            if (objAuthority == null)
            {
                return updateSuccessful;
            }

            string updateString = "UPDATE tblIssuingAuthority SET issuing_authority_name_id = {0}, issuing_authority_biography = '{1}', issuing_authority_birth_year = {2}, issuing_authority_birth_era_id = {3}, issuing_authority_death_year = {4}, issuing_authority_death_era_id = {5}, sequence_id = {7} WHERE issuing_authority_id = {6}";
            updateString = string.Format(updateString, objAuthority.Issuing_Authority_Name_Id, objAuthority.Issuing_Authority_Biography, objAuthority.Issuing_Authority_Birth_Year, objAuthority.Issuing_Authority_Birth_Era_Id, objAuthority.Issuing_Authority_Death_Year, objAuthority.Issuing_Authority_Death_Era_Id, objAuthority.Issuing_Authority_Id, objAuthority.Sequence_Id);

            updateSuccessful = DataLayer.UpdateTypeRecord(updateString);

            return updateSuccessful;
        }

        public static bool DeleteIssuingAuthorityRecord(IssuingAuthority objAuthority)
        {
            bool deleteSuccessful = false;

            if (objAuthority == (IssuingAuthority)null)
            {
                return deleteSuccessful;
            }

            string deleteStatement = string.Format("DELETE FROM tblIssuingAuthority WHERE issuing_authority_id = {0}", objAuthority.Issuing_Authority_Id.ToString());

            deleteSuccessful = DataLayer.DeleteTypeRecord(deleteStatement);

            return deleteSuccessful;
        }

        /* END CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD CRUD END */

        /* Get all of the records */

        public static List<IssuingAuthority> GetIssuingAuthorityRecords()
        {
            List<IssuingAuthority> lstAuthority = new List<IssuingAuthority>();
            IssuingAuthority objAuthority;

            string selectString = "SELECT issuing_authority_id, issuing_authority_name_id, issuing_authority_biography, issuing_authority_birth_year, issuing_authority_birth_era_id, issuing_authority_death_year, issuing_authority_death_era_id, sequence_id FROM tblIssuingAuthority";

            SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
            SqlCommand comm = new SqlCommand(selectString, conn);
            SqlDataReader rdr;

            try
            {
                conn.Open();
                rdr = comm.ExecuteReader();

                while (rdr.Read())
                {
                    objAuthority = new IssuingAuthority();
                    objAuthority.Issuing_Authority_Id = Convert.ToInt32(rdr["issuing_authority_id"]);
                    objAuthority.Issuing_Authority_Name_Id = Convert.ToInt32(rdr["issuing_authority_name_id"]);
                    objAuthority.Issuing_Authority_Biography = Convert.ToString(rdr["issuing_authority_biography"]);
                    objAuthority.Issuing_Authority_Birth_Year = Convert.ToInt32(rdr["issuing_authority_birth_year"]);
                    objAuthority.Issuing_Authority_Birth_Era_Id = Convert.ToInt32(rdr["issuing_authority_birth_era_id"]);
                    objAuthority.Issuing_Authority_Death_Year = Convert.ToInt32(rdr["issuing_authority_death_year"]);
                    objAuthority.Issuing_Authority_Death_Era_Id = Convert.ToInt32(rdr["issuing_authority_death_era_id"]);
                    objAuthority.Sequence_Id = Convert.ToInt32(rdr["sequence_id"]);

                    lstAuthority.Add(objAuthority);
                }
            }
            catch
            {
                lstAuthority = null;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                comm.Dispose();
            }

            return lstAuthority;
        }

        /* get a single record based on issuing_authority_id */

        public static IssuingAuthority GetIssuingAuthorityRecord(int issuing_authority__id)
        {
            IssuingAuthority objIssuingAuthority = (IssuingAuthority)null;

            if (issuing_authority__id < 1)
            {
                return objIssuingAuthority;
            }

            string storedProcedureString = "GetAuthority_SP";
            SqlConnection conn = new SqlConnection(DataLayer.ConnectionString);
            SqlCommand comm = new SqlCommand(storedProcedureString, conn);
            SqlDataReader rdr;
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@AuthorityId", issuing_authority__id);

            try
            {
                conn.Open();
                rdr = comm.ExecuteReader();

                while (rdr.Read())
                {
                    objIssuingAuthority = new IssuingAuthority();

                    //  select issuing_authority_id, issuing_authority_name_id,issuing_authority_biography, issuing_authority_birth_year, issuing_authority_birth_era_id, issuing_authority_death_year, issuing_authority_death_era_id

                    objIssuingAuthority = new IssuingAuthority();
                    objIssuingAuthority.Issuing_Authority_Id = Convert.ToInt32(rdr["issuing_authority_id"]);
                    objIssuingAuthority.Issuing_Authority_Name_Id = Convert.ToInt32(rdr["issuing_authority_name_id"]);
                    objIssuingAuthority.Issuing_Authority_Biography = Convert.ToString(rdr["issuing_authority_biography"]);
                    objIssuingAuthority.Issuing_Authority_Birth_Year = Convert.ToInt32(rdr["issuing_authority_birth_year"]);
                    objIssuingAuthority.Issuing_Authority_Birth_Era_Id = Convert.ToInt32(rdr["issuing_authority_birth_era_id"]);
                    objIssuingAuthority.Issuing_Authority_Death_Year = Convert.ToInt32(rdr["issuing_authority_death_year"]);
                    objIssuingAuthority.Issuing_Authority_Death_Era_Id = Convert.ToInt32(rdr["issuing_authority_death_era_id"]);
                    objIssuingAuthority.Sequence_Id = Convert.ToInt32(rdr["sequence_id"]);
                }
            }
            catch (Exception ex)
            {
                objIssuingAuthority = null;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                comm.Dispose();
            }

            return objIssuingAuthority;
        }
    }
}