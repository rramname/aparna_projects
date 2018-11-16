using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_IndianSuppliers
{
    class Program
    {
        static void Main(string[] args)
        {
            string csvData = File.ReadAllText("input.csv");
            string[] rows = csvData.Split('\n');
            int count = 0;
            foreach (string row in rows)
            {

                if (row.ToLower().Contains("india"))
                {
                    count++;
                }
            
            }
            Console.WriteLine("Indian Suppliers : " + count.ToString());
        }
    }
}
