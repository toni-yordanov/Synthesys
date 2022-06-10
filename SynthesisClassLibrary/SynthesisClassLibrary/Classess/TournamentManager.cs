using System;
using System.Collections.Generic;
using System.Text;
using SynthesisClassLibrary.DAL;

namespace SynthesisClassLibrary.Classess
{
	public class TournamentManager
	{
		private List<Tournament> _tournamentList;
		private ITournamentDAL _dh;
		public TournamentManager(ITournamentDAL dh)
		{
			_dh = dh;
			_tournamentList = dh.GetTournaments();
		}

		public void CreateTournament(Tournament t)
		{
			_dh.AddTournament(t);
		}

		public void DeleteTournament(int id)
		{
			_dh.DeleteTournament(id);
		}

		public List<Tournament> GetTournaments()
		{
			return _dh.GetTournaments();
		}

		public Tournament GetTournament(int id)
		{
			return _dh.GetTournament(id);
		}
	}
}
