namespace ADO_Errors_1_Available_Assets
{
    public class AssetLog
    {
        private int _assetId;
        private string _userCheckOutTo;
        private string _expectedCheckIn;
        private string _assetStatus;


        public AssetLog()
        {

        }

        public AssetLog(int _assetId, string _userCheckOutTo, string _expectedCheckIn, string _assetStatus)
        {
            this._assetId = _assetId;
            this._userCheckOutTo = _userCheckOutTo;
            this._expectedCheckIn = _expectedCheckIn;
            this._assetStatus = _assetStatus;
        }

        public int AssetId { get { return _assetId; } set { this._assetId = value; } }
        public string UserCheckOutTo { get { return _userCheckOutTo; } set { this._userCheckOutTo = value; } }
        public string ExpectedCheckIn { get { return _expectedCheckIn; } set { this._expectedCheckIn = value; } }
        public string AssetStatus { get { return _assetStatus; } set { this._assetStatus = value; } }



    }
}