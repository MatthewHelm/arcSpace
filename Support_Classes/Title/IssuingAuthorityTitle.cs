using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bcs.arcSpace.Support_Classes
{
    public class IssuingAuthorityTitle
    {
      private int _title_id;
      private string _issuing_authority_title;
      private string _description;

      public IssuingAuthorityTitle()
      { }



      public int Title_Id
      {
         get
         {
            return _title_id;
         }

         set
         {
            _title_id = value;
         }
      }

      public string Issuing_Authority_Title
      {
         get
         {
            return _issuing_authority_title;
         }

         set
         {
            _issuing_authority_title = value;
         }
      }

      public string Description
      {
         get
         {
            return _description;
         }

         set
         {
            _description = value;
         }
      }


   }
}

