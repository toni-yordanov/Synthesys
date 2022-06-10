using System;
using System.Collections.Generic;
using System.Text;
using SynthesisClassLibrary.Classess;

namespace SynthesisClassLibrary.DAL
{
	public interface ITournamentDAL
	{
		void AddTournament(Tournament t);

		void DeleteTournament(int id);

		List<Tournament> GetTournaments();

		Tournament GetTournament(int id);
	}
}
