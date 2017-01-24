using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissors
{
    class rockpaperscissors
    {
        Player playerOne;
        Player playerTwo;
        public void StartGame()
        {

            ChooseNumberOfPlayers();
            playerOne.chooseName();
            playerTwo.chooseName();
            PlayOneRound();
            TrackGamesWon();
            Console.ReadKey();



            //    case "2 Player":
            //        Console.WriteLine("Player One you play first. Please enter Rock, Paper, Scissors, Lizard, Spock ");
            //        answer = Console.ReadLine().ToLower();
                        Console.WriteLine("Player One you play first. Please enter Rock, Paper, Scissors, Lizard, Spock ");
            //        answer = Console.ReadLine().ToLower();
            //        
        }
        public void PlayOneRound ()
        {
            playerOne.ThrowSign();
            playerTwo.ThrowSign();
            int playerWhoWon = WinGame();
            DisplayWinner(playerWhoWon);
            CalculateGamesWon(playerWhoWon);
            RepeatGame();

        }


        public void ChooseNumberOfPlayers()
        {
            Console.WriteLine("Do you want to play 1 Player or 2 Player? Type 1 or 2");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                playerOne = new Human();
                playerTwo = new Computer();
            }
            else if (choice == "2")
                    {
                playerOne = new Human();
                playerTwo = new Human();
            }


        }
        public int WinGame() {

            int result = (5 + playerOne.playerChoice - playerTwo.playerChoice) % 5;
            int playerWhoWon = 0;
            if (result == 1 || result == 3)
            {
                playerWhoWon = 1;
            }
            else if (result == 2 || result == 4)
            {
                playerWhoWon = 2;
            }
            else if (result == 0)
            {
                playerWhoWon = 3;
            }

            return playerWhoWon;
        }

        public void DisplayWinner(int playerWhoWon)
        {
            switch (playerWhoWon)
            {
                case 1:
                    Console.WriteLine("Congrats. Player One has won this round!");
                    break;
                case 2:
                    Console.WriteLine("Congrats. Player Two has won this round!");
                    break;
                case 3:
                    Console.WriteLine("Nice try, but it's a tie!");
                    break;


            }

        }

        public void RepeatGame()
        {
            if (playerOne.gamesWon < 2 && playerTwo.gamesWon <2)
            PlayOneRound();
        }

        public void TrackGamesWon()
        {
            if (playerOne.gamesWon == 2)
            {
                Console.WriteLine("Congrats. Player One has won this entire game!");
            }
            else if (playerTwo.gamesWon == 2)
            {
                Console.WriteLine("Congrats. Player Two has won this entire game!");
            }

        }

        public void CalculateGamesWon(int playerWhoWon)
        {
            switch (playerWhoWon)
            {
                case 1:
                    playerOne.gamesWon++;
                    break;
                case 2:
                    playerTwo.gamesWon++;
                    break;
                case 3:
                    break;


            }
        }

    }
    }

