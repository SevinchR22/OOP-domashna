using System;
using System.Collections.Generic;
using System.Text;

namespace domashna_football_2201561029
{
    public class GoalKeeper:Football_player
    {
        public Goalkeeper(string name, int age, int number, double height, Team team) : base(name, age, number, height)
        {
            Team = team;
        }
    }
}
