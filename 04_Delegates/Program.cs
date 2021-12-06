using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        delegate int Operation(int x, int y);

        static void Main(string[] args)
        {
            Operation operation = Sum;
            Operation operation1 = new Operation(Sum);

            Console.WriteLine(operation(5,6));
            Console.WriteLine(operation1(5,6));            
            
            Console.ReadKey();
        }
        private static int Sum(int x, int y) { return x + y; }
    }
}
