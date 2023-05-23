using System;
using System.Collections.Generic;
using System.Text;

namespace domashna_football_2201561029
{
     public class Striker:Football_player
    {
        public Striker(string name, int age, int number, double height, Team team) : base(name, age, number, height)
        {
            Team = team;
        }
    }
}
