using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EventDel_4_AssetDet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of assets");
            int n = int.Parse(Console.ReadLine());
            ArrayList assets = new ArrayList();
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the details {0} ", (i + 1).ToString());
                string[] str = Console.ReadLine().Split(',');
                Asset a = new Asset(int.Parse(str[0]), str[1],int.Parse(str[2]), str[3]);
                assets.Add(a);
            }

            Console.WriteLine("Select the attribute to get the values");

            PropertyInfo[] info = typeof(Asset).GetProperties();
            int counter = 1;
            foreach(PropertyInfo p in info)
            {
                Console.WriteLine(counter.ToString()+"."+p.Name);
                counter++;
            }
            string proName = Console.ReadLine();

      
            foreach (Asset a in assets)
            {
                PropertyInfo inf = typeof(Asset).GetProperty(proName);
                Console.WriteLine(inf.GetValue(a).ToString());
            }

        }
    }
}
