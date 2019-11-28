using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace bcs.arcSpace.Support_Classes
{
    public class PhysicalAttributes
    {
        private int _physical_attributes_id;
        private decimal _weight;
        private decimal _diameter;
        private int _die_axis;

        public PhysicalAttributes()
        {
        }


        public int Physical_Attribute_Id
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
    }
}
