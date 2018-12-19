using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_XML_1_UpdatingStatus
{
    class Program
    {
        static void Main(string[] args)
        {
            AssetLogBO bo = new AssetLogBO();
            List<AssetLog> assets = new List<AssetLog>();
            assets = bo.GetAllAssetLogs();
            Console.WriteLine("Asset Details:");
            Console.WriteLine(String.Format("{0,-10}{1,-20}{2,-20}{3}", "Id", "Username", "Checkout date ", "Status"));
            foreach (AssetLog a in assets)
            {
                Console.WriteLine(String.Format("{0,-10}{1,-20}{2,-20}{3}", a.AssetId, a.Username, a.ExpectedCheckoutDate, a.Status));
            }

            Console.WriteLine("Select the Asset id to be updated");
            int id = int.Parse(Console.ReadLine());

            List<string> statuses = new List<string>();
            statuses = bo.GetAllAssetStatus();
            int counter = 1;
            foreach (string str in statuses)
            {
                Console.WriteLine(counter++.ToString() + "." + str);

            }


            Console.WriteLine("Choose updated status:");
            int statusId = int.Parse(Console.ReadLine());

            string status = bo.GetAllAssetStatusByID(statusId);//.Where(x => x.id == statusId).FirstOrDefault().Status;

            bo.UpdateAssetLog(id, status);
            Console.WriteLine(Environment.NewLine);
            List<AssetLog> assets2 = new List<AssetLog>();
            assets2 = bo.GetAllAssetLogs();
            Console.WriteLine(String.Format("{0,-10}{1,-20}{2,-20}{3}", "Id", "Asset Name", "User Name", "Status"));
            foreach (AssetLog a in assets2)
            {
                Console.WriteLine(String.Format("{0,-10}{1,-20}{2,-20}{3}", a.AssetId, a.Username, a.ExpectedCheckoutDate, a.Status));
            }

        }
    }
    
}
