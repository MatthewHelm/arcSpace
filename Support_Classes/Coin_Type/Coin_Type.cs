using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bcs.arcSpace.Support_Classes
{
    public class Coin_Type
    {
       private uint coin_type_id;
       private string coin_type_name;
       private string coin_type_desc;


       public uint Coin_Type_Id
       {
          get
          {
             return coin_type_id;
          }

          set
          {
             coin_type_id = value;
          }
       }


       public string Coin_Type_Name
       {
          get
          {
             return coin_type_name;
          }

          set
          {
             coin_type_name = value;
          }
       }


       public string Coin_Type_Desc
       {
          get
          {
             return coin_type_desc;
          }

          set
          {
             coin_type_desc = value;
          }
       }
    }
}
