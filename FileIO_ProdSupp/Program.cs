using FileIO_ProdSetup;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_ProdSupp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number of assets");
            int totAsset = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the asset details and supplier details");
            List<Asset> assets = new List<Asset>();
            List<Supplier> suppliers = new List<Supplier>();
            for(int i = 0; i < totAsset; i++)
            {
                string det = Console.ReadLine();
                string[] dets = det.Split(',');
                string Name = dets[0];
                string Serial = dets[1];
                DateTime PurDAte = DateTime.ParseExact(dets[2], "dd/MM/yyyy", null);// DateTime.Parse(dets[2], new CultureInfo("en-CA"));
                Double cost = Double.Parse(dets[3]);

                string supName = dets[4];
                string address = dets[5];

                
                Asset a = new Asset(Name, Serial, PurDAte, cost);
                Supplier sup = new Supplier();
                sup.Name = supName;
                sup.Address = address;
                Supplier curSupp = new Supplier();
                if (suppliers.Exists(s=>s.Name==sup.Name && s.Address == sup.Address))
                {
                    
                    curSupp = suppliers.FirstOrDefault(s => s.Name == sup.Name && s.Address == sup.Address);
                    curSupp._assetList.Add(a);
                }
                else
                {
                    curSupp.Name = supName;
                    curSupp.Address = address;
                    curSupp._assetList=new List<Asset>();
                    curSupp._assetList.Add(a);
                    suppliers.Add(curSupp);
                }

            }

            suppliers.Sort();

            using (StreamWriter outputFile = new StreamWriter("output.txt"))
            {
                foreach (Supplier s in suppliers)
                {
                    outputFile.WriteLine("|" + s.Name + "|" + s.Address+"|");
                    
                    foreach (Asset a in s._assetList)
                    {
                        outputFile.WriteLine(a.Name + "," + a.SerialNum + "," + a.Pdate.ToString("dd/MM/yyyy") + "," + a.Cost.ToString());
                        
                    }
                }

            }
           
            Console.ReadLine();
        }
    }
}
