using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bcs.arcSpace.Support_Classes
{
    public class Country
    {
      private int _countryId;
      private string _countryName;

      public int Country_Id
      {
         get
         {
            return _countryId;
         }

         set
         {
            _countryId = value;
         }
      }

      public string Country_Name
      {
         get
         {
            return _countryName;
         }

         set
         {
            _countryName = value;
         }
      }
   }
}
