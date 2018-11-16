using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_AssetRemove
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Asset> assets = new List<Asset>();

            assets.Add(new Asset(6489, "Laptop"," Hardware", DateTime.ParseExact("12-12-2017", "dd-MM-yyyy", null) , 50000.00));
            assets.Add(new Asset(7459, "Printer", " Hardware", DateTime.ParseExact("02-05-2014", "dd-MM-yyyy", null), 17500.50));
            assets.Add(new Asset(2465, "MS Office", " Software", DateTime.ParseExact("05-01-2011", "dd-MM-yyyy", null), 6000.00));
            assets.Add(new Asset(6903, "Visual Studio", " Software", DateTime.ParseExact("09-06-2018", "dd-MM-yyyy", null), 2560.75));
            assets.Add(new Asset(7835, "Windows OS", " Software", DateTime.ParseExact("04-12-2014", "dd-MM-yyyy", null), 10000.00));

            Console.WriteLine("Enter the asset id");
            int id = int.Parse(Console.ReadLine());

            Asset rm = assets.Where(a => a.AssetId == id).FirstOrDefault();

            if (rm!=null)
            {
                assets.Remove(rm);
                Console.WriteLine(String.Format("{0,-15}{1,-15}{2,-15}{3,-15}{4,0}", "Asset Id", "Asset Name", "Category", "Purchase Date", "Purchase Cost"));
                foreach(Asset ast in assets)
                {
                    Console.WriteLine(String.Format("{0,-15}{1,-15}{2,-15}{3,-15}{4,0}", ast.AssetId,ast.AssetName, ast.Category,ast.PurchaseDate.ToString("dd-MM-yyyy"),ast.PurchaseCost.ToString("f2")));
                }
            }
            else
            {
                Console.WriteLine("Asset id not found");
            }

           

        }
    }
}
