using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bcs.arcSpace.Support_Classes
{
    public class RIC
    {
      private int _coin_id;
      private string _ric_volume;
      private string _ric_volume_description;
      private int _ric_volume_id;
      private string _ric_section;
      private string _ric_section_description;
      private int _ric_section_id;
      private string _ric_index;
      private string _ric_index_description;
      private int _ric_index_id;

      public RIC()
      {

      }

      public int Coin_Id
      {
         get { return _coin_id; }
         set { _coin_id = value; }

      }
      public string Ric_Volume
      {
         get { return _ric_volume; }
         set { _ric_volume = value; }
      }

      public string Ric_Volume_Description
      {
         get { return _ric_volume_description; }
         set { _ric_volume_description = value; }
      }

      public int Ric_Volume_Id
      {
         get { return _ric_volume_id; }
         set { _ric_volume_id = value; }
      }

      public string Ric_Section
      {
         get { return _ric_section; }
         set { _ric_section = value; }
      }


      public string Ric_Section_Description
      {
         get { return _ric_section_description; }
         set { _ric_section_description = value; }
      }

      public int Ric_Section_Id
      {
         get { return _ric_section_id; }
         set { _ric_section_id = value; }
      }

      public string Ric_Index
      {
         get { return _ric_index; }
         set { _ric_index = value; }
      }

      public string Ric_Index_Description
      {
         get { return _ric_index_description; }
         set { _ric_index_description = value; }
      }

      public int Ric_Index_Id
      {
         get { return _ric_index_id; }
         set { _ric_index_id = value; }
      }

   }
}
