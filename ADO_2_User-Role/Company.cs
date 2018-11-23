namespace ADO_2_User_Role
{
    public class Company
    {
        int _companyId;
        string _name;
        string _address;
        string _state;
        string _country;

        public Company(int _companyId, string _name, string _address, string _state, string _country)
        {
            this._companyId = _companyId;
            this._name = _name;
            this._address = _address;
            this._state = _state;
            this._country = _country;
        }

        public int CompanyId
        {
            get
            {
                return _companyId;
            }

            set
            {
                this._companyId = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                this._name = value;
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }

            set
            {
                this._address = value;
            }
        }

        public string State
        {
            get
            {
                return _state;
            }

            set
            {
                this._state = value;
            }
        }

        public string Country
        {
            get
            {
                return _country;
            }

            set
            {
                this._country = value;
            }
        }
    }
}