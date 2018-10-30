using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab13
{
    class User : Player
    {
        public User()
        {//default constructor used in CreateUser method
         //originally I had a more detailed constructor but found there wasn't a use for it
            Name = "Player1";
            RoshamboValue = "Scissors";
            //the default value of scissors is so by default the player would beat Wellington
            //if somehow a string wasn't passed 
        }

        public override string GenerateRoshambo()
        {//allows user to choose their weapon
            Console.WriteLine("Rock, paper, or scissors?");            
            int inputNum = Validator.CheckNum($@"1 -- Rock
2 -- Paper
3 -- Scissors
", "Please enter a number between 1 and 3: ", 1, 3);
            return Enum.GetName(typeof(Roshambo), inputNum);
        }

        public static User CreateUser()
        {//gives the user in Main a name, ideally the user's name
            User user = new User();
            Console.Write("Enter your name: ");
            user.Name = Console.ReadLine();
            if (user.Name == "")
            {
                user.Name = "Player1";
            }
            Console.WriteLine($"Input received: {user.Name}");
            return user;
        }
    }
}
