using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bcs.arcSpace.Support_Classes
{
    public class Dealer
    {
      private int _dealerId;
      private string _firstName;
      private string _lastName;
      private string _businessName;
      private string _address1;
      private string _address2;
      private string _city;
      private int _stateProvinceId;
      private string _postalCode;
      private int _countryId;
      private string _phoneNumber;
      private string _emailAddress;
      private string _webSite;
      private string _notes;


      public Dealer()
      {

      }

      /// <summary>
      /// 
      /// </summary>
      public int Dealer_Id
      {
         get
         {
            return _dealerId;
         }

         set
         {
            _dealerId = value;
         }
      }

      /// <summary>
      /// 
      /// </summary>
      public string First_Name
      {
         get
         {
            return _firstName;
         }

         set
         {
            _firstName = value;
         }
      }

      /// <summary>
      /// 
      /// </summary>
      public string Last_Name
      {
         get
         {
            return _lastName;
         }

         set
         {
            _lastName = value;
         }
      }

      /// <summary>
      /// 
      /// </summary>
      public string Business_Name
      {
         get
         {
            return _businessName;
         }

         set
         {
            _businessName = value;
         }
      }
      
      
      /// <summary>
      /// 
      /// </summary>
      public string Address1
      {
         get
         {
            return _address1;
         }

         set
         {
            _address1 = value;
         }
      }
     
      
      /// <summary>
      /// 
      /// </summary>
      public string Address2
      {
         get
         {
            return _address2;
         }

         set
         {
            _address2 = value;
         }
      }

      /// <summary>
      /// 
      /// </summary>
      public string City
      {
         get
         {
            return _city;
         }

         set
         {
            _city = value;
         }
      }

      /// <summary>
      /// 
      /// </summary>
      public int State_Province_Id
      {
         get
         {
            return _stateProvinceId;
         }

         set
         {
            _stateProvinceId = value;
         }
      }

      /// <summary>
      /// 
      /// </summary>
      public string Postal_Code
      {
         get
         {
            return _postalCode;
         }

         set
         {
            _postalCode = value;
         }
      }

      /// <summary>
      /// 
      /// </summary>
      public int Country_Id
      {
         get
         {
            return _countryId;
         }

         set
         {
            _countryId = value;
         }
      }


      /// <summary>
      /// 
      /// </summary>
      public string Phone_Number
      {
         get
         {
            return _phoneNumber;
         }

         set
         {
            _phoneNumber = value;
         }
      }


      /// <summary>
      /// 
      /// </summary>
      public string Email_Address
      {
         get
         {
            return _emailAddress;
         }

         set
         {
            _emailAddress = value;
         }
      }

      /// <summary>
      /// 
      /// </summary>
      public string Web_Site
      {
         get
         {
            return _webSite;
         }

         set
         {
            _webSite = value;
         }
      }


      /// <summary>
      /// 
      /// </summary>
      public string Notes
      {
         get
         {
            return _notes;
         }

         set
         {
            _notes = value;
         }
      }
   }
}
