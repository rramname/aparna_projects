using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_AssetRemove
{
    public class Asset
    {
        private int _assetId;
        public int AssetId
        {
            get { return _assetId; }
            set { _assetId = value; }
        }

        private string _assetName;
        public string AssetName
        {
            get { return _assetName; }
            set { _assetName = value; }
        }

        private string _category;
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        private DateTime _purchaseDate;
        public DateTime PurchaseDate
        {
            get { return _purchaseDate; }
            set { _purchaseDate = value; }
        }

        private double _purchaseCost;
        public double PurchaseCost
        {
            get { return _purchaseCost; }
            set { _purchaseCost = value; }
        }

        public Asset(int _assetId,string _assetName,string  _category,DateTime _purchaseDate,double _purchaseCost)
        {
            this._assetId = _assetId;
            this._assetName = _assetName;
            this._category = _category;
            this._purchaseDate = _purchaseDate;
            this._purchaseCost = _purchaseCost;
        }
    }
}
