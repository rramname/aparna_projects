using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_ProductOfSuppliers
{
    public class Asset
    {
        private string _assetName;
        public string AssetName
        {
            get { return _assetName; }
            set { _assetName = value; }
        }
        private string _serial;
        public string Serial
        {
            get { return _serial; }
            set { _serial = value; }
        }
        private DateTime _purchaseDate;
        public DateTime Pdate
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
        private Model _model;
        public Model Model
        {
            get { return _model; }
            set { _model = value; }
        }
    }
}
