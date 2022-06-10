using System;
using System.Collections.Generic;
using System.Text;
using SynthesisClassLibrary.Classess;

namespace SynthesisClassLibrary.DAL
{
	public interface IMatchDAL
	{
		void AddMatch(Match m, int tournamentID);

		List<Match> GetMatches(int tournamentId);

		Match GetMatch(int id);
	}
}
