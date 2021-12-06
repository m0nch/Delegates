using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate void Message();

    class Program
    {
        static void Main(string[] args)
        {
            Message message = Hello;
            message += HowAreYou;
            message();

            Console.ReadKey();
        }
        private static void Hello()
        {
            Console.Write("Hello! ");
        }
        private static void HowAreYou()
        {
            Console.Write("How are you?");
        }
    }
}
