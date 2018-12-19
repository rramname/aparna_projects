using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDelRef_CC
{
    public class Agent
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public Agent(int Id, string name)
        {
            this._id = Id;
            this._name = name;

        }
    }
}
