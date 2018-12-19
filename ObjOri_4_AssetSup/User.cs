namespace ObjOri_4_AssetSup
{
    internal class User
    {
        private string _userName;

        private int _employeeNo;


        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                this._userName = value;
            }
        }


        public int EmployeeNo
        {
            get
            {
                return _employeeNo;
            }
            set
            {
                this._employeeNo = value;
            }
        }



        public User(string _userName, int _employeeNo)
        {
            this._userName = _userName;

            this._employeeNo = _employeeNo;

        }
    }
}