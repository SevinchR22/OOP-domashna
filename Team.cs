using System;
using System.Collections.Generic;
using System.Text;

namespace domashna_football_2201561029
{
    public class Team
    {
        public Coach Coach { get; set; }
        public Football_player[] Players { get; set; }
        public double AverageAge => Math.Round(Players.Average(p => p.Age));

        public Team(Coach coach, Football_player[] players)
        {
            Coach = coach;
            Players = players;
        }
        public double PrintAverageAge()
        {
            int totalAge = 0;
            int playerCount = 0;

            foreach (Football_player player in Players)
            {
                if (player != null)
                {
                    totalAge += player.Age;
                    playerCount++;
                }
            }

            if (playerCount > 0)
            {
                return (double)totalAge / playerCount;
            }
            else
            {
                return 0;
            }
        }
    }
}
