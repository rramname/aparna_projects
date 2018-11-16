using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_SortingValues
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, int> sortedList = new SortedList<string, int>();
            var minValue = Int32.MaxValue;

            string minKey = null;
            Console.WriteLine("Enter the number of Assets:");
            int num = int.Parse(Console.ReadLine());
            int counter = 1;

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter Asset" + counter + " ID:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter duration of repair[hours]:");
                int exp = int.Parse(Console.ReadLine());
                if(exp<=24)
                sortedList.Add(name, exp);
                counter++;
            }
            Console.WriteLine("Asset(s) with minor issues:");
           
           
            foreach(var item in sortedList)
            {
                Console.WriteLine(item.Key);
            }

            Console.ReadLine();


        }
    }
}
