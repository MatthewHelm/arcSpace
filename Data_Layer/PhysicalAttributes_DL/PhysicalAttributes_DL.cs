using System;
using bcs.arcSpace.Support_Classes;
namespace bcs.arcSpace.Data_Layer
{
   public class PhysicalAttributes_DL
   {
      public Boolean InsertPhysicalAttributeObject(PhysicalAttributes objPhysicalAttributes)
      {
         bool insertSuccessful = false;

         string insertString = "Insert into tblPhysicalAttributes (weight, diameter, die_axis) values ({0}, {1}, {2})";
         insertString = String.Format(insertString, objPhysicalAttributes.Weight.ToString(), objPhysicalAttributes.Diameter.ToString(), objPhysicalAttributes.Die_Axis.ToString());

         insertSuccessful = DataLayer.InsertTypeRecord(insertString);

         return insertSuccessful;
      }
   }
}