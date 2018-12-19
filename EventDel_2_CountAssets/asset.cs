using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDel_2_CountAssets
{
    public class Asset
    {

        public Asset(string _name, string _model, string _category, string _id)
        {
            this._name = _name;
            this._model = _model;
            this._category = _category;
            this._id = _id;
        }
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

        private string _category;
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        private string _id;
        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}
