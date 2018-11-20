using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParams_DisplayAssetBasedOnDate
{
    public class AssetBO
    {
        public List<Asset> FindAssetsBasedOnYearOfPurchase(List<Asset> a, string purchasedYear)
        {
            List<Asset> assets = new List<Asset>();
            

            DateTime iDate = DateTime.Parse(purchasedYear);
            return a.Where(x => x.PurchaseDate == iDate).ToList<Asset>();


            //return assets;
        }
    }
}
