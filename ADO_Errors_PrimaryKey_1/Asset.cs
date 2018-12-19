using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Errors_PrimaryKey_1
{
    public class Asset
    {
        int _id;
        string _name;
        string _category;
        string _purchaseDate;
        string _cost;

        public Asset(int _id, string _name, string _category, string _purchaseDate, string _cost)
        {

            this._id = _id;
            this._name = _name;
            this._category = _category;
            this._purchaseDate = _purchaseDate;
            this._cost = _cost;
        }

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
        }
        public string purchaseDate
        {
            get
            {
                return _purchaseDate;
            }
            set
            {
                _purchaseDate = value;
            }
        }
        public string Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                _cost = value;
            }
        }
    }
}
