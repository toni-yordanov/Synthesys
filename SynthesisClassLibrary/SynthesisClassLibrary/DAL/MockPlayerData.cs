using System;
using System.Collections.Generic;
using System.Text;
using SynthesisClassLibrary.Classess;

namespace SynthesisClassLibrary.DAL
{
	public class MockPlayerData : IPlayerDAL
	{
		List<Player> players;
		public MockPlayerData()
		{
			players = new List<Player>();
		}

		public void AddPlayer(Player p)
		{
			players.Add(p);
		}

		public void EditPlayer(Player p)
		{
			for(int i = 0; i < players.Count; i++)
            {
				if(players[i].Id == p.Id)
                {
					players[i] = p;
                }
            }
		}

		public void DeletePlayer(int id)
		{
			for (int i = 0; i < players.Count; i++)
			{
				if (players[i].Id == id)
				{
					players.RemoveAt(i);
				}
			}
		}

		public List<Player> GetPlayers()
		{
			return players;
		}

		public Player GetPlayer(int id)
		{
			for (int i = 0; i < players.Count; i++)
			{
				if (players[i].Id == id)
				{
					return players[i];
				}
			}
			return null;

		}

		

		public List<Match> GetPlayerGames(int id)
		{
			return null;
		}

        public void AssignPlayerTournament(int pId, int tId)
        {
			//throw new NotImplementedException();
        }
    }
}
