using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imperial_Project
{
    internal class player
    {
        public string name;
        public string attack;
        private float health;
        private float level;

        public player(string Aname, string Aattack)
        {
           name = Aname;
           attack = Aattack;
           health = 0f;
           level = 0f;
        }

        public void run()
        {
            Console.WriteLine(name + " Sprinted Away!");
            health -= 0.2f;
            level += 0.5f;
            Console.WriteLine(name + " Level increased to " + level);
        }
    }
}
