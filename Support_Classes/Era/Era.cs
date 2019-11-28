using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bcs.arcSpace.Support_Classes
{
    public class Era
    {
      private int _era_id;
      private string _era_name;
      private string _era_description;


      public Era()
      {

      }


      public int Era_Id
      {
         get
         {
            return _era_id;
         }

         set
         {
            _era_id = value;
         }
      }

      public string Era_Name
      {
         get
         {
            return _era_name;
         }

         set
         {
            _era_name = value;
         }
      }

      public string Era_Description
      {
         get
         {
            return _era_description;
         }

         set
         {
            _era_description = value;
         }
      }
   }
}
