using System.Collections.Generic;

namespace ADO_Errors_1_Available_Assets
{
    public class AssetLogBO
    {
        public List<AssetLog> DisplayAllAssets()
        {
            AssetLogDAO dao = new AssetLogDAO();
            return dao.DisplayAllAssets();
        }


        public Asset DisplayAvailableAssets(int assetId)
        {
            AssetLogDAO dao = new AssetLogDAO();
            return dao.DisplayAvailableAssets(assetId);
            //fill your code;
        }

    }
}