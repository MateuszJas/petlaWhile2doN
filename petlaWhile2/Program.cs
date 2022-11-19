using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace petlaWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int s = 0, z = 0, a = 0;
            int w = System.Convert.ToInt32(Console.ReadLine());
            
            while (a != w)
            {
                a++;

                Console.WriteLine("a= {0} \t s= {1}", a, s);

                s = (z + 1) + s;

                z++;
                                
            }
            Console.WriteLine("Suma = " + s);
            Console.ReadKey();
        }
    }
}
