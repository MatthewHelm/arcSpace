using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bcs.arcSpace.Support_Classes
{
    public class CoinLabelSet
    {
      private int coin_id;
      private string issuing_authority_name;
      private string reign_start;
      private string reign_end;
      private string obverse_legend;
      private string reverse_legend;
      private string exergue;
      private string mint;
      private string mint_year_start;
      private string mint_year_end;
      private string description;
      private string ric_index;
      private decimal price;

      public CoinLabelSet()
      {
      }

      public int Coin_Id
      {
         get { return coin_id; }
         set { coin_id = value; }
      }

      public string Issuing_Authority_Name
      {
         get { return issuing_authority_name; }
         set { issuing_authority_name = value; }
      }

      public string Reign_Start
      {
         get { return reign_start; }
         set { reign_start = value; }
      }

      public string Reign_End
      {
         get { return reign_end; }
         set { reign_end = value; }
      }

      public string Obverse_Legend
      {
         get { return obverse_legend; }
         set { obverse_legend = value; }
      }


      public string Reverse_Legend
      {
         get { return reverse_legend; }
         set { reverse_legend = value; }
      }

      public string Exergue
      {
         get { return exergue; }
         set { exergue = value; }
      }

      public string Mint
      {
         get { return mint; }
         set { mint = value; }
      }

      public string Mint_Start_year
      {
         get { return mint_year_start; }
         set { mint_year_start = value; }
      }

      public string Mint_End_year
      {
         get { return mint_year_end; }
         set { mint_year_end = value; }
      }

      public string Description
      {
         get { return description; }
         set { description = value; }
      }

      public string RIC_Index
      {
         get { return ric_index; }
         set { ric_index = value; }
      }

      public decimal Price
      {
         get { return price; }
         set { price = value; }
      }

   }
}
