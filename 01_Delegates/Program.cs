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
            Message message;
            if (DateTime.Now.Hour < 12 )
            {
                message = GoodMorning;
            }
            else
            {
                message = GoodEvening;
            }
            message();
        }

        private static void GoodMorning()
        {
            Console.WriteLine("Good Morning!");
        }
        private static void GoodEvening()
        {
            Console.WriteLine("Good Evening!");
        }
    }
}
