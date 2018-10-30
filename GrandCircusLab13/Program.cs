using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GrandCircusLab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Napoleon napoleon = new Napoleon();
            Wellington wellington = new Wellington();
            //generates an instance of each opponent

            int[] winLossArray = new int[] { 0, 0, 0 };
            //allows game to keep track of your w/l/d record

            Console.WriteLine("It's rock-paper-scissors time!\n");

            bool playAgain = true;

            User user = ChoosePlayer();
            int oppoChoice = ChooseOpponent();

            while (playAgain)
            {
                if (oppoChoice == 1)
                {
                    winLossArray = Shoot(napoleon, user, winLossArray);
                }
                else if (oppoChoice == 2)
                {
                    winLossArray = Shoot(wellington, user, winLossArray);
                }
                playAgain = Validator.PlayAgain();
            }
            Quitter(winLossArray);
        }

        static User ChoosePlayer()
        {
            int playerChoice = Validator.CheckNum(@"Choose a character to play as, or play as yourself:
1 -- Play as self
2 -- Napoleon (randomly chooses)
3 -- Wellington (always chooses rock)
(Warning: choosing a character means you cannot input rock/paper/scissors)", 
"Please enter a number between 1 and 3.", 1, 3);
            if (playerChoice == 1)
            {
                User user = User.CreateUser();
                return user;
            }
            else if (playerChoice == 2)
            {                
                User user = new RoshamboApp("Napoleon", "Rock");
                return user;
            }
            else
            {
                User user = new RoshamboApp("Wellington", "Rock");
                return user;
            }
            
        }

        static int ChooseOpponent()
        {//allows user to choose between the two available opponent classes and display it
            int oppoChoice = Validator.CheckNum($@"Which opponent would you like to play?
1 -- Napoleon (randomly chooses)
2 -- Wellington (always chooses rock)", 
"Please enter either 1 or 2: ", 1, 2);
            string[] oppoArray = new string[] { "Napoleon", "Wellington" };
            //quick way to display which opponent user has chosen
            Console.WriteLine($"Opponent chosen: {oppoArray[oppoChoice-1]}");
            return oppoChoice;
        }

        static void Quitter(int[] winLossArray)
        {//displays win/loss/draw stats and a goodbye message
            Console.WriteLine($"\nWins: {winLossArray[0],-8}");
            Console.WriteLine($"Losses: {winLossArray[1],-8}");
            Console.WriteLine($"Draws: {winLossArray[2],-8}");
            Console.WriteLine("\nThanks for playing!\n");
            Console.ReadKey();
        }

        static int[] Shoot(Player opponent, User user, int[] winLossArray)
        {//does the actual "rock, paper, scissors, shoot" and determines the winner
            string oppoString = opponent.GenerateRoshambo();
            string userString = user.GenerateRoshambo();
            //has each user make their pick before throwing
            bool userWin = true;

            Console.WriteLine("Rock. . .");
            Thread.Sleep(500); //used a delay here to simulate the actual game being played
            Console.WriteLine("Paper. . .");
            Thread.Sleep(500);
            Console.WriteLine("Scissors. . .");
            Thread.Sleep(500);
            Console.WriteLine("Shoot!\n");
            //I personally always include "shoot" in my rock-paper-scissors games
            Console.Write($"{user.Name} throws {userString}! ");
            Console.WriteLine($"{opponent.Name} throws {oppoString}!");            

            if(userString == oppoString)
            {
                Console.WriteLine("Draw!");
                winLossArray[2]++;
                return winLossArray;
            }

            if (userString == "Rock")
            {
                if (oppoString == "Paper")
                {
                    Console.Write("Paper covers rock! ");
                    userWin = false;
                }
                else if (oppoString == "Scissors")
                {
                    Console.Write("Rock smashes scissors! ");
                    userWin = true;
                }
            }
            else if(userString == "Paper")
            {
                if (oppoString == "Rock")
                {
                    Console.Write("Paper covers rock! ");
                    userWin = true;
                }
                else if (oppoString == "Scissors")
                {
                    Console.Write("Scissors cut paper! ");
                    userWin = false;
                }
            }
            else if(userString == "Scissors")
            {
                if (oppoString == "Paper")
                {
                    Console.Write("Scissors cut paper! ");
                    userWin = true;
                }
                else if (oppoString == "Rock")
                {
                    Console.Write("Rock smashes scissors! ");
                    userWin = false;
                }
            }

            if (userWin)
            {
                Console.WriteLine($"{user.Name} wins!");
                winLossArray[0]++;
            }

            else
            {
                Console.WriteLine($"{opponent.Name} wins!");
                winLossArray[1]++;
            }

            return winLossArray;
        }
    }
}
