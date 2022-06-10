using System;
using System.Collections.Generic;
using System.Text;
using SynthesisClassLibrary.DAL;


namespace SynthesisClassLibrary.Classess
{

	public class MockMatchData: IMatchDAL
	{
		private List<Match> matches;
        public MockMatchData()
        {
			matches = new List<Match>();
        }
		public void AddMatch(Match m, int tournamentID)
		{
			matches.Add(m);
		}

		public List<Match> GetMatches(int tournamentId)
		{
			return matches;
		}

		public Match GetMatch(int id)
		{
			foreach(Match m in matches)
            {
				if(m.Id == id)
                {
					return m;
                }
            }
			return null;
		}

        

    }
}
