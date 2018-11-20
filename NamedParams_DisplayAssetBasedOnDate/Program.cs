using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParams_DisplayAssetBasedOnDate
{
    class Program
    {
        static void Main(string[] args)
        {

            
            int count = int.Parse(Console.ReadLine());

            List<Asset> assets = new List<Asset>();
            for(int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                string[] arr = input.Split(',');

                string name = arr[0];
                string model = arr[1];
                DateTime pDate = DateTime.ParseExact(arr[2], "MM/dd/yyyy", null);

                string category = arr[3]==null || arr[3].Length<2 ? null:arr[3];
                if(category==null)
                {
                    Asset a = new Asset(name, model, pDate);
                    assets.Add(a);
                }

                else
                {
                    Asset a = new Asset(name, model, pDate, category);
                    assets.Add(a);
                }
                   
               
            }

            string date = Console.ReadLine();

            AssetBO bo = new AssetBO();

            List<Asset> filtered = bo.FindAssetsBasedOnYearOfPurchase(assets, date);

            foreach(Asset a in filtered)
            {
                Console.WriteLine(a.Name + " - " + a.Category);
            }
        }

    }
}
