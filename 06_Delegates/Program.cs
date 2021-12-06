using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        delegate void Message();
        static void Main(string[] args)
        {
            Message message1 = Hello;
            Message message2 = HowAreYou;
            Message message = message1 + message2;
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
