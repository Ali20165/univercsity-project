using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double p = 3.14;
            double c, mohit, msahat;
            Console.Write("enter a number: ");
            c = double.Parse(Console.ReadLine());
            mohit = c * p;
            msahat = c * 0.5 * c * 0.5 * p;

            Console.WriteLine("msahat is {0} and mohit is {1} ", msahat, mohit);

            Console.ReadKey();

        }
    }
}
