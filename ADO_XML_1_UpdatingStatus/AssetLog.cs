namespace ADO_XML_1_UpdatingStatus
{
    public class AssetLog
    {
        private int _assetId;
        private string _username;
        private string _expectedCheckoutDate;
        private string _status;

        public AssetLog(int assetId, string username, string expectedCheckoutDate, string status)
        {
            _assetId = assetId;
            _username = username;
            _expectedCheckoutDate = expectedCheckoutDate;
            this._status = status;
        }

        public int AssetId
        {
            get { return _assetId; }
            set { _assetId = value; }
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string ExpectedCheckoutDate
        {
            get { return _expectedCheckoutDate; }
            set { _expectedCheckoutDate = value; }
        }

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public override string ToString()
        {
            return String.Format("{0,-10}{1,-20}{2,-20}{3}", _assetId, _username, _expectedCheckoutDate, _status);
        }
    }
}