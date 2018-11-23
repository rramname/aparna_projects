using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_1_AssetStatus
{
    public class AssetBO
    {
        public List<Asset> GetAllAsset()
        {
            AssetDAO assetDAO = new AssetDAO();

            return assetDAO.GetAllAsset();
        }

        public List<string> GetAllAssetStatus()
        {
            AssetDAO assetDAO = new AssetDAO();
            return assetDAO.GetAllAssetStatus();
        }

        public List<Asset_Status> GetAllAssetStatusByID()
        {
            AssetDAO assetDAO = new AssetDAO();
            return assetDAO.GetAllAssetStatusByID();
        }

        public void UpdateAsset(int id, string status)
        {
            AssetDAO assetDAO = new AssetDAO();
          
            assetDAO.UpdateAsset(id, status);
        }
    }
}
