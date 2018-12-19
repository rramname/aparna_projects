using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Errors_1_Available_Assets
{
    class Program
    {
        static void Main(string[] args)
        {
            AssetLogBO assetLogBO = new AssetLogBO();
            List<AssetLog> assetlogList = assetLogBO.DisplayAllAssets();

            Console.WriteLine(String.Format("{0,-15}{1,-25}{2,-25}{3}", "AssetId", "UserCheckOutTo", "ExpectedCheckIn", "AssetStatus"));
            foreach (AssetLog a in assetlogList)
            {
                Console.WriteLine(String.Format("{0,-15}{1,-25}{2,-25}{3}", a.AssetId, a.UserCheckOutTo, a.ExpectedCheckIn, a.AssetStatus));
            }



            Console.WriteLine("Enter the asset id");
            int assetId = Convert.ToInt32(Console.ReadLine());

            Asset asset = new Asset();

            try
            {
                asset = assetLogBO.DisplayAvailableAssets(assetId);

                Console.WriteLine(String.Format("{0,-15}{1,-15}{2}", "AssetId", "AssetName", "Category"));
                Console.WriteLine(String.Format("{0,-15}{1,-15}{2}", asset.AssetId, asset.AssetName, asset.Category));
            }
            catch (InvalidAccessException e)
            {
                Console.WriteLine("Exception :"+e.Message);
            }

        }
    }
}
