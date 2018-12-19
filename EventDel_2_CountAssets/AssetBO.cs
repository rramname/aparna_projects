using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDel_2_CountAssets
{

    public class AssetBO
    {
        public delegate int CountAssetsDelegate(ArrayList assetList, string category);
        public static int countAssetsByCategory(ArrayList list, string category)
        {
            return list.Cast<Asset>().Where(x => x.Category.Equals(category)).Count();
            
        }

    }
}
