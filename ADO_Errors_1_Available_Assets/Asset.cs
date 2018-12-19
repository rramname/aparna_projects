namespace ADO_Errors_1_Available_Assets
{
    public class Asset
    {
        private int _assetId;
        private string _assetName;
        private string _category;

        public Asset()
        {

        }
        public Asset(int _assetId, string _assetName, string _category)
        {
            this._assetId = _assetId;
            this._assetName = _assetName;
            this._category = _category;
        }

        public int AssetId { get { return _assetId; } set { this._assetId = value; } }
        public string AssetName { get { return _assetName; } set { this._assetName = value; } }
        public string Category { get { return _category; } set { this._category = value; } }

    }
}