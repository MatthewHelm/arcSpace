using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bcs.arcSpace.Support_Classes
{
    public class Grade
    {
      private int _grade_id;
      private string _grade_code;
      private string _description;

      public Grade()
      {
      }

      public int Grade_Id
      {
         get
         {
            return _grade_id;
         }

         set
         {
            _grade_id = value;
         }
      }

      public string Grade_Code
      {
         get
         {
            return _grade_code;
         }

         set
         {
            _grade_code = value;
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
