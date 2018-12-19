using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Errors_PrimaryKey_1
{
    public class AssetBO
    {
        public List<Asset> GetAllAssetDetails()
        {
            AssetDAO assetDAO = new AssetDAO();

            return assetDAO.GetAllAssetDetails();
        }
        public int CreateAsset(Asset asset)
        {
            AssetDAO assetDAO = new AssetDAO();

            return assetDAO.CreateAsset(asset);
        }
    }
}
