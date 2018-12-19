using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjOri_7
{
    public class SilverPlan :DataPlan
    {
        int _downloadSize = 0;
        public SilverPlan(int _downloadSize)
        {
            this._downloadSize = _downloadSize;
        }
        public override void TotalCost()
        {
            
            int cost = this._downloadSize * 1024 * 10;
            Console.WriteLine("Total cost in silver plan : " + cost.ToString() +" Cents");
        }
    }
}
