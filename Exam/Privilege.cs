namespace Exam
{
    public class Privilege
    {
        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public override string ToString()
        {
            return System.String.Format("{0,-20}{1,-20}",this._id, this._name);
        }
    }
}