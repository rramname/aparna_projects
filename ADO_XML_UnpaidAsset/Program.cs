using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_XML_UnpaidAsset
{
    class Program
    {
        private static IEnumerable<AssetLog> assets;

        static void Main(string[] args)
        {
            bool flag = true;
            int option;
            AssetBO assetBo = new AssetBO();

            while (flag)
            {
                Console.WriteLine("1. Display asset purchase details");
                Console.WriteLine("2. Display Paid supplier details");
                Console.WriteLine("3. Filter and display unpaid assets");
                Console.WriteLine("4. Exit");

                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}{4}", "Serial Number", "Name", "Category", "Supplier", "Cost");
                        List<Asset> assets = assetBo.GetAssets();
                       foreach (Asset a in assets)
                        {
                            Console.WriteLine(String.Format("{0,-20}{1,-20}{2,-20}{3,-20}{4}", a.SerialNumber, a.Name, a.Category,a.Supplier, a.Cost));
                        }
                        break;
                    case 2:
                        Console.WriteLine("Paid supplier names are");

                        string id = Console.ReadLine();
                        List<string> supNames = new List<string>();
                        string xmlFile = "supplier.xml";
                        supNames = assetBo.GetSupplierNames(xmlFile);
                        foreach (string str in supNames)
                        {
                            Console.WriteLine(str);

                        }


                        break;
                    case 3:

                        List<string> supNames2 = new List<string>();
                        string xmlFile2 = "supplier.xml";
                        supNames2 = assetBo.GetSupplierNames(xmlFile2);
                        foreach (string str in supNames2)
                        {
                            assetBo.RemovePaidAssets(str);

                        }
                        Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}{4}", "Serial Number", "Name", "Category", "Supplier", "Cost");
                        List<Asset> assets2 = assetBo.GetAssets();
                        foreach (Asset a in assets2)
                        {
                            if(supNames2.Exists(sy=>sy==a.Supplier))
                            Console.WriteLine(String.Format("{0,-20}{1,-20}{2,-20}{3,-20}{4}", a.SerialNumber, a.Name, a.Category, a.Supplier, a.Cost));
                        }
                        
                        //fill your code

                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}
