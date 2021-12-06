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
            Math math = new Math();
            Operation operation = math.Sum;
            int result = operation(4, 5);
            Console.WriteLine(result);
        }
    }    
    class Math
    {
        public int Sum(int x, int y) { return x + y; }
    }
}
