using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bcs.arcSpace.Support_Classes
{
    public class StateProvince
    {
      private int _stateProvinceId;
      private int _countryId;
      private string _stateProvince;

      /// <summary>
      /// 
      /// </summary>
      public int State_Province_Id
      {
         get
         {
            return _stateProvinceId;
         }

         set
         {
            _stateProvinceId = value;
         }
      }

      /// <summary>
      /// 
      /// </summary>
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

      /// <summary>
      /// 
      /// </summary>
      public string State_Province
      {
         get
         {
            return _stateProvince;
         }

         set
         {
            _stateProvince = value;
         }
      }




   }
}
