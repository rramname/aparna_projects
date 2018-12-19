namespace ObjOri_4_AssetSup
{
    internal class Asset
    {
        private int _assetId;
        private string _assetName;

        public int AssetId
        {
            get
            {
                return _assetId;
            }
            set
            {
                this._assetId = value;
            }
        }

        public string AssetName
        {
            get
            {
                return _assetName;
            }
            set
            {
                this._assetName = value;
            }
        }


        public Asset(int _assetId, string _assetName)
        {
            this._assetId = _assetId;
            this._assetName = _assetName;

        }

    }
}