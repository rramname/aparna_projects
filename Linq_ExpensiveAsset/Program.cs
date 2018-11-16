using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_ExpensiveAsset
{
    class Program
    {
        static void Main(string[] args)
        {
            string csvData = File.ReadAllText("input.csv");
            string[] rows = csvData.Split('\n');
            List<Asset> asset = new List<Asset>();
            foreach (string row in rows)
            {


                if (!string.IsNullOrEmpty(row))
                {
                    string[] cols = row.Split(',');

                    string Name = cols[0];
                    string Category = cols[1];
                    double Cost = Convert.ToDouble(cols[2]);
                    Asset c = new Asset(Name, Category, Cost);
                    asset.Add(c);
                }

            }

            Asset max = asset.OrderByDescending(a => a.Cost).First();

            Console.WriteLine("Asset name : " + max.Name);
            Console.WriteLine("Asset category : " + max.Category);
            Console.WriteLine("Premium cost :" + max.Cost.ToString());
        }
    }
}
