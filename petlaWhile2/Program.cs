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
            
            int s = 0;
            int z = 0;
            int w = System.Convert.ToInt32(Console.ReadLine());
            int a = 0;

            while (a != w)
            {
                a++;

                Console.WriteLine("a= " + a + " s= " + s);

                s = (z + 1) + s;

                z++;
                                
            }
            Console.WriteLine("Suma = " + s);
            Console.ReadKey();
        }
    }
}
