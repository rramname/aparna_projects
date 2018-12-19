using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_XML_1_UpdatingStatus
{
    public class AssetLogBO
    {
        public void UpdateAssetLog(int id, string status)
        {

            AssetLogDAO assetDAO = new AssetLogDAO();

            assetDAO.UpdateAssetLog(id, status);
        }

        public List<AssetLog> GetAllAssetLogs()
        {
            AssetLogDAO assetDAO = new AssetLogDAO();
            return assetDAO.GetAllAssetLogs();
        }

        public List<string> GetAllAssetStatus()
        {
            //List<string> statuses = new List<string>();
            AssetLogDAO assetDAO = new AssetLogDAO();
            return assetDAO.GetAllAssetStatuses();
        }

        public string GetAllAssetStatusByID(int id)
        {
            AssetLogDAO assetDAO = new AssetLogDAO();

            return assetDAO.GetAllAssetStatusByID(id);
        }
        


    }
}
