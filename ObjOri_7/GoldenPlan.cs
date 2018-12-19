using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjOri_7
{
    public class GoldenPlan : DataPlan
    {
        int _downloadSize = 0;
        public GoldenPlan(int _downloadSize)
        {
            this._downloadSize = _downloadSize;
        }
        public override void TotalCost()
        {
            int cost = this._downloadSize * 1024 * 5;
            Console.WriteLine("Total cost in golden plan : " + cost.ToString());
        }
    }
}
