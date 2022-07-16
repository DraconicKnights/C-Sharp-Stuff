using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Function: ");
            string Function = Console.ReadLine();
            if (Function == "Calculate")
            {
                Console.WriteLine("Enter an Operator: ");
                string op = Console.ReadLine();
                Console.WriteLine("Enter a Number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a Number");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Calculation.Calc(op, num1, num2);
            }
            else if (Function == "WhileLoop")
            {
                Loop.WhileLoop();
            }
            else if (Function == "Guess")
            {
                Guessgame.guess();
            }
            else if (Function == "ForLoop")
            {
                Loop.ForLoop();
            }
            else
            {
                Console.WriteLine(Function + " Is an Invalid Function");
            }


            Console.ReadLine();
        }
    }
}
