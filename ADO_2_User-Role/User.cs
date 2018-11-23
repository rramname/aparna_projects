namespace ADO_2_User_Role
{
    public class User
    {
        int _userId;
        string _name;
        Role _role;
        Company _company;

        public User(int _userId, string _name, Role _role, Company _company)
        {
            this._userId = _userId;
            this._name = _name;
            this._role = _role;
            this._company = _company;
        }

        public int UserId
        {
            get
            {
                return _userId;
            }

            set
            {
                this._userId = value;
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

        public Role Role
        {
            get
            {
                return _role;
            }

            set
            {
                this._role = value;
            }
        }

        public Company Company
        {
            get
            {
                return _company;
            }

            set
            {
                this._company = value;
            }
        }
    }
}