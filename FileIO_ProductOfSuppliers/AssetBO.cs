using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_ProductOfSuppliers
{
    public class AssetBO
    {
        public void SaveAllAssets(List<Asset> asset)
        {
            using (StreamWriter outputFile = new StreamWriter("output.csv", false, Encoding.Unicode))
            {
                foreach (Asset a in asset)
                {
                    outputFile.WriteLine(a.AssetName + "," + a.Serial + "," + a.Pdate.ToString("dd/MM/yyyy") + "," + a.PurchaseCost.ToString("0.##")+","+a.Model.Mname+","+a.Model.Manufacturer);
                }

            }
        }
    }
}
