using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Errors_PrimaryKey_1
{
    class Program
    {
        static void Main(string[] args)
        {
            AssetBO assetBOSel = new AssetBO();

            List<Asset> assetList = assetBOSel.GetAllAssetDetails();
            Console.WriteLine("Asset details are:");
            Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15}{4}", "AssetId", "Name", "Category", "Date", "Cost");

            foreach (Asset i in assetList)
            {
                Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15}{4}", i.Id, i.Name, i.Category, i.purchaseDate, i.Cost);
            }
            Console.WriteLine("Enter the asset details to insert:");


            int n = Convert.ToInt32(Console.ReadLine());

            string name = Console.ReadLine();

            string cetagory = Console.ReadLine();

            string date = Console.ReadLine();

            string cost = Console.ReadLine();

            Asset assetIns = new Asset(n, name, cetagory, date, cost);
            AssetBO assetBOIns = new AssetBO();
            int x = assetBOIns.CreateAsset(assetIns);
            if (x != 0)
            {
                List<Asset> assetList2 = assetBOIns.GetAllAssetDetails();
                Console.WriteLine("Asset details after insert:");
                Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15}{4}", "AssetId", "Name", "Category", "Date", "Cost");

                foreach (Asset i in assetList2)
                {
                    Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15}{4}", i.Id, i.Name, i.Category, i.purchaseDate, i.Cost);
                }
            }
            else
            {
                Console.WriteLine("Primary key exception asset id already exists");
            }
            Console.ReadLine();
        }
    }
}
