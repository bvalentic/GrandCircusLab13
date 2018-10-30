using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab13
{
    public abstract class Player
    {
        private string name;
        private string roshamboValue;

        public string Name { get { return name; } set { name = value; } }
        public string RoshamboValue { get { return roshamboValue; } set { roshamboValue = value; } }

        public Player (string name, string roshamboValue)
        {//this constructor isn't necessary 
         //but I wanted to do some more class practice
            Name = name;
            RoshamboValue = roshamboValue;
        }

        public Player()
        {//Player needs a default constructor so the subclasses can have one
        }

        public abstract string GenerateRoshambo();
    }
}
