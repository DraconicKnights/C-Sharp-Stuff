using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    internal class Calculation
    {
        public static void Calc(string op, int num1, int num2)
        {

            try
            {

                switch (op)
                {
                    case "+":
                        Console.WriteLine(num1 + num2);
                        break;
                    case "-":
                        Console.WriteLine(num1 - num2);
                        break;
                    case "*":
                        Console.WriteLine(num1 * num2);
                        break;
                    case "/":
                        Console.WriteLine(num1 / num2);
                        break;
                    case "%":
                        Console.WriteLine(num1 % num2);
                        break;
                    default:
                        Console.WriteLine("Invalid Operator");
                        break;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
