using Microsoft.VisualStudio.TestTools.UnitTesting;
using SynthesisClassLibrary.Classess;
using SynthesisClassLibrary.DAL;
using System;
using System.Collections.Generic;

namespace TestProjectSynthesis
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

            Tournament tournament = new Tournament(1 ,information, name, date, min, max, address, sport);
            tournamentManager.CreateTournament(tournament);

            Assert.AreEqual(tournamentManager.GetTournament(1).Address, address);
            Assert.AreEqual(tournamentManager.GetTournament(1).Name, name);
            Assert.AreEqual(tournamentManager.GetTournament(1).StartTime, date);

        }

        [TestMethod]
        public void TestPlayerCreation()
        {
            PlayerManager playerManager = new PlayerManager(new MockPlayerData());
            string email = "email@email";
            string password = "pass";
            string name = "name";
            DateTime date = DateTime.Now;
            string address = "address";

            Player player = new Player(1, name, email, address, password, date);
            playerManager.CreatePlayer(player);

            Assert.AreEqual(playerManager.GetPlayer(1).Address, address);
            Assert.AreEqual(playerManager.GetPlayer(1).Name, name);
            Assert.AreEqual(playerManager.GetPlayer(1).BirthDate, date);

        }

        [TestMethod]
        public void TestAddingResults()
        {
            List<Match> list = new List<Match>();
            Match match = new Match(0, new Player(), new Player());
            Match match2 = new Match(1, new Player(), new Player());
            Match match3 = new Match(2, new Player(), new Player());
            Match match4 = new Match(3, new Player(), new Player());
            list.Add(match);
            list.Add(match2);
                
            list.Add(match3);
            list.Add(match4);
            int score1 = 9;
            int score2 = 12;
            GameManager gameManager = new GameManager(list);
            gameManager.ScoreMatch(0, score1, score2, new Karate());

            Assert.AreEqual(gameManager.GetGames()[0].Score1, score1);
            Assert.AreEqual(gameManager.GetGames()[0].Score2, score2);
            Assert.AreEqual(gameManager.GetGames()[0].Winer, 2);
        }
        [TestMethod]
        public void TestPlayerUpdate()
        {
            PlayerManager playerManager = new PlayerManager(new MockPlayerData());
            string email = "email@email";
            string password = "pass";
            string name = "name";
            DateTime date = DateTime.Now;
            string address = "address";

            Player player = new Player(1, name, email, address, password, date);
            playerManager.CreatePlayer(player);

            Assert.AreEqual(playerManager.GetPlayer(1).Address, address);
            Assert.AreEqual(playerManager.GetPlayer(1).Name, name);

            string newAddress = "new Address";
            string newName = "new Name";
            player.Name = newName;
            player.Address = newAddress;

            playerManager.EditPlayer(player);

            Assert.AreEqual(playerManager.GetPlayer(1).Address, newAddress);
            Assert.AreEqual(playerManager.GetPlayer(1).Name, newName);

        }

    }
}