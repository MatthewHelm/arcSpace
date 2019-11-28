using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bcs.arcSpace.Support_Classes
{
    public class IssuingAuthorityReign
    {

      // issuing_authority_reign_biography

      private int _issuing_authority_reign_id;
      private int _issuing_authority_title_id;
      private int _issuing_authority_id;
      private int _period_id;
      private int _reign_start_year;
      private int _reign_start_era_id;
      private int _reign_end_year;
      private int _reign_end_era_id;
      private string _issuing_authority_reign_biography;

      public IssuingAuthorityReign()
      {

      }

      public int Issuing_Authority_Reign_Id
      {
         get
         {
            return _issuing_authority_reign_id;
         }

         set
         {
            _issuing_authority_reign_id = value;
         }
      }

      //public int Issuing_Authority_Name_Id
      //{
      //   get
      //   {
      //      return _issuing_authority_name_id;
      //   }

      //   set
      //   {
      //      _issuing_authority_name_id = value;
      //   }
      //}


      public int Issuing_Authority_Id
      {
         get
         {
            return _issuing_authority_id;
         }

         set
         {
            _issuing_authority_id = value;
         }
      }




      public int Issuing_Authority_Title_Id
      {
         get
         {
            return _issuing_authority_title_id;
         }

         set
         {
            _issuing_authority_title_id = value;
         }
      }

      public int Period_Id
      {
         get
         {
            return _period_id;
         }

         set
         {
            _period_id = value;
         }
      }

      public int Reign_Start_Year
      {
         get
         {
            return _reign_start_year;
         }

         set
         {
            _reign_start_year = value;
         }
      }


      public int Reign_Start_Era_Id
      {
         get
         {
            return _reign_start_era_id;
         }

         set
         {
            _reign_start_era_id = value;
         }
      }


      public int Reign_End_Year
      {
         get
         {
            return _reign_end_year;
         }

         set
         {
            _reign_end_year = value;
         }
      }


      public int Reign_End_Era_Id
      {
         get
         {
            return _reign_end_era_id;
         }

         set
         {
            _reign_end_era_id = value;
         }
      }


      public string Issuing_Authority_Reign_Biography
      {
         get
         {
            return _issuing_authority_reign_biography;
         }

         set
         {
            _issuing_authority_reign_biography = value;
         }
      }
   }
}
