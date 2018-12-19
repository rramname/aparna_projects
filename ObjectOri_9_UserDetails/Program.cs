using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOri_9_UserDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the Data Format\n1.CSV\n2.FixedLength");
            int ch = Convert.ToInt32(Console.ReadLine());
            if (ch == 1)
            {
                CSVUserData h = new CSVUserData();
                Console.WriteLine("Enter the data in csv format");
                String data = Console.ReadLine();
                h.CreateUser(data);
            }
            else if (ch == 2)
            {
                FixedLengthUserData h = new FixedLengthUserData();
                Console.WriteLine("Enter the data in fixed length format");
                String data = Console.ReadLine();
                h.CreateUser(data);
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
    }
}
