using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace domashna_football_2201561029
{
    public class Game
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public List<Goal> Goals { get; set; }
        public string Result { get; set; }
        public Team Winner { get; set; }

        public Game(Team team1, Team team2, Referee referee)
        {
            Team1 = team1;
            Team2 = team2;
            Referee = referee;
            Goals = new List<Goal>();
        }

        public void PrintResult()
        {
            Console.WriteLine($"Goals:");
            foreach (var goal in Goals)
            {
                Console.WriteLine($"- Minute: {goal.Minute}, Player: {goal.Player.Name}, Team: {goal.Player.Team.Coach.Name}");
            }
            Console.WriteLine($"--End of the Match--");
            Console.WriteLine($"Game Result: {Result}");
            if (Winner != null)
            {
                Console.WriteLine($"Winner: {Winner.Coach.Name}'s Team");
            }
            else
            {
                Console.WriteLine("The game ended in a draw.");
            }
        }
    }
}
