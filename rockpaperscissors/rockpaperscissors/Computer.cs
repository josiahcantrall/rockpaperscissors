using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissors
{
    public class Computer : Player
    {

        public override void chooseName()
        {
            name = ("Computer");
        }

        public override void ThrowSign()
        {
            Random random = new Random();
            playerChoice = random.Next(0, 4);
            

            if (playerChoice == 0) 
            {
                
                Console.WriteLine("The computer has played rock");
            }

            else if (playerChoice == 1)
            {

                Console.WriteLine("The computer has played paper");
            }

            else if (playerChoice == 2)
            {

                Console.WriteLine("The computer has played scissors");
            }

            else if (playerChoice == 3)
            {

                Console.WriteLine("The computer has played spock");
            }

            else if (playerChoice == 4)
            {

                Console.WriteLine("The computer has played lizzard");
            }
        }
    }
}
