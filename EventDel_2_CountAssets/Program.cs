using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDel_2_CountAssets
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of Assets");
                int n = int.Parse(Console.ReadLine());
            ArrayList assets = new ArrayList();
            for (int i= 0; i < n; i++)
            {
                Console.WriteLine("Enter the Asset {0} details",i.ToString());
                string[] str = Console.ReadLine().Split(',');
                Asset a = new Asset(str[0], str[1], str[2], str[3]);
                assets.Add(a);
            }

    
            Console.WriteLine("Enter the category");
            string cat = Console.ReadLine();
            AssetBO bo = new AssetBO();
                   
            AssetBO.CountAssetsDelegate del = new AssetBO.CountAssetsDelegate(AssetBO.countAssetsByCategory);
            int count = del(assets, cat);
            Console.WriteLine("Assets count in the category {0} is {1}", cat, count.ToString());

        }
    }
}
