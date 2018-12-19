namespace EventDel_4_AssetDet
{
    internal class Asset
    {

        public Asset(int _assetId, string _serial, int _orderNumber, string _purchasedDate)
        {
            this._assetId = _assetId;
            this._serial = _serial;
            this._orderNumber = _orderNumber;
            this._purchasedDate = _purchasedDate;
        }
        private int _assetId;
        public int AssetID
        {
            get { return _assetId; }
            set { _assetId = value; }
        }

        private string _serial;
        public string Serial
        {
            get { return _serial; }
            set { _serial = value; }
        }

        private int _orderNumber;
        public int OrderNumber
        {
            get { return _orderNumber; }
            set { _orderNumber = value; }
        }

        private string _purchasedDate;
        public string PurchaseDate
        {
            get { return _purchasedDate; }
            set { _purchasedDate = value; }
        }
    }
}