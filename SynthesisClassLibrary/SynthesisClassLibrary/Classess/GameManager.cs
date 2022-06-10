using SynthesisClassLibrary.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace SynthesisClassLibrary.Classess
{
	public class GameManager
	{
		private List<Match> _matches;
		public GameManager()
		{
			_matches = new List<Match>();
		}

        public GameManager(List<Match> matches)
        {
			_matches = matches;
        }

		public List<Match> GetGames()
		{
			return _matches;
		}

		public List<string> GenerateGames(Tournament tournament)
		{
            List<Match> matches = new List<Match>();
			List<string> schedule = new List<string>();
            List<Player> players = tournament.GetPlayerManager().GetPlayers();
			if(players.Count %2 != 0)
            {
				schedule.Add("----------");
            }
            int counter = 0;
            int games = (players.Count - 1);

            List<string> teams = new List<string>();

            for (int i = 1; i < players.Count; i++)
            {
                teams.Add(players[i].ToString());
            }

            int teamsSize = teams.Count;

            for (int game = 0; game < games; game++)
            {
                schedule.Add($"Round {game + 1}");

                int teamIdx = game % teamsSize;

                schedule.Add($"Game{++counter}: {teams[teamIdx]} vs {players[0].ToString()}" );
                matches.Add(new Match(players[teamIdx], players[0]));

                for (int idx = 1; idx < (players.Count / 2); idx++)
                {
                    int firstTeam = (game + idx) % teamsSize;
                    int secondTeam = (game + teamsSize - idx) % teamsSize;
                    schedule.Add($"Game {++counter}: {teams[firstTeam]} vs {teams[secondTeam]}");
                    matches.Add(new Match(players[firstTeam], players[secondTeam]));
                }
            }

            if(!(matches == _matches))
            {
                AddMatches(matches, tournament.Id);
                _matches = matches;
            }

            return schedule;
		}

        private void AddMatches(List<Match> matches, int id)
        {

            MatchDataHelper dh = new MatchDataHelper();
            for(int i = 0; i < matches.Count; i++)
            {
                if(matches[i] != _matches[i])
                {
                    dh.AddMatch(matches[i], id);
                }
            }
        }

        public void ScoreMatch(int id, int score1, int score2, Sport sport)
        {
            MatchDataHelper dh = new MatchDataHelper();
            foreach(Match match in _matches)
            {
                if(id == match.Id)
                {
                    match.AddScore(score1, score2, sport);
                    dh.ScoreMatch(match);
                }
            }
        }
	}
}
