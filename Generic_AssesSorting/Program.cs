using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_AssesSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, DateTime> sortedList = new SortedList<string, DateTime>();
            Console.WriteLine("Enter the number of Assets:");
            int num = int.Parse(Console.ReadLine());

            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter Software name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter Expiry date for " + name + ":");
                DateTime exp = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy",null);

                sortedList.Add(name, exp);
            }
            Console.WriteLine("Sorted List:");
            foreach(var item in sortedList)
            {
                Console.WriteLine(item.Key + " || " + item.Value.ToString("dd-MM-yyyy"));
            }
        }
    }
}
