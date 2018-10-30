using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab13
{
    public class Validator
    {
        public static int CheckNum(string promptString, string errorMessage, int minInt, int maxInt)
        {//displays a prompt, returns an error if the input isn't in the allowed range
            Console.WriteLine(promptString);
            int inputNum;
            string inputString = Console.ReadLine();
            while (!(int.TryParse(inputString, out inputNum)) || int.Parse(inputString) < minInt || int.Parse(inputString) > maxInt)
            {
                Console.Write("I'm sorry, I don't understand. " + errorMessage);
                inputString = Console.ReadLine();
            }
            return inputNum;
        }

        public static bool PlayAgain()
        {//allows user to continue playing their opponent if they so wish
            bool playAgain = true;
            Console.Write("\nWould you like to play again? (y/n) ");
            string playString = Console.ReadLine().ToLower();
            while (!(playString == "yes" || playString == "y" || playString == "no" || playString == "n"))
            {
                Console.Write("I'm sorry, I didn't understand. Please input a \"yes\" or \"no\": ");
                playString = Console.ReadLine();
            }
            if (playString == "yes" || playString == "y")
            {
                Console.WriteLine("\nOkay!\n");
                return true;
            }
            else if (playString == "no" || playString == "n")
            {
                return false;
            }
            return playAgain;
        }
    }


}
