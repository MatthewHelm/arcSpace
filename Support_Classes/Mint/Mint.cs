using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bcs.arcSpace.Support_Classes
{
    public class Mint
    {
       private int _mint_id;
       private string _mint_name;
       private string _description;
       private string _mint_location;
       private string _service_start_date;
       private string _service_end_date;
       private string _modern_location;
       private string _mint_abbreviations;

       public Mint()
       {
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

       public string Description
       {
          get
          {
             return _description;
          }

          set
          {
             _description = value;
          }
       }

       public string Mint_Location
       {
          get
          {
             return _mint_location;
          }

          set
          {
            _mint_location = value;
          }
       }

       public string Service_Start_Date
       {
          get
          {
             return _service_start_date;
          }

          set
          {
             _service_start_date = value;
          }
       }

       public string Service_End_Date
       {
          get
          {
             return _service_end_date;
          }

          set
          {
            _service_end_date = value;
          }
       }

       public string Modern_Location
       {
          get
          {
             return _modern_location;
          }

          set
          {
             _modern_location = value;
          }
       }

       public string Mint_Abbreviations
       {
          get
          {
             return _mint_abbreviations;
          }

          set
          {
             _mint_abbreviations = value;
          }
       }






    }
}
