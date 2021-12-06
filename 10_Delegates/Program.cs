using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    //Delegates can be Generic
    delegate T Opearation<T, K>(K val);
    class Program
    {
        static void Main(string[] args)
        {
            Opearation<decimal, int> opearation = Square;

            Console.WriteLine(opearation(7));
            Console.ReadKey();
        }
        static decimal Square(int n) { return n * n; }
    }
}
