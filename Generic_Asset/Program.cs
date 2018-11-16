using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Asset
{
    class Program
    {
        static void Main(string[] args)
        {
            int assetid;
            Hashtable hashtable = new Hashtable();
            List<string> added = new List<string>();
            hashtable.Add("CPU - 1000", 1000);
            hashtable.Add("Mouse - 2000", 2000);
            hashtable.Add("Keyboard - 3000", 3000);
            hashtable.Add("Monitor - 4000", 4000);
            int cpu = 1000;
            int mouse = 2000;
            int keyboard = 3000;
            int monitor = 4000;

            do
            {
                Console.WriteLine("Select Asset Type");
                Console.WriteLine("1)CPU");
                Console.WriteLine("2)Mouse");
                Console.WriteLine("3)Keyboard");
                Console.WriteLine("4)Monitor");
                Console.WriteLine("5)Exit");
                assetid = Convert.ToInt32(Console.ReadLine());

               
                if (assetid == 1)
                {
                    cpu = cpu + 1;
                    hashtable.Add("CPU - " + cpu.ToString(), cpu);
                    added.Add("CPU - " + cpu.ToString());
                    Console.WriteLine("CPU Added");
                    Console.WriteLine("Next asset id for CPU :" + (cpu).ToString());

                  
                }
                if (assetid == 2)
                {
                    mouse = mouse + 1;
                    hashtable.Add("Mouse - " + mouse.ToString(), cpu);
                    added.Add("Mouse - " + mouse.ToString());
                    Console.WriteLine("Mouse Added");
                    Console.WriteLine("Next asset id for Mouse :" + (mouse + 1).ToString());
                }
                if (assetid == 3)
                {
                    keyboard = keyboard + 1;
                    hashtable.Add("Keyboard - " + keyboard.ToString(), cpu);
                    added.Add("Keyboard - " + keyboard.ToString());
                    Console.WriteLine("Keyboard Added");
                    Console.WriteLine("Next asset id for CPU :" + (keyboard + 1).ToString());
                }
                if (assetid == 4)
                {
                    monitor = monitor + 1;
                    hashtable.Add("Monitor - " + monitor.ToString(), cpu);
                    added.Add("Monitor - " + monitor.ToString());
                    Console.WriteLine("Monitor Added");
                    Console.WriteLine("Next asset id for Monitor :" + (monitor + 1).ToString());
                }
             
            } while (assetid != 5);

         
            foreach (string entry in added)
            {
                Console.WriteLine(entry);
            }

            Console.ReadLine();
        }
    }
    
}
