using System;
using System.Collections.Generic;
using System.Text;
using SynthesisClassLibrary.DAL;

namespace SynthesisClassLibrary.Classess
{
	public class PlayerManager
	{
		private List<Player> _players;
		private IPlayerDAL _dh;
		public PlayerManager(IPlayerDAL dh)
		{
			_dh = dh;
			_players = dh.GetPlayers();
		}
		public PlayerManager()
        {
			_dh = new PlayerDataHelper();
			_players = new List<Player>();
        }
		public PlayerManager(List<Player> players)
        {
			_dh = new PlayerDataHelper();
			_players = players;
		}

		public void CreatePlayer(Player p)
		{
			_players.Add(p);
			_dh.AddPlayer(p);
		}
		public void EditPlayer(Player p)
        {
			for(int i = 0; i < _players.Count; i++)
            {
				if (_players[i].Id == p.Id)
                {
					_players[i] = p;
				}
            }
        }

		public void DeletePlayer(int id)
		{
			_dh.DeletePlayer(id);
			for(int i = 0; i < _players.Count; i++)
            {
				if( _players[i].Id == id)
                {
					_players.RemoveAt(i);
                }
            }
		}

		public List<Player> GetPlayers()
		{
			return _players;
		}

		public Player GetPlayer(int id)
		{
			for (int i = 0; i < _players.Count; i++)
			{
				if (_players[i].Id == id)
				{
					return _players[i];
				}
			}
			return null;
		}
	}
}
