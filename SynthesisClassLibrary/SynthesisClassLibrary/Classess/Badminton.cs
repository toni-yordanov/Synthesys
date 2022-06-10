using System;
using System.Collections.Generic;
using System.Text;

namespace SynthesisClassLibrary.Classess
{
	public class Badminton : Sport
	{

        public override string ToString()
        {
			return "Badminton";
        }

        public override int GetWiner(int score1, int score2)
        {
            if (score1 > score2 && (score1 - score2) >= 2)
            {
                return 1;
            }
            if (score1 < score2 && (score2 - score1) >= 2)
            {
                return 2;
            }
            if (score1 < score2)
            {
                return 2;
            }
            if (score1 > score2)
            {
                return 1;
            }
            if(score1 == 30)
            {
                return 1;
            }
            if (score2 == 30)
            {
                return 2;
            }
            return 0;
        }
    }
}
