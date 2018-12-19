using System.Collections.Generic;

namespace ADO_XML_UnpaidAsset
{
    public class AssetBO
    {
        public void RemovePaidAssets(string supplierName)
        {

            AssetDAO assetDAO = new AssetDAO();

            assetDAO.RemovePaidAssets(supplierName);
        }

        public List<Asset> GetAssets()
        {
            AssetDAO assetDAO = new AssetDAO();
            return assetDAO.GetAssets();
        }

        public List<string> GetSupplierNames(string xmlFileName)
        {
            //List<string> statuses = new List<string>();
            AssetDAO assetDAO = new AssetDAO();
            return assetDAO.GetSupplierNames(xmlFileName);
        }
    }
}