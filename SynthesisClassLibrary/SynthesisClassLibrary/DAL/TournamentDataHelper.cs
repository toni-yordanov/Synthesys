using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using SynthesisClassLibrary.Classess;

namespace SynthesisClassLibrary.DAL
{
	public class TournamentDataHelper : ITournamentDAL 
	{
		private string con;

		public TournamentDataHelper()
		{
			con = "Server=studmysql01.fhict.local;Uid=dbi451143;Database=dbi451143;Pwd=1;SSL Mode=None;";
		}

		public void AddTournament(Tournament t)
		{
			string sql = "INSERT INTO tournaments(information, Name, startTime, minPlayers, maxPlayers, address, sportType) " +
				"VALUES (@information,  @Name, @startTime, @minPlayers, @maxPlayers, @address, @sportType)";



			MySqlConnection databaseConnection = new MySqlConnection(con);
			
			MySqlCommand commandDatabase = new MySqlCommand(sql, databaseConnection);
			try
			{
				commandDatabase.Parameters.AddWithValue("@Name", t.Name);
				commandDatabase.Parameters.AddWithValue("@startTime", t.StartTime);
				commandDatabase.Parameters.AddWithValue("@minPlayers", t.MinPlayers);
				commandDatabase.Parameters.AddWithValue("@maxPlayers", t.MaxPlayers);
				commandDatabase.Parameters.AddWithValue("@sportType", t.Sport.ToString());
				commandDatabase.Parameters.AddWithValue("@address", t.Address);
				commandDatabase.Parameters.AddWithValue("@information", t.Information);



				databaseConnection.Open();

				commandDatabase.ExecuteNonQuery();
				


			}
			catch (Exception e)
			{

			}
			finally
			{
				databaseConnection.Close();
			}

		}

		

		public void DeleteTournament(int id)
		{
			string sql = "Delete from tournaments where id = @id";



			MySqlConnection databaseConnection = new MySqlConnection(con);

			MySqlCommand commandDatabase = new MySqlCommand(sql, databaseConnection);
			try
			{
				commandDatabase.Parameters.AddWithValue("@id",id);

				databaseConnection.Open();

				commandDatabase.ExecuteNonQuery();

			}
			catch (Exception e)
			{

			}
			finally
			{
				databaseConnection.Close();
			}
		}

		public List<Tournament> GetTournaments()
		{
			MatchDataHelper dh1 = new MatchDataHelper();
			List<Tournament> tournaments = new List<Tournament>();
			string sql = "SELECT id, information, Name, startTime, minPlayers, maxPlayers, address, sportType  FROM tournaments";

			MySqlConnection databaseConnection = new MySqlConnection(con);

			MySqlCommand commandDatabase = new MySqlCommand(sql, databaseConnection);
			try
			{
				PlayerDataHelper dh = new PlayerDataHelper();
				databaseConnection.Open();

				MySqlDataReader dr = commandDatabase.ExecuteReader();
                while (dr.Read())
                {
					Tournament tournament = new Tournament((int)dr[0], dr[1].ToString(), dr[2].ToString(), (DateTime)dr[3], (int)dr[4], (int)dr[5], dr[6].ToString() ,dr[7].ToString() , dh1.GetMatches((int)dr[0]), dh.GetPlayersFromTournament((int)dr[0]));
					tournaments.Add(tournament);
                }


			}
			catch (Exception e)
			{

			}
			finally
			{
				databaseConnection.Close();
			}
			return tournaments;
		}

		public Tournament GetTournament(int id)
		{
			MatchDataHelper dh1 = new MatchDataHelper();
			Tournament tournament = null;
			string sql = "SELECT id, information, Name, startTime, minPlayers, maxPlayers, address, sportType  FROM tournaments where id = @id";

			MySqlConnection databaseConnection = new MySqlConnection(con);

			MySqlCommand commandDatabase = new MySqlCommand(sql, databaseConnection);
			commandDatabase.Parameters.AddWithValue("@id", id);
			try
			{
				PlayerDataHelper dh = new PlayerDataHelper();
				databaseConnection.Open();

				MySqlDataReader dr = commandDatabase.ExecuteReader();
				while (dr.Read())
				{
					tournament = new Tournament((int)dr[0], dr[1].ToString(), dr[2].ToString(), (DateTime)dr[3], (int)dr[4], (int)dr[5], dr[6].ToString(), dr[7].ToString(),dh1.GetMatches((int)dr[0]), dh.GetPlayersFromTournament((int)dr[0]));
				}


			}
			catch (Exception e)
			{

			}
			finally
			{
				databaseConnection.Close();
			}
			return tournament;
		}

		
	}
	
}
