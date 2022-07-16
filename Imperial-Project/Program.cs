using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imperial_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            enemy hostile01 = new enemy("Tank", "Battle Unit", 5);
            enemy hostile02 = new enemy("Scout", "Local Unit", 2);
            player user01 = new player("Test", "SnowAttack");


            hostile01.Attack();
            hostile01.Attack();


            hostile02.Attack();

            user01.run();

            Console.ReadLine();
        }
    }
}
