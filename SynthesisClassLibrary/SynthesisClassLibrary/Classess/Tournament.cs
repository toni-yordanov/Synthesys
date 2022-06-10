using System;
using System.Collections.Generic;
using System.Text;

namespace SynthesisClassLibrary.Classess
{
	public class Tournament
	{
		private int _id;
		private string _sport;
		private string _information;
		private DateTime _startTime;
		private int _minPlayers;
		private int _maxPlayers;
		private string _address;
		private string _name;
		private GameManager _gameManager;
		private PlayerManager _playerManager;

		public int Id
		{
			get
			{
				return _id;
			}
		}

        public string Name 
		{
			get 
			{ 
				return _name; 
			} 
			set 
			{
				_name = value; 
			} 
		}

        public string Information
		{
			get
			{
				return _information;
			}
			set
			{
				_information = value;
			}
		}

		public DateTime StartTime
		{
			get
			{
				return _startTime;
			}
			set
			{
				_startTime = value;
			}
		}

		public int MinPlayers
		{
			get
			{
				return _minPlayers;
			}
			set
			{
				_minPlayers = value;
			}
		}

		public int MaxPlayers
		{
			get
			{
				return _maxPlayers;
			}
			set
			{
				_maxPlayers = value;
			}
		}

		public string Address
		{
			get
			{
				return _address;
			}
			set
			{
				_address = value;
			}
		}

        public string Sport { get { return _sport; } }

        public Tournament(int id, string information, string name, DateTime startTime, int minPlayers, int maxPlayers, string adress, string sport, List<Match> games, List<Player> players)
		{
			_id = id;
			_information = information;
			_name = name;
			_startTime = startTime;
			_minPlayers = minPlayers;
			_maxPlayers = maxPlayers;
			_address = adress;
			_sport = sport;
			_gameManager = new GameManager(games);
			_playerManager = new PlayerManager(players);
		}

		public Tournament(string information, string name, DateTime startTime, int minPlayers, int maxPlayers, string adress, string sport)
		{
			_information = information;
			_name = name;
			_startTime = startTime;
			_minPlayers = minPlayers;
			_maxPlayers = maxPlayers;
			_address = adress;
			_gameManager = new GameManager(new List<Match>());
			_playerManager = new PlayerManager(new List<Player>());
			_sport = sport;
		}

		public Tournament(int id, string information, string name, DateTime startTime, int minPlayers, int maxPlayers, string adress, string sport)
		{
			_id = id;
			_sport = sport;
			_information = information;
			_name = name;
			_startTime = startTime;
			_minPlayers = minPlayers;
			_maxPlayers = maxPlayers;
			_address = adress;
			_gameManager = new GameManager(new List<Match>());
			_playerManager = new PlayerManager(new List<Player>());
		}

		public GameManager GetGameManager()
        {
			return _gameManager;
        }

		public PlayerManager GetPlayerManager()
        {
			return _playerManager;
        }

        public override string ToString()
        {
			return $"{_name} - {StartTime}";
        }
    }
}
