using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace bcs.arcSpace.Support_Classes
{
    public class Coin
    {
      private int _coin_id;
      private string _coin_name;
      private int _coin_type_id;
      private int _material_id;
      private string _coin_description;
      private int _issuing_authority_reign_id;
      private int _mint_id;
      private decimal _weight;
      private decimal _diameter;
      private int _die_axis;
      private int _physical_attributes_id;
      private string _obverse_legend;
      private byte[] _obverse_image;
      private int _obverse_id;
      private string _reverse_legend;
      private string _exergue;
      private byte[] _reverse_image;
      private int _reverse_id;
      private int _dealer_id;
      private int _grade_id;
      private decimal _price;
      private int _ric_volume_id;
      private int _ric_section_id;
      private string _ric_index;
      private int _ric_index_id;
      private int _start_minting_year;
      private int _end_minting_year;
      private int _start_minting_year_era;
      private int _end_minting_year_era;


      public Coin()
      {
      }

      public int Coin_Id
      {
         get { return _coin_id; }
         set { _coin_id = value; }
      }

      public string Coin_Name
      {
         get { return _coin_name; }
         set { _coin_name = value; }
      }

      public int Coin_Type_Id
      {
         get { return _coin_type_id; }
         set { _coin_type_id = value; }
      }

      public int Material_Id
      {
         get { return _material_id; }
         set { _material_id = value; }
      }

      public string Coin_Description
      {
         get { return _coin_description; }
         set { _coin_description = value; }
      }

      //public string Issuing_Authority_Name
      //{
      //   get { return _issuing_authority_name; }
      //   set { _issuing_authority_name = value; }
      //}
      //public int Issuing_Authority_Id
      //{
      //   get { return _issuing_authority_id; }
      //   set { _issuing_authority_id = value; }
      //}

      public int Issuing_Authority_Reign_Id
      {
         get { return _issuing_authority_reign_id; }
         set { _issuing_authority_reign_id = value; }
      }

      public int Mint_Id
      {
         get { return _mint_id; }
         set { _mint_id = value; }
      }

      public decimal Weight
      {
         get { return _weight; }
         set { _weight = value; }
      }

      public decimal Diameter
      {
         get { return _diameter; }
         set { _diameter = value; }
      }

      public int Die_Axis
      {
         get { return _die_axis; }
         set { _die_axis = value; }
      }

      public int Physical_Attributes_Id
      {
         get { return _physical_attributes_id; }
         set { _physical_attributes_id = value; }
      }

      public int Obverse_Id
      {
         get { return _obverse_id; }
         set { _obverse_id = value; }
      }

      public string Obverse_Legend
      {
         get { return _obverse_legend; }
         set { _obverse_legend = value; }
      }

      public byte[] Obverse_Image
      {
         get { return _obverse_image; }
         set { _obverse_image = value; }
      }

      public int Reverse_Id
      {
         get { return _reverse_id; }
         set { _reverse_id = value; }
      }

      public string Reverse_Legend
      {
         get { return _reverse_legend; }
         set { _reverse_legend = value; }
      }

      public string Exergue
      {
         get { return _exergue; }
         set { _exergue = value; }
      }

      public byte[] Reverse_Image
      {
         get { return _reverse_image; }
         set { _reverse_image = value; }
      }

      public int Dealer_Id
      {
         get { return _dealer_id; }
         set { _dealer_id = value; }
      }

      public int Grade_Id
      {
         get { return _grade_id; }
         set { _grade_id = value; }
      }

      public decimal Price
      {
         get { return _price; }
         set { _price = value; }
      }

      public int Ric_Volume_Id
      {
         get { return _ric_volume_id; }
         set { _ric_volume_id = value; }
      }

      public int Ric_Section_Id
      {
         get { return _ric_section_id; }
         set { _ric_section_id = value; }
      }
      public int Ric_Index_Id
      {
         get { return _ric_index_id; }
         set { _ric_index_id = value; }
      }

      public string Ric_Index
      {
         get { return _ric_index; }
         set { _ric_index = value; }
      }


      public int Start_Minting_Year
      {
         get { return _start_minting_year; }
         set { _start_minting_year = value; }
      }

      public int End_Minting_Year
      {
         get { return _end_minting_year; }
         set { _end_minting_year = value; }
      }


      public int Start_Minting_Year_Era
      {
         get { return _start_minting_year_era; }
         set { _start_minting_year_era = value; }
      }

      public int End_Minting_Year_Era
      {
         get { return _end_minting_year_era; }
         set { _end_minting_year_era = value; }
      }

   }
}
