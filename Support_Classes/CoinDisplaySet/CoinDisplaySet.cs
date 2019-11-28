using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bcs.arcSpace.Support_Classes
{
    public class CoinDisplaySet
    {
      private byte[] _obverse_image;
      private byte[] _reverse_image;
      private int _coin_id;
      private string _issuing_authority_name;
      private string _obverse_legend;
      private string _reverse_legend;
      private string _exergue;
      private string _ric_label;

      public CoinDisplaySet()
      {
      }

      public byte[] Obverse_Image
      {
         get { return _obverse_image; }
         set { _obverse_image = value; }
      }

      public byte[] Reverse_Image
      {
         get { return _reverse_image; }
         set { _reverse_image = value; }
      }

      public int Coin_Id
      {
         get { return _coin_id; }
         set { _coin_id = value; }
      }

      public String Issuing_Authority_Name
      {
         get { return _issuing_authority_name; }
         set { _issuing_authority_name = value; }
      }

      public String Obverse_Legend
      {
         get { return _obverse_legend; }
         set { _obverse_legend = value; }
      }


      public String Reverse_Legend
      {
         get { return _reverse_legend; }
         set { _reverse_legend = value; }
      }

      public String Exergue
      {
         get { return _exergue; }
         set { _exergue = value; }
      }

      public String Ric_Label
      {
         get { return _ric_label; }
         set { _ric_label = value; }
      }
   }
}
