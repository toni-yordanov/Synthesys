using System;
using System.Collections.Generic;
using System.Text;

namespace SynthesisClassLibrary.Classess
{
	public class Player
	{
		private int _id;
		private string _name;
		private string _address;
		private DateTime _birthDate;
		private string _email;
		private string _password;

		public string Email
		{
			get
			{
				return _email;
			}
			set
			{
				_email = value;
			}
		}

		public string Password
		{
			get
			{
				return _password;
			}
			set
			{
				_password = value;
			}
		}

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

		public DateTime BirthDate
		{
			get
			{
				return _birthDate;
			}
			set
			{
				_birthDate = value;
			}
		}

		public Player(int id, string name, string email,  string address, string password, DateTime birthDate)
		{
			_id = id;
			_name = name;
			_email = email;
			_password = password;
			_address = address;
			_birthDate = birthDate;
		}

        public Player()
        {

        }

		public Player(string name, string email,  string address, string password, DateTime birthDate)
		{
			_name = name;
			_email = email;
			_password = password;
			_address = address;
			_birthDate = birthDate;
		}

        public override string ToString()
        {
			return $"{Id} - {Name}";
        }
    }
}
