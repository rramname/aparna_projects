using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_1_AssetStatus
{
    class Program
    {
        static void Main(string[] args)
        {
            AssetBO bo = new AssetBO();
            List<Asset> assets = new List<Asset>();
            assets = bo.GetAllAsset();
            Console.WriteLine("Asset Details:");
            Console.WriteLine(String.Format("{0,-10}{1,-20}{2,-20}{3}", "Id", "Asset Name", "User Name", "Status"));
            foreach (Asset a in assets)
            {
                Console.WriteLine(String.Format("{0,-10}{1,-20}{2,-20}{3}", a.Id, a.Name, a.UserName, a.Status));
            }

            Console.WriteLine("Select the Asset id to be updated");
            int id = int.Parse(Console.ReadLine());

            List<string> statuses = new List<string>();
            statuses = bo.GetAllAssetStatus();
            int counter = 1;
            foreach(string str in statuses)
            {
                Console.WriteLine(counter++.ToString()+"."+str);

            }

            Console.Write("Choose updated status:");
            int statusId = int.Parse(Console.ReadLine());

            string status = bo.GetAllAssetStatusByID().Where(x => x.Id == statusId).FirstOrDefault().Status;

            bo.UpdateAsset(id, status);
            Console.WriteLine(Environment.NewLine);
            List<Asset> assets2 = new List<Asset>();
            assets2 = bo.GetAllAsset();
            Console.WriteLine(String.Format("{0,-10}{1,-20}{2,-20}{3}", "Id", "Asset Name", "User Name", "Status"));
            foreach (Asset a in assets2)
            {
                Console.WriteLine(String.Format("{0,-10}{1,-20}{2,-20}{3}", a.Id, a.Name, a.UserName, a.Status));
            }

        }
    }
}
