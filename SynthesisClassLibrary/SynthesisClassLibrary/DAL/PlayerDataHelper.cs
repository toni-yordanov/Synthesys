using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using SynthesisClassLibrary.Classess;

namespace SynthesisClassLibrary.DAL
{
	public class PlayerDataHelper : IPlayerDAL
	{
		private string con;

		public PlayerDataHelper()
		{
			con = "Server=studmysql01.fhict.local;Uid=dbi451143;Database=dbi451143;Pwd=1;SSL Mode=None;";
		}

		public void AddPlayer(Player p)
		{
			MySqlConnection conn = new MySqlConnection(con);
			try
			{
				string sql = "INSERT INTO player(name, email, password, address, birthDate) VALUES (@name, @email, @password, @address, @birthDate)";
				MySqlCommand command = new MySqlCommand(sql, conn);
				command.Parameters.AddWithValue("@name", p.Name);
				command.Parameters.AddWithValue("@email", p.Email);
				command.Parameters.AddWithValue("@password", p.Password);
				command.Parameters.AddWithValue("@address", p.Address);
				command.Parameters.AddWithValue("@birthDate", p.BirthDate);
				conn.Open();

				command.ExecuteNonQuery();


			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				conn.Close();
			}
		}

		public void EditPlayer(Player p)
		{
			MySqlConnection conn = new MySqlConnection(con);
			try
			{
				string sql = "Update player set name = @name, email = @email, password = @password where id = @id";
				MySqlCommand command = new MySqlCommand(sql, conn);
				command.Parameters.AddWithValue("@name", p.Name);
				command.Parameters.AddWithValue("@email", p.Email);
				command.Parameters.AddWithValue("@password", p.Password);
				command.Parameters.AddWithValue("@id", p.Id);
				conn.Open();

				command.ExecuteNonQuery();


			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				conn.Close();
			}
		}

		public void DeletePlayer(int id)
		{
			MySqlConnection conn = new MySqlConnection(con);
			try
			{
				string sql = "Delete from player where id = @id";
				MySqlCommand command = new MySqlCommand(sql, conn);
				command.Parameters.AddWithValue("@id", id);
				conn.Open();

				command.ExecuteNonQuery();


			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				conn.Close();
			}
		}

		public List<Player> GetPlayers()
		{
			List<Player> players = new List<Player>();
			MySqlConnection conn = new MySqlConnection(con);
			try
			{
				string sql = "SELECT * FROM player";
				MySqlCommand command = new MySqlCommand(sql, conn);
				conn.Open();

				MySqlDataReader dr = command.ExecuteReader();
				while (dr.Read())
				{
					Player account = new Player((int)dr[0], dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), (DateTime)dr[5]);
					players.Add(account);
				}

			}
			catch (Exception ex)
			{

			}
			finally
			{
				conn.Close();
			}
			return players;
		}

        internal List<Player> GetPlayersFromTournament(int id)
        {
            List<Player> players = new List<Player> ();
			MySqlConnection conn = new MySqlConnection(con);
			try
			{
				string sql = "SELECT playerId FROM player_tournament  where tournametId = @id";
				MySqlCommand command = new MySqlCommand(sql, conn);
				command.Parameters.AddWithValue("@id", id);
				conn.Open();

				MySqlDataReader dr = command.ExecuteReader();
				while (dr.Read())
				{
					players.Add(GetPlayer((int)dr[0]));

				}

			}
			catch (Exception ex)
			{
				return null;

			}
			finally
			{
				conn.Close();
			}
			return players;
		}

        public Player GetPlayer(int id)
		{
			Player account = null;
			MySqlConnection conn = new MySqlConnection(con);
			try
			{
				string sql = "SELECT * FROM acount where id = @id";
				MySqlCommand command = new MySqlCommand(sql, conn);
				command.Parameters.AddWithValue("@id", id);
				conn.Open();

				MySqlDataReader dr = command.ExecuteReader();
				while (dr.Read())
				{
					account = new Player((int)dr[0], dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), (DateTime)dr[5]);
					
				}

			}
			catch (Exception ex)
			{
				return null;

			}
			finally
			{
				conn.Close();
			}
			return account;
		}

		public List<Match> GetPlayerGames(int id)
		{
			List<Match> matches = new List<Match>();


			string sql = "SELECT *  FROM tournaments where playerId = @id";

			MySqlConnection databaseConnection = new MySqlConnection(con);

			MySqlCommand commandDatabase = new MySqlCommand(sql, databaseConnection);
			try
			{
				PlayerDataHelper dh = new PlayerDataHelper();

				databaseConnection.Open();

				commandDatabase.Parameters.AddWithValue("@id", id);

				MySqlDataReader dr = commandDatabase.ExecuteReader();
				while (dr.Read())
				{
					Match match = new Match((int)dr[0], (int)dr[1], (int)dr[2], dh.GetPlayer((int)dr[3]), dh.GetPlayer((int)dr[4]));
					matches.Add(match);
				}

				return matches;

			}
			catch (Exception e)
			{

			}
			finally
			{
				databaseConnection.Close();
			}
			return matches;
		}

        public void AssignPlayerTournament(int pId, int tId)
        {
			MySqlConnection conn = new MySqlConnection(con);
			try
			{
				string sql = "INSERT INTO player_tournament(playerId, tournamentId) VALUES (@playerId, @tournamentId)";
				MySqlCommand command = new MySqlCommand(sql, conn);
				command.Parameters.AddWithValue("@playerId", pId);
				command.Parameters.AddWithValue("@tournamentId", tId);
				conn.Open();

				command.ExecuteNonQuery();


			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				conn.Close();
			}
		}
    }
}
