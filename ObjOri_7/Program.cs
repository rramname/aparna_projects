using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjOri_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int downloadSize;
            Console.WriteLine("Enter the bandwidth used (GB)");
            downloadSize = Convert.ToInt32(Console.ReadLine());

           
                
                DataPlan dp= DataPlan.FindMyPlan(downloadSize);
            dp.DownloadSize = downloadSize;
                dp.TotalCost();
                
        }
    }
}
