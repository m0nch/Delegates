using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class Program
    {
        private delegate double Operation(int x, int y);
        static void Main(string[] args)
        {
            Console.Write("Input first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input operator (+,-,*,/): ");
            string op = Convert.ToString(Console.ReadLine());

            Operation operation = null;
            switch (op)
            {
                case "+":
                    operation = (a, b) => a + b;
                    break;
                case "-":
                    operation = (a, b) => a - b;
                    break;
                case "*":
                    operation = (a, b) => a * b;
                    break;
                case "/":
                    operation = (a, b) =>
                    {
                        if (b != 0)
                        {
                            return a / (double)b;
                        }
                        else
                        {
                            Console.WriteLine("Wrong division by zero");
                            return 0;
                        }
                    };
                    break;
                default:
                    Console.WriteLine("Wrong operator");
                    break;
            }
            if (operation != null)
            {
                Console.WriteLine($"The operation {op} return {operation?.Invoke(num1, num2)}");
            }

            Console.ReadKey();
        }
    }
}
