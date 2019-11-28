using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
   
coin_id int,
issuing_authority_name varchar(128),
issuing_authority_title varchar(64),
coin_type varchar(64),
startMintingYear varchar(8),
endMintingYear varchar(8),
mint_name varchar(64),
material_description varchar(64),
diameter varchar(16),
weight varchar(16),
dieAxis varchar(16),
obverse_legend varchar(512),
obverse_description varchar(1024),
reverse_legend varchar(512),
exergue varchar(128),
reverse_description varchar(1024),
RicIndex varchar(512),
usdPrice varchar(32),
period_name varchar(64),
StartEra varchar(32), 
EndEra varchar(32)),
grade,
coin_description
 
  
 */

namespace bcs.arcSpace.Support_Classes
{
   public class XlReportAndLabel
   {
      private int _rep_label_id;
      private int _coin_id;  // coin_id int
      private string _issuing_authority_name;   // issuing_authority_name varchar(128)
      private string _issuing_authority_title;  // issuing_authority_title varchar(64)
      private string _coin_type;                // coin_type varchar(64),startMintingYear varchar(8)
      private string _start_minting_year;       // startMintingYear varchar(8)
      private string _start_minting_year_era;
      private string _end_minting_year;         // endMintingYear varchar(8)
      private string _end_minting_year_era;
      private string _mint_name;                // mint_name varchar(64)
      private string _material_description;     // material_description varchar(64)
      private string _diameter;
      private string _weight;
      private string _die_axis;
      private string _obverse_legend;
      private string _obverse_description;
      private string _reverse_legend;
      private string _exergue;
      private string _reverse_description;
      private string _ric_index;
      private string _usd_price;
      private string _period;
      private string _reign_begin_year; 
      private string _reign_end_year;
      private string _grade;
      private string _coin_description;



      public int Rep_Label_Id
      {
         get
         {
            return _rep_label_id;
         }

         set
         {
            _rep_label_id = value;
         }
      }

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


      public string Start_Minting_Year
      {
         get
         {
            return _start_minting_year;
         }

         set
         {
            _start_minting_year = value;
         }
      }


        public string Start_Minting_Year_Era
        {
            get
            {
                return _start_minting_year_era;
            }

            set
            {
                _start_minting_year_era = value;
            }
        }


      public string End_Minting_Year
      {
         get
         {
            return _end_minting_year;
         }

         set
         {
            _end_minting_year = value;
         }
      }


        public string End_Minting_Year_Era
        {
            get
            {
                return _end_minting_year_era;
            }

            set
            {
                _end_minting_year_era = value;
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


      public string Diameter
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


      public string Weight
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


      public string Die_Axis
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

      public string Obverse_Description
      {
         get
         {
            return _obverse_description;
         }

         set
         {
            _obverse_description = value;
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

      public string Reverse_Description
      {
         get
         {
            return _reverse_description;
         }

         set
         {
            _reverse_description = value;
         }
      }


      public string Ric_Index
      {
         get
         {
            return _ric_index;
         }

         set
         {
            _ric_index = value;
         }
      }

      public string Usd_Price
      {
         get
         {
            return _usd_price;
         }

         set
         {
            _usd_price = value;
         }
      }

      public string Period
      {
         get
         {
            return _period;
         }

         set
         {
            _period = value;
         }
      }


      public string Grade
      {
         get
         {
            return _grade;
         }

         set
         {
            _grade = value;
         }
      }

      public string Reign_Begin_Year
      {
         get
         {
            return _reign_begin_year;
         }

         set
         {
            _reign_begin_year = value;
         }
      }

      public string Reign_End_Year
      {
         get
         {
            return _reign_end_year;
         }

         set
         {
            _reign_end_year = value;
         }
      }



   }
}
