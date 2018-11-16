using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_ProductOfSuppliers
{
    class Program
    {
        static void Main(string[] args)
        {
         


            Console.WriteLine("Enter number of assets");
            int n = Convert.ToInt32(Console.ReadLine());
            List<Asset> assets = new List<Asset>();

            List<Model> models = new List<Model>();

            models.Add(new Model { Mname= "A653", Manufacturer= "Acer" });
            models.Add(new Model { Mname = "L764", Manufacturer = "Lenovo" });
            models.Add(new Model { Mname = "S598", Manufacturer = "Samsung" });
            models.Add(new Model { Mname = "D688", Manufacturer = "Dell" });
            models.Add(new Model { Mname = "HP67", Manufacturer = "HP" });


            //AssetBo bo=new AssetBO();
            for (int i = 0; i < n; i++)
            {
                Asset _asset = new Asset();
                Console.WriteLine("Enter the asset name");
                string AssetName = Console.ReadLine();
                Console.WriteLine("Enter the serial");
                string Serial = Console.ReadLine();
                Console.WriteLine("Enter the purchase date");
                string Pdate = Console.ReadLine();
                Console.WriteLine("Enter the Purchase cost");
                double PurchaseCost = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the model name");
                string Model1 = Console.ReadLine();

                _asset.AssetName = AssetName;
                _asset.Serial = Serial;
                _asset.Pdate = DateTime.ParseExact(Pdate, "dd/MM/yyyy", null);
                _asset.PurchaseCost = PurchaseCost;

                _asset.Model = new Model();
                _asset.Model.Mname = Model1;
                _asset.Model.Manufacturer = models.Where(x => x.Mname == Model1).FirstOrDefault().Manufacturer;

                assets.Add(_asset);
        }

            AssetBO bo = new AssetBO();
            bo.SaveAllAssets(assets);
            Console.WriteLine("Asset information saved successfully");
    }
    }
}
