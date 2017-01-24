using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissors
{
    public class Player
    {
        public string name;
        public int playerChoice;
        public int gamesWon = 0;


        public virtual void chooseName()
        {
            Console.WriteLine("Please type your name");
            name = Console.ReadLine();

        }

        List<string> options = new List<string>();
        
        public Player ()
        {
            options.Add("rock");
            options.Add("paper");
            options.Add("scissors");
            options.Add("spock");
            options.Add("lizzard");
        }

        public virtual void ThrowSign()
        {
            Console.WriteLine(name + " Please type one option: scissors, spock, lizzard, rock, or paper");
            string action = Console.ReadLine();
            playerChoice = options.IndexOf(action);

        }

   

     

        
    }
}
