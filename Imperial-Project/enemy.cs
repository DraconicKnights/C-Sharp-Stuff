using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imperial_Project
{
    internal class enemy
    {
        private string type;
        public string description;
        private float health;
        private float level;
        private float strength;
        private bool injured;

        public static int ammount;

        public enemy(string Atype, string Adescription, int Alevel)
        {
            type = Atype;
            description = Adescription;
            health = 10;
            level = Alevel;
            strength = 5;


            ammount++;
        }

        public void Attack()
        {
            injured = false;

            if (!injured)
            {
                if (strength >= 1 || health >= 5)
                {
                    Console.WriteLine(type + " Attacks");
                    strength -= 0.5f;
                    level += 0.5f;
                    health -= 0.8f;
                    Console.WriteLine(type + " Strenth remaining " + strength);
                    Console.WriteLine(type + " Level: " + level);
                }
                else if (health > 0 && health < 5)
                {
                    Console.WriteLine(type + " Attacked but was heavely damaged");
                    health -= 1.5f;
                    Console.WriteLine(type + " Health: " + health);
                }
                else if (health <= 0)
                {
                    Console.WriteLine(type + "Failed to Attack");
                    injured = true;

                }
            } else
            {
                Console.WriteLine(type + " Is unable to attack due to being injured");
            }
        }

        public void Heal()
        {
            if (injured && health >= 1)
            {
                Console.WriteLine(type + " Has begone to heal");
                Console.WriteLine("Health: " + health);
                health += 0.8f;
                Console.WriteLine("Health: " + health);
            }
            else
            {
                Console.WriteLine("Unable to heal as to much damage has been done");
            }
        }

        public void retreat()
        {
            if (injured && health <= 0)
            {
                Console.WriteLine(type + "Has retreated from the battle");
            }
            else
            {
                Console.WriteLine("There is no reason to retreat yet");
            }
        }
    }
}
