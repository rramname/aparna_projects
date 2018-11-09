using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList veh = new ArrayList();
            Console.WriteLine("Enter Vehicle Numbers");
            List<string> withSum = new List<string>();
            string num = string.Empty;
            do
            {
                num = Console.ReadLine();
                veh.Add(num);
            } while (!num.Equals("exit"));

            foreach(string number in veh)
            {
                var b = string.Join("", number.Where(char.IsDigit));
                int sum = 0;
                foreach(char x in b.ToCharArray())
                {
                    sum = sum + (int)(x - '0'); ;
                }
                if (sum == 8)
                {
                    withSum.Add(number);
                }
            }
            Console.WriteLine("Vehicle Numbers which is having the sum 8");

            if (withSum.Count == 0)
            {
                Console.WriteLine("No such vehicles!");
            }
            else
            {
                foreach(string str in withSum)
                {
                    Console.WriteLine(str);
                }
            }
            }
            
        
    }
}
