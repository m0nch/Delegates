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
        delegate void Message();
        static void Main(string[] args)
        {
            Operation operation = Add;
            operation(3, 4);
            operation.Invoke(3, 4);

            operation = null;
            operation?.Invoke(3, 4);

            Message message = Hello;
            message();
            message.Invoke();

            message = null;
            message?.Invoke();

            Console.ReadKey();
        }
        private static int Add(int x, int y) { return x + y; }
        private static void Hello() { Console.WriteLine("Hello"); }
    }
}
