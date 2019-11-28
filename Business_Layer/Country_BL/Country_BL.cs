using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bcs.arcSpace.Support_Classes;
using bcs.arcSpace.Data_Layer;

namespace bcs.arcSpace.Business_Layer
{
    public class Country_BL
    {
      public static List<Country> GetCountryList()
      {
         List<Country> lstCountry = null;
         lstCountry = Data_Layer.Country_DL.GetCountryRecordList();
         return lstCountry;
      }

    }
}
