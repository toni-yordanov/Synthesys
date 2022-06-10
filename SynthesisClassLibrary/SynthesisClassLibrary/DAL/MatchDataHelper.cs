using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using SynthesisClassLibrary.Classess;

namespace SynthesisClassLibrary.DAL
{
	public class MatchDataHelper : IMatchDAL
	{
		private string con;

        public MatchDataHelper()
        {
            con = "Server=studmysql01.fhict.local;Uid=dbi451143;Database=dbi451143;Pwd=1;SSL Mode=None;";
            
        }

		public void AddMatch(Match m, int tournamentId)
		{
            string sql = "INSERT INTO matches(playerId1, playerId2, tournamentID) VALUES (@playerId1,playerId2,@tournamentID)";

            MySqlConnection conn = new MySqlConnection(con);
            try
            {
                conn.Open();
                MySqlCommand cmd1 = new MySqlCommand(sql, conn);
                cmd1.Parameters.AddWithValue("@playerId1", m.Player1.Id);
                cmd1.Parameters.AddWithValue("@playerId2", m.Player2.Id);
                cmd1.Parameters.AddWithValue("@tournamentID", tournamentId);
                cmd1.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
        }

		public List<Match> GetMatches(int tournamentId)
		{
            List<Match> matches = new List<Match>();
            PlayerManager playerManager = new PlayerManager();
            string sql = "Select * From matches Where tournamentID = @tournamentID";

            MySqlConnection conn = new MySqlConnection(con);
            try
            {
                conn.Open();
                MySqlCommand cmd1 = new MySqlCommand(sql, conn);
                cmd1.Parameters.AddWithValue("@tournamentID", tournamentId);

                MySqlDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    if(dr[1] == null)
                    {
                        Match match = new Match((int)dr[0], playerManager.GetPlayer((int)dr[3]), playerManager.GetPlayer((int)dr[4]));
                        matches.Add(match);
                    }
                    else
                    {
                        Match match = new Match((int)dr[0], (int)dr[1], (int)dr[2], playerManager.GetPlayer((int)dr[3]), playerManager.GetPlayer((int)dr[4]));
                        matches.Add(match);
                    }
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return matches;
        }

		public Match GetMatch(int id)
		{
            Match match = null;
            PlayerManager playerManager = new PlayerManager();
            string sql = "Select * From matches Where id = @id";

            MySqlConnection conn = new MySqlConnection(con);
            try
            {
                conn.Open();
                MySqlCommand cmd1 = new MySqlCommand(sql, conn);
                cmd1.Parameters.AddWithValue("@id", id);

                MySqlDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[1] == null)
                    {
                        match = new Match((int)dr[0], playerManager.GetPlayer((int)dr[3]), playerManager.GetPlayer((int)dr[4]));
                    }
                    else
                    {
                        match = new Match((int)dr[0], (int)dr[1], (int)dr[2], playerManager.GetPlayer((int)dr[3]), playerManager.GetPlayer((int)dr[4]));
                    }
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return match;
        }

        public void ScoreMatch(Match match)
        {
            string sql = "INSERT INTO matches(score1, score2, winer) VALUES (@score1,score2,@winer)";

            MySqlConnection conn = new MySqlConnection(con);
            try
            {
                conn.Open();
                MySqlCommand cmd1 = new MySqlCommand(sql, conn);
                cmd1.Parameters.AddWithValue("@score1", match.Score1);
                cmd1.Parameters.AddWithValue("@score2", match.Score2);
                cmd1.Parameters.AddWithValue("@winer", match.Winer);
                cmd1.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
