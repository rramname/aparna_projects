namespace ObjOri_4_AssetSup
{
    internal class AssetLog
    {
        private User _user;
        private Asset _asset;

        public User User
        {
            get
            {
                return _user;
            }
            set
            {
                this._user = value;
            }
        }

        public Asset Asset
        {
            get
            {
                return _asset;
            }
            set
            {
                this._asset = value;
            }
        }


        public AssetLog(User _user, Asset _asset)
        {
            this._user = _user;
            this._asset = _asset;

        }

    }
}