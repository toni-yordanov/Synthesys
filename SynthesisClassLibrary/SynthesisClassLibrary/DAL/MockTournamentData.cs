using System;
using System.Collections.Generic;
using System.Text;
using SynthesisClassLibrary.Classess;

namespace SynthesisClassLibrary.DAL
{
	public class MockTournamentData : ITournamentDAL
	{
		List<Tournament> tournamentList;
		public MockTournamentData()
		{
			tournamentList = new List<Tournament>();
		}

		public void AddTournament(Tournament t)
		{
			tournamentList.Add(t);
		}

		public void DeleteTournament(int id)
		{
			for(int i = 0; i < tournamentList.Count; i++)
            {
				if(tournamentList[i].Id == id)
                {
					tournamentList.RemoveAt(i);
                }
            }
		}

		public List<Tournament> GetTournaments()
		{
			return tournamentList;
		}

		public Tournament GetTournament(int id)
		{
			for (int i = 0; i < tournamentList.Count; i++)
			{
				if (tournamentList[i].Id == id)
				{
					return tournamentList[i];
				}
			}
			return null;
		}
	}
}
