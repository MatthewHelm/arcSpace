using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bcs.arcSpace.Support_Classes
{
    public class IssuingAuthorityName
    {
      private int _issuing_authority_name_id;
      private string _issuing_authority_name;
      private string _issuing_authority_full_name;
      private string _issuing_authority_alternate_name;


      public IssuingAuthorityName()
      {

      }

      public int Issuing_Authority_Name_Id
      {
         get
         {
            return _issuing_authority_name_id;
         }

         set
         {
            _issuing_authority_name_id = value;
         }
      }

      public string Issuing_Authority_Name
      {
         get
         {
            return _issuing_authority_name;
         }

         set
         {
            _issuing_authority_name = value;
         }
      }

      public string Issuing_Authority_Full_Name
      {
         get
         {
            return _issuing_authority_full_name;
         }

         set
         {
            _issuing_authority_full_name = value;
         }
      }

      public string Issuing_Authority_Alternate_Name
      {
         get
         {
            return _issuing_authority_alternate_name;
         }

         set
         {
            _issuing_authority_alternate_name = value;  
         }
      }
    }
}
