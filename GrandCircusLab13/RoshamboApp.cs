using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab13
{
    class RoshamboApp : User
    {
        //allows user to play as either Napoleon or Wellington if they so desire

        public RoshamboApp(string name, string roshamboValue)
        {
            Name = name;
            RoshamboValue = roshamboValue;
        }

        public override string GenerateRoshambo()
        {//generates a value dependent on which character is chosen
            if (this.Name == "Wellington")
            {
                this.RoshamboValue = "Rock";
                return this.RoshamboValue;
            }
            else if (this.Name == "Napoleon")
            {
                Random rng = new Random();
                int choice = rng.Next(1, 3);
                Array values = Enum.GetValues(typeof(Roshambo));

                return values.GetValue(rng.Next(values.Length)).ToString();
            }
            else return "";

        }
    }
}
