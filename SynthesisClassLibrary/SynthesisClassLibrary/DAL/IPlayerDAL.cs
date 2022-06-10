using System;
using System.Collections.Generic;
using System.Text;
using SynthesisClassLibrary.Classess;

namespace SynthesisClassLibrary.DAL
{
	public interface IPlayerDAL
	{
		void AddPlayer(Player p);

		void EditPlayer(Player p);

		void DeletePlayer(int id);

		List<Player> GetPlayers();

		Player GetPlayer(int id);

		List<Match> GetPlayerGames(int id);

		void AssignPlayerTournament(int pId, int tId);
	}
}
