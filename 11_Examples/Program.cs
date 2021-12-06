using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class Program
    {
        private delegate decimal MyDelegate(int a, int b, int c);

        static void Main(string[] args)
        {
            Console.Write("Input first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input third number: ");
            int number3 = Convert.ToInt32(Console.ReadLine());

            MyDelegate myDelegate = (a, b, c) => (decimal)(a + b + c) / 3;  //lambda expression
            Console.WriteLine($"The avarege of input numbers is {myDelegate(number1, number2, number3)}");

            Console.ReadKey();
        }
    }
}
