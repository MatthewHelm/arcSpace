using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bcs.arcSpace.Support_Classes
{
    public class Material
    {
      private int _material_id;
      private string _material_description;
      private string _material_notes;

      public Material()
      { }

      public int Material_Id
      {
         get
         {
            return _material_id;
         }

         set
         {
            _material_id = value;
         }
      }

      public string Material_Description
      {
         get
         {
            return _material_description;
         }

         set
         {
            _material_description = value;
         }
      }

      public string Material_Notes
      {
         get
         {
            return _material_notes;
         }

         set
         {
            _material_notes = value;
         }
      }

   }
}
