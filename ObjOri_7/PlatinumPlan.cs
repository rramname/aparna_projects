using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjOri_7
{
    public class PlatinumPlan : DataPlan
    {
        int _downloadSize = 0;
        public PlatinumPlan(int _downloadSize)
        {
            this._downloadSize = _downloadSize;
        }
        public override void TotalCost()
        {
            int cost = _downloadSize * 1024 * 2;
            Console.WriteLine("Total cost in platinum plan : " + cost.ToString());
        }
    }
}
