using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bcs.arcSpace.Support_Classes
{

   public class ArcNode : TreeNode
    {
      private int _coin_id;
      private string _coin_description;

      private int _coin_type_id;
      private string _coin_type;

      private int _issuing_authority_reign_id;
      private string _issuing_authority_name;

      private int _issuing_authority_title_id;
      private string _issuing_authority_title;

      private int _period_id;
      private string _period_name;

      private int _start_year;
      private int _end_year;
      private int _start_era_id;
      private int _end_era_id;
      private string _formatted_reign;


      private int _mint_id;
      private string _mint_name;

      private int _physical_attributes_id;
      private decimal _weight;
      private decimal _diameter;
      private int _die_axis;

      private int _grade_id;
      private string _grade_code;

      private int _obverse_id;
      private string _obverse_legend;
      private byte[] _obverse_image;


      private int _reverse_id;
      private string _reverse_legend;
      private string _exergue;
      private byte[] _reverse_image;

      //private int _ric_index_id;
      //private int _ric_section_id;
      //private int _ric_volume_id;
      private string _formatted_ric_Index;


      public int Coin_Id
      {
         get
         {
            return _coin_id;
         }

         set
         {
            _coin_id = value;
         }
      }


      public string Coin_Description
      {
         get
         {
            return _coin_description;
         }

         set
         {
            _coin_description = value;
         }
      }




      public int Coin_Type_Id
      {
         get
         {
            return _coin_type_id;
         }

         set
         {
            _coin_type_id = value;
         }
      }




      public string Coin_Type
      {
         get
         {
            return _coin_type;
         }

         set
         {
            _coin_type = value;
         }
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

      public string Period_Name
      {
         get
         {
            return _period_name;
         }

         set
         {
            _period_name = value;
         }
      }

      public int Start_Year
      {
         get
         {
            return _start_year;
         }

         set
         {
            _start_year = value;
         }
      }

      public int End_Year
      {
         get
         {
            return _end_year;
         }

         set
         {
            _end_year = value;
         }
      }

      public int Start_Era_Id
      {
         get
         {
            return _start_era_id;
         }

         set
         {
            _start_era_id = value;
         }
      }

      public int End_Era_Id
      {
         get
         {
            return _end_era_id;
         }

         set
         {
            _end_era_id = value;
         }
      }


      public string Formatted_Reign
      {
         get
         {
            return _formatted_reign;
         }

         set
         {
            _formatted_reign = value;
         }
      }

      public int Mint_Id
      {
         get
         {
            return _mint_id;
         }

         set
         {
            _mint_id = value;
         }
      }

      public string Mint_Name
      {
         get
         {
            return _mint_name;
         }

         set
         {
            _mint_name = value;
         }
      }

      public int Physical_Attributes_id
      {
         get
         {
            return _physical_attributes_id;
         }

         set
         {
            _physical_attributes_id = value;
         }
      }


      public decimal Weight
      {
         get
         {
            return _weight;
         }

         set
         {
            _weight = value;
         }
      }

      public decimal Diameter
      {
         get
         {
            return _diameter;
         }

         set
         {
            _diameter = value;
         }
      }


      public int Die_Axis
      {
         get
         {
            return _die_axis;
         }

         set
         {
            _die_axis = value;
         }
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



      public int Obverse_Id
      {
         get
         {
            return _obverse_id;
         }

         set
         {
            _obverse_id = value;
         }
      }

      public string Obverse_Legend
      {
         get
         {
            return _obverse_legend;
         }

         set
         {
            _obverse_legend = value;
         }
      }


      public byte[] Obverse_Image
      {
         get
         {
            return _obverse_image;
         }

         set
         {
            _obverse_image= value;
         }
      }


      public int Reverse_Id
      {
         get
         {
            return _reverse_id;
         }

         set
         {
            _reverse_id = value;
         }
      }

      public string Reverse_Legend
      {
         get
         {
            return _reverse_legend;
         }

         set
         {
            _reverse_legend = value;
         }
      }

  
      public string Exergue
      {
         get
         {
            return _exergue;
         }

         set
         {
            _exergue = value;
         }
      }


      public byte[] Reverse_Image
      {
         get
         {
            return _reverse_image;
         }

         set
         {
            _reverse_image = value;
         }
      }


      //public int Ric_Index_id
      //{
      //   get
      //   {
      //      return _ric_index_id;
      //   }

      //   set
      //   {
      //      _ric_index_id = value;
      //   }
      //}

      //public int Ric_Section_id
      //{
      //   get
      //   {
      //      return _ric_section_id;
      //   }

      //   set
      //   {
      //      _ric_section_id = value;
      //   }
      //}

      //public int Ric_Volume_id
      //{
      //   get
      //   {
      //      return _ric_volume_id;
      //   }

      //   set
      //   {
      //      _ric_volume_id = value;
      //   }
      //}

      public string Formatted_Ric_Index
      {
         get
         {
            return _formatted_ric_Index;
         }

         set
         {
            _formatted_ric_Index = value;
         }
      }
   }
}
