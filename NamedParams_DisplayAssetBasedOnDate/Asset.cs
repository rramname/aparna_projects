using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParams_DisplayAssetBasedOnDate
{
    public class Asset
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _model;
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        private DateTime _purchaseDate;
        public DateTime PurchaseDate
        {
            get { return _purchaseDate; }
            set { _purchaseDate = value; }
        }

        private string _category;
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public Asset(string _name, string _model, DateTime _purchaseDate, string _category= "Electronic Asset")
        {
            this._name = _name;
            this._category = _category;
            this._model = _model;
            this._purchaseDate = _purchaseDate;
        }
    }
}
