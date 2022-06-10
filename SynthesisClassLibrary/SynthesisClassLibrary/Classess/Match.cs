using System;
using System.Collections.Generic;
using System.Text;

namespace SynthesisClassLibrary.Classess
{
	public class Match
	{
		private int _id;
		private int _score1;
		private int _score2;
		private int _winer;
		private Player _player1;
		private Player _player2;

		public int Id
		{
			get
			{
				return _id;
			}
		}

		public int Score1 { get { return _score1; } }
		public int Score2 { get { return _score2; } }

		public int Winer { get { return _winer; } }
		public Player Player1 { get { return _player1; } }
		public Player Player2 { get { return _player2; } }

		public Match(int id, int score1, int score2,  Player p1, Player p2)
		{
			_id = id;
			_score1 = score1;
			_score2 = score2;
			_player1 = p1;
			_player2 = p2;
		}

		public Match(int id, Player p1, Player p2)
		{
			_id = id;
			_player1 =p1;
			_player2 =p2;
		}

		public Match(Player p1, Player p2)
		{
			_player1 = p1;
			_player2 = p2;
		}

		public Player Getwiner()
        {
			if( _winer == 1)
            {
				return Player1;
            }
			if( _winer == 2)
            {
				return Player2;
            }
			return null;
        }

		public void AddScore(int s1, int s2, Sport sport)
        {
			_score1 = s1;
			_score2 = s2;
			_winer = sport.GetWiner(s1, s2);
        }

		

        public override string ToString()
        {
			return $"{Player1.ToString()} vs {Player2.ToString()}";
        }


    }
}
