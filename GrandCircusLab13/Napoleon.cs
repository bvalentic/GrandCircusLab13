using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab13
{
    public class Napoleon : Player
    {//inherits from Player but uses only a default constructor and one method
        public string name;
        public string roshamboValue;

        public Napoleon()
        {
            Name = "Napoleon";
            RoshamboValue = GenerateRoshambo();
        }

        public override string GenerateRoshambo()
        {//randomly generates one of the three available values and returns it as a string
            Random rng = new Random();
            int choice = rng.Next(1, 3);
            Array values = Enum.GetValues(typeof(Roshambo));

            return values.GetValue(rng.Next(values.Length)).ToString();

        }

    }
}
