using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    //Delegates as method parameters
    delegate void GetMessage();
    class Program
    {
        static void Main(string[] args)
        {
            if (DateTime.Now.Hour < 12)
            {
                ShowMessage(GoodMorning);
            }
            else
            {
                ShowMessage(GoodEvening);
            }
            Console.ReadKey();
        }
        private static void ShowMessage(GetMessage _getMessage)
        {
            _getMessage?.Invoke();
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
