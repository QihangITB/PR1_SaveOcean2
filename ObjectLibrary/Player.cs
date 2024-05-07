using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLibrary
{
    public class Player
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public int Experience { get; set; }

        public Player(string name, string role, int experiencePoints)
        {
            Name = name;
            Role = role;
            Experience = experiencePoints;
        }

    }
}
