using System;
using System.Collections.Generic;
using System.Text;

namespace domashna_football_2201561029
{
     public class Midfield:Football_player
    {
        public Midfield(string name, int age, int number, double height, Team team) : base(name, age, number, height)
        {
            Team = team;
        }
    }
}
