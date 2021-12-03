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
            Operation operation = Add;
            int result = operation(5, 6);
            Console.WriteLine(result);

            operation = Multiply;
            result = operation(5, 6);
            Console.WriteLine(result);

            Console.ReadKey();
        }

        private static int Add(int x, int y)
        {
            return x + y;
        }

        private static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
