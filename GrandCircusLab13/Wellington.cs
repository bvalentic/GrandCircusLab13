using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab13
{
    public class Wellington : Player
    {//inherits from Player but only has a default constructor and one method
        public string name;
        public string roshamboValue;        

        public Wellington()
        {//there isn't a reason to give this another name
            Name = "Wellington";
            RoshamboValue = GenerateRoshambo();
        }

        public override string GenerateRoshambo()
        {//the fact this is a method instead of just using the constructor is because 
         //the other methods call GenerateRoshambo so I need it to exist
            return "Rock";
        }
    }
}
