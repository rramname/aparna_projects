using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_AssetCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of assets:");
            int count = int.Parse(Console.ReadLine());
            List<string> cats = new List<string>();
            Console.WriteLine("Enter the assets:");
            for(int i = 0; i < count; i++)
            {
                cats.Add(Console.ReadLine().Substring(0, 3));
            }
           foreach(var x in cats.GroupBy(n => n).Select(group => new { group.Key, Count=group.Count() }))
            {
                Console.WriteLine(x.Key + " - " + x.Count.ToString());
            }
        }
    }
}
