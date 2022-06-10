using Microsoft.VisualStudio.TestTools.UnitTesting;
using SynthesisClassLibrary.Classess;
using SynthesisClassLibrary.DAL;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCreateTournament()
        {
            TournamentManager tournamentManager = new TournamentManager(new MockTournamentData());
            string sport = "Karate";
            string information = "Some information";
            string name = "name";
            DateTime date = DateTime.Now;
            int min = 4;
            int max = 8;
            string address = "address";

            Tournament tournament = new Tournament(1, information, name, date, min, max, address, sport);
            tournamentManager.CreateTournament(tournament);

            Assert.AreEqual(tournamentManager.GetTournament(1).Address, address);
            Assert.AreEqual(tournamentManager.GetTournament(1).Name, name);
            Assert.AreEqual(tournamentManager.GetTournament(1).StartTime, date);

        }

    }
}