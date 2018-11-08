using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Policy> input = new List<Policy>();
            string str = "Y";
            Console.WriteLine("Enter Policy Details");
            do
            {
               
                string uinput = Console.ReadLine();

                string[] uinp = uinput.Split(',');
                
                  
                Agent a = new Agent(uinp[0],uinp[1]);
          

                
                if (uinp.Length == 4)
                {
                    Policy p = new Policy(uinp[2],a, uinp[3]);
                    input.Add(p);
                }
                else if (uinp.Length == 5) {
                    Policy p = new Policy(uinp[2], a, uinp[3],Convert.ToDouble( uinp[4]));
                    input.Add(p);
                }
                else
                {
                    Policy p = new Policy(uinp[2], a);
                    input.Add(p);
                }

             

                Console.WriteLine("Enter 'Y' to add another detail");
                 str = Console.ReadLine();

            } while (str == "Y");

            Console.WriteLine("Enter Agent ID");
            string id = Console.ReadLine();
            PolicyBO bo = new PolicyBO();
            List<Policy> filtered= bo.FindPolicies(input, id);
            foreach (Policy p in filtered)
            {
                p.ToString();
            }

            Console.ReadLine();
        }
    }
}
