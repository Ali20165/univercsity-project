using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double f, c;

            Console.Write("enter a temp: ");
            c = Double.Parse(Console.ReadLine());
            f = c * 1.8 + 32;
            
            Console.WriteLine("Fahrenheit = {0} ", f );

            Console.ReadKey();
        }
    }
}
