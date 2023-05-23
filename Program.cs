using System;

namespace domashna_football_2201561029
{
    class Program
    {
        static void Main(string[] args)
        {
            Coach coach1 = new Coach("Coach 1", 45);
            Coach coach2 = new Coach("Coach 2", 42);
            AssistantReferee assistantReferee1 = new AssistantReferee("Alex", 30);
            AssistantReferee assistantReferee2 = new AssistantReferee("Boris", 32);
            Team team1 = new Team(coach1, null);
            Team team2 = new Team(coach2, null);
            Football_player[] team1Players = new Football_player[]
            {
            new GoalKeeper("Player 1", 25, 1, 190, team1),
            new Defender("Player 2", 28, 2, 180, team1),
            new Defender("Player 3", 29, 3, 185, team1),
            new Defender("Player 4", 24, 4, 175, team1),
            new Defender("Player 5", 30, 5, 177, team1),
            new Midfield("Player 6", 26, 6, 175, team1),
            new Midfield("Player 7", 27, 7, 180, team1),
            new Midfield("Player 8", 25, 8, 182, team1),
            new Striker("Player 9", 30, 9, 185, team1),
            new Striker("Player 10", 29, 10, 178, team1),
            new Striker("Player 11", 20, 11, 184, team1)
            };

            Football_player[] team2Players = new Football_player[]
            {
            new GoalKeeper("Player 12", 28, 1, 192, team2),
            new Defender("Player 13", 28, 2, 188, team2),
            new Defender("Player 14", 22, 3, 185, team2),
            new Defender("Player 15", 24, 4, 182, team2),
            new Defender("Player 16", 27, 5, 177, team2),
            new Midfield("Player 17", 26, 6, 175, team2),
            new Midfield("Player 18", 25, 7, 187, team2),
            new Midfield("Player 19", 28, 8, 182, team2),
            new Striker("Player 20", 30, 9, 180, team2),
            new Striker("Player 21", 32, 10, 178, team2),
            new Striker("Player 22", 26, 11, 184, team2)
            };

            team1.Players = team1Players;
            team2.Players = team2Players;


            Referee referee = new Referee("Dino", 35);

            Game game = new Game(team1, team2, referee);


            game.Goals.Add(new Goal(10, team1Players[0]));
            game.Goals.Add(new Goal(15, team1Players[0]));
            game.Goals.Add(new Goal(25, team2Players[2]));
            game.Goals.Add(new Goal(30, team2Players[8]));

            int team1Goals = game.Goals.Count(g => g.Player.Team == game.Team1);
            int team2Goals = game.Goals.Count(g => g.Player.Team == game.Team2);

            string result;
            Team winner;

            if (team1Goals > team2Goals)
            {
                result = $"{team1Goals}-{team2Goals}";
                winner = game.Team1;
            }
            else if (team1Goals < team2Goals)
            {
                result = $"{team1Goals}-{team2Goals}";
                winner = game.Team2;
            }
            else
            {
                result = $"{team1Goals}-{team2Goals}";
                winner = null;
            }
            Console.WriteLine($"--Match is starting-");
            Console.WriteLine($"Our referee today is {referee.Name}");
            Console.WriteLine($"Assistant referees are {assistantReferee1.Name} and {assistantReferee2.Name}");
            Console.WriteLine($"The Average age of a team1 players is {team1.PrintAverageAge().ToString("0.00")}");
            Console.WriteLine($"The Average age of a team2 players is {team2.PrintAverageAge().ToString("0.00")}");
            game.Result = result;
            game.Winner = winner;
            game.PrintResult();
        }
    }
}
