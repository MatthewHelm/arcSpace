namespace bcs.arcSpace.Support_Classes
{
    public class IssuingAuthority
    {
        private int _issuing_authority_id;
        private int _issuing_authority_name_id;
        private string _issuing_authority_biography;
        private int _issuing_authority_birth_year;
        private int _issuing_authority_birth_era_id;
        private int _issuing_authority_death_year;
        private int _issuing_authority_death_era_id;
        private int _sequence_id;

        public IssuingAuthority()
        {
        }

        public int Issuing_Authority_Id
        {
            get
            {
                return _issuing_authority_id;
            }

            set
            {
                _issuing_authority_id = value;
            }
        }

        public int Issuing_Authority_Name_Id
        {
            get
            {
                return _issuing_authority_name_id;
            }

            set
            {
                _issuing_authority_name_id = value;
            }
        }

        public string Issuing_Authority_Biography
        {
            get
            {
                return _issuing_authority_biography;
            }

            set
            {
                _issuing_authority_biography = value;
            }
        }

        public int Issuing_Authority_Birth_Year
        {
            get
            {
                return _issuing_authority_birth_year;
            }

            set
            {
                _issuing_authority_birth_year = value;
            }
        }

        public int Issuing_Authority_Birth_Era_Id
        {
            get
            {
                return _issuing_authority_birth_era_id;
            }

            set
            {
                _issuing_authority_birth_era_id = value;
            }
        }

        public int Issuing_Authority_Death_Year
        {
            get
            {
                return _issuing_authority_death_year;
            }

            set
            {
                _issuing_authority_death_year = value;
            }
        }

        public int Issuing_Authority_Death_Era_Id
        {
            get
            {
                return _issuing_authority_death_era_id;
            }

            set
            {
                _issuing_authority_death_era_id = value;
            }
        }

        public int Sequence_Id
        {
            get
            {
                return _sequence_id;
            }

            set
            {
                _sequence_id = value;
            }
        }
    }
}