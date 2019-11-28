using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bcs.arcSpace.Support_Classes
{
    public class Period
    {
      private int _period_id;
      private string _period_name;
      private string _period_description;
      private int _start_year;
      private int _start_era_id;
      private int _end_year;
      private int _end_era_id;
      private int _seq_no;

      public Period()
      {

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

      public string Period_Description
      {
         get
         {
            return _period_description;
         }

         set
         {
            _period_description = value;
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


      public int Seq_No
      {
         get
         {
            return _seq_no;
         }

         set
         {
            _seq_no = value;
         }
      }
   }
}
