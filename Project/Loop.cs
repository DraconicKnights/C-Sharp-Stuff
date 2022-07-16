using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    internal class Loop
    {
        public static void WhileLoop()
        {
            int i = 0;
            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public static void ForLoop()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i + " This is a test");
            }
        }
    }
}
