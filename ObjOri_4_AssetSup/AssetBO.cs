using System;

namespace ObjOri_4_AssetSup
{
    internal class AssetBO
    {
        public void FindAssetDetail(AssetLog[] assetLog, string userName)
        {
            Console.WriteLine("Assets of {0} are :",userName);
            Console.WriteLine(String.Format("{0,-20}{1,0}", "Asset Id", "Asset Name"));
            
            foreach (AssetLog a in assetLog)
            {
                if(a.User!=null && a.Asset != null)
                {
                    if (a.User.UserName == userName)
                    {
                        Console.WriteLine(String.Format("{0,-20}{1,0}", a.Asset.AssetId, a.Asset.AssetName));
                    }
                }
                
            }
            //fill your code;

        }




        public void FindUsers(AssetLog[] assetLog, int assetId)
        {

            foreach (AssetLog a in assetLog)
            {
                if (a.Asset.AssetId == assetId)
                {

                    Console.WriteLine(a.User.UserName);
                }
            }


        }

    }
}