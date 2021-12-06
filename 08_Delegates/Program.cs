using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    //If the delegate returns some value, then the value of the last method 
    //from the call list is returned (if there are several methods in the call list)
    delegate int Operation(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            Operation operation = Add;
            operation += Subtract;
            operation += Multiply;

            Console.WriteLine(operation(5, 6));
            Console.ReadKey();
        }
        private static int Add(int x, int y) { return x + y; }
        private static int Subtract(int x, int y) { return x - y; }
        private static int Multiply(int x, int y) { return x * y; }
    }
}
