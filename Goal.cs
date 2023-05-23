using System;
using System.Collections.Generic;
using System.Text;

namespace domashna_football_2201561029
{
    public class Goal
    {
        public int Minute { get; set; }
        public Football_player Player { get; set; }
        public Team Team { get; }

        public Goal(int minute, Football_player player)
        {
            Minute = minute;
            Player = player;
            Team = player.Team;
        }
    }
}
