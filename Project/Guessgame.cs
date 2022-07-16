using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    internal class Guessgame
    {
        public static void guess()
        {
            //Variuables
            string secretword = "Commander";
            string guess = "";
            int tries = 10;
            // bools = true or false
            bool guesses = false;
            bool end = false;

            // while guess is not commander and guesses and end are false the loop will continue
            while (guess != secretword && !guesses && !end)
            {
                // Checks to see if tries are above or equal to 1
                if (tries >= 1)
                {

                    Console.Write("Enter Guess: ");
                    guess = Console.ReadLine();
                    //Checks to see if guess is equal to the secretword
                    if (guess == secretword)
                    {
                        //sets guesses to true which breaks the loop
                        guesses = true;
                        Console.WriteLine("Congrats you have won with " + tries + " tries left, the correct word was " + secretword);
                    }
                    else
                    {
                        //takes 1 try away from tries everytime it's run
                        tries--;
                        Console.WriteLine("Try Again, You have " + tries + " Left");
                    }
                }
                else
                {
                    //Changes end to true which also breaks the loop
                    end = true;
                    Console.WriteLine("You have failed to guess correctly and have used up all of you're tries");
                }
            }

            Console.ReadLine();
        }
    }
}
