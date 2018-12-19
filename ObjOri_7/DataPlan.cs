using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjOri_7
{
    public abstract class DataPlan
    {
        int _downloadSize;
        public DataPlan() {
            //this._downloadSize = downloadSize;
        }
        public int DownloadSize
        {
            get
            {

                return _downloadSize;
            }
            set
            {
                _downloadSize = value;
            }
        }

        public abstract void TotalCost();
        

        public static DataPlan FindMyPlan(int _downloadSize)
        {
            if (_downloadSize > 0 && _downloadSize < 25)
                return new SilverPlan(_downloadSize);
            if (_downloadSize >= 25 && _downloadSize < 50)
                return new GoldenPlan(_downloadSize);

           else
                return new PlatinumPlan(_downloadSize);
           
        }

    }
}
